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

namespace Automatizador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text.Equals("Administrador") && txtContrasena.Text.Equals("12345678"))
            {
                txtUsuario.Text = string.Empty;
                txtContrasena.Text = string.Empty;
                this.Hide();
                FormularioPrincipal frm = new FormularioPrincipal();
                frm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("No ha ingresado usuario ni contraseña!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsuario.Focus();
                SetsText();                
            }
        }

        private void SetsText()
        {
            txtUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
        }
    }
}
