using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SistemaExamenes.Alumnos
{
    public partial class Pantalla_Principal_Alum : Form
    {
        
        BLL.Alumnos al = new BLL.Alumnos();
        BLL.Maestro maes = new BLL.Maestro();
        public Pantalla_Principal_Alum()
        {
            InitializeComponent();
        }

        

        private void CARGAR_MATERIAS()
        {
            DataSet ds;
            ds = maes.CARGA_MATERIAS();
            cb_Materias.DataSource = ds.Tables[0];
            cb_Materias.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            Seleccionar_Examen frm = new Seleccionar_Examen();
            al.Nombre = cb_Materias.Text;
            al.ID_EXAMEN();
            int id = al.IdExamen;
            frm.lb_IdExamen.Text = Convert.ToString(id);
            frm.lb_IdAlumno.Text = lb_Id.Text;
            frm.Show();

        }

        private void Pantalla_Principal_Alum_Load(object sender, EventArgs e)
        {
            CARGAR_MATERIAS();
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

        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desarrollador: Karen Aguilar Garita\n Correo: karenaguilargarita@outlook.com\n" +
                "", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
