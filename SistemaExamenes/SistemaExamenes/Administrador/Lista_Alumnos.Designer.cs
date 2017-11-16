namespace SistemaExamenes.Administrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Alumnos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Alumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Nombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Registrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_NomAlumno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_IDUsuario = new System.Windows.Forms.TextBox();
            this.cb_Grupo = new System.Windows.Forms.ComboBox();
            this.cb_Grado = new System.Windows.Forms.ComboBox();
            this.cb_Maestro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Crear = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_Confirm_Contra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_Confirmacion = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Limpiar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Modificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_BuscarMan = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_MaestroMan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_NomBusque = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_idUsuario = new System.Windows.Forms.Label();
            this.lb_idAlumno = new System.Windows.Forms.Label();
            this.cb_GrupoMan = new System.Windows.Forms.ComboBox();
            this.cb_GradoMan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarMan)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(18, 59);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 534);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dgv_Alumnos);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(673, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Alumnos";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgv_Alumnos
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Alumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Alumnos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Alumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Alumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Alumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.DoubleBuffered = true;
            this.dgv_Alumnos.EnableHeadersVisualStyles = false;
            this.dgv_Alumnos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_Alumnos.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_Alumnos.Location = new System.Drawing.Point(7, 104);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Alumnos.RowTemplate.Height = 24;
            this.dgv_Alumnos.Size = new System.Drawing.Size(661, 386);
            this.dgv_Alumnos.TabIndex = 4;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(387, 55);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(60, 32);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
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
            this.txt_Nombre.Location = new System.Drawing.Point(48, 54);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(323, 33);
            this.txt_Nombre.TabIndex = 2;
            this.txt_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(673, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Alumno";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Registrar);
            this.panel2.Controls.Add(this.txt_NomAlumno);
            this.panel2.Controls.Add(this.txt_IDUsuario);
            this.panel2.Controls.Add(this.cb_Grupo);
            this.panel2.Controls.Add(this.cb_Grado);
            this.panel2.Controls.Add(this.cb_Maestro);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(335, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 461);
            this.panel2.TabIndex = 3;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageActive = null;
            this.btn_Registrar.Location = new System.Drawing.Point(33, 373);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(276, 39);
            this.btn_Registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Registrar.TabIndex = 13;
            this.btn_Registrar.TabStop = false;
            this.btn_Registrar.Zoom = 10;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // txt_NomAlumno
            // 
            this.txt_NomAlumno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomAlumno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NomAlumno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NomAlumno.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomAlumno.HintText = "Nombre Alumno";
            this.txt_NomAlumno.isPassword = false;
            this.txt_NomAlumno.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NomAlumno.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NomAlumno.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NomAlumno.LineThickness = 3;
            this.txt_NomAlumno.Location = new System.Drawing.Point(33, 177);
            this.txt_NomAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomAlumno.Name = "txt_NomAlumno";
            this.txt_NomAlumno.Size = new System.Drawing.Size(274, 33);
            this.txt_NomAlumno.TabIndex = 12;
            this.txt_NomAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_IDUsuario
            // 
            this.txt_IDUsuario.Enabled = false;
            this.txt_IDUsuario.Location = new System.Drawing.Point(72, 20);
            this.txt_IDUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IDUsuario.Name = "txt_IDUsuario";
            this.txt_IDUsuario.Size = new System.Drawing.Size(212, 28);
            this.txt_IDUsuario.TabIndex = 6;
            this.txt_IDUsuario.Visible = false;
            // 
            // cb_Grupo
            // 
            this.cb_Grupo.FormattingEnabled = true;
            this.cb_Grupo.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cb_Grupo.Location = new System.Drawing.Point(114, 302);
            this.cb_Grupo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Grupo.Name = "cb_Grupo";
            this.cb_Grupo.Size = new System.Drawing.Size(195, 30);
            this.cb_Grupo.TabIndex = 10;
            // 
            // cb_Grado
            // 
            this.cb_Grado.FormattingEnabled = true;
            this.cb_Grado.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto"});
            this.cb_Grado.Location = new System.Drawing.Point(114, 244);
            this.cb_Grado.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Grado.Name = "cb_Grado";
            this.cb_Grado.Size = new System.Drawing.Size(193, 30);
            this.cb_Grado.TabIndex = 9;
            // 
            // cb_Maestro
            // 
            this.cb_Maestro.FormattingEnabled = true;
            this.cb_Maestro.Location = new System.Drawing.Point(114, 87);
            this.cb_Maestro.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Maestro.Name = "cb_Maestro";
            this.cb_Maestro.Size = new System.Drawing.Size(193, 30);
            this.cb_Maestro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Grupo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 250);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Grado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maestro:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Crear);
            this.panel1.Controls.Add(this.txt_Confirm_Contra);
            this.panel1.Controls.Add(this.txt_Contraseña);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.lb_Confirmacion);
            this.panel1.Location = new System.Drawing.Point(8, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 461);
            this.panel1.TabIndex = 2;
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Crear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Crear.Image")));
            this.btn_Crear.ImageActive = null;
            this.btn_Crear.Location = new System.Drawing.Point(47, 373);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(224, 40);
            this.btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Crear.TabIndex = 9;
            this.btn_Crear.TabStop = false;
            this.btn_Crear.Zoom = 10;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_Confirm_Contra
            // 
            this.txt_Confirm_Contra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Confirm_Contra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Confirm_Contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Confirm_Contra.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Confirm_Contra.HintText = "";
            this.txt_Confirm_Contra.isPassword = true;
            this.txt_Confirm_Contra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Confirm_Contra.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Confirm_Contra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Confirm_Contra.LineThickness = 3;
            this.txt_Confirm_Contra.Location = new System.Drawing.Point(47, 302);
            this.txt_Confirm_Contra.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Confirm_Contra.Name = "txt_Confirm_Contra";
            this.txt_Confirm_Contra.Size = new System.Drawing.Size(224, 33);
            this.txt_Confirm_Contra.TabIndex = 8;
            this.txt_Confirm_Contra.Text = "Contraseña";
            this.txt_Confirm_Contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Contraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Contraseña.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Contraseña.HintText = "";
            this.txt_Contraseña.isPassword = true;
            this.txt_Contraseña.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Contraseña.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Contraseña.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Contraseña.LineThickness = 3;
            this.txt_Contraseña.Location = new System.Drawing.Point(47, 177);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(224, 33);
            this.txt_Contraseña.TabIndex = 7;
            this.txt_Contraseña.Text = "Contraseña";
            this.txt_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Contraseña.OnValueChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Usuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Usuario.HintText = "Usuario";
            this.txt_Usuario.isPassword = false;
            this.txt_Usuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Usuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Usuario.LineThickness = 3;
            this.txt_Usuario.Location = new System.Drawing.Point(47, 84);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(224, 33);
            this.txt_Usuario.TabIndex = 6;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_Confirmacion
            // 
            this.lb_Confirmacion.AutoSize = true;
            this.lb_Confirmacion.Location = new System.Drawing.Point(4, 244);
            this.lb_Confirmacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Confirmacion.Name = "lb_Confirmacion";
            this.lb_Confirmacion.Size = new System.Drawing.Size(197, 24);
            this.lb_Confirmacion.TabIndex = 5;
            this.lb_Confirmacion.Text = "Confirmar Contraseña:";
            this.lb_Confirmacion.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(673, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento Info";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Limpiar);
            this.panel3.Controls.Add(this.btn_Eliminar);
            this.panel3.Controls.Add(this.btn_Modificar);
            this.panel3.Controls.Add(this.btn_BuscarMan);
            this.panel3.Controls.Add(this.txt_MaestroMan);
            this.panel3.Controls.Add(this.txt_NomBusque);
            this.panel3.Controls.Add(this.lb_idUsuario);
            this.panel3.Controls.Add(this.lb_idAlumno);
            this.panel3.Controls.Add(this.cb_GrupoMan);
            this.panel3.Controls.Add(this.cb_GradoMan);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(87, 29);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 460);
            this.panel3.TabIndex = 4;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Bisque;
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageActive = null;
            this.btn_Limpiar.Location = new System.Drawing.Point(298, 386);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 38);
            this.btn_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Limpiar.TabIndex = 24;
            this.btn_Limpiar.TabStop = false;
            this.btn_Limpiar.Zoom = 10;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageActive = null;
            this.btn_Eliminar.Location = new System.Drawing.Point(173, 386);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(109, 38);
            this.btn_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Eliminar.TabIndex = 23;
            this.btn_Eliminar.TabStop = false;
            this.btn_Eliminar.Zoom = 10;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageActive = null;
            this.btn_Modificar.Location = new System.Drawing.Point(49, 386);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 38);
            this.btn_Modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Modificar.TabIndex = 22;
            this.btn_Modificar.TabStop = false;
            this.btn_Modificar.Zoom = 10;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_BuscarMan
            // 
            this.btn_BuscarMan.BackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarMan.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarMan.Image")));
            this.btn_BuscarMan.ImageActive = null;
            this.btn_BuscarMan.Location = new System.Drawing.Point(377, 52);
            this.btn_BuscarMan.Name = "btn_BuscarMan";
            this.btn_BuscarMan.Size = new System.Drawing.Size(55, 32);
            this.btn_BuscarMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_BuscarMan.TabIndex = 21;
            this.btn_BuscarMan.TabStop = false;
            this.btn_BuscarMan.Zoom = 10;
            this.btn_BuscarMan.Click += new System.EventHandler(this.btn_BuscarMan_Click);
            // 
            // txt_MaestroMan
            // 
            this.txt_MaestroMan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaestroMan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_MaestroMan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_MaestroMan.HintForeColor = System.Drawing.Color.Empty;
            this.txt_MaestroMan.HintText = "Maestro";
            this.txt_MaestroMan.isPassword = false;
            this.txt_MaestroMan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_MaestroMan.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_MaestroMan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_MaestroMan.LineThickness = 3;
            this.txt_MaestroMan.Location = new System.Drawing.Point(76, 167);
            this.txt_MaestroMan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaestroMan.Name = "txt_MaestroMan";
            this.txt_MaestroMan.Size = new System.Drawing.Size(294, 33);
            this.txt_MaestroMan.TabIndex = 20;
            this.txt_MaestroMan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_NomBusque
            // 
            this.txt_NomBusque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomBusque.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NomBusque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NomBusque.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomBusque.HintText = "Nombre Alumno";
            this.txt_NomBusque.isPassword = false;
            this.txt_NomBusque.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NomBusque.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NomBusque.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NomBusque.LineThickness = 3;
            this.txt_NomBusque.Location = new System.Drawing.Point(76, 52);
            this.txt_NomBusque.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomBusque.Name = "txt_NomBusque";
            this.txt_NomBusque.Size = new System.Drawing.Size(294, 33);
            this.txt_NomBusque.TabIndex = 19;
            this.txt_NomBusque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_idUsuario
            // 
            this.lb_idUsuario.AutoSize = true;
            this.lb_idUsuario.Location = new System.Drawing.Point(179, 113);
            this.lb_idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idUsuario.Name = "lb_idUsuario";
            this.lb_idUsuario.Size = new System.Drawing.Size(60, 24);
            this.lb_idUsuario.TabIndex = 18;
            this.lb_idUsuario.Text = "label3";
            // 
            // lb_idAlumno
            // 
            this.lb_idAlumno.AutoSize = true;
            this.lb_idAlumno.Location = new System.Drawing.Point(60, 113);
            this.lb_idAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idAlumno.Name = "lb_idAlumno";
            this.lb_idAlumno.Size = new System.Drawing.Size(70, 24);
            this.lb_idAlumno.TabIndex = 17;
            this.lb_idAlumno.Text = "label12";
            this.lb_idAlumno.Visible = false;
            // 
            // cb_GrupoMan
            // 
            this.cb_GrupoMan.FormattingEnabled = true;
            this.cb_GrupoMan.Items.AddRange(new object[] {
            "Mañana",
            "Tarde"});
            this.cb_GrupoMan.Location = new System.Drawing.Point(158, 296);
            this.cb_GrupoMan.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GrupoMan.Name = "cb_GrupoMan";
            this.cb_GrupoMan.Size = new System.Drawing.Size(212, 30);
            this.cb_GrupoMan.TabIndex = 9;
            // 
            // cb_GradoMan
            // 
            this.cb_GradoMan.FormattingEnabled = true;
            this.cb_GradoMan.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto"});
            this.cb_GradoMan.Location = new System.Drawing.Point(158, 233);
            this.cb_GradoMan.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GradoMan.Name = "cb_GradoMan";
            this.cb_GradoMan.Size = new System.Drawing.Size(212, 30);
            this.cb_GradoMan.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 300);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Grupo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 237);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Grado:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(704, 42);
            this.panel4.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(657, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 42);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Lista_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Alumnos";
            this.Load += new System.EventHandler(this.Lista_Alumnos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarMan)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_Grupo;
        private System.Windows.Forms.ComboBox cb_Grado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_GrupoMan;
        private System.Windows.Forms.ComboBox cb_GradoMan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_Confirmacion;
        private System.Windows.Forms.TextBox txt_IDUsuario;
        private System.Windows.Forms.Label lb_idAlumno;
        private System.Windows.Forms.Label lb_idUsuario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Alumnos;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Nombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Confirm_Contra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuImageButton btn_Registrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomAlumno;
        private System.Windows.Forms.ComboBox cb_Maestro;
        private Bunifu.Framework.UI.BunifuImageButton btn_Crear;
        private Bunifu.Framework.UI.BunifuImageButton btn_Modificar;
        private Bunifu.Framework.UI.BunifuImageButton btn_BuscarMan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_MaestroMan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomBusque;
        private Bunifu.Framework.UI.BunifuImageButton btn_Eliminar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Limpiar;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}