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

namespace SistemaExamenes.Maestro
{
    public partial class Elaborar_Examen : Form
    {
        BLL.Maestro maes = new BLL.Maestro();
        public Elaborar_Examen()
        {
            InitializeComponent();
        }

        private void Elaborar_Examen_Load(object sender, EventArgs e)
        {
            CARGAR_MATERIAS();
            CARGAR_CODEXAMEN();
            pn_Respuestas.Visible = false;
            txt_PareoB.Enabled = false;
            btn_AceptarB.Enabled = false;
        }

        private void CARGAR_MATERIAS()
        {
            DataSet ds;
            ds = maes.CARGA_MATERIAS();
            cb_Materias.DataSource = ds.Tables[0];
            cb_Materias.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
        }

        private void CARGAR_CODEXAMEN()
        {
            maes.Nombre = cb_Materias.Text;
            maes.CARGA_CODEXAMEN();
            lb_Codigo.Text = maes.CodExamen;
        }

        private void cb_Materias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CARGAR_CODEXAMEN();
        }

        private void btn_GuardarPregunta_Click(object sender, EventArgs e)
        {
            INSERT_PREGUNTA_MARCAR();
            
        }

        private void INSERT_PREGUNTA_MARCAR()
        {
            if (txt_Pregunta.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la pregunta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }
            else
            {

                maes.Examen = cb_Materias.Text;
                maes.Pregunta = txt_Pregunta.Text;
                maes.Seccion = "Marque con X";
                maes.CodExamen = lb_Codigo.Text;
                maes.INSERT_PREGUNTA();

                if (maes.Validacion == "Insertado")
                {
                   
                    pn_Respuestas.Visible = true;
                    txt_Pregunta.Enabled = false;
                    btn_GuardarPregunta.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            INSERT_RESPUESTAS_MARCA();
            

        }

        private void INSERT_RESPUESTAS_MARCA()
        {
            #region Validaciones
            if (nu_PuntosMarque.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar los puntos de la respuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nu_PuntosMarque.Focus();
                return;
            }
            else if (txt_Respuesta1.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la respuesta 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }else if (txt_Respuesta2.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la respuesta 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }else if (txt_Respuesta3.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la respuesta 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }else if (txt_Respuesta4.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la respuesta 4", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }else if (ck_Respuesta1.Checked ==false && ck_Respuesta2.Checked==false && ck_Respuesta3.Checked==false && ck_Respuesta4.Checked == false)
            {
                MessageBox.Show("Favor seleccionar con el check la respuesta correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return;
            }
            #endregion

            if (ck_Respuesta1.Checked == true)
            {
                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta1.Text;
                maes.Puntos = Convert.ToDecimal(nu_PuntosMarque.Text);
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta2.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta3.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta4.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Pregunta y respuestas almacenadas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LIMPIAR();
                    pn_Respuestas.Visible = false;
                   
                    txt_Pregunta.Enabled = true;
                    btn_GuardarPregunta.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }else if (ck_Respuesta2.Checked == true)
            {
                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta1.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta2.Text;
                maes.Puntos = Convert.ToDecimal(nu_PuntosMarque.Text);
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta3.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta4.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Respuestas almacenadas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LIMPIAR();
                    pn_Respuestas.Visible = false;
                    
                    txt_Pregunta.Enabled = true;
                    btn_GuardarPregunta.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }else if (ck_Respuesta3.Checked == true)
            {
                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta1.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta2.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta3.Text;
                maes.Puntos = Convert.ToDecimal(nu_PuntosMarque.Text);
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta4.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Respuestas almacenadas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LIMPIAR();
                    pn_Respuestas.Visible = false;
                  
                    txt_Pregunta.Enabled = true;
                    btn_GuardarPregunta.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }else if (ck_Respuesta4.Checked == true)
            {
                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta1.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta2.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta3.Text;
                maes.Puntos = 0;
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                maes.Pregunta = txt_Pregunta.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_Respuesta4.Text;
                maes.Puntos = Convert.ToDecimal(nu_PuntosMarque.Text);
                maes.Seccion = "Marque con X";
                maes.INSERT_RESPUESTAS();

                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Respuestas almacenadas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LIMPIAR();
                    pn_Respuestas.Visible = false;
                    
                    txt_Pregunta.Enabled = true;
                    btn_GuardarPregunta.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            


        }

        private void LIMPIAR()
        {
            txt_Pregunta.Text = String.Empty;
            txt_Respuesta1.Text = String.Empty;
            txt_Respuesta2.Text = String.Empty;
            txt_Respuesta3.Text = String.Empty;
            txt_Respuesta4.Text = String.Empty;
            ck_Respuesta1.Checked = false;
            ck_Respuesta2.Checked = false;
            ck_Respuesta3.Checked = false;
            ck_Respuesta4.Checked = false;
            nu_PuntosMarque.Text = "";
        }

        private void btn_AgregarA_Click(object sender, EventArgs e)
        {
            INSERTAR_PREGUNTA_PAREO();
        }


        private void INSERTAR_PREGUNTA_PAREO()
        {
            if (txt_PareoA.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la pregunta de la columna A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }
            else
            {

                maes.Examen = cb_Materias.Text;
                maes.Pregunta = txt_PareoA.Text;
                maes.Seccion = "Pareo";
                maes.CodExamen = lb_Codigo.Text;
                maes.INSERT_PREGUNTA();

                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Pregunta guardada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txt_PareoB.Enabled = true;
                    btn_AceptarB.Enabled = true;
                    txt_PareoA.Enabled = false;
                    btn_AgregarA.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        private void btn_AceptarB_Click(object sender, EventArgs e)
        {
            INSERTAR_REPUESTA_PAREO();
            
        }

        private void INSERTAR_REPUESTA_PAREO()
        {
            if (txt_PareoB.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar la respuesta de la columna B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Pregunta.Focus();
                return;
            }else if (nu_PuntosPareo.Text == String.Empty)
            {
                MessageBox.Show("Favor ingresar los puntos de la respuesta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nu_PuntosPareo.Focus();
                return;
            }
            else
            {
                maes.Pregunta = txt_PareoA.Text;
                maes.CodExamen = lb_Codigo.Text;
                maes.Respuesta = txt_PareoB.Text;
                maes.Puntos = Convert.ToDecimal(nu_PuntosPareo.Text);
                maes.Seccion = "Pareo";
                maes.INSERT_RESPUESTAS();
                if (maes.Validacion == "Insertado")
                {
                    MessageBox.Show("Respuesta guardada Correctamente", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txt_PareoB.Enabled = false;
                    btn_AceptarB.Enabled = false;
                    txt_PareoA.Enabled = true;
                    btn_AgregarA.Enabled = true;
                    LIMPIAR1();

                 
                    

                }
                else
                {
                    MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void LIMPIAR1()
        {
            txt_PareoA.Text = String.Empty;
            txt_PareoB.Text = String.Empty;
            nu_PuntosPareo.Text = "";

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Recuerde Guardar antes de salir, esta seguro de Salir?", "Validacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                

                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void btn_GuardarTodo_Click(object sender, EventArgs e)
        {
            LIMPIAR();
            LIMPIAR1();
            maes.Nombre = cb_Materias.Text;
            maes.ACTUALIZA_SECUENCIA_EXAMEN();
            CARGAR_CODEXAMEN();
            MessageBox.Show("Examen Guardado", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
