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

        public DataTable ListarAcessos(string filtroBusca, bool buscaRede, int filtroServidor)
        {
            DataTable DT = new DataTable();
            string strBuscaRede = "";
            string strFiltroServidor = "";
            string strAgrupamento = "";

            switch(filtroServidor)
            {
                case 0:
                    strFiltroServidor = "";
                    break;
                case 1:
                    strFiltroServidor = " AND f.filial_central = 1 ";
                    break;
                case 2:
                    strFiltroServidor = " AND f.filial_central = 0 ";
                    break;
            }

            switch (buscaRede)
            {
                case true:
                    strBuscaRede = $" r.rede_nome ";
                    strAgrupamento = $" ORDER BY r.rede_nome asc ";
                    break;
                case false:
                    strAgrupamento = $" ORDER BY f.filial_nome asc ";
                    strBuscaRede = $" r.rede_nome LIKE '%{filtroBusca}%' OR f.filial_nome ";
                    break;
            }

            strQuery = $" SELECT f.codigo, rede_nome, codigo_filial_automatiza,  filial_nome, filial_tipo_acesso " +
                $"FROM access.filial f INNER JOIN access.rede r ON f.codigo_rede = r.codigo " +
                $"WHERE {strBuscaRede} LIKE '%{filtroBusca}%' {strFiltroServidor} {strAgrupamento} LIMIT 50; ";
            
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
        public DataTable ObterInformacoes(int id) 
        {
            DataTable DT = new DataTable();
            string strQuery = $" SELECT f.codigo_filial_automatiza, r.rede_nome, f.filial_nome, f.filial_id_acesso, f.filial_tipo_acesso, f.filial_senha_acesso, f.filial_central  " +
                $"FROM access.filial f INNER JOIN access.rede r ON f.codigo_rede = r.codigo " +
                $"WHERE f.codigo = {id}; ";

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
