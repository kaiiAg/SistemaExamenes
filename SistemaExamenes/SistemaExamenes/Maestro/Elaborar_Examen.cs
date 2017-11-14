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
        }

        private void CARGAR_MATERIAS()
        {
            DataSet ds;
            ds = maes.CARGA_MATERIAS();
            cb_Materias.DataSource = ds.Tables[0];
            cb_Materias.DisplayMember = ds.Tables[0].Columns["nombre"].ColumnName.ToString();
        }
    }
}
