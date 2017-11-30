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
    public partial class Lista_Maestros : Form
    {
        Administracion admin = new Administracion();

        public Lista_Maestros()
        {
            InitializeComponent();
        }

        private void Lista_Maestros_Load(object sender, EventArgs e)
        {
            try
            {
                CARGAR_MAESTROS();
                pn_Registro.Visible = false;
                txt_ConfiContra.Visible = false;
                lb_Confirmas.Visible = false;
                pn_Crear.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " Lista_Maestros_Load");
            }
        }

        public void CARGAR_MAESTROS()
        {
            try
            {
                dvg_Maestros.DataSource = admin.CARGA_MAESTROS_ALL().Tables[0];
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " CARGAR_MAESTROS");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            CARGAR_MAESTROS();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                admin.NombreMaestro = txt_NombreBus.Text;
                dvg_Maestros.DataSource = admin.BUSQUEDA_MAESTRO().Tables[0];
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_Buscar_Click");
            }
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            try
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

                if (txt_Contraseña.Text == txt_ConfiContra.Text)
                {
                    admin.Username = txt_Usuario.Text;
                    admin.Password = txt_Contraseña.Text;
                    admin.Status = 1;
                    admin.Tipo = 2;
                    admin.INSERT_USUARIOS();

                    admin.Username = txt_Usuario.Text;
                    admin.ID_USUARIO();


                    if (admin.Validacion == "Insertado")
                    {
                        MessageBox.Show("Usuario Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_idUsuario.Text = Convert.ToString(admin.ID);
                        LIMPIAR();

                        txt_ConfiContra.Visible = false;
                        lb_Confirmas.Visible = false;
                        pn_Crear.Visible = false;
                        pn_Registro.Visible = true;


                    }
                }
                else
                {
                    MessageBox.Show("Por favor Confirmar Contraseña", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_Crear_Click");
            }
        }

        private void LIMPIAR()
        {
            txt_Usuario.Text = string.Empty;
            txt_Contraseña.Text = "Contraseña";
            txt_ConfiContra.Text = "Contraseña";
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_ConfiContra.Visible = true;
                lb_Confirmas.Visible = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " txt_Contraseña_TextChanged");
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validaciones
                if (txt_idUsuario.Text == string.Empty)
                {
                    MessageBox.Show("Debe registrar primero un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_idUsuario.Focus();
                    return;
                }
                else if (txt_NomMaestro.Text == string.Empty)
                {
                    MessageBox.Show("Favor Ingresar Nombre del Estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_NomMaestro.Focus();
                    return;

                }
                #endregion

                admin.IdUsuario = Convert.ToInt32(txt_idUsuario.Text);
                admin.NombreMaestro = txt_NomMaestro.Text;
                admin.INSERT_MAESTROS();
                if (admin.Validacion == "Insertado")
                {
                    MessageBox.Show("Maestro Insertado Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LIMPIAR1();
                    CARGAR_MAESTROS();
                    pn_Registro.Visible = false;
                    pn_Crear.Visible = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_Registrar_Click");
            }

        }

        private void LIMPIAR1()
        {
            txt_idUsuario.Text = string.Empty;
            txt_NomMaestro.Text = string.Empty;
          
        }

        private void btn_BuscarMan_Click(object sender, EventArgs e)
        {
            try
            {
                admin.NombreMaestro = txt_NomBusque.Text;
                admin.MANTENIMIENTO_BUSQUEDA_MAESTRO();
                lb_IdMaestro.Text = Convert.ToString(admin.IdMaestro);
                lb_idUsuario.Text = Convert.ToString(admin.IdUsuario);
                txt_NameMaestro.Text = admin.NombreMaestro;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_BuscarMan_Click");
            }


        }

        public void LimpiarMantenimiento()
        {
            txt_NomBusque.Text = String.Empty;
            txt_NameMaestro.Text= String.Empty;
            lb_IdMaestro.Text = String.Empty;

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                admin.IdMaestro = Convert.ToInt32(lb_IdMaestro.Text);
                admin.NombreMaestro = txt_NameMaestro.Text;
                admin.UPDATE_MAESTRO();


                if (admin.Validacion == "Actualizado")
                {
                    MessageBox.Show("Informacion Actualizada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarMantenimiento();
                    CARGAR_MAESTROS();

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_Modificar_Click");
            }


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                admin.IdMaestro = Convert.ToInt32(lb_IdMaestro.Text);
                admin.DELETE_MAESTRO();
                if (admin.Validacion == "Eliminado")
                {
                    MessageBox.Show("Informacion Borrada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    admin.IdUsuario = Convert.ToInt32(lb_idUsuario.Text);
                    admin.DELETE_USER();
                    LimpiarMantenimiento();
                    CARGAR_MAESTROS();

                }

                admin.IdUsuario = Convert.ToInt32(lb_idUsuario.Text);
                admin.DELETE_USER();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " btn_Eliminar_Click");
            }

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
