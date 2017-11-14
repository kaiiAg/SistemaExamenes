namespace SistemaExamenes.Administrador
{
    partial class Lista_Materias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Materias));
            this.dgv_Materias = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_Materia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_Agregar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Materias
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Materias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Materias.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Materias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Materias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Materias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Materias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Materias.DoubleBuffered = true;
            this.dgv_Materias.EnableHeadersVisualStyles = false;
            this.dgv_Materias.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgv_Materias.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgv_Materias.Location = new System.Drawing.Point(12, 120);
            this.dgv_Materias.Name = "dgv_Materias";
            this.dgv_Materias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Materias.RowTemplate.Height = 24;
            this.dgv_Materias.Size = new System.Drawing.Size(675, 417);
            this.dgv_Materias.TabIndex = 0;
            // 
            // txt_Materia
            // 
            this.txt_Materia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Materia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Materia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Materia.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Materia.HintText = "Nombre Materia";
            this.txt_Materia.isPassword = false;
            this.txt_Materia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_Materia.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_Materia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_Materia.LineThickness = 3;
            this.txt_Materia.Location = new System.Drawing.Point(13, 59);
            this.txt_Materia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Materia.Name = "txt_Materia";
            this.txt_Materia.Size = new System.Drawing.Size(379, 33);
            this.txt_Materia.TabIndex = 1;
            this.txt_Materia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageActive = null;
            this.btn_Agregar.Location = new System.Drawing.Point(399, 48);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(162, 44);
            this.btn_Agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.TabStop = false;
            this.btn_Agregar.Zoom = 10;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Lista_Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 549);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.txt_Materia);
            this.Controls.Add(this.dgv_Materias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lista_Materias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista_Materias";
            this.Load += new System.EventHandler(this.Lista_Materias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Materias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Agregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Materias;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Materia;
        private Bunifu.Framework.UI.BunifuImageButton btn_Agregar;
    }
}