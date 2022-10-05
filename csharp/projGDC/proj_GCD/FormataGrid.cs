using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proj_GCD
{
    internal class FormataGrid
    {
        /*
         * aplica larguras específicas
         */
        public void DefinirLarguras(DataGridView d)
        {

        }

        /**
         * aplica cores específicas 
         */
        public void DefinirCores(DataGridView d)
        {

        }

        /**
         * define headers com texto específico
         */
        public void DefinirHeaders(DataGridView d)
        {

            d.Columns["data"].HeaderCell.Value = "Data";
            d.Columns["descricao"].HeaderCell.Value = "Descrição";
            d.Columns["verificacao"].HeaderCell.Value = "Verificação";
            d.Columns["valorDebito"].HeaderCell.Value = "Débito";
            d.Columns["valorCredito"].HeaderCell.Value = "Crédito";

        }

        /**
         * aplica 'euro'  em créditos, débitos e saldos, incluindo as textboxes
        */
        public void FormatarMoney(DataGridView d, TextBox t1, TextBox t2)
        {
            d.Columns["valorDebito"].DefaultCellStyle.Format = "C2";
            d.Columns["valorCredito"].DefaultCellStyle.Format = "C2";
            d.Columns["Saldo"].DefaultCellStyle.Format = "C2";

            t1.Text = t1.Text +" €";
            t2.Text = t2.Text + " €";
        }

    }
}
