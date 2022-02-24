using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador.Forms.Data
{
    public partial class ServiceFazenda : Form
    {
        public ServiceFazenda()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiceFazenda_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
        }

        private void ComboBoxLoad()
        {
            cmbWebSites.Items.Add("Sage Brasil");
            cmbWebSites.Items.Add("Consulta Codigo CEST");
            cmbWebSites.Items.Add("Fazenda Brasil");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string value = "http://";
            

            switch (this.cmbWebSites.SelectedIndex)
            {
                case (1):
                    value += "200.32.43.222:8124/auth/login/page";
                    break;
                case (2):
                    value += "www.codigocest.com.br/consulta-codigo-cest-pelo-ncm";
                    break;
                case (3):
                    value += "www.nfe.fazenda.gov.br/portal/disponibilidade.aspx?versao=0.00&tipoConteudo=P2c98tUpxrI=&AspxAutoDetectCookieSupport=1";
                    break;
            }


            this.webBrowser1.Navigate(value);
        }
    }
}
