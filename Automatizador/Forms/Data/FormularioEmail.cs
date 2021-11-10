using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador
{
    public partial class FormularioEmail : Form
    {
        private bool control;

        public FormularioEmail()
        {
            InitializeComponent();
            ChargeComboBox();
            datosCasillasCorreo();

            control = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChargeComboBox()
        {
            string[] name = { "DIEGO RODRIGUEZ" , "EDUARDO TAPIA"  , "JUAN PABLO TOSCANELLI" , 
                              "JULIO DIAZ" , "JUAN JOSÉ OCHOA" , "DIEGO SAAVEDRA"  ,
                              "YENHY GUZMÁN", "CAMILA BAETTI", "SERGIO GARZÓN", "FACUNDO ASTUDILLO" };


            for (int i = 0; i < name.Length; i++)
            {
                cmbNombres.Items.Add(name[i].ToString());
            }
        }

        private void datosCasillasCorreo()
        {
            string[] data = {
                "Las casillas @venturi.com.ar son utilizadas por betech para comunicaciones para " +
                "\ncon el cliente Venturi. Se componen con la primera letra del nombre del usuario, " +
                "\nseguido del apellido ej.: yguzman@venturi.com.ar",
                "Las casillas .venturi@gmail.com ó vh@gmail.com se usan para interactuar " +
                "\ncon los usuarios el cliente Venturi mediante las herramientas de Google. " +
                "\nSe componen con la primera letra del nombre del usuario, seguido del apellido " +
                "\nej.: yguzman.venturi@gmal.com ó jsalguerovh@gmail.com",
                "Las casillas .betech@gmail.com son de uso interno de la empresa para compartir " +
                "\narchivos e interactuar con las herramientas de Google. Se componen con la primera " +
                "\nletra del nombre del usuario, seguido del apellido ej.: yguzman.betech@gmail.com",
                "Las casillas @beitech.com.ar son para el uso y contacto con gente externa a la empresa."
            };

            toolTip1.SetToolTip(btnBeTechGmail, data[0]);
            toolTip1.SetToolTip(btnVenturiGmail, data[1]);
            toolTip1.SetToolTip(btnBetech, data[2]);
            toolTip1.SetToolTip(btnVenturi, data[3]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cmbNombres.SelectedIndex != -1 && control)
            {
                control = false;
                txtBetechGmail.SelectAll();
                txtBetechGmail.Copy();
                DeshabilitarCampos();                
            }            
        }

        private void btnVenturiGmail_Click(object sender, EventArgs e)
        {
            if (cmbNombres.SelectedIndex != -1 && control)
            {
                control = false;
                txtVenturiGmail.SelectAll();
                txtVenturiGmail.Copy();
                DeshabilitarCampos();
            }            
        }

        private void btnBetech_Click(object sender, EventArgs e)
        {
            if (cmbNombres.SelectedIndex != -1 && control)
            {
                control = false;
                txtBetech.SelectAll();
                txtBetech.Copy();
                DeshabilitarCampos();
            }            
        }

        private void btnVenturi_Click(object sender, EventArgs e)
        {
            if (cmbNombres.SelectedIndex != -1 && control)
            {
                control = false;
                txtVenturi.SelectAll();
                txtVenturi.Copy();
                DeshabilitarCampos();
            }            
        }

        private void cmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueBetechGmail, valueBetech, valueVenturi, valueVenturiGmail, nombreAuxiliar;

            valueBetechGmail = ".betech@gmail.com";
            valueBetech = "@beitech.com.ar";
            valueVenturi = "@venturi.com.ar";
            valueVenturiGmail = ".venturi@gmail.com";
            nombreAuxiliar = "";

            switch (cmbNombres.SelectedIndex)
            {
                case 0: nombreAuxiliar = "drodriguez"; break;
                case 1: nombreAuxiliar = "etapia"; break;
                case 2: nombreAuxiliar = "jtoscanelli"; break;
                case 3: nombreAuxiliar = "jdiaz"; break;
                case 4: nombreAuxiliar = "jocha"; break;
                case 5: nombreAuxiliar = "dsaavedra"; break;
                case 6: nombreAuxiliar = "yguzman"; break;
                case 7: nombreAuxiliar = "cbaetti"; break;
                case 8: nombreAuxiliar = "sgarzon"; break;
                case 9: nombreAuxiliar = "fastudillo"; break;
            }

            txtBetech.Text = nombreAuxiliar + valueBetech;
            txtBetechGmail.Text = nombreAuxiliar + valueBetechGmail;
            txtVenturi.Text = nombreAuxiliar + valueVenturi;
            txtVenturiGmail.Text = nombreAuxiliar + valueVenturiGmail;
        }


        private void DeshabilitarCampos()
        {
            pnlEmailCopiado.Visible = true;
            Thread.Sleep(1000);
            pnlEmailCopiado.Visible = false;
            control = true;
        }

    }
}
