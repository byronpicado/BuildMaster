namespace CapaDePresentacion.Catálogos
{
    partial class FrmProgreso
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
            this.DGVProgreso = new System.Windows.Forms.DataGridView();
            this.panelProgreso = new System.Windows.Forms.Panel();
            this.BtnProgreso = new System.Windows.Forms.Button();
            this.DTPFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProgreso)).BeginInit();
            this.panelProgreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Progreso";
            // 
            // DGVProgreso
            // 
            this.DGVProgreso.AllowUserToAddRows = false;
            this.DGVProgreso.AllowUserToDeleteRows = false;
            this.DGVProgreso.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVProgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProgreso.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVProgreso.Location = new System.Drawing.Point(21, 354);
            this.DGVProgreso.Name = "DGVProgreso";
            this.DGVProgreso.ReadOnly = true;
            this.DGVProgreso.RowHeadersWidth = 62;
            this.DGVProgreso.RowTemplate.Height = 28;
            this.DGVProgreso.Size = new System.Drawing.Size(935, 318);
            this.DGVProgreso.TabIndex = 19;
            this.DGVProgreso.Tag = "";
            // 
            // panelProgreso
            // 
            this.panelProgreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelProgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProgreso.Controls.Add(this.BtnProgreso);
            this.panelProgreso.Controls.Add(this.DTPFechaRegistro);
            this.panelProgreso.Controls.Add(this.BtnEliminar);
            this.panelProgreso.Controls.Add(this.BtnEditar);
            this.panelProgreso.Controls.Add(this.BtnGuardar);
            this.panelProgreso.Controls.Add(this.TxtDescripcion);
            this.panelProgreso.Controls.Add(this.TxtCodigo);
            this.panelProgreso.Controls.Add(this.label4);
            this.panelProgreso.Controls.Add(this.label3);
            this.panelProgreso.Controls.Add(this.label2);
            this.panelProgreso.Location = new System.Drawing.Point(21, 82);
            this.panelProgreso.Name = "panelProgreso";
            this.panelProgreso.Size = new System.Drawing.Size(935, 255);
            this.panelProgreso.TabIndex = 18;
            // 
            // BtnProgreso
            // 
            this.BtnProgreso.Location = new System.Drawing.Point(756, 206);
            this.BtnProgreso.Name = "BtnProgreso";
            this.BtnProgreso.Size = new System.Drawing.Size(75, 31);
            this.BtnProgreso.TabIndex = 18;
            this.BtnProgreso.Text = "Limpiar";
            this.BtnProgreso.UseVisualStyleBackColor = true;
            this.BtnProgreso.Click += new System.EventHandler(this.BtnProgreso_Click);
            // 
            // DTPFechaRegistro
            // 
            this.DTPFechaRegistro.Location = new System.Drawing.Point(586, 40);
            this.DTPFechaRegistro.Name = "DTPFechaRegistro";
            this.DTPFechaRegistro.Size = new System.Drawing.Size(323, 26);
            this.DTPFechaRegistro.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(555, 206);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 30);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEditar.Location = new System.Drawing.Point(311, 207);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 30);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.AutoSize = true;
            this.BtnGuardar.BackColor = System.Drawing.Color.Lime;
            this.BtnGuardar.Location = new System.Drawing.Point(71, 207);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(46, 110);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(863, 26);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(46, 42);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(224, 26);
            this.TxtCodigo.TabIndex = 7;
            this.TxtCodigo.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "*Fecha Registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Código";
            // 
            // FrmProgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVProgreso);
            this.Controls.Add(this.panelProgreso);
            this.Controls.Add(this.label1);
            this.Name = "FrmProgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Progreso";
            this.Load += new System.EventHandler(this.FrmProgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProgreso)).EndInit();
            this.panelProgreso.ResumeLayout(false);
            this.panelProgreso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVProgreso;
        private System.Windows.Forms.Panel panelProgreso;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFechaRegistro;
        private System.Windows.Forms.Button BtnProgreso;
    }
}