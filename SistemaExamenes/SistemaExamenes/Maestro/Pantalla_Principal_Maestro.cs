using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExamenes.Maestro
{
    public partial class Pantalla_Principal_Maestro : Form
    {
        public Pantalla_Principal_Maestro()
        {
            InitializeComponent();
        }

        private void elaborarExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Elaborar_Examen frm = new Elaborar_Examen();
            frm.Show();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Alumnos frm = new Lista_Alumnos();
            frm.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta seguro de Cerrar Sesion", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                Application.Restart();

            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
