﻿namespace CapaDePresentacion.Catálogos
{
    partial class FrmProyecto
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
            this.DGVProyecto = new System.Windows.Forms.DataGridView();
            this.panelProyecto = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtFechaFin = new System.Windows.Forms.TextBox();
            this.TxtFechaInicio = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtIdProyecto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProyecto)).BeginInit();
            this.panelProyecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Proyecto";
            // 
            // DGVProyecto
            // 
            this.DGVProyecto.AllowUserToAddRows = false;
            this.DGVProyecto.AllowUserToDeleteRows = false;
            this.DGVProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProyecto.Location = new System.Drawing.Point(22, 354);
            this.DGVProyecto.Name = "DGVProyecto";
            this.DGVProyecto.ReadOnly = true;
            this.DGVProyecto.RowHeadersWidth = 62;
            this.DGVProyecto.RowTemplate.Height = 28;
            this.DGVProyecto.Size = new System.Drawing.Size(935, 318);
            this.DGVProyecto.TabIndex = 19;
            this.DGVProyecto.Tag = "";
            // 
            // panelProyecto
            // 
            this.panelProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProyecto.Controls.Add(this.BtnEliminar);
            this.panelProyecto.Controls.Add(this.BtnEditar);
            this.panelProyecto.Controls.Add(this.BtnGuardar);
            this.panelProyecto.Controls.Add(this.TxtEstado);
            this.panelProyecto.Controls.Add(this.TxtFechaFin);
            this.panelProyecto.Controls.Add(this.TxtFechaInicio);
            this.panelProyecto.Controls.Add(this.TxtDescripcion);
            this.panelProyecto.Controls.Add(this.TxtNombre);
            this.panelProyecto.Controls.Add(this.TxtIdProyecto);
            this.panelProyecto.Controls.Add(this.label7);
            this.panelProyecto.Controls.Add(this.label6);
            this.panelProyecto.Controls.Add(this.label5);
            this.panelProyecto.Controls.Add(this.label4);
            this.panelProyecto.Controls.Add(this.label3);
            this.panelProyecto.Controls.Add(this.label2);
            this.panelProyecto.Location = new System.Drawing.Point(22, 82);
            this.panelProyecto.Name = "panelProyecto";
            this.panelProyecto.Size = new System.Drawing.Size(935, 255);
            this.panelProyecto.TabIndex = 18;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(691, 207);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 30);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEditar.Location = new System.Drawing.Point(396, 207);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 30);
            this.BtnEditar.TabIndex = 15;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
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
            // 
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(325, 126);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(178, 26);
            this.TxtEstado.TabIndex = 12;
            // 
            // TxtFechaFin
            // 
            this.TxtFechaFin.Location = new System.Drawing.Point(46, 126);
            this.TxtFechaFin.Name = "TxtFechaFin";
            this.TxtFechaFin.Size = new System.Drawing.Size(183, 26);
            this.TxtFechaFin.TabIndex = 11;
            // 
            // TxtFechaInicio
            // 
            this.TxtFechaInicio.Location = new System.Drawing.Point(664, 41);
            this.TxtFechaInicio.Name = "TxtFechaInicio";
            this.TxtFechaInicio.Size = new System.Drawing.Size(179, 26);
            this.TxtFechaInicio.TabIndex = 10;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(414, 41);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(194, 26);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(199, 41);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(168, 26);
            this.TxtNombre.TabIndex = 8;
            // 
            // TxtIdProyecto
            // 
            this.TxtIdProyecto.Location = new System.Drawing.Point(46, 42);
            this.TxtIdProyecto.Name = "TxtIdProyecto";
            this.TxtIdProyecto.Size = new System.Drawing.Size(100, 26);
            this.TxtIdProyecto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id ";
            // 
            // FrmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVProyecto);
            this.Controls.Add(this.panelProyecto);
            this.Controls.Add(this.label1);
            this.Name = "FrmProyecto";
            this.Text = "Formulario Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProyecto)).EndInit();
            this.panelProyecto.ResumeLayout(false);
            this.panelProyecto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVProyecto;
        private System.Windows.Forms.Panel panelProyecto;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtFechaFin;
        private System.Windows.Forms.TextBox TxtFechaInicio;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtIdProyecto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}