using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaExamenes.Alumnos
{
    public partial class Seleccionar_Examen : Form
    {
        BLL.Alumnos al = new BLL.Alumnos();
        int i = 1;
        public Seleccionar_Examen()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CARGAR_CODEXAMEN()
        {
            DataSet ds;
            al.IdExamen = Convert.ToInt32(lb_IdExamen.Text);
            ds = al.CARGAR_CODEXAMEN();
            cb_CodExamen.DataSource = ds.Tables[0];
            cb_CodExamen.DisplayMember = ds.Tables[0].Columns["codigoExamen"].ColumnName.ToString();
        }

        private void Seleccionar_Examen_Load(object sender, EventArgs e)
        {
            CARGAR_CODEXAMEN();
            

        }

        

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            INSERT_RESPUESTAS();
        }

        private void INSERT_RESPUESTAS()
        {
            string dato = "";
            int filaSeleccionada =
                      dgv_Respuestas.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (filaSeleccionada == 1)
            {
                foreach (DataGridViewRow rowPrincipal in dgv_Respuestas.SelectedRows)
                {
                    dato = (Convert.ToString(rowPrincipal.Cells["respuesta"].Value).ToString());

                }
            }

                    al.IdExamen = Convert.ToInt32(lb_IdExamen.Text);
            al.Pregunta = lb_Pregunta.Text;
            al.Respuesta = dato;
            al.IdAlumno = Convert.ToInt32(lb_IdAlumno.Text);
            al.CodExamen = cb_CodExamen.Text;
            al.INSERT_RESPUESTAS_ALUMNOS();
            if (al.Validacion == "Insertado")
            {

                try
                {
                    cb_IdPreguntaX.SelectedIndex += 1;
                    MOSTRAR_PREGUNTA();
                    MOSTRAR_RESPUESTA();

                }catch (Exception ex)
                {
                    MessageBox.Show("Finalizacion de parte Marque con X");
                }

            }
            else
            {
                MessageBox.Show("Ocurrio un error", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        private void btn_CargarExamen_Click(object sender, EventArgs e)
        {
            CARGAR_IDPREGUNTA_X();
            MOSTRAR_PREGUNTA();
            MOSTRAR_RESPUESTA();
        }

        private void CARGAR_IDPREGUNTA_X()
        {
            DataSet ds;
            al.IdExamen = Convert.ToInt32(lb_IdExamen.Text);
            al.CodExamen = cb_CodExamen.Text;
            al.Seccion = lb_SeccionX.Text;
            ds = al.ID_PREGUNTA();
            cb_IdPreguntaX.DataSource = ds.Tables[0];
            cb_IdPreguntaX.DisplayMember = ds.Tables[0].Columns["idPregunta"].ColumnName.ToString();

        }

        
        private void MOSTRAR_PREGUNTA()
        {
            al.IdPregunta = Convert.ToInt32(cb_IdPreguntaX.Text);
            al.MOSTRAR_PREGUNTA();
            lb_Pregunta.Text = al.Pregunta;
        }

        private void MOSTRAR_RESPUESTA()
        {
            al.IdPregunta = Convert.ToInt32(cb_IdPreguntaX.Text);
           
            dgv_Respuestas.DataSource = al.MOSTRAR_RESPUESTA().Tables[0];
           
        }

        
    }
}
