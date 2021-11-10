using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador.Forms.Main
{
    public partial class FormDimension : Form
    {

        private Form formularioPrincipal;

        public FormDimension()
        {
            InitializeComponent();
            LoadCmbData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbWidth.Text.CompareTo("") != 0)
                formularioPrincipal.Width = int.Parse(cmbWidth.Text);

            if(cmbHeight.Text.CompareTo("") != 0)
                formularioPrincipal.Height = int.Parse(cmbHeight.Text);

            formularioPrincipal.StartPosition = FormStartPosition.WindowsDefaultLocation;
            formularioPrincipal.Enabled = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formularioPrincipal.Enabled = true;
            this.Close();
        }

        public void SetFormularioPrincipal(Form formPrincipal)
        {
            this.formularioPrincipal = formPrincipal;

            cmbWidth.Text = formPrincipal.Width.ToString();
            cmbHeight.Text = formPrincipal.Height.ToString();

        }

        private void LoadCmbData() {

            string[] width = { "1500", "1600", "1700", "1800", "1900" };

            for (int i = 0; i < width.Length; i++)
            {
                cmbWidth.Items.Add(width[i]);
            }

            string[] height = { "550", "650", "750", "850", "950" };

            for(int j = 0; j < height.Length; j++)
            {
                cmbHeight.Items.Add(height[j]);
            }
        }

    }
}
