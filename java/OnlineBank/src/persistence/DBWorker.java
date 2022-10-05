package persistence;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
/**
 *Classe que trata da inter-ligação com a base de dados
 * @author Karina
 */
public class DBWorker {
     private final String servidor;
    private final String user;
    private final String password;
    private final String baseDados;
    private final String url;

    private final Connection conn;

    /**
     *Construtor. inicializa Connection com os parametros passados como argumento
     * @param servidor servidor a ligar
     * @param user utilizador
     * @param password password
     * @param baseDados nome da base de dados a ligar
     * @throws SQLException
     * @throws ClassNotFoundException
     * @throws IllegalAccessException
     * @throws InstantiationException
     */
    public DBWorker(String servidor, String user, String password, String baseDados) throws SQLException, ClassNotFoundException, IllegalAccessException, InstantiationException {
        this.servidor = servidor;
        this.user = user;
        this.password = password;
        this.baseDados = baseDados;
        this.url = "jdbc:mysql://" + this.servidor + ":3306/" + this.baseDados + "?serverTimezone=UTC";
        conn = getConnection();
    }

    private Connection getConnection() throws SQLException, ClassNotFoundException, IllegalAccessException, InstantiationException {
        Class.forName("com.mysql.cj.jdbc.Driver").newInstance();
        return DriverManager.getConnection(url, user, password);
    }

    /**
     * Executar update na BD
     * @param sql
     * @return o mesmo que Statement.executeUpdate
     * @throws SQLException
     */
    public int executeUpdate(String sql) throws SQLException {
        final Statement st = conn.createStatement();
        int resultado = st.executeUpdate(sql);
        return resultado;
    }

    /**
     *Executar uma query na base de dados
     * @param sql
     * @return resultSet
     * @throws SQLException
     */
    public ResultSet executeQuery(String sql) throws SQLException {
        final Statement st = conn.createStatement();
        return st.executeQuery(sql);
    }
    
    /**
     *Cria um preparedStatement
     * @param sql
     * @return PreparedStatement
     * @throws SQLException
     */
    public PreparedStatement createPreparedStatement(String sql) throws SQLException{
        return conn.prepareStatement(sql,  Statement.RETURN_GENERATED_KEYS);
    }
    
    /**
     * Fecha a conexão
     * @throws SQLException
     */
    public void closeConnection() throws SQLException {

        if (conn != null) {
            conn.close();
        }
    }

    /**
     *Obter a primary key gerada pelo motor da BD
     * @param ps
     * @return primary Key
     */
    public Integer getGeneratedKey(PreparedStatement ps) {
        try{
            ResultSet rs = ps.getGeneratedKeys();
            
         if(rs.next()){
                return rs.getInt(1);
         }
         
        }catch(SQLException e){
            e.printStackTrace();
        }
        
        return null;
    }

}
