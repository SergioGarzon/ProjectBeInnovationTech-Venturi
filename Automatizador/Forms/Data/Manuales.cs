using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador.Fomularios
{
    public partial class Manuales : Form
    {
        public Manuales()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manuales_Load(object sender, EventArgs e)
        {
            ChargeCountry();
        }

        private void ChargeCountry()
        {
            string[] data = { "Argentina", "Brasil", "Chile", "Paraguay"};

            for(int i = 0; i < data.Length; i++)
            {
                cmbPais.Items.Add(data[i].ToString());
            }

            cmbPais.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
