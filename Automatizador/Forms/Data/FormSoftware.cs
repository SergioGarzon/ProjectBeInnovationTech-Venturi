using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador
{
    public partial class FormSoftware : Form
    {

        private string selectedBrowser;

        #region CONSTRUCTOR

        public FormSoftware()
        {
            InitializeComponent();

            /*
             * iexplorer.exe
             * msedge.exe
             * chrome.exe
             * firefox.exe
             */
        }

        #endregion  

        #region METODOS

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ((FormularioPrincipal) this.Owner).Enabled = true;
        }
               

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            selectedBrowser = "chrome.exe";

            if (chkChrome.Checked)
                chkDisabled(1);          
        }

        private void chkMozilla_CheckedChanged(object sender, EventArgs e)
        {
            selectedBrowser = "firefox.exe";

            if(chkMozilla.Checked)            
                chkDisabled(2);
            
        }

        private void chkMicrosoftEdge_CheckedChanged(object sender, EventArgs e)
        {
            selectedBrowser = "msedge.exe";

            if (chkMicrosoftEdge.Checked)            
                chkDisabled(3);            
        }

        private void chkInternetExplorer_CheckedChanged(object sender, EventArgs e)
        {
            selectedBrowser = "iexplorer.exe";

            if (chkInternetExplorer.Checked)
                chkDisabled(4);
        }        

        #endregion


        #region EVENTOS

        private void btnSage_Click(object sender, EventArgs e)
        {
            startUrl(getUrlData(1));
        }
        
        private void btnCestCode_Click(object sender, EventArgs e)
        {
            startUrl(getUrlData(2));  //Codigo CEST
        }
        
        private void btnSpiceworks_Click(object sender, EventArgs e)
        {
            startUrl(getUrlData(3));        
        }

        private void btnJira_Click(object sender, EventArgs e)
        {
            startUrl(getUrlData(4));
        }

        private void btnSkype_Click(object sender, EventArgs e)
        {
            startUrl(getUrlData(5));
        }

        private void btnCopySage_Click(object sender, EventArgs e)
        {
            textBox1.Text = getUrlData(1);
            copyUrl("Sage: " + getUrlData(1));
        }

        private void btnCopyCestCode_Click(object sender, EventArgs e)
        {
            textBox1.Text = getUrlData(2);
            copyUrl("Código CEST: " + getUrlData(2));
        }

        private void btnCopySpiceworks_Click(object sender, EventArgs e)
        {
            textBox1.Text = getUrlData(3);
            copyUrl("Spiceworks: " + getUrlData(3));
        }

        private void btnCopyJira_Click(object sender, EventArgs e)
        {
            textBox1.Text = getUrlData(4);
            copyUrl("Jira: " + getUrlData(4));
        }

        private void btnImposto_Click(object sender, EventArgs e)
        {
            textBox1.Text = getUrlData(5);
            copyUrl("Ley de transparencia: " + getUrlData(5));
        }


        #endregion

        #region METHODS

        private void startUrl(string url)
        {
            try
            {
                if(chkChrome.Checked)                
                    selectedBrowser = "chrome.exe";
                

                System.Diagnostics.Process.Start(selectedBrowser, url);
            }
            catch (Win32Exception e)
            {
                MessageBox.Show("El navegador seleccionado no esta instalado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void copyUrl(string url)
        {
            textBox1.SelectAll();
            textBox1.Copy();

            MessageBox.Show("La url de " + url + " fue copiada al portapapeles",
                "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string getUrlData(int value)
        {
            string dataValue = "http://";

            switch(value)
            {
                case 1:
                    dataValue += "200.32.43.222:8124/auth/login/page";
                    break;
                case 2:
                    dataValue += "www.codigocest.com.br/consulta-codigo-cest-pelo-ncm";
                    break;
                case 3:
                    dataValue += "srvcontrol:8648/tickets/";
                    break;
                case 4:
                    dataValue += "venturihnos.atlassian.net/jira/projects";
                    break;
                case 5:
                    dataValue += "";
                    break;
            }

            return dataValue;
        }

        private void chkDisabled(int values)
        {
            switch(values)
            {
                case 1:
                    chkInternetExplorer.Checked = false;
                    chkMozilla.Checked = false;
                    chkMicrosoftEdge.Checked = false;
                    break;
                case 2:
                    chkChrome.Checked = false;
                    chkInternetExplorer.Checked = false;
                    chkMicrosoftEdge.Checked = false;
                    break;
                case 3:
                    chkChrome.Checked = false;
                    chkInternetExplorer.Checked = false;
                    chkMozilla.Checked = false;
                    break;
                case 4:
                    chkChrome.Checked = false;
                    chkMicrosoftEdge.Checked = false;
                    chkMozilla.Checked = false;
                    break;
            }
        }

        #endregion
        
    }
}
