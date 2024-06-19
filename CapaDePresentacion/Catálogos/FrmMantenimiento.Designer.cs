﻿namespace CapaDePresentacion.Catálogos
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
            this.DGVMantenimiento = new System.Windows.Forms.DataGridView();
            this.panelHabilidad = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPFechaMantenimiento = new System.Windows.Forms.DateTimePicker();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMantenimiento)).BeginInit();
            this.panelHabilidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(542, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catálogo de Mantenimiento";
            // 
            // DGVMantenimiento
            // 
            this.DGVMantenimiento.AllowUserToAddRows = false;
            this.DGVMantenimiento.AllowUserToDeleteRows = false;
            this.DGVMantenimiento.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMantenimiento.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.DGVMantenimiento.Location = new System.Drawing.Point(22, 354);
            this.DGVMantenimiento.Name = "DGVMantenimiento";
            this.DGVMantenimiento.ReadOnly = true;
            this.DGVMantenimiento.RowHeadersWidth = 62;
            this.DGVMantenimiento.RowTemplate.Height = 28;
            this.DGVMantenimiento.Size = new System.Drawing.Size(935, 318);
            this.DGVMantenimiento.TabIndex = 21;
            this.DGVMantenimiento.Tag = "";
            // 
            // panelHabilidad
            // 
            this.panelHabilidad.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelHabilidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHabilidad.Controls.Add(this.BtnLimpiar);
            this.panelHabilidad.Controls.Add(this.label4);
            this.panelHabilidad.Controls.Add(this.DTPFechaMantenimiento);
            this.panelHabilidad.Controls.Add(this.TxtCodigo);
            this.panelHabilidad.Controls.Add(this.BtnEliminar);
            this.panelHabilidad.Controls.Add(this.BtnEditar);
            this.panelHabilidad.Controls.Add(this.BtnGuardar);
            this.panelHabilidad.Controls.Add(this.TxtDescripcion);
            this.panelHabilidad.Controls.Add(this.label3);
            this.panelHabilidad.Controls.Add(this.label2);
            this.panelHabilidad.Location = new System.Drawing.Point(22, 82);
            this.panelHabilidad.Name = "panelHabilidad";
            this.panelHabilidad.Size = new System.Drawing.Size(935, 255);
            this.panelHabilidad.TabIndex = 20;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(780, 164);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 33);
            this.BtnLimpiar.TabIndex = 20;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "*Fecha del mantenimiento";
            // 
            // DTPFechaMantenimiento
            // 
            this.DTPFechaMantenimiento.Location = new System.Drawing.Point(554, 46);
            this.DTPFechaMantenimiento.Name = "DTPFechaMantenimiento";
            this.DTPFechaMantenimiento.Size = new System.Drawing.Size(354, 26);
            this.DTPFechaMantenimiento.TabIndex = 18;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(82, 46);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(100, 26);
            this.TxtCodigo.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(554, 160);
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
            this.BtnEditar.Location = new System.Drawing.Point(312, 161);
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
            this.BtnGuardar.Location = new System.Drawing.Point(82, 161);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(82, 107);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(826, 26);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "*Código";
            // 
            // FrmMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVMantenimiento);
            this.Controls.Add(this.panelHabilidad);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMantenimiento";
            this.Load += new System.EventHandler(this.FrmMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMantenimiento)).EndInit();
            this.panelHabilidad.ResumeLayout(false);
            this.panelHabilidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVMantenimiento;
        private System.Windows.Forms.Panel panelHabilidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFechaMantenimiento;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}