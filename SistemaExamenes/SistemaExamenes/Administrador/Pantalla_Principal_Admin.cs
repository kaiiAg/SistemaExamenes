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
            try
            {
                Lista_Maestros list_maes = new Lista_Maestros();
                list_maes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void maestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                Lista_Alumnos list_alum = new Lista_Alumnos();
                list_alum.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Materias list_mat = new Lista_Materias();
                list_mat.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Desarrollador: Karen Aguilar Garita\n Correo: karenaguilargarita@outlook.com\n" +
                    "", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
