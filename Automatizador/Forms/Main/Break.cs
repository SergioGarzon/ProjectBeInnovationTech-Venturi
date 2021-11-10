using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Automatizador.Fomularios
{
    public partial class Break : Form
    {
        private SoundPlayer sound;

        public Break()
        {
            InitializeComponent();
        }

        private void Break_Load(object sender, EventArgs e)
        {
        }

        private void AudioPlayer()
        {
            try
            {
                sound = new SoundPlayer(Application.StartupPath + @"\son\ball.wav");
                sound.Play();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try {
                sound.Stop();
            }
            catch(Exception e2) {
                
            }*/

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
