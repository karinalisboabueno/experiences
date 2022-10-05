using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_GCD
{
    internal class CalculosNaGrid
    {
        //percorre a coluna saldo e calcula os saldos
       public void PreencherColunaDosSaldos (DataGridView d)
        {

            Double acumulador = 0;

            for (int i = 0; i < d.Rows.Count; i++)
            {
                DataGridViewRow row = d.Rows[i];

                acumulador = acumulador + Convert.ToDouble(row.Cells["Saldo"].Value);


                row.Cells["Saldo"].Value = acumulador ;


            }


        }

        //se t for 'd', calcula total de débitos; 'c', a dos créditos
        public void PreencherTextBoxTotal(DataGridView d,TextBox tb, char tipo)
        {
            Double acumulador = 0;

            String chaveColuna = (tipo == 'c' ? "valorCredito" : "valorDebito");

            for (int i = 0; i < d.Rows.Count; i++)
            {
                DataGridViewRow row = d.Rows[i];

                acumulador = acumulador + Convert.ToDouble(row.Cells[chaveColuna].Value);

                 

            }

            tb.Text = acumulador.ToString();

        }


    }
}
