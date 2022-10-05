using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pascoa
{
    internal class Ligacao
    {

        //public Ligacao()
        //{
        //    string str_sql = "select * from movimentos";
        //    string str_conection = "DATA SOURCE=188.121.44.214;INITIAL CATALOG=bdGdc2 ;USER ID=geralGdc;Password=123.Abc+;";
        //}

        public string str_sql ;
        public string str_conection;



        public DataTable Procurar()
        {
            SqlConnection C = new SqlConnection(str_conection); C.Open();

            SqlCommand command = C.CreateCommand(); command.CommandText = str_sql;


            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable t = new DataTable();


            da.Fill(t);
            C.Close();

            return t;  // leva os registos



        }

    }
   }

