using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Automatizador.Fomularios.Beneficios_fiscales;

namespace Automatizador.Fomularios
{
    public partial class FormularioBeneficioFiscal : Form
    {
        public FormularioBeneficioFiscal()
        {
            InitializeComponent();

            addComboBoxValues();
        }

        #region EVENTS
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            TablaValoresBeneficioFiscal tablaValores = new TablaValoresBeneficioFiscal();
            tablaValores.ShowDialog(this);
        }

        private void btnCopiarBeneficio_Click(object sender, EventArgs e)
        {
            if (cmbCST.SelectedIndex != -1)
            {
                if (txtValorBeneficio.Text.CompareTo("NULL") != 0)
                {
                    txtValorBeneficio.SelectAll();
                    txtValorBeneficio.Copy();
                    MostrarPanelCopiado();
                    MessageBox.Show("Se ha copiado el valor " + txtValorBeneficio.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El valor es nulo, no puede ser copiado", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        #endregion

        #region EVENTS

        private void cmbCST_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cmbCST.SelectedIndex)
            {
                case 0:
                case 1:
                case 8:
                case 10:
                    txtValorBeneficio.Text = "NULL";
                    break;
                case 2:
                    txtValorBeneficio.Text = "PR820001";
                    break;
                case 3:
                case 5:
                    txtValorBeneficio.Text = "PR800001";
                    break;
                case 4:
                    txtValorBeneficio.Text = "PR810001";
                    break;
                case 6:
                    txtValorBeneficio.Text = "PR840001";
                    break;
                case 7:
                    txtValorBeneficio.Text = "PR830001";
                    break;
                case 9:
                    txtValorBeneficio.Text = "PR820001";
                    break;
            }   
            
        }

        private void addComboBoxValues()
        {
            string[] values = { "00", "10", "20", "30", "40", "41", "50", "51", "60", "70", "90" };

            for(int i = 0; i < values.Length; i++)
            {
                cmbCST.Items.Add(values[i].ToString());
            }
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MostrarPanelCopiado()
        {
            pnlInfoBeneficio.Visible = true;
            Thread.Sleep(1000);
            pnlInfoBeneficio.Visible = false;
        }

        #endregion
    }
}
