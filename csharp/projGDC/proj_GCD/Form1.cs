using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using Comunidade;
using Pascoa;

namespace proj_GCD

{
    public partial class Form1 : Form
    {
        CalculosNaGrid calculosGrid;
        FormataGrid formataGrid;
        public Form1()
        {
            calculosGrid = new CalculosNaGrid();
            formataGrid = new FormataGrid();

            InitializeComponent();
           

        }

        private DataTable BuscaDados(string ssql)
        {

            //precisar de ir buscar os dados à bd busco a property Sc
            Conecta obj = new Conecta();
            return obj.BuscaDados(ssql);
        }

        private void atualizaGrid()
        {
            atualizaGrid("");
        }

        private void atualizaGrid(String criterio)
        {

            String where = "";

            String idCliente = Convert.ToString(lsbClientes.SelectedValue);
            
            if (idCliente == "" || idCliente==null)
            {
                // se não tiver idCliente, entao vai fazer 1=1 (ou seja, vai mostrar tudo)
                where = "1=1";
            }
            else
            {
                // se tiver idCliente, faz a condição usando esse id
                where = "idCliente = " + idCliente;
            }


            //concatena a condição atual com a que vier como argumento
            where = where + " " + criterio;

            try
            {

                dgvMovimentos.DataSource = BuscaDados("select data,descricao, verificacao, coalesce(valorDebito,0) valorDebito, coalesce(valorCredito,0) valorCredito, coalesce(valorDebito,0) - coalesce(valorCredito,0) as Saldo, Movimentos.id from Movimentos  where "+ where );

                

                dgvMovimentos.Columns["id"].Visible = false;
            }
            catch (Exception)
            {

                //liga-se a base de dados remota
                Ligacao obj = new Ligacao();

                obj.str_sql = "select data,descricao, verificacao, coalesce(valorDebito,0) valorDebito, coalesce(valorCredito,0) valorCredito, coalesce(valorDebito,0) - coalesce(valorCredito,0) as Saldo, Movimentos.id from Movimentos  where " + where ;
                obj.str_conection = "Data Source=188.121.44.214;Initial Catalog=bdGdc2 ;USER ID=geralGdc;Password=123.Abc+;";
                dgvMovimentos.DataSource = obj.Procurar();
            }

            

           
            calculosGrid.PreencherColunaDosSaldos(dgvMovimentos);
            calculosGrid.PreencherTextBoxTotal(dgvMovimentos, txtCreditoAcumulado, 'c');
            calculosGrid.PreencherTextBoxTotal(dgvMovimentos, txtDebitoAcumulado, 'd');

            formataGrid.DefinirHeaders(dgvMovimentos);
            formataGrid.FormatarMoney(dgvMovimentos, txtCreditoAcumulado, txtDebitoAcumulado);


        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable clientes = BuscaDados("select * from Clientes");
                lsbClientes.ValueMember = "id";
                lsbClientes.DisplayMember = "nomeCliente";
                lsbClientes.DataSource = clientes;

               
            }
            catch (Exception)
            {
                //liga-se a base de dados remota
                Ligacao obj = new Ligacao();

                obj.str_sql = "select * from clientes";
                obj.str_conection = "Data Source=188.121.44.214;Initial Catalog=bdGdc2 ;USER ID=geralGdc;Password=123.Abc+;";
                lsbClientes.ValueMember = "id";
                lsbClientes.DisplayMember = "nomeCliente";
                lsbClientes.DataSource = obj.Procurar();

              
            }
             
     
            atualizaGrid();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDebito.Text!="" && txtCredito.Text!="")
            {
                string box_msg = "Impossivel fazer o Registo!";

                string box_title = "Erro";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtCredito.Text =="" && txtDebito.Text =="")
            {
                string box_msg = "Impossivel fazer o Registo!";

                string box_title = "Erro";

                MessageBox.Show(box_msg, box_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
                if (DialogResult.Yes == MessageBox.Show(dtMovimento.Value.ToString("dd-MM-yyyy") + "\n" + lsbClientes.GetItemText(lsbClientes.SelectedItem) + "\n" + " valor a debito: " + txtDebito.Text + "\n valor a credito: " +
                    txtCredito.Text + "\n\n\n CONFIRMA ?", "Verifique os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    //Sua rotina de inserção
                    //Confirmando inserção para o utilizador
                    String sql = "INSERT INTO Movimentos(data, descricao, idCliente, valorDebito, valorCredito ) VALUES (cast('" + dtMovimento.Value.ToString("yyyy-MM-dd") + "' as date),'"+txtDescricao.Text+ "','" + lsbClientes.SelectedValue + "','" + txtDebito.Text + "','" + txtCredito.Text + "')";
                    BuscaDados(sql);
                    MessageBox.Show("Registro Inserido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



            lsbClientes_SelectedIndexChanged(sender, e);


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }


        private void lsbClientes_SelectedIndexChanged(object sender, EventArgs e) 
        {


            // SelectedIndex == -1 significa que não tem nenhum cliente selecionado
            if (lsbClientes.SelectedIndex == -1)
            {
                panel1.Enabled = false;
            }
            else
            {
                panel1.Enabled = true;
            }
           
           
            String totalMovimentos = BuscaDados("select count(*) as total from movimentos where idcliente='" + lsbClientes.SelectedValue+"'").Rows[0]["total"].ToString();

            lblNumMovimentos.Text = totalMovimentos;

            atualizaGrid();
        }
     

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from clientes where nomeCliente LIKE '%" + txtFiltro.Text + "%'";
          
            lsbClientes.DataSource = BuscaDados(sql);

           
        }

        private void recolonizarMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colonias recolonizar = new Colonias();
            recolonizar.RecolonizarTabelaDeMovimentos();

            atualizaGrid();
            
        }

       

        private void f2AtualizarMovimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = dgvMovimentos.CurrentRow.Cells;

            string id = cells["id"].Value.ToString();
            string data = Convert.ToDateTime(cells["data"].Value).ToString("yyyy-MM-dd");
            string descricao = cells["descricao"].Value.ToString();
            string verificacao = cells["verificacao"].Value.ToString();
            string valorDebito = cells["valorDebito"].Value.ToString();
            string valorCredito = cells["valorCredito"].Value.ToString();

            //Confirmando update para o utilizador
            String sql = "update Movimentos set data= '" + data + "',descricao= '" + descricao + "',verificacao='" + verificacao + "',valorDebito='" + valorDebito + "',valorCredito='" + valorCredito + "' where id='" + id + "'";

            BuscaDados(sql);

            atualizaGrid();
        }


        private void AtualizarMovimento_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = dgvMovimentos.CurrentRow.Cells;


            string id = cells["id"].Value.ToString();
            string data = Convert.ToDateTime(cells["data"].Value).ToString("yyyy-MM-dd");
            string descricao = cells["descricao"].Value.ToString();
            string verificacao = cells["verificacao"].Value.ToString();
            string valorDebito = cells["valorDebito"].Value.ToString();
            string valorCredito = cells["valorCredito"].Value.ToString();


            //Confirmando update para o utilizador
            String sql = "update Movimentos set data= '" + data + "',descricao= '" + descricao + "',verificacao='" + verificacao + "',valorDebito='" + valorDebito + "',valorCredito='" + valorCredito + "' where id='" + id + "'";

            BuscaDados(sql);

            atualizaGrid();
        }

