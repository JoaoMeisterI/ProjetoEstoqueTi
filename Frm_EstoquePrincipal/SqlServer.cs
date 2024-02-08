using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

//para manipular os bancos de dados
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace EstoqueTI
{
    public class SqlClassServer
    {
        public string stringConection;
        public SqlConnection conexaoDb;

        //Construtor da classe

        public SqlClassServer()
        {
            try
            {
                //Chave de conexão
                // stringConection = "Data Source=megazord;Initial Catalog=EstoqueTi;Persist Security Info=True;User ID=sa;Password=123;TrustServerCertificate=True";
                stringConection = ConfigurationManager.ConnectionStrings["Dbteste"].ConnectionString;
                //Conexão com o banco, coloca a string de conexão dentro
                conexaoDb = new SqlConnection(stringConection);
                conexaoDb.Open();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           

        }

        public DataTable SQLQuery(string SQL)
        {
            DataTable dt = new DataTable();
            try
            {
                var meuCommand = new SqlCommand(SQL, conexaoDb);
                //sem limite de tempo, ou seja a consulta demora full
                //Se tu coloca tempo ele lança uma excessão a partir do tempo
                meuCommand.CommandTimeout = 0;
                var myReader = meuCommand.ExecuteReader();
                //CarregaConsulta
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public string SQLCommand(string SQL)
        {
            try
            {
                var myCommand = new SqlCommand(SQL, conexaoDb);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            conexaoDb.Close();
        }



    }

}
