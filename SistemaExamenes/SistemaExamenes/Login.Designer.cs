﻿namespace SistemaExamenes
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_Contraseña = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Ingresar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ingresar)).BeginInit();
            this.SuspendLayout();
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
            this.txt_Usuario.Location = new System.Drawing.Point(66, 72);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(231, 33);
            this.txt_Usuario.TabIndex = 5;
            this.txt_Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txt_Contraseña.Location = new System.Drawing.Point(66, 156);
            this.txt_Contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(231, 33);
            this.txt_Contraseña.TabIndex = 6;
            this.txt_Contraseña.Text = "Contraseña";
            this.txt_Contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ingresar.Image")));
            this.btn_Ingresar.ImageActive = null;
            this.btn_Ingresar.Location = new System.Drawing.Point(66, 266);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(231, 57);
            this.btn_Ingresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Ingresar.TabIndex = 7;
            this.btn_Ingresar.TabStop = false;
            this.btn_Ingresar.Zoom = 10;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 364);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ingresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Usuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Contraseña;
        private Bunifu.Framework.UI.BunifuImageButton btn_Ingresar;
    }
}

