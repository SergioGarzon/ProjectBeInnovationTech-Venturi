using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatizador.Fomularios.Beneficios_fiscales
{
    public partial class TablaValoresBeneficioFiscal : Form
    {
        #region CONSTRUCTORS

        public TablaValoresBeneficioFiscal()
        {
            InitializeComponent();

            addGridView();           
        }


        private void TablaValoresBeneficioFiscal_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region EVENTS

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewButtonCell cell = (DataGridViewButtonCell) dgvBeneficioFiscal.Rows[e.RowIndex].Cells[e.ColumnIndex];

            string valor = "";


            if(cell.Value.ToString() == "COPIAR")
            {                
                valor = (dgvBeneficioFiscal.Rows[e.RowIndex].Cells[2].Value.ToString());
            }

            txtValueBeneficioFiscal.Text = valor;

            txtValueBeneficioFiscal.SelectAll();
            txtValueBeneficioFiscal.Copy();

            MessageBox.Show("Se ha copiado al portapapeles el valor de beneficio fiscal: " + txtValueBeneficioFiscal.Text, "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close();
            ((FormularioBeneficioFiscal) this.Owner).Enabled = true;
        }

        #endregion

        #region METHOD

        private void addGridView()
        {
            string[] numeroCST = { "00", "10", "20", "30", "40", "50", "51", "60", "70", "90" };

            string[] beneficio = { "NULL", "NULL" , "PR820001" , "PR800001", "PR810001", "PR800001", "PR840001", "PR830001",
                    "NULL", "PR820001", "NULL"};

            int contador = 0;

            for(int i = 1; i < 11; i++)
            {
                dgvBeneficioFiscal.Rows.Add(i, numeroCST[contador], beneficio[contador]);
                contador++;
            }
        }

        #endregion


    }
}
