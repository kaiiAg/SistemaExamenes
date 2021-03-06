﻿using System;
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
    public partial class Lista_Alumnos : Form
    {
        BLL.Maestro maes = new BLL.Maestro();
        public Lista_Alumnos()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Lista_Alumnos_Load(object sender, EventArgs e)
        {
            CARGAR_NOTAS();
        }

        private void CARGAR_NOTAS()
        {
            try
            {
                maes.IdMaestro = Convert.ToInt32(lb_ID.Text);
                dgv_Notas.DataSource = maes.MOSTRAR_NOTAS().Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_ListaNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nombre.Text != String.Empty)
                {
                    maes.Nombre = txt_Nombre.Text;
                    maes.IdMaestro = Convert.ToInt32(lb_ID.Text);
                    dgv_Notas.DataSource = maes.CARGAR_NOTAS_BUSQUEDA().Tables[0];
                }
                else
                {
                    CARGAR_NOTAS();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
