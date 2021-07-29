using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.src.Modules.Access.DAL
{
    public class pnl_BuscarDAL
    {
        private Conexao _bdCon = new Conexao();
        private MySqlCommand _cmd;
        private string strQuery = "";

        public DataTable ListarAcessos(string filtroBusca)
        {
            DataTable DT = new DataTable();

            strQuery = "SELECT * FROM access.filial; ";
            
            try
            {
                _cmd = new MySqlCommand(strQuery, _bdCon.con);
                _bdCon.Conectar();

                _bdCon.mysqlAdapter = new MySqlDataAdapter(_cmd);

                _bdCon.mysqlAdapter.Fill(DT);
                return DT;
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                _bdCon.Desconectar();
                strQuery = null;
                _bdCon.mysqlAdapter = null;
            }
        }
    }
}
