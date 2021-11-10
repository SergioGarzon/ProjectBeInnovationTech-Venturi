using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automatizador.ADO;

namespace Automatizador.Forms.Clients
{
    public partial class ClientesForm : Form
    {
        private BusinessLogicLayer _businessLogicLayer;

        public ClientesForm()
        {
            InitializeComponent();

            _businessLogicLayer = new BusinessLogicLayer();

            ReturnContact();
            ChargeComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnContact()
        {
            List<ClientsCode> dataClients = _businessLogicLayer.GetClientsData();
            dgvClients.DataSource = dataClients;
        }

        private void ChargeComboBox()
        {
            cmbSucursal.Items.Add("Argentina");
            cmbSucursal.Items.Add("Brasil");
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
