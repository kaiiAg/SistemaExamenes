namespace SistemaExamenes.Maestro
{
    partial class Elaborar_Examen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elaborar_Examen));
            this.w = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_GuardarPregunta = new Bunifu.Framework.UI.BunifuImageButton();
            this.pn_Respuestas = new System.Windows.Forms.Panel();
            this.txt_Pregunta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_Respuesta1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Respuesta2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Respuesta3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Respuesta4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ck_Respuesta1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ck_Respuesta2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ck_Respuesta3 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ck_Respuesta4 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lb_IdPregunta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_PareoA = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_PareoB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_AgregarA = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_AceptarB = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nu_PuntosPareo = new System.Windows.Forms.NumericUpDown();
            this.nu_PuntosMarque = new System.Windows.Forms.NumericUpDown();
            this.cb_Materias = new System.Windows.Forms.ComboBox();
            this.w.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_GuardarPregunta)).BeginInit();
            this.pn_Respuestas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AceptarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PuntosPareo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PuntosMarque)).BeginInit();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.Controls.Add(this.tabPage1);
            this.w.Controls.Add(this.tabPage2);
            this.w.Location = new System.Drawing.Point(15, 16);
            this.w.Margin = new System.Windows.Forms.Padding(4);
            this.w.Name = "w";
            this.w.SelectedIndex = 0;
            this.w.Size = new System.Drawing.Size(671, 520);
            this.w.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lb_IdPregunta);
            this.tabPage1.Controls.Add(this.btn_GuardarPregunta);
            this.tabPage1.Controls.Add(this.pn_Respuestas);
            this.tabPage1.Controls.Add(this.txt_Pregunta);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(663, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Marque con X";
            // 
            // btn_GuardarPregunta
            // 
            this.btn_GuardarPregunta.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_GuardarPregunta.Image = ((System.Drawing.Image)(resources.GetObject("btn_GuardarPregunta.Image")));
            this.btn_GuardarPregunta.ImageActive = null;
            this.btn_GuardarPregunta.Location = new System.Drawing.Point(516, 105);
            this.btn_GuardarPregunta.Name = "btn_GuardarPregunta";
            this.btn_GuardarPregunta.Size = new System.Drawing.Size(122, 33);
            this.btn_GuardarPregunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_GuardarPregunta.TabIndex = 3;
            this.btn_GuardarPregunta.TabStop = false;
            this.btn_GuardarPregunta.Zoom = 10;
            // 
            // pn_Respuestas
            // 
            this.pn_Respuestas.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_Respuestas.Controls.Add(this.nu_PuntosMarque);
            this.pn_Respuestas.Controls.Add(this.bunifuImageButton1);
            this.pn_Respuestas.Controls.Add(this.label1);
            this.pn_Respuestas.Controls.Add(this.ck_Respuesta4);
            this.pn_Respuestas.Controls.Add(this.ck_Respuesta3);
            this.pn_Respuestas.Controls.Add(this.ck_Respuesta2);
            this.pn_Respuestas.Controls.Add(this.ck_Respuesta1);
            this.pn_Respuestas.Controls.Add(this.txt_Respuesta4);
            this.pn_Respuestas.Controls.Add(this.txt_Respuesta3);
            this.pn_Respuestas.Controls.Add(this.txt_Respuesta2);
            this.pn_Respuestas.Controls.Add(this.txt_Respuesta1);
            this.pn_Respuestas.Location = new System.Drawing.Point(18, 167);
            this.pn_Respuestas.Name = "pn_Respuestas";
            this.pn_Respuestas.Size = new System.Drawing.Size(620, 311);
            this.pn_Respuestas.TabIndex = 2;
            // 
            // txt_Pregunta
            // 
            this.txt_Pregunta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Pregunta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Pregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Pregunta.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Pregunta.HintText = "Pregunta";
            this.txt_Pregunta.isPassword = false;
            this.txt_Pregunta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Pregunta.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Pregunta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Pregunta.LineThickness = 3;
            this.txt_Pregunta.Location = new System.Drawing.Point(18, 65);
            this.txt_Pregunta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pregunta.Name = "txt_Pregunta";
            this.txt_Pregunta.Size = new System.Drawing.Size(620, 33);
            this.txt_Pregunta.TabIndex = 0;
            this.txt_Pregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.nu_PuntosPareo);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_AceptarB);
            this.tabPage2.Controls.Add(this.btn_AgregarA);
            this.tabPage2.Controls.Add(this.txt_PareoB);
            this.tabPage2.Controls.Add(this.txt_PareoA);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(663, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Pareo";
            // 
            // txt_Respuesta1
            // 
            this.txt_Respuesta1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Respuesta1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Respuesta1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Respuesta1.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Respuesta1.HintText = "Respuesta 1";
            this.txt_Respuesta1.isPassword = false;
            this.txt_Respuesta1.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Respuesta1.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Respuesta1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Respuesta1.LineThickness = 3;
            this.txt_Respuesta1.Location = new System.Drawing.Point(30, 68);
            this.txt_Respuesta1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Respuesta1.Name = "txt_Respuesta1";
            this.txt_Respuesta1.Size = new System.Drawing.Size(379, 33);
            this.txt_Respuesta1.TabIndex = 0;
            this.txt_Respuesta1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Respuesta2
            // 
            this.txt_Respuesta2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Respuesta2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Respuesta2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Respuesta2.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Respuesta2.HintText = "Respuesta 2";
            this.txt_Respuesta2.isPassword = false;
            this.txt_Respuesta2.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Respuesta2.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Respuesta2.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Respuesta2.LineThickness = 3;
            this.txt_Respuesta2.Location = new System.Drawing.Point(30, 129);
            this.txt_Respuesta2.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Respuesta2.Name = "txt_Respuesta2";
            this.txt_Respuesta2.Size = new System.Drawing.Size(379, 33);
            this.txt_Respuesta2.TabIndex = 1;
            this.txt_Respuesta2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Respuesta3
            // 
            this.txt_Respuesta3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Respuesta3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Respuesta3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Respuesta3.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Respuesta3.HintText = "Respuesta 3";
            this.txt_Respuesta3.isPassword = false;
            this.txt_Respuesta3.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Respuesta3.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Respuesta3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Respuesta3.LineThickness = 3;
            this.txt_Respuesta3.Location = new System.Drawing.Point(30, 194);
            this.txt_Respuesta3.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Respuesta3.Name = "txt_Respuesta3";
            this.txt_Respuesta3.Size = new System.Drawing.Size(379, 33);
            this.txt_Respuesta3.TabIndex = 2;
            this.txt_Respuesta3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Respuesta4
            // 
            this.txt_Respuesta4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Respuesta4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Respuesta4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Respuesta4.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Respuesta4.HintText = "Respuesta 4";
            this.txt_Respuesta4.isPassword = false;
            this.txt_Respuesta4.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Respuesta4.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Respuesta4.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Respuesta4.LineThickness = 3;
            this.txt_Respuesta4.Location = new System.Drawing.Point(30, 263);
            this.txt_Respuesta4.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Respuesta4.Name = "txt_Respuesta4";
            this.txt_Respuesta4.Size = new System.Drawing.Size(379, 33);
            this.txt_Respuesta4.TabIndex = 3;
            this.txt_Respuesta4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ck_Respuesta1
            // 
            this.ck_Respuesta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta1.Checked = false;
            this.ck_Respuesta1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ck_Respuesta1.ForeColor = System.Drawing.Color.White;
            this.ck_Respuesta1.Location = new System.Drawing.Point(417, 80);
            this.ck_Respuesta1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ck_Respuesta1.Name = "ck_Respuesta1";
            this.ck_Respuesta1.Size = new System.Drawing.Size(20, 20);
            this.ck_Respuesta1.TabIndex = 4;
            // 
            // ck_Respuesta2
            // 
            this.ck_Respuesta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta2.Checked = false;
            this.ck_Respuesta2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ck_Respuesta2.ForeColor = System.Drawing.Color.White;
            this.ck_Respuesta2.Location = new System.Drawing.Point(417, 142);
            this.ck_Respuesta2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ck_Respuesta2.Name = "ck_Respuesta2";
            this.ck_Respuesta2.Size = new System.Drawing.Size(20, 20);
            this.ck_Respuesta2.TabIndex = 5;
            // 
            // ck_Respuesta3
            // 
            this.ck_Respuesta3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta3.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta3.Checked = false;
            this.ck_Respuesta3.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ck_Respuesta3.ForeColor = System.Drawing.Color.White;
            this.ck_Respuesta3.Location = new System.Drawing.Point(417, 207);
            this.ck_Respuesta3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ck_Respuesta3.Name = "ck_Respuesta3";
            this.ck_Respuesta3.Size = new System.Drawing.Size(20, 20);
            this.ck_Respuesta3.TabIndex = 6;
            // 
            // ck_Respuesta4
            // 
            this.ck_Respuesta4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta4.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ck_Respuesta4.Checked = false;
            this.ck_Respuesta4.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ck_Respuesta4.ForeColor = System.Drawing.Color.White;
            this.ck_Respuesta4.Location = new System.Drawing.Point(417, 276);
            this.ck_Respuesta4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ck_Respuesta4.Name = "ck_Respuesta4";
            this.ck_Respuesta4.Size = new System.Drawing.Size(20, 20);
            this.ck_Respuesta4.TabIndex = 7;
            // 
            // lb_IdPregunta
            // 
            this.lb_IdPregunta.AutoSize = true;
            this.lb_IdPregunta.Location = new System.Drawing.Point(14, 114);
            this.lb_IdPregunta.Name = "lb_IdPregunta";
            this.lb_IdPregunta.Size = new System.Drawing.Size(60, 24);
            this.lb_IdPregunta.TabIndex = 4;
            this.lb_IdPregunta.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puntos de la Pregunta:";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(481, 276);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(136, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // txt_PareoA
            // 
            this.txt_PareoA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PareoA.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_PareoA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PareoA.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PareoA.HintText = "Pareo Columna A";
            this.txt_PareoA.isPassword = false;
            this.txt_PareoA.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_PareoA.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_PareoA.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_PareoA.LineThickness = 3;
            this.txt_PareoA.Location = new System.Drawing.Point(8, 138);
            this.txt_PareoA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PareoA.Name = "txt_PareoA";
            this.txt_PareoA.Size = new System.Drawing.Size(253, 33);
            this.txt_PareoA.TabIndex = 0;
            this.txt_PareoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_PareoB
            // 
            this.txt_PareoB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PareoB.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_PareoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PareoB.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PareoB.HintText = "Pareo Columna B";
            this.txt_PareoB.isPassword = false;
            this.txt_PareoB.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_PareoB.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_PareoB.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_PareoB.LineThickness = 3;
            this.txt_PareoB.Location = new System.Drawing.Point(317, 138);
            this.txt_PareoB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PareoB.Name = "txt_PareoB";
            this.txt_PareoB.Size = new System.Drawing.Size(287, 33);
            this.txt_PareoB.TabIndex = 1;
            this.txt_PareoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_AgregarA
            // 
            this.btn_AgregarA.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AgregarA.Image = ((System.Drawing.Image)(resources.GetObject("btn_AgregarA.Image")));
            this.btn_AgregarA.ImageActive = null;
            this.btn_AgregarA.Location = new System.Drawing.Point(258, 127);
            this.btn_AgregarA.Name = "btn_AgregarA";
            this.btn_AgregarA.Size = new System.Drawing.Size(52, 44);
            this.btn_AgregarA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AgregarA.TabIndex = 2;
            this.btn_AgregarA.TabStop = false;
            this.btn_AgregarA.Zoom = 10;
            // 
            // btn_AceptarB
            // 
            this.btn_AceptarB.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_AceptarB.Image = ((System.Drawing.Image)(resources.GetObject("btn_AceptarB.Image")));
            this.btn_AceptarB.ImageActive = null;
            this.btn_AceptarB.Location = new System.Drawing.Point(604, 127);
            this.btn_AceptarB.Name = "btn_AceptarB";
            this.btn_AceptarB.Size = new System.Drawing.Size(52, 44);
            this.btn_AceptarB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AceptarB.TabIndex = 3;
            this.btn_AceptarB.TabStop = false;
            this.btn_AceptarB.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor de Respuestas:";
            // 
            // nu_PuntosPareo
            // 
            this.nu_PuntosPareo.Location = new System.Drawing.Point(217, 42);
            this.nu_PuntosPareo.Name = "nu_PuntosPareo";
            this.nu_PuntosPareo.Size = new System.Drawing.Size(43, 28);
            this.nu_PuntosPareo.TabIndex = 5;
            // 
            // nu_PuntosMarque
            // 
            this.nu_PuntosMarque.Location = new System.Drawing.Point(210, 8);
            this.nu_PuntosMarque.Name = "nu_PuntosMarque";
            this.nu_PuntosMarque.Size = new System.Drawing.Size(48, 28);
            this.nu_PuntosMarque.TabIndex = 10;
            // 
            // cb_Materias
            // 
            this.cb_Materias.FormattingEnabled = true;
            this.cb_Materias.Location = new System.Drawing.Point(511, 8);
            this.cb_Materias.Name = "cb_Materias";
            this.cb_Materias.Size = new System.Drawing.Size(171, 30);
            this.cb_Materias.TabIndex = 1;
            // 
            // Elaborar_Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 549);
            this.Controls.Add(this.cb_Materias);
            this.Controls.Add(this.w);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Elaborar_Examen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elaborar_Examen";
            this.Load += new System.EventHandler(this.Elaborar_Examen_Load);
            this.w.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_GuardarPregunta)).EndInit();
            this.pn_Respuestas.ResumeLayout(false);
            this.pn_Respuestas.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AceptarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PuntosPareo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nu_PuntosMarque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl w;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuImageButton btn_GuardarPregunta;
        private System.Windows.Forms.Panel pn_Respuestas;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Pregunta;
        private Bunifu.Framework.UI.BunifuCheckbox ck_Respuesta4;
        private Bunifu.Framework.UI.BunifuCheckbox ck_Respuesta3;
        private Bunifu.Framework.UI.BunifuCheckbox ck_Respuesta2;
        private Bunifu.Framework.UI.BunifuCheckbox ck_Respuesta1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Respuesta4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Respuesta3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Respuesta2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Respuesta1;
        private System.Windows.Forms.Label lb_IdPregunta;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PareoB;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PareoA;
        private Bunifu.Framework.UI.BunifuImageButton btn_AceptarB;
        private Bunifu.Framework.UI.BunifuImageButton btn_AgregarA;
        private System.Windows.Forms.NumericUpDown nu_PuntosMarque;
        private System.Windows.Forms.NumericUpDown nu_PuntosPareo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Materias;
    }
}