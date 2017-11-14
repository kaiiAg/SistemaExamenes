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

namespace SistemaExamenes.Administrador
{
    public partial class Lista_Materias : Form
    {
        Administracion admin = new Administracion();
        public Lista_Materias()
        {
            InitializeComponent();
        }

        private void Lista_Materias_Load(object sender, EventArgs e)
        {
            CARGA();
        }
        private void CARGA()
        {
            dgv_Materias.DataSource = admin.CARGA_MATERIAS().Tables[0];
        }

        private void INSERTAR()
        {
            if (txt_Materia.Text == String.Empty)
            {
                MessageBox.Show("Ingrese Materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Materia.Focus();
                return;
            }
            else
            {
                admin.Nombre = txt_Materia.Text;
                admin.INSERT_MATERIAS();
                if (admin.Validacion == "Insertado")
                {
                    MessageBox.Show("Materia Insertada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_Materia.Text = String.Empty;
                    CARGA();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            


            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            INSERTAR();
        }
    }
}
