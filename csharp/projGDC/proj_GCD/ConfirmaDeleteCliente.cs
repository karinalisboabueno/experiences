using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_GCD
{
    public partial class ConfirmaDeleteCliente : Form
    {
       public  Boolean cancelar = true;
        public Boolean apagar = false;

        public ConfirmaDeleteCliente()
        {
            InitializeComponent();
        }

        public ConfirmaDeleteCliente(int totalMovimentos)
        {

            InitializeComponent();

            this.labelNrMovimentos.Text = totalMovimentos.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if(txtBoxNrMovimentos.Text == this.labelNrMovimentos.Text)
            {
                this.apagar = true;
                this.cancelar = false;
            }

            this.Close();
        }


    }
}
