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

namespace Automatizador
{
    public partial class EliminarPedido : Form
    {
        private Form formulario;
        private BusinessLogicLayer _businessLogicLayer;

        public EliminarPedido()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        public void setFormulario(Form formulario)
        {
            this.formulario = formulario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    var query = from pedMat in PEDIDO_MAT
        //                where pedMat.PM_NUMERO = ''
        //                select pedMat.*;





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
