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
using Automatizador.Forms.Main;

namespace Automatizador
{
    public partial class FormularioPrincipal : Form
    {
        private Timer ts;
        private bool control = true;
        private bool controlMax = true;

        public FormularioPrincipal()
        {
            ts = null;
            ts = new Timer();
            ts.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ts.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime dt = DateTime.Now;
            lblFecha.Text = dt.ToString("dd/MM/yyyy");
            lblHora.Text = dt.ToString("hh:mm:ss");

            if(lblHora.Text.Equals("12:55:00") && control)
            {
                control = false;
                Break breakTime = new Break();
                breakTime.ShowDialog();
            } 
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ts = null;
            control = true;
            this.Close();
            ((Login)this.Owner).Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            OpenPrograms openProg = new OpenPrograms();
            openProg.setFormulario(this);            
            OpenForm(openProg, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets tickets = new Tickets();
            this.Enabled = false;
            tickets.EnabledForm(this);
            OpenForm(tickets, 1);            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSoftware formSoftware = new FormSoftware();
            this.Enabled = false;
            formSoftware.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormularioEmail formulariEmail = new FormularioEmail();
            OpenForm(formulariEmail, 1);
        }

        private void OpenForm(Form frm, int value)
        {
            if (value == 1)
                frm.ShowDialog();
            else
                frm.Show();
        }

        private void btnServers_Click(object sender, EventArgs e)
        {
            Manuales manual = new Manuales();
            OpenForm(manual, 1);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (controlMax)
            {
                this.WindowState = FormWindowState.Maximized;
                this.MaximizeBox = true;
                controlMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.MaximizeBox = false;
                controlMax = true;
            }
        }

        

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimizeBox = true;           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormDimension formulario = new FormDimension();
            formulario.SetFormularioPrincipal(this);
            formulario.ShowDialog();
        }
    }
}
