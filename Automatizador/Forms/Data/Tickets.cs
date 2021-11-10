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
    public partial class Tickets : Form
    {
        private Form formulario;

        public Tickets()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            formulario.Enabled = true;
        }

        public void EnabledForm(Form form1)
        {
            formulario = form1;
        }

    }
}
