namespace SistemaExamenes.Maestro
{
    partial class Lista_Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Alumnos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgv_Notas = new System.Windows.Forms.DataGridView();
            this.NombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamenRealizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosExamen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntosObtenidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 42);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(668, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // dgv_Notas
            // 
            this.dgv_Notas.AllowUserToAddRows = false;
            this.dgv_Notas.AllowUserToDeleteRows = false;
            this.dgv_Notas.AllowUserToOrderColumns = true;
            this.dgv_Notas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Notas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreAlumno,
            this.Grado,
            this.Grupo,
            this.Fecha,
            this.ExamenRealizado,
            this.PuntosExamen,
            this.PuntosObtenidos});
            this.dgv_Notas.Location = new System.Drawing.Point(12, 151);
            this.dgv_Notas.Name = "dgv_Notas";
            this.dgv_Notas.ReadOnly = true;
            this.dgv_Notas.RowTemplate.Height = 24;
            this.dgv_Notas.Size = new System.Drawing.Size(699, 412);
            this.dgv_Notas.TabIndex = 1;
            // 
            // NombreAlumno
            // 
            this.NombreAlumno.DataPropertyName = "nombre";
            this.NombreAlumno.HeaderText = "NombreAlumno";
            this.NombreAlumno.Name = "NombreAlumno";
            this.NombreAlumno.ReadOnly = true;
            this.NombreAlumno.Width = 150;
            // 
            // Grado
            // 
            this.Grado.DataPropertyName = "grado";
            this.Grado.HeaderText = "Grado";
            this.Grado.Name = "Grado";
            this.Grado.ReadOnly = true;
            // 
            // Grupo
            // 
            this.Grupo.DataPropertyName = "grupo";
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            this.Grupo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // ExamenRealizado
            // 
            this.ExamenRealizado.DataPropertyName = "codExamen";
            this.ExamenRealizado.HeaderText = "ExamenRealizado";
            this.ExamenRealizado.Name = "ExamenRealizado";
            this.ExamenRealizado.ReadOnly = true;
            this.ExamenRealizado.Width = 150;
            // 
            // PuntosExamen
            // 
            this.PuntosExamen.DataPropertyName = "Puntos del Examen";
            this.PuntosExamen.HeaderText = "PuntosExamen";
            this.PuntosExamen.Name = "PuntosExamen";
            this.PuntosExamen.ReadOnly = true;
            this.PuntosExamen.Width = 150;
            // 
            // PuntosObtenidos
            // 
            this.PuntosObtenidos.DataPropertyName = "resultado";
            this.PuntosObtenidos.HeaderText = "PuntosObtenidos";
            this.PuntosObtenidos.Name = "PuntosObtenidos";
            this.PuntosObtenidos.ReadOnly = true;
            this.PuntosObtenidos.Width = 150;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombre.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Nombre.HintText = "Nombre Alumno";
            this.txt_Nombre.isPassword = false;
            this.txt_Nombre.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Nombre.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Nombre.LineThickness = 3;
            this.txt_Nombre.Location = new System.Drawing.Point(13, 87);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(379, 33);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(399, 81);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(111, 38);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // Lista_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 575);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.dgv_Notas);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Alumnos";
            this.Load += new System.EventHandler(this.Lista_Alumnos_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Notas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.DataGridView dgv_Notas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamenRealizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosExamen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntosObtenidos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
    }
}