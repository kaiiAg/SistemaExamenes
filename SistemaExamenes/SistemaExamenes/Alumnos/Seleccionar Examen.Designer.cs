namespace SistemaExamenes.Alumnos
{
    partial class Seleccionar_Examen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seleccionar_Examen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_CodExamen = new System.Windows.Forms.ComboBox();
            this.lb_IdExamen = new System.Windows.Forms.Label();
            this.lb_SeccionX = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_Respuestas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Pregunta = new System.Windows.Forms.Label();
            this.cb_IdPreguntaX = new System.Windows.Forms.ComboBox();
            this.btn_Siguiente = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ColumnaB = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgv_ColumnaA = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cb_PreguntasPa = new System.Windows.Forms.ComboBox();
            this.lb_SeccionPareo = new System.Windows.Forms.Label();
            this.lb_IdAlumno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_CargarExamen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cargar = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Respuestas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Siguiente)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnaA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cargar)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_CodExamen
            // 
            this.cb_CodExamen.FormattingEnabled = true;
            this.cb_CodExamen.Location = new System.Drawing.Point(488, 61);
            this.cb_CodExamen.Margin = new System.Windows.Forms.Padding(4);
            this.cb_CodExamen.Name = "cb_CodExamen";
            this.cb_CodExamen.Size = new System.Drawing.Size(274, 30);
            this.cb_CodExamen.TabIndex = 0;
            // 
            // lb_IdExamen
            // 
            this.lb_IdExamen.AutoSize = true;
            this.lb_IdExamen.Location = new System.Drawing.Point(12, 71);
            this.lb_IdExamen.Name = "lb_IdExamen";
            this.lb_IdExamen.Size = new System.Drawing.Size(96, 24);
            this.lb_IdExamen.TabIndex = 2;
            this.lb_IdExamen.Text = "IdExamen";
            this.lb_IdExamen.Visible = false;
            // 
            // lb_SeccionX
            // 
            this.lb_SeccionX.AutoSize = true;
            this.lb_SeccionX.Location = new System.Drawing.Point(16, 17);
            this.lb_SeccionX.Name = "lb_SeccionX";
            this.lb_SeccionX.Size = new System.Drawing.Size(131, 24);
            this.lb_SeccionX.TabIndex = 3;
            this.lb_SeccionX.Text = "Marque con X";
            this.lb_SeccionX.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 139);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(750, 587);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.cb_IdPreguntaX);
            this.tabPage1.Controls.Add(this.btn_Siguiente);
            this.tabPage1.Controls.Add(this.lb_SeccionX);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marque con X";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgv_Respuestas);
            this.panel2.Controls.Add(this.lb_Pregunta);
            this.panel2.Location = new System.Drawing.Point(133, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(583, 288);
            this.panel2.TabIndex = 13;
            // 
            // dgv_Respuestas
            // 
            this.dgv_Respuestas.AllowUserToAddRows = false;
            this.dgv_Respuestas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Respuestas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_Respuestas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Respuestas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Respuestas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Respuestas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Respuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Respuestas.ColumnHeadersVisible = false;
            this.dgv_Respuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.respuesta});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Respuestas.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_Respuestas.DoubleBuffered = true;
            this.dgv_Respuestas.EnableHeadersVisualStyles = false;
            this.dgv_Respuestas.GridColor = System.Drawing.Color.White;
            this.dgv_Respuestas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_Respuestas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_Respuestas.Location = new System.Drawing.Point(99, 64);
            this.dgv_Respuestas.Name = "dgv_Respuestas";
            this.dgv_Respuestas.ReadOnly = true;
            this.dgv_Respuestas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Respuestas.RowTemplate.Height = 24;
            this.dgv_Respuestas.Size = new System.Drawing.Size(481, 206);
            this.dgv_Respuestas.TabIndex = 12;
            // 
            // respuesta
            // 
            this.respuesta.DataPropertyName = "respuesta";
            this.respuesta.HeaderText = "respuesta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            // 
            // lb_Pregunta
            // 
            this.lb_Pregunta.AutoSize = true;
            this.lb_Pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pregunta.Location = new System.Drawing.Point(95, 11);
            this.lb_Pregunta.Name = "lb_Pregunta";
            this.lb_Pregunta.Size = new System.Drawing.Size(0, 29);
            this.lb_Pregunta.TabIndex = 0;
            // 
            // cb_IdPreguntaX
            // 
            this.cb_IdPreguntaX.FormattingEnabled = true;
            this.cb_IdPreguntaX.Location = new System.Drawing.Point(595, 11);
            this.cb_IdPreguntaX.Name = "cb_IdPreguntaX";
            this.cb_IdPreguntaX.Size = new System.Drawing.Size(121, 30);
            this.cb_IdPreguntaX.TabIndex = 11;
            this.cb_IdPreguntaX.Visible = false;
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Siguiente.Image = ((System.Drawing.Image)(resources.GetObject("btn_Siguiente.Image")));
            this.btn_Siguiente.ImageActive = null;
            this.btn_Siguiente.Location = new System.Drawing.Point(550, 487);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(166, 59);
            this.btn_Siguiente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Siguiente.TabIndex = 5;
            this.btn_Siguiente.TabStop = false;
            this.btn_Siguiente.Zoom = 10;
            this.btn_Siguiente.Click += new System.EventHandler(this.btn_Siguiente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgv_ColumnaB);
            this.tabPage2.Controls.Add(this.dgv_ColumnaA);
            this.tabPage2.Controls.Add(this.cb_PreguntasPa);
            this.tabPage2.Controls.Add(this.lb_SeccionPareo);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pareo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columna B";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Columna A";
            this.label1.Visible = false;
            // 
            // dgv_ColumnaB
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ColumnaB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_ColumnaB.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_ColumnaB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ColumnaB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ColumnaB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_ColumnaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ColumnaB.DoubleBuffered = true;
            this.dgv_ColumnaB.EnableHeadersVisualStyles = false;
            this.dgv_ColumnaB.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_ColumnaB.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_ColumnaB.Location = new System.Drawing.Point(376, 84);
            this.dgv_ColumnaB.Name = "dgv_ColumnaB";
            this.dgv_ColumnaB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ColumnaB.RowTemplate.Height = 24;
            this.dgv_ColumnaB.Size = new System.Drawing.Size(360, 462);
            this.dgv_ColumnaB.TabIndex = 3;
            this.dgv_ColumnaB.Visible = false;
            // 
            // dgv_ColumnaA
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ColumnaA.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_ColumnaA.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_ColumnaA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ColumnaA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ColumnaA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_ColumnaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ColumnaA.DoubleBuffered = true;
            this.dgv_ColumnaA.EnableHeadersVisualStyles = false;
            this.dgv_ColumnaA.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_ColumnaA.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_ColumnaA.Location = new System.Drawing.Point(6, 84);
            this.dgv_ColumnaA.Name = "dgv_ColumnaA";
            this.dgv_ColumnaA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ColumnaA.RowTemplate.Height = 24;
            this.dgv_ColumnaA.Size = new System.Drawing.Size(352, 462);
            this.dgv_ColumnaA.TabIndex = 2;
            this.dgv_ColumnaA.Visible = false;
            // 
            // cb_PreguntasPa
            // 
            this.cb_PreguntasPa.FormattingEnabled = true;
            this.cb_PreguntasPa.Location = new System.Drawing.Point(589, 15);
            this.cb_PreguntasPa.Name = "cb_PreguntasPa";
            this.cb_PreguntasPa.Size = new System.Drawing.Size(121, 30);
            this.cb_PreguntasPa.TabIndex = 1;
            this.cb_PreguntasPa.Visible = false;
            // 
            // lb_SeccionPareo
            // 
            this.lb_SeccionPareo.AutoSize = true;
            this.lb_SeccionPareo.Location = new System.Drawing.Point(27, 21);
            this.lb_SeccionPareo.Name = "lb_SeccionPareo";
            this.lb_SeccionPareo.Size = new System.Drawing.Size(60, 24);
            this.lb_SeccionPareo.TabIndex = 0;
            this.lb_SeccionPareo.Text = "Pareo";
            this.lb_SeccionPareo.Visible = false;
            // 
            // lb_IdAlumno
            // 
            this.lb_IdAlumno.AutoSize = true;
            this.lb_IdAlumno.Location = new System.Drawing.Point(145, 71);
            this.lb_IdAlumno.Name = "lb_IdAlumno";
            this.lb_IdAlumno.Size = new System.Drawing.Size(91, 24);
            this.lb_IdAlumno.TabIndex = 5;
            this.lb_IdAlumno.Text = "IdAlumno";
            this.lb_IdAlumno.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 42);
            this.panel1.TabIndex = 6;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(679, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(46, 42);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(726, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // btn_CargarExamen
            // 
            this.btn_CargarExamen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_CargarExamen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_CargarExamen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_CargarExamen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CargarExamen.BorderRadius = 0;
            this.btn_CargarExamen.ButtonText = "Iniciar Examen";
            this.btn_CargarExamen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CargarExamen.DisabledColor = System.Drawing.Color.Gray;
            this.btn_CargarExamen.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_CargarExamen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_CargarExamen.Iconimage")));
            this.btn_CargarExamen.Iconimage_right = null;
            this.btn_CargarExamen.Iconimage_right_Selected = null;
            this.btn_CargarExamen.Iconimage_Selected = null;
            this.btn_CargarExamen.IconMarginLeft = 0;
            this.btn_CargarExamen.IconMarginRight = 0;
            this.btn_CargarExamen.IconRightVisible = true;
            this.btn_CargarExamen.IconRightZoom = 0D;
            this.btn_CargarExamen.IconVisible = true;
            this.btn_CargarExamen.IconZoom = 90D;
            this.btn_CargarExamen.IsTab = false;
            this.btn_CargarExamen.Location = new System.Drawing.Point(487, 101);
            this.btn_CargarExamen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_CargarExamen.Name = "btn_CargarExamen";
            this.btn_CargarExamen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_CargarExamen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_CargarExamen.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_CargarExamen.selected = false;
            this.btn_CargarExamen.Size = new System.Drawing.Size(275, 0);
            this.btn_CargarExamen.TabIndex = 7;
            this.btn_CargarExamen.Text = "Iniciar Examen";
            this.btn_CargarExamen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CargarExamen.Textcolor = System.Drawing.Color.White;
            this.btn_CargarExamen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarExamen.Click += new System.EventHandler(this.btn_CargarExamen_Click);
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Cargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cargar.Image")));
            this.btn_Cargar.ImageActive = null;
            this.btn_Cargar.Location = new System.Drawing.Point(488, 101);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(274, 40);
            this.btn_Cargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cargar.TabIndex = 8;
            this.btn_Cargar.TabStop = false;
            this.btn_Cargar.Zoom = 10;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_CargarExamen_Click);
            // 
            // Seleccionar_Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(771, 737);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.btn_CargarExamen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lb_IdAlumno);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lb_IdExamen);
            this.Controls.Add(this.cb_CodExamen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seleccionar_Examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar_Examen";
            this.Load += new System.EventHandler(this.Seleccionar_Examen_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Respuestas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Siguiente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ColumnaA)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_CodExamen;
        public System.Windows.Forms.Label lb_IdExamen;
        public System.Windows.Forms.Label lb_SeccionX;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label lb_IdAlumno;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lb_Pregunta;
        private Bunifu.Framework.UI.BunifuImageButton btn_Siguiente;
        private Bunifu.Framework.UI.BunifuFlatButton btn_CargarExamen;
        private System.Windows.Forms.Label lb_SeccionPareo;
        private System.Windows.Forms.ComboBox cb_IdPreguntaX;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Respuestas;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_ColumnaB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_ColumnaA;
        private System.Windows.Forms.ComboBox cb_PreguntasPa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private Bunifu.Framework.UI.BunifuImageButton btn_Cargar;
    }
}