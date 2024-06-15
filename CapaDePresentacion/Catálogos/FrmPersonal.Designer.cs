﻿namespace CapaDePresentacion.Catálogos
{
    partial class FrmPersonal
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
            this.DGVPersonal = new System.Windows.Forms.DataGridView();
            this.panelPersonal = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.DTPFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.TxtNombre2 = new System.Windows.Forms.TextBox();
            this.TxtNombre1 = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).BeginInit();
            this.panelPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Personal";
            // 
            // DGVPersonal
            // 
            this.DGVPersonal.AllowUserToAddRows = false;
            this.DGVPersonal.AllowUserToDeleteRows = false;
            this.DGVPersonal.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPersonal.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVPersonal.Location = new System.Drawing.Point(22, 354);
            this.DGVPersonal.Name = "DGVPersonal";
            this.DGVPersonal.ReadOnly = true;
            this.DGVPersonal.RowHeadersWidth = 62;
            this.DGVPersonal.RowTemplate.Height = 28;
            this.DGVPersonal.Size = new System.Drawing.Size(935, 318);
            this.DGVPersonal.TabIndex = 19;
            this.DGVPersonal.Tag = "";
            // 
            // panelPersonal
            // 
            this.panelPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPersonal.Controls.Add(this.BtnLimpiar);
            this.panelPersonal.Controls.Add(this.DTPFechaContratacion);
            this.panelPersonal.Controls.Add(this.BtnEliminar);
            this.panelPersonal.Controls.Add(this.BtnEditar);
            this.panelPersonal.Controls.Add(this.BtnGuardar);
            this.panelPersonal.Controls.Add(this.TxtCargo);
            this.panelPersonal.Controls.Add(this.TxtApellidoMaterno);
            this.panelPersonal.Controls.Add(this.TxtApellidoPaterno);
            this.panelPersonal.Controls.Add(this.TxtNombre2);
            this.panelPersonal.Controls.Add(this.TxtNombre1);
            this.panelPersonal.Controls.Add(this.TxtCodigo);
            this.panelPersonal.Controls.Add(this.label8);
            this.panelPersonal.Controls.Add(this.label7);
            this.panelPersonal.Controls.Add(this.label6);
            this.panelPersonal.Controls.Add(this.label5);
            this.panelPersonal.Controls.Add(this.label4);
            this.panelPersonal.Controls.Add(this.label3);
            this.panelPersonal.Controls.Add(this.label2);
            this.panelPersonal.Location = new System.Drawing.Point(22, 82);
            this.panelPersonal.Name = "panelPersonal";
            this.panelPersonal.Size = new System.Drawing.Size(935, 255);
            this.panelPersonal.TabIndex = 18;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(823, 195);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 35);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // DTPFechaContratacion
            // 
            this.DTPFechaContratacion.Location = new System.Drawing.Point(550, 126);
            this.DTPFechaContratacion.Name = "DTPFechaContratacion";
            this.DTPFechaContratacion.Size = new System.Drawing.Size(365, 26);
            this.DTPFechaContratacion.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(594, 207);
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
            this.BtnEditar.Location = new System.Drawing.Point(340, 207);
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
            // TxtCargo
            // 
            this.TxtCargo.Location = new System.Drawing.Point(325, 126);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.Size = new System.Drawing.Size(178, 26);
            this.TxtCargo.TabIndex = 12;
            // 
            // TxtApellidoMaterno
            // 
            this.TxtApellidoMaterno.Location = new System.Drawing.Point(46, 126);
            this.TxtApellidoMaterno.Name = "TxtApellidoMaterno";
            this.TxtApellidoMaterno.Size = new System.Drawing.Size(183, 26);
            this.TxtApellidoMaterno.TabIndex = 11;
            // 
            // TxtApellidoPaterno
            // 
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(735, 42);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(179, 26);
            this.TxtApellidoPaterno.TabIndex = 10;
            this.TxtApellidoPaterno.Text = " ";
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.Location = new System.Drawing.Point(485, 42);
            this.TxtNombre2.Name = "TxtNombre2";
            this.TxtNombre2.Size = new System.Drawing.Size(194, 26);
            this.TxtNombre2.TabIndex = 9;
            // 
            // TxtNombre1
            // 
            this.TxtNombre1.Location = new System.Drawing.Point(270, 42);
            this.TxtNombre1.Name = "TxtNombre1";
            this.TxtNombre1.Size = new System.Drawing.Size(168, 26);
            this.TxtNombre1.TabIndex = 8;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(18, 42);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(236, 26);
            this.TxtCodigo.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "*Fecha de su contratación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "*Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "*Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "*Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "*Segundo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Primer nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Cédula";
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVPersonal);
            this.Controls.Add(this.panelPersonal);
            this.Controls.Add(this.label1);
            this.Name = "FrmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulario Personal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPersonal)).EndInit();
            this.panelPersonal.ResumeLayout(false);
            this.panelPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVPersonal;
        private System.Windows.Forms.Panel panelPersonal;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.TextBox TxtNombre2;
        private System.Windows.Forms.TextBox TxtNombre1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFechaContratacion;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}