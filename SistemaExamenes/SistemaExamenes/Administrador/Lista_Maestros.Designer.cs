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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dvg_Maestros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NombreBus = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_NomMestro = new System.Windows.Forms.TextBox();
            this.cb_Usuario = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_UsuarioMan = new System.Windows.Forms.ComboBox();
            this.txt_NameMaestro = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.txt_NomBusque = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_BuscarMan = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Maestros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_Buscar);
            this.tabPage1.Controls.Add(this.txt_NombreBus);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dvg_Maestros);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Maestros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(796, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento Info";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dvg_Maestros
            // 
            this.dvg_Maestros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Maestros.Location = new System.Drawing.Point(6, 83);
            this.dvg_Maestros.Name = "dvg_Maestros";
            this.dvg_Maestros.RowTemplate.Height = 24;
            this.dvg_Maestros.Size = new System.Drawing.Size(784, 333);
            this.dvg_Maestros.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txt_NombreBus
            // 
            this.txt_NombreBus.Location = new System.Drawing.Point(174, 36);
            this.txt_NombreBus.Name = "txt_NombreBus";
            this.txt_NombreBus.Size = new System.Drawing.Size(198, 22);
            this.txt_NombreBus.TabIndex = 2;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(418, 28);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(82, 31);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Crear);
            this.panel1.Controls.Add(this.txt_Contraseña);
            this.panel1.Controls.Add(this.txt_Usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 373);
            this.panel1.TabIndex = 3;
            // 
            // btn_Crear
            // 
            this.btn_Crear.Location = new System.Drawing.Point(123, 212);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(99, 47);
            this.btn_Crear.TabIndex = 4;
            this.btn_Crear.Text = "Crear Usuario";
            this.btn_Crear.UseVisualStyleBackColor = true;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(94, 130);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(179, 22);
            this.txt_Contraseña.TabIndex = 3;
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(94, 82);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(179, 22);
            this.txt_Usuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Registrar);
            this.panel2.Controls.Add(this.txt_NomMestro);
            this.panel2.Controls.Add(this.cb_Usuario);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(385, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 373);
            this.panel2.TabIndex = 4;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(120, 199);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(118, 44);
            this.btn_Registrar.TabIndex = 10;
            this.btn_Registrar.Text = "Registrar Maestro";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // txt_NomMestro
            // 
            this.txt_NomMestro.Location = new System.Drawing.Point(91, 130);
            this.txt_NomMestro.Name = "txt_NomMestro";
            this.txt_NomMestro.Size = new System.Drawing.Size(170, 22);
            this.txt_NomMestro.TabIndex = 7;
            // 
            // cb_Usuario
            // 
            this.cb_Usuario.FormattingEnabled = true;
            this.cb_Usuario.Location = new System.Drawing.Point(91, 82);
            this.cb_Usuario.Name = "cb_Usuario";
            this.cb_Usuario.Size = new System.Drawing.Size(170, 24);
            this.cb_Usuario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Usuario:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Usuario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nombre:";
            // 
            // cb_UsuarioMan
            // 
            this.cb_UsuarioMan.FormattingEnabled = true;
            this.cb_UsuarioMan.Location = new System.Drawing.Point(126, 119);
            this.cb_UsuarioMan.Name = "cb_UsuarioMan";
            this.cb_UsuarioMan.Size = new System.Drawing.Size(170, 24);
            this.cb_UsuarioMan.TabIndex = 5;
            // 
            // txt_NameMaestro
            // 
            this.txt_NameMaestro.Location = new System.Drawing.Point(126, 169);
            this.txt_NameMaestro.Name = "txt_NameMaestro";
            this.txt_NameMaestro.Size = new System.Drawing.Size(170, 22);
            this.txt_NameMaestro.TabIndex = 7;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(14, 312);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(118, 44);
            this.btn_Modificar.TabIndex = 10;
            this.btn_Modificar.Text = "Modificar Registro";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(143, 312);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(118, 44);
            this.btn_Eliminar.TabIndex = 11;
            this.btn_Eliminar.Text = "Eliminar Registro";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(267, 312);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(118, 44);
            this.btn_Limpiar.TabIndex = 12;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // txt_NomBusque
            // 
            this.txt_NomBusque.Location = new System.Drawing.Point(126, 23);
            this.txt_NomBusque.Name = "txt_NomBusque";
            this.txt_NomBusque.Size = new System.Drawing.Size(170, 22);
            this.txt_NomBusque.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Nombre:";
            // 
            // btn_BuscarMan
            // 
            this.btn_BuscarMan.Location = new System.Drawing.Point(302, 14);
            this.btn_BuscarMan.Name = "btn_BuscarMan";
            this.btn_BuscarMan.Size = new System.Drawing.Size(65, 44);
            this.btn_BuscarMan.TabIndex = 15;
            this.btn_BuscarMan.Text = "Buscar";
            this.btn_BuscarMan.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_BuscarMan);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_NomBusque);
            this.panel3.Controls.Add(this.btn_Limpiar);
            this.panel3.Controls.Add(this.btn_Eliminar);
            this.panel3.Controls.Add(this.btn_Modificar);
            this.panel3.Controls.Add(this.txt_NameMaestro);
            this.panel3.Controls.Add(this.cb_UsuarioMan);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(200, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(397, 377);
            this.panel3.TabIndex = 5;
            // 
            // Lista_Maestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 471);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lista_Maestros";
            this.Text = "Lista_Maestros";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Maestros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_NombreBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvg_Maestros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Crear;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_NomMestro;
        private System.Windows.Forms.ComboBox cb_Usuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_BuscarMan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_NomBusque;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.TextBox txt_NameMaestro;
        private System.Windows.Forms.ComboBox cb_UsuarioMan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}