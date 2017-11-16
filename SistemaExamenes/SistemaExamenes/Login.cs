using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;
using SistemaExamenes.Administrador;
using SistemaExamenes.Maestro;
using SistemaExamenes.Alumnos;

namespace SistemaExamenes
{
    public partial class Login : Form
    {
        Acceso objlogin = new Acceso();
        BLL.Alumnos al = new BLL.Alumnos();
        BLL.Maestro maes = new BLL.Maestro();
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            Pantalla_Principal_Admin objmenuprincipal = new Pantalla_Principal_Admin();
            Pantalla_Principal_Maestro objmenuprincipal2 = new Pantalla_Principal_Maestro();
            Pantalla_Principal_Alum objmenuprincipal3 = new Pantalla_Principal_Alum();


            objlogin.LoginU = txt_Usuario.Text;
            objlogin.Contra = txt_Contraseña.Text;
            objlogin.LOGIN();
            if (objlogin.Tipo == 1)
            {


                MessageBox.Show("Bienvenido: " + txt_Usuario.Text, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //objmenuprincipal.tsl_Usuario.Text = objlogin.LoginSalida;
                //objmenuprincipal.tsl_Ubicacion.Text = objlogin.Ubicacion;
                //objmenuprincipal.tsl_Rol.Text = objlogin.Rol;
                objmenuprincipal.Show();
                this.Hide();
            }
            else if(objlogin.Tipo == 2)
            {
                MessageBox.Show("Bienvenido: " + txt_Usuario.Text, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maes.User = txt_Usuario.Text;
                maes.Pass = txt_Contraseña.Text;
                maes.ID_MAESTRO();
                int id = maes.IdMaestro;
                objmenuprincipal2.lb_IdMaestro.Text = Convert.ToString(id);
                objmenuprincipal2.Show();
                this.Hide();

            }
            else if (objlogin.Tipo == 3)
            {
                MessageBox.Show("Bienvenido: " + txt_Usuario.Text, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                al.User = txt_Usuario.Text;
                al.Pass = txt_Contraseña.Text;
                al.ID_ALUMNO();
                int id = al.IdAlumno;
                objmenuprincipal3.lb_Id.Text = Convert.ToString(id);
                objmenuprincipal3.Show();
                this.Hide();
                
            }
            else
            {
                txt_Usuario.Focus();
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
