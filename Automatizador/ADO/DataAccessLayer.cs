using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatizador.ADO
{
    //Capa de acceso a datos
    public class DataAccessLayer
    {
        private string stringConnections = "";

        private SqlConnection connectionSql;

        public DataAccessLayer()
        {
            connectionSql = new SqlConnection(stringConnections);
        }

        public List<ClientsCode> getDataClients(string query)
        {
            List<ClientsCode> clientList = new List<ClientsCode>();

            try
            {
                connectionSql.Open();

                SqlCommand commandSql = new SqlCommand(query, connectionSql);

                SqlDataReader reader = commandSql.ExecuteReader();

                while (reader.Read())
                {
                    clientList.Add(new ClientsCode {
                        cl_codigo = reader["CL_CODIGO"].ToString(),
                        cl_nombre = reader["CL_NOMBRE"].ToString(),
                        cl_direcc = reader["CL_DIRECC"].ToString(),
                        cl_locali = reader["CL_LOCALI"].ToString(),
                        cl_tipodoc = reader["CL_TIPDOC"].ToString(),
                        cl_cuit = reader["CL_CUIT"].ToString()
                    }); 
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connectionSql.Close();
            }

            return clientList;
        }


    }
}
