namespace CapaDePresentacion.Catálogos
{
    partial class FrmMantenimiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIdMantenimiento = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.panelMantenimiento = new System.Windows.Forms.Panel();
            this.DGVMantenimiento = new System.Windows.Forms.DataGridView();
            this.panelMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Mantenimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // TxtIdMantenimiento
            // 
            this.TxtIdMantenimiento.Location = new System.Drawing.Point(205, 40);
            this.TxtIdMantenimiento.Name = "TxtIdMantenimiento";
            this.TxtIdMantenimiento.Size = new System.Drawing.Size(100, 26);
            this.TxtIdMantenimiento.TabIndex = 7;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Location = new System.Drawing.Point(358, 39);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(168, 26);
            this.TxtFecha.TabIndex = 8;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(573, 39);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(194, 26);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.Location = new System.Drawing.Point(205, 108);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEditar.Location = new System.Drawing.Point(392, 108);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 30);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(576, 108);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 30);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMantenimiento.Controls.Add(this.BtnEliminar);
            this.panelMantenimiento.Controls.Add(this.BtnEditar);
            this.panelMantenimiento.Controls.Add(this.BtnGuardar);
            this.panelMantenimiento.Controls.Add(this.TxtDescripcion);
            this.panelMantenimiento.Controls.Add(this.TxtFecha);
            this.panelMantenimiento.Controls.Add(this.TxtIdMantenimiento);
            this.panelMantenimiento.Controls.Add(this.label4);
            this.panelMantenimiento.Controls.Add(this.label3);
            this.panelMantenimiento.Controls.Add(this.label2);
            this.panelMantenimiento.Location = new System.Drawing.Point(21, 82);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(935, 255);
            this.panelMantenimiento.TabIndex = 18;
            // 
            // DGVMantenimiento
            // 
            this.DGVMantenimiento.AllowUserToAddRows = false;
            this.DGVMantenimiento.AllowUserToDeleteRows = false;
            this.DGVMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMantenimiento.Location = new System.Drawing.Point(21, 354);
            this.DGVMantenimiento.Name = "DGVMantenimiento";
            this.DGVMantenimiento.ReadOnly = true;
            this.DGVMantenimiento.RowHeadersWidth = 62;
            this.DGVMantenimiento.RowTemplate.Height = 28;
            this.DGVMantenimiento.Size = new System.Drawing.Size(935, 318);
            this.DGVMantenimiento.TabIndex = 19;
            this.DGVMantenimiento.Tag = "";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVMantenimiento);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.label1);
            this.Name = "FrmMantenimiento";
            this.Text = "Formulario Mantenimiento";
            this.panelMantenimiento.ResumeLayout(false);
            this.panelMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIdMantenimiento;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Panel panelMantenimiento;
        private System.Windows.Forms.DataGridView DGVMantenimiento;
    }
}