from flask import Flask, render_template, request, redirect, url_for, session
from flask_mysqldb import MySQL  # pip install flask-mysqldb
import MySQLdb.cursors
import re  # expressões regulares

app = Flask(__name__)  # inicia app
app.secret_key = 'a minha palavra secreta'  # hash generetor(token)

app.config['MYSQL_HOST'] = 'localhost'
app.config['MYSQL_USER'] = 'root'
app.config['MYSQL_PASSWORD'] = ''
app.config['MYSQL_DB'] = 'pythonlogin'

mysql = MySQL(app)  # ligar com a BD

# criar uma rota(FLASK)


@app.route('/pythonlogin/', methods=['GET', 'POST'])
def login():
    msg = ''
    if request.method == 'POST' and 'username' in request.form and 'password' in request.form:
        username = request.form['username']
        password = request.form['password']
        cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute(
            'select * from accounts where username = %s and password = %s', (username, password))
        account = cursor.fetchone()
        if account:
            session['loggedin'] = True
            session['id'] = account['id']
            session['username'] = account['username']
            return redirect(url_for('home'))
        else:
            msg = 'Incorrecto username/password'

    return render_template('index.html', msg=msg)


@app.route('/pythonlogin/logout') #rota para o login
def logout():
    # mandar ligações anterores abaixo
    session.pop('loggedin', None)
    session.pop('id', None)
    session.pop('username', None)
    return redirect(url_for('login'))

@app.route('/pythonlogin/register', methods=['GET','POST']) #rota para o registro
def register():
    msg=''
    if request.method == 'POST' and 'username' in request.form and 'password' in request.form and 'email' in request.form:
        username= request.form['username']
        password= request.form['password']
        email= request.form['email']
        cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute('select * from accounts where username = %s',(username,))
        account = cursor.fetchone()
        if account:
            msg ='Conta já existe!'
        elif not re.match(r'[^@]+@[^@]+\.[^@]+', email):    #pra testar se tem o @ e . no email
            msg= 'Email inválido!'
        elif not re.match(r'[A-Za-z0-9]+', username):
            msg= 'Caracteres inválidos!'
        elif not username or not password or not email:
            msg= 'Por favor preencher todos os campos'
        else:
            cursor.execute('insert into accounts values (null,%s,%s,%s)',(username,password,email,)) 
            mysql.connection.commit() 
            msg= 'Utilizador inserido com sucesso!' 


    elif request.method == 'POST':
        msg = 'Por favor preencher formulário'
    return render_template('register.html', msg=msg)         

@app.route('/pythonlogin/home')
def home():
    if 'loggedin' in session:
        return render_template('home.html', username = session['username'])
    return redirect(url_for('login'))

@app.route('/pythonlogin/profile')
def profile():
    if 'loggedin' in session:
        cursor = mysql.connection.cursor(MySQLdb.cursors.DictCursor)
        cursor.execute('select * from accounts where id= %s', (session['id'],))
        account = cursor.fetchone()
        return render_template('profile.html', account = account)
    return redirect(url_for('login'))        




if __name__ == "__main__":  # ativar o servidor flask, ficar no "ar"
    app.run(debug=True)