        private void eliminarEntreDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string dataInicial = dtpInicio.Value.ToString("yyyy-MM-dd");
            string dataFinal = dtpFim.Value.ToString("yyyy-MM-dd");

            String totalMovimentos = BuscaDados("select count(*) as total from movimentos where data between'" + dataInicial + "' and '" + dataFinal + "' and idcliente=" + lsbClientes.SelectedValue).Rows[0]["total"].ToString();

            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show("No período de " + dataInicial + "até " + dataFinal + "\n" + lsbClientes.GetItemText(lsbClientes.SelectedItem) + "\n" + "Número de Movimentos: " + totalMovimentos + "\n\n\n CONFIRMA a remoção do registo ?", "Confirme os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                //Confirmando a remocao para o utilizador
                String sql2 = "delete from movimentos  where data between'" + dataInicial + "' and '" + dataFinal + "' and idcliente=" + lsbClientes.SelectedValue;
                BuscaDados(sql2);
                MessageBox.Show("Registro removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            lsbClientes_SelectedIndexChanged(sender, e);


        }

        private void eliminarLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = dgvMovimentos.CurrentRow.Cells;

            string id = cells["id"].Value.ToString();
            string data = Convert.ToDateTime(cells["data"].Value).ToString("yyyy-MM-dd");
            string descricao = cells["descricao"].Value.ToString();
            string verificacao = cells["verificacao"].Value.ToString();
            string valorDebito = cells["valorDebito"].Value.ToString().Replace("€", "");
            string valorCredito = cells["valorCredito"].Value.ToString().Replace("€", "");


            //Criar um MessageBox com os botões Sim e Não e deixar o botão 2(Não) selecionado por padrão e comparar o botão apertado
            if (DialogResult.Yes == MessageBox.Show(data + "\n" + lsbClientes.GetItemText(lsbClientes.SelectedItem) + "\n" + " valor a debito: " + valorDebito + "\n valor a credito: " + valorCredito + "\n Descrição: " + descricao + "\n Verificação: " + verificacao + "\n\n\n CONFIRMA a remoção do registo ?", "Confirme os dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {

                //Confirmando a remocao para o utilizador
                String sql = "delete from movimentos where id =' " + id + "'";
                BuscaDados(sql);
                MessageBox.Show("Registro removido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            lsbClientes_SelectedIndexChanged(sender, e);
        }

        private void listarMêsCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            atualizaGrid("and month(data)=month(GETDATE())");



        }

        private void listarEntreDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dataInicial = dtpInicio.Value.ToString("yyyy-MM-dd");
            string dataFinal = dtpFim.Value.ToString("yyyy-MM-dd");

            atualizaGrid("and data between '" + dataInicial + "' and '" + dataFinal + "'");

        }

        private void balanceteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsbClientes.ClearSelected();

            atualizaGrid("and month(data)=month(GETDATE())");
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            //DataRowView p = (DataRowView)lsbClientes.SelectedItem;

            //String s = lsbClientes.GetItemText(p);
            //MessageBox.Show(s);

            //MessageBox.Show(Convert.ToString(lsbClientes.GetItemText(lsbClientes.SelectedItem)));
            MessageBox.Show(lsbClientes.GetItemText(lsbClientes.SelectedItem).ToString());


        }

        private void btnCount_Click(object sender, EventArgs e)
        {
          //lsbClientes.DataSource = null;
          //lsbClientes.DataSource = BuscaDados("select count(*) as total from clientes");

          // string contagem = dt
            
          

        }

        private void btnFormBDs_Click(object sender, EventArgs e)
        {
            FormBDs formBDs = new FormBDs();
            formBDs.Show();
        }
    }
}