using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automatizador.Fomularios;
using Automatizador.Forms.Clients;

namespace Automatizador
{
    public partial class OpenPrograms : Form
    {
        private Form formularioPrincipal;

        public OpenPrograms()
        {            
            InitializeComponent();
            CargarDatosCombo();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formularioPrincipal.Enabled = true;
            
        }

        public void setFormulario(Form formulario)
        {
            this.formularioPrincipal = formulario;
        }


        private void CargarDatosCombo()
        {
            comboBox1.Items.Add("Charge ticket beneficio fiscal");
            comboBox1.Items.Add("Verify IPI value");
            comboBox1.Items.Add("Delete order Zeus");
            comboBox1.Items.Add("Consultar clientes");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    FormularioBeneficioFiscal formularioBf = new FormularioBeneficioFiscal();
                    formularioBf.ShowDialog();
                    break;
                case 1:
                    break;
                case 2:
                    EliminarPedido eliminarPedido = new EliminarPedido();
                    eliminarPedido.ShowDialog();
                    break;
                case 3:
                    ClientesForm cl = new ClientesForm();
                    cl.ShowDialog();
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
