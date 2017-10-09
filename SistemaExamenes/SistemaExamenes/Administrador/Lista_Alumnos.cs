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
    public partial class Lista_Alumnos : Form
    {
        Administracion admin = new Administracion();
        public Lista_Alumnos()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txt_Usuario.Text == string.Empty)
            {
                MessageBox.Show("Favor Ingresar Nuevo Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
                return;
            }
            else if (txt_Contraseña.Text == string.Empty)
            {
                MessageBox.Show("Favor Ingresar Contraseña para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseña.Focus();
                return;
            }           
            #endregion

            if(txt_Contraseña.Text == txt_Confirm_Contra.Text)
            {
                admin.Username = txt_Usuario.Text;
                admin.Password = txt_Contraseña.Text;
                admin.Status = 1;
                admin.Tipo = 3;
                admin.INSERT_USUARIOS();

                admin.Username = txt_Usuario.Text;
                admin.ID_USUARIO();
                CARGA_MAESTROS();

                if (admin.Validacion == "Insertado")
                {
                    MessageBox.Show("Usuario Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IDUsuario.Text = Convert.ToString(admin.ID);
                    LIMPIAR();
                   
                }
            }
            else
            {
                MessageBox.Show("Por favor Confirmar Contraseña", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void LIMPIAR()
        {
            txt_Usuario.Text = string.Empty;
            txt_Contraseña.Text = string.Empty;
            txt_Confirm_Contra.Text = string.Empty;
        }

        private void LIMPIAR1()
        {
            txt_IDUsuario.Text = string.Empty;
            txt_NomAlumno.Text = string.Empty;
            cb_Maestro.DataSource = null;
            cb_Grupo.Text = string.Empty;
            cb_Grado.Text = string.Empty;
        }
        private void Lista_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            lb_Confirmacion.Visible = true;
            txt_Confirm_Contra.Visible = true;
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            if (txt_IDUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe registrar primero un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IDUsuario.Focus();
                return;
            }
            else if (txt_NomAlumno.Text == string.Empty)
            {
                MessageBox.Show("Favor Ingresar Nombre del Estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NomAlumno.Focus();
                return;

            }else if(cb_Grado.Text == string.Empty)
            {
                MessageBox.Show("Favor escoger grado del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_Grado.Focus();
                return;
            }
            else if (cb_Grupo.Text == string.Empty)
            {
                MessageBox.Show("Favor escoger grupo del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_Grado.Focus();
                return;
            }
            #endregion

            admin.NombreMaestro = cb_Maestro.Text;
            admin.ID_MAESTRO();
            int id = admin.ID;

            admin.IdUsuario = Convert.ToInt32(txt_IDUsuario.Text);
            admin.IdMaestro = id;
            admin.Nombre = txt_NomAlumno.Text;
            admin.Grado = cb_Grado.Text;
            admin.Grupo = cb_Grupo.Text;
            admin.INSERT_ALUMNOS();
            if (admin.Validacion == "Insertado")
            {
                MessageBox.Show("Alumno Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LIMPIAR1();

            }
            else
            {
                MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }





        }

        private void CARGA_MAESTROS()
        {
            DataSet ds;
            ds = admin.CARGA_MAESTROS();            
            cb_Maestro.DataSource = ds.Tables[0];
            cb_Maestro.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
           //cb_Maestro.ValueMember = ds.Tables[0].Columns["Id_Rol"].ColumnName.ToString();
        }

        
    }
}
