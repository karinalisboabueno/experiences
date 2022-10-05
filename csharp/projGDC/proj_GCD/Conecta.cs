using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Comunidade
{
    internal class Conecta
    {
        //property
        public String _conString;
        //get e set
        public String ConString
        {
            get
            {
                return _conString;
            }
            set
            {
                this._conString = value;
            }
        }

        //private String scCasa = "data source = DESKTOP-SBS9GUS\\SQLEXPRESS;Initial Catalog = bdGCD;User Id = sa;Password = 123;";

        //construtor por defeito
        public Conecta()
        {
            this._conString = "data source = DESKTOP-A077TH4\\SQLEXPRESS4;Initial Catalog = bdGdc;User Id=sa;Password=123.Abc+;";
            //this._conString = "data source = DESKTOP-SBS9GUS\\SQLEXPRESS;Initial Catalog = bdGCD;User Id = sa;Password = 123;";
           
        }
        //construtor que pode ser passado uma nova string
        public Conecta(String connection)
        {
            this._conString = connection;
        }




        public DataTable BuscaDados(string str_sql)
        {


            SqlConnection C = new SqlConnection(this._conString); C.Open();

            SqlCommand command = C.CreateCommand(); command.CommandText = str_sql;


            SqlDataAdapter da = new SqlDataAdapter(command);

            DataTable t = new DataTable();


            da.Fill(t);
            C.Close();

            return t;  // leva os registos


        }
    }




}