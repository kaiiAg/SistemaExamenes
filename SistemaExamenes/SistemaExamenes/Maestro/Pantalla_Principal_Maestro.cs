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
            try
            {
                Elaborar_Examen frm = new Elaborar_Examen();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Lista_Alumnos frm = new Lista_Alumnos();
                frm.lb_ID.Text = lb_IdMaestro.Text;
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Pantalla_Principal_Maestro_Load(object sender, EventArgs e)
        {

        }
    }
}
