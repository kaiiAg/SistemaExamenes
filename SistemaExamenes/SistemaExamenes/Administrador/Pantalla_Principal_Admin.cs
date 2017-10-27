using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExamenes.Administrador
{
    public partial class Pantalla_Principal_Admin : Form
    {
        public Pantalla_Principal_Admin()
        {
            InitializeComponent();
        }

        private void Pantalla_Principal_Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Lista_Maestros list_maes = new Lista_Maestros();
            list_maes.Show();

            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Alumnos list_alum = new Lista_Alumnos();
            list_alum.Show();
        }
    }
}
