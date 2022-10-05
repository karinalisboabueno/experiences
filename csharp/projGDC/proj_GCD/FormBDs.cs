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
    public partial class FormBDs : Form
    {
        private String bdSelecionada = "local";
        public FormBDs()
        {
            InitializeComponent();
        }

        //Buscar dados as BD
        private DataTable BuscaDados(string ssql)
        {
           
            Conecta obj = new Conecta();

            if (bdSelecionada == "leopardo")
            {
                obj.ConString = "Data Source=leopardo\\SQLLEO; Initial Catalog = bdGdc; User ID = geral; Password=123.Abc;";
            }else if(bdSelecionada == "godaddy")
            {
                obj.ConString = "Data Source = 188.121.44.214; Initial Catalog = bdGdc2; USER ID = geralGdc; Password = 123.Abc +; ";
            }
            else if (bdSelecionada == "local")
            {
                
                obj.ConString = "data source = DESKTOP-A077TH4\\SQLEXPRESS4;Initial Catalog = bdGdc;User Id=sa;Password=123.Abc+;"; 
            }

            return obj.BuscaDados(ssql);

        }
        private void atualizaList()
        {

           
               
            DataTable clientes = BuscaDados("select * from Clientes");
            lstClientes.ValueMember = "id";
            lstClientes.DisplayMember = "nomeCliente";
            lstClientes.DataSource = clientes;



        }

        private void rdbLeopardo_Click(object sender, EventArgs e)
        {
            bdSelecionada = "leopardo";
            atualizaList();
        }

        private void rdbGodaddy_Click(object sender, EventArgs e)
        {
            bdSelecionada = "godaddy";
            atualizaList();
        }

        private void rdbLocal_Click(object sender, EventArgs e)
        {
            bdSelecionada = "local";
            atualizaList();
        }

        private void FormBDs_Load(object sender, EventArgs e)
        {
            rdbGodaddy.Checked=false;
            rdbLeopardo.Checked = false;
            rdbLocal.Checked = true;
        }

       
        private void btnFormBDs2_Click_1(object sender, EventArgs e)
        {
            FormBDs2 formBDs = new FormBDs2(lstClientes);
            formBDs.Show();
        }

      

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }
    }
}

