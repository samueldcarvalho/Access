using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.src.Modules.Access.DAL
{
    public class Conexao
    {
        public MySqlConnection con = new MySqlConnection();
        public string strConnection = "Server=localhost;Database=access;Uid=root;Pwd=asd99536416";
        public MySqlCommand cmd;
        public MySqlDataAdapter mysqlAdapter;
        public MySqlDataReader mysqlReader; 

        public MySqlConnection Conectar()
        {
            con.ConnectionString = strConnection;
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();

            return con;
        }

        public void Desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
