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
                    lb_Confirmacion.Visible = false;
                    txt_Confirm_Contra.Visible = false;
                    panel1.Visible = false;
                    panel2.Visible = true;

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
            CARGAR_ALUMNOS();
            txt_Confirm_Contra.Visible = false;
            lb_Confirmacion.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;

            //txt_Nombre.AutoCompleteMode = AutoCompleteMode.Suggest;
            //txt_Nombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            //addItems(DataCollection);
            //txt_Nombre.AutoCompleteCustomSource = DataCollection;

        }

        //public void addItems(AutoCompleteStringCollection col)
        //{

        //    foreach (var alumno in dgv_Alumnos)
        //    {
        //        col.Add(alumno);


        //    }

        //}

        public void CARGAR_ALUMNOS()
        {
            dgv_Alumnos.DataSource = admin.CARGA_ALUMNOS().Tables[0];
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
                panel1.Visible = true;
                panel2.Visible = false;

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

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            admin.Nombre = txt_Nombre.Text;
            dgv_Alumnos.DataSource = admin.BUSQUEDA_ALUMNO().Tables[0];
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            CARGAR_ALUMNOS();
        }

        private void btn_BuscarMan_Click(object sender, EventArgs e)
        {
            

            admin.Nombre = txt_NomBusque.Text;
            admin.MANTENIMIENTO_BUSQUEDA();
            lb_idAlumno.Text = Convert.ToString(admin.IdAlumno);
            lb_idUsuario.Text = Convert.ToString(admin.IdUsuario);
            //int idmaestro = admin.IdMaestro;
            //admin.ID = idmaestro;
            //admin.NOMBRE_MAESTRO();
            txt_MaestroMan.Text = admin.NombreMaestro;
            cb_GradoMan.Text = admin.Grado;
            cb_GrupoMan.Text = admin.Grupo;
            
        }

        public void LimpiarMantenimiento()
        {
            txt_NomBusque.Text = String.Empty;
            txt_MaestroMan.Text = String.Empty;
            cb_GradoMan.Text = String.Empty;
            cb_GrupoMan.Text = String.Empty;
            lb_idAlumno.Text = String.Empty;
            lb_idUsuario.Text = String.Empty;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            admin.NombreMaestro = txt_MaestroMan.Text;
            admin.ID_MAESTRO();
            int id = admin.ID;

            admin.IdAlumno = Convert.ToInt32(lb_idAlumno.Text);
            admin.Nombre = txt_NomBusque.Text;
            admin.IdMaestro = id;
            admin.Grado = cb_GradoMan.Text;
            admin.Grupo = cb_GrupoMan.Text;
            admin.UPDATE_ALUMNO();

            if (admin.Validacion == "Actualizado")
            {
                MessageBox.Show("Informacion Actualizada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarMantenimiento();
                

            }


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            admin.IdAlumno = Convert.ToInt32(lb_idAlumno.Text);
            admin.DELETE_ALUMNO();

            if (admin.Validacion == "Eliminado")
            {
                MessageBox.Show("Informacion Borrada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarMantenimiento();
                
            }

            admin.IdUsuario = Convert.ToInt32(lb_idUsuario.Text);
            admin.DELETE_USER();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
