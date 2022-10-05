using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pascoa;
using Comunidade;

namespace proj_GCD
{
    public partial class Form2 : Form
    {
        ConfirmaDeleteCliente confirmDeleteCliente;
        public Form2()
        {
            InitializeComponent();
        }

        private DataTable BuscaDados(string ssql)
        {

            //precisar de ir buscar os dados à bd
            Conecta obj = new Conecta();
            return obj.BuscaDados(ssql);
        }

      

        private void atualizaGrid()
        {

            try
            {
                dgvClientes.DataSource = BuscaDados("select * from clientes");
            }
            catch (Exception)
            {
                //liga-se a base de dados remota
                Ligacao obj = new Ligacao();

                obj.str_sql = "select * from clientes";
                obj.str_conection = "Data Source=188.121.44.214;Initial Catalog=bdGdc2 ;USER ID=geralGdc;Password=123.Abc+;";
                dgvClientes.DataSource = obj.Procurar();
             
            }
            
            
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void btnInsereCliente_Click(object sender, EventArgs e)
        {

            String sql = "INSERT into clientes" + "(nomeCliente, marcador, refInterna) VALUES ('" + txtNome.Text + "','"+ txtRefCliente.Text + "','"+txtMarcador.Text+"')";

            BuscaDados(sql);

            atualizaGrid();

        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            string idCliente = dgvClientes.CurrentRow.Cells["id"].Value.ToString();

            
           DialogResult resultado = MessageBox.Show("Tem a certeza que deseja remover o cliente?", "Confirmação", MessageBoxButtons.YesNo);
           
            
            
            if (resultado == DialogResult.Yes)
            {

                DataTable totalMovimentosRows = BuscaDados("select count(*) as total from movimentos where idcliente=" + idCliente);
                int totalMovimentos = (int)totalMovimentosRows.Rows[0]["total"];

                // instanciar janela do tipo "confirmaDeleteCliente"
                confirmDeleteCliente = new ConfirmaDeleteCliente(totalMovimentos);

                // executar funcao "DialogConfirmaDelete_FormClosed" ao fechar
                confirmDeleteCliente.FormClosed += DialogConfirmaDelete_FormClosed;

                confirmDeleteCliente.Show();

            }


        }

        private void DialogConfirmaDelete_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!confirmDeleteCliente.cancelar && confirmDeleteCliente.apagar)
            {
                string idCliente = dgvClientes.CurrentRow.Cells["id"].Value.ToString();

                BuscaDados("delete from movimentos where idcliente=" + idCliente);
                BuscaDados("delete from clientes where id="+idCliente);

                MessageBox.Show("Registo removido com sucesso!");

            }
            else
            {
                MessageBox.Show("Introduziu valor errado ou cancelou");
            }

            atualizaGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idCliente = dgvClientes.CurrentRow.Cells["id"].Value.ToString();
            string nomeCliente = dgvClientes.CurrentRow.Cells["nomeCliente"].Value.ToString();
            string RefCliente = dgvClientes.CurrentRow.Cells["refInterna"].Value.ToString();

            BuscaDados("update clientes set nomeCliente= " + "'" + nomeCliente +"'" + ",refInterna= "+"'"+RefCliente+"'where id='"+idCliente+ "'");
            atualizaGrid();


        }

        private void btnRecolonizar_Click(object sender, EventArgs e)
        {

            Colonias recolonizar = new Colonias();

            recolonizar.RecolonizarTabelaDeClientesEMovimentos();

            atualizaGrid();
            this.Close();
        }

        private void txtMarcador_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
