namespace SistemaExamenes.Administrador
{
    partial class Lista_Maestros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Maestros));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dvg_Maestros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_Buscar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_NombreBus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pn_Registro = new System.Windows.Forms.Panel();
            this.btn_Registrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_NomMaestro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_idUsuario = new System.Windows.Forms.TextBox();
            this.pn_Crear = new System.Windows.Forms.Panel();
            this.lb_Confirmas = new System.Windows.Forms.Label();
            this.btn_Crear = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_ConfiContra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Limpiar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Eliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_Modificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_NameMaestro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_BuscarMan = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_NomBusque = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lb_idUsuario = new System.Windows.Forms.Label();
            this.lb_IdMaestro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Salir = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Maestros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pn_Registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).BeginInit();
            this.pn_Crear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarMan)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(24, 68);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(664, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.dvg_Maestros);
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.txt_NombreBus);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(656, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Maestros";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dvg_Maestros
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dvg_Maestros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dvg_Maestros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dvg_Maestros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvg_Maestros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvg_Maestros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvg_Maestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Maestros.DoubleBuffered = true;
            this.dvg_Maestros.EnableHeadersVisualStyles = false;
            this.dvg_Maestros.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dvg_Maestros.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dvg_Maestros.Location = new System.Drawing.Point(8, 132);
            this.dvg_Maestros.Margin = new System.Windows.Forms.Padding(4);
            this.dvg_Maestros.Name = "dvg_Maestros";
            this.dvg_Maestros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dvg_Maestros.RowTemplate.Height = 24;
            this.dvg_Maestros.Size = new System.Drawing.Size(640, 340);
            this.dvg_Maestros.TabIndex = 1;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Buscar.Image")));
            this.btn_Buscar.ImageActive = null;
            this.btn_Buscar.Location = new System.Drawing.Point(429, 48);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(62, 33);
            this.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.Zoom = 10;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_NombreBus
            // 
            this.txt_NombreBus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NombreBus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NombreBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NombreBus.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NombreBus.HintText = "Nombre del Maestro";
            this.txt_NombreBus.isPassword = false;
            this.txt_NombreBus.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NombreBus.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NombreBus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NombreBus.LineThickness = 3;
            this.txt_NombreBus.Location = new System.Drawing.Point(34, 36);
            this.txt_NombreBus.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_NombreBus.Name = "txt_NombreBus";
            this.txt_NombreBus.Size = new System.Drawing.Size(331, 45);
            this.txt_NombreBus.TabIndex = 0;
            this.txt_NombreBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pn_Registro);
            this.tabPage2.Controls.Add(this.pn_Crear);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(656, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Usuario";
            // 
            // pn_Registro
            // 
            this.pn_Registro.Controls.Add(this.btn_Registrar);
            this.pn_Registro.Controls.Add(this.txt_NomMaestro);
            this.pn_Registro.Controls.Add(this.txt_idUsuario);
            this.pn_Registro.Location = new System.Drawing.Point(332, 34);
            this.pn_Registro.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Registro.Name = "pn_Registro";
            this.pn_Registro.Size = new System.Drawing.Size(320, 448);
            this.pn_Registro.TabIndex = 4;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageActive = null;
            this.btn_Registrar.Location = new System.Drawing.Point(36, 358);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(245, 39);
            this.btn_Registrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Registrar.TabIndex = 12;
            this.btn_Registrar.TabStop = false;
            this.btn_Registrar.Zoom = 10;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // txt_NomMaestro
            // 
            this.txt_NomMaestro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomMaestro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NomMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NomMaestro.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomMaestro.HintText = "Nombre Maestro";
            this.txt_NomMaestro.isPassword = false;
            this.txt_NomMaestro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NomMaestro.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NomMaestro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NomMaestro.LineThickness = 3;
            this.txt_NomMaestro.Location = new System.Drawing.Point(36, 147);
            this.txt_NomMaestro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_NomMaestro.Name = "txt_NomMaestro";
            this.txt_NomMaestro.Size = new System.Drawing.Size(245, 45);
            this.txt_NomMaestro.TabIndex = 5;
            this.txt_NomMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_idUsuario
            // 
            this.txt_idUsuario.Enabled = false;
            this.txt_idUsuario.Location = new System.Drawing.Point(36, 63);
            this.txt_idUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idUsuario.Name = "txt_idUsuario";
            this.txt_idUsuario.Size = new System.Drawing.Size(212, 28);
            this.txt_idUsuario.TabIndex = 5;
            this.txt_idUsuario.Visible = false;
            // 
            // pn_Crear
            // 
            this.pn_Crear.Controls.Add(this.lb_Confirmas);
            this.pn_Crear.Controls.Add(this.btn_Crear);
            this.pn_Crear.Controls.Add(this.txt_ConfiContra);
            this.pn_Crear.Controls.Add(this.txt_Contraseña);
            this.pn_Crear.Controls.Add(this.txt_Usuario);
            this.pn_Crear.Location = new System.Drawing.Point(4, 34);
            this.pn_Crear.Margin = new System.Windows.Forms.Padding(4);
            this.pn_Crear.Name = "pn_Crear";
            this.pn_Crear.Size = new System.Drawing.Size(320, 448);
            this.pn_Crear.TabIndex = 3;
            // 
            // lb_Confirmas
            // 
            this.lb_Confirmas.AutoSize = true;
            this.lb_Confirmas.Location = new System.Drawing.Point(41, 222);
            this.lb_Confirmas.Name = "lb_Confirmas";
            this.lb_Confirmas.Size = new System.Drawing.Size(96, 24);
            this.lb_Confirmas.TabIndex = 11;
            this.lb_Confirmas.Text = "Confirmar:";
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Crear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Crear.Image")));
            this.btn_Crear.ImageActive = null;
            this.btn_Crear.Location = new System.Drawing.Point(41, 358);
            this.btn_Crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(245, 39);
            this.btn_Crear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Crear.TabIndex = 10;
            this.btn_Crear.TabStop = false;
            this.btn_Crear.Zoom = 10;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // txt_ConfiContra
            // 
            this.txt_ConfiContra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ConfiContra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ConfiContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ConfiContra.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ConfiContra.HintText = "";
            this.txt_ConfiContra.isPassword = true;
            this.txt_ConfiContra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ConfiContra.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ConfiContra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ConfiContra.LineThickness = 3;
            this.txt_ConfiContra.Location = new System.Drawing.Point(41, 248);
            this.txt_ConfiContra.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_ConfiContra.Name = "txt_ConfiContra";
            this.txt_ConfiContra.Size = new System.Drawing.Size(245, 45);
            this.txt_ConfiContra.TabIndex = 4;
            this.txt_ConfiContra.Text = "Contraseña";
            this.txt_ConfiContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Contraseña.Location = new System.Drawing.Point(41, 147);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(245, 45);
            this.txt_Contraseña.TabIndex = 3;
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
            this.txt_Usuario.Location = new System.Drawing.Point(41, 46);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(245, 45);
            this.txt_Usuario.TabIndex = 2;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(656, 490);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento Info";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_Limpiar);
            this.panel3.Controls.Add(this.btn_Eliminar);
            this.panel3.Controls.Add(this.btn_Modificar);
            this.panel3.Controls.Add(this.txt_NameMaestro);
            this.panel3.Controls.Add(this.btn_BuscarMan);
            this.panel3.Controls.Add(this.txt_NomBusque);
            this.panel3.Controls.Add(this.lb_idUsuario);
            this.panel3.Controls.Add(this.lb_IdMaestro);
            this.panel3.Location = new System.Drawing.Point(148, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 456);
            this.panel3.TabIndex = 5;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.Bisque;
            this.btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Limpiar.Image")));
            this.btn_Limpiar.ImageActive = null;
            this.btn_Limpiar.Location = new System.Drawing.Point(259, 352);
            this.btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 38);
            this.btn_Limpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Limpiar.TabIndex = 22;
            this.btn_Limpiar.TabStop = false;
            this.btn_Limpiar.Zoom = 10;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageActive = null;
            this.btn_Eliminar.Location = new System.Drawing.Point(142, 352);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(109, 38);
            this.btn_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Eliminar.TabIndex = 21;
            this.btn_Eliminar.TabStop = false;
            this.btn_Eliminar.Zoom = 10;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Modificar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.Image")));
            this.btn_Modificar.ImageActive = null;
            this.btn_Modificar.Location = new System.Drawing.Point(25, 352);
            this.btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(109, 38);
            this.btn_Modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Modificar.TabIndex = 20;
            this.btn_Modificar.TabStop = false;
            this.btn_Modificar.Zoom = 10;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_NameMaestro
            // 
            this.txt_NameMaestro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NameMaestro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NameMaestro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NameMaestro.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NameMaestro.HintText = "Nuevo Nombre";
            this.txt_NameMaestro.isPassword = false;
            this.txt_NameMaestro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NameMaestro.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NameMaestro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NameMaestro.LineThickness = 3;
            this.txt_NameMaestro.Location = new System.Drawing.Point(25, 225);
            this.txt_NameMaestro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_NameMaestro.Name = "txt_NameMaestro";
            this.txt_NameMaestro.Size = new System.Drawing.Size(295, 45);
            this.txt_NameMaestro.TabIndex = 7;
            this.txt_NameMaestro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_BuscarMan
            // 
            this.btn_BuscarMan.BackColor = System.Drawing.Color.Transparent;
            this.btn_BuscarMan.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarMan.Image")));
            this.btn_BuscarMan.ImageActive = null;
            this.btn_BuscarMan.Location = new System.Drawing.Point(329, 80);
            this.btn_BuscarMan.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarMan.Name = "btn_BuscarMan";
            this.btn_BuscarMan.Size = new System.Drawing.Size(49, 35);
            this.btn_BuscarMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_BuscarMan.TabIndex = 18;
            this.btn_BuscarMan.TabStop = false;
            this.btn_BuscarMan.Zoom = 10;
            this.btn_BuscarMan.Click += new System.EventHandler(this.btn_BuscarMan_Click);
            // 
            // txt_NomBusque
            // 
            this.txt_NomBusque.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomBusque.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_NomBusque.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NomBusque.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomBusque.HintText = "Nombre";
            this.txt_NomBusque.isPassword = false;
            this.txt_NomBusque.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_NomBusque.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_NomBusque.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_NomBusque.LineThickness = 3;
            this.txt_NomBusque.Location = new System.Drawing.Point(25, 70);
            this.txt_NomBusque.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_NomBusque.Name = "txt_NomBusque";
            this.txt_NomBusque.Size = new System.Drawing.Size(295, 45);
            this.txt_NomBusque.TabIndex = 6;
            this.txt_NomBusque.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lb_idUsuario
            // 
            this.lb_idUsuario.AutoSize = true;
            this.lb_idUsuario.Location = new System.Drawing.Point(122, 158);
            this.lb_idUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_idUsuario.Name = "lb_idUsuario";
            this.lb_idUsuario.Size = new System.Drawing.Size(60, 24);
            this.lb_idUsuario.TabIndex = 16;
            this.lb_idUsuario.Text = "label4";
            this.lb_idUsuario.Visible = false;
            // 
            // lb_IdMaestro
            // 
            this.lb_IdMaestro.AutoSize = true;
            this.lb_IdMaestro.Location = new System.Drawing.Point(21, 158);
            this.lb_IdMaestro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IdMaestro.Name = "lb_IdMaestro";
            this.lb_IdMaestro.Size = new System.Drawing.Size(79, 24);
            this.lb_IdMaestro.TabIndex = 0;
            this.lb_IdMaestro.Text = "Usuario:";
            this.lb_IdMaestro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Salir);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 45);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.ImageActive = null;
            this.btn_Salir.Location = new System.Drawing.Point(665, 0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(47, 45);
            this.btn_Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Salir.TabIndex = 0;
            this.btn_Salir.TabStop = false;
            this.btn_Salir.Zoom = 10;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Lista_Maestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lista_Maestros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Maestros";
            this.Load += new System.EventHandler(this.Lista_Maestros_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Maestros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Buscar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pn_Registro.ResumeLayout(false);
            this.pn_Registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Registrar)).EndInit();
            this.pn_Crear.ResumeLayout(false);
            this.pn_Crear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Crear)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Limpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_BuscarMan)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pn_Crear;
        private System.Windows.Forms.Panel pn_Registro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_IdMaestro;
        private System.Windows.Forms.TextBox txt_idUsuario;
        private System.Windows.Forms.Label lb_idUsuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NombreBus;
        private Bunifu.Framework.UI.BunifuImageButton btn_Buscar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dvg_Maestros;
        private Bunifu.Framework.UI.BunifuImageButton btn_Crear;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ConfiContra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contraseña;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuImageButton btn_Registrar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomMaestro;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomBusque;
        private Bunifu.Framework.UI.BunifuImageButton btn_BuscarMan;
        private Bunifu.Framework.UI.BunifuImageButton btn_Modificar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NameMaestro;
        private Bunifu.Framework.UI.BunifuImageButton btn_Limpiar;
        private Bunifu.Framework.UI.BunifuImageButton btn_Eliminar;
        private System.Windows.Forms.Label lb_Confirmas;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}