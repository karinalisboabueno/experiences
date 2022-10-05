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
    public partial class FormBDs2 : Form
    {

        private ListBox pointer;
        public FormBDs2(ListBox l)
        {
            InitializeComponent();
            pointer = l;
        }

             

        private void btnClienteSelecionado_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(pointer.Text);


        }
    } 
}
