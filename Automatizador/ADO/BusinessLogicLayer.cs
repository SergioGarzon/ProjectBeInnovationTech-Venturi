using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatizador.ADO
{
    //Esto es para la capa de la logica de negocios
    public class BusinessLogicLayer
    {
        private DataAccessLayer _dataaccesslayer;

        public BusinessLogicLayer()
        {
            _dataaccesslayer = new DataAccessLayer();
        }

        public List<ClientsCode> GetClientsData()
        {
            string query = @"select CL_CODIGO, CL_NOMBRE, CL_DIRECC, CL_LOCALI, CL_TIPDOC, CL_CUIT 
                            from CLIENTES with(nolock)
                            order by CL_CODIGO asc";

            return _dataaccesslayer.getDataClients(query);
        }

    }
}
