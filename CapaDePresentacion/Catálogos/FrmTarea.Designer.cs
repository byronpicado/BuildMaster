namespace CapaDePresentacion.Catálogos
{
    partial class FrmTarea
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
            this.DGVTarea = new System.Windows.Forms.DataGridView();
            this.panelTarea = new System.Windows.Forms.Panel();
            this.DTPFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DTPFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtIdTarea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTarea)).BeginInit();
            this.panelTarea.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Tarea";
            // 
            // DGVTarea
            // 
            this.DGVTarea.AllowUserToAddRows = false;
            this.DGVTarea.AllowUserToDeleteRows = false;
            this.DGVTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTarea.Location = new System.Drawing.Point(22, 354);
            this.DGVTarea.Name = "DGVTarea";
            this.DGVTarea.ReadOnly = true;
            this.DGVTarea.RowHeadersWidth = 62;
            this.DGVTarea.RowTemplate.Height = 28;
            this.DGVTarea.Size = new System.Drawing.Size(935, 318);
            this.DGVTarea.TabIndex = 19;
            this.DGVTarea.Tag = "";
            // 
            // panelTarea
            // 
            this.panelTarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelTarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTarea.Controls.Add(this.DTPFechaFin);
            this.panelTarea.Controls.Add(this.DTPFechaInicio);
            this.panelTarea.Controls.Add(this.BtnEliminar);
            this.panelTarea.Controls.Add(this.BtnEditar);
            this.panelTarea.Controls.Add(this.BtnGuardar);
            this.panelTarea.Controls.Add(this.TxtEstado);
            this.panelTarea.Controls.Add(this.TxtDescripcion);
            this.panelTarea.Controls.Add(this.TxtIdTarea);
            this.panelTarea.Controls.Add(this.label7);
            this.panelTarea.Controls.Add(this.label6);
            this.panelTarea.Controls.Add(this.label5);
            this.panelTarea.Controls.Add(this.label3);
            this.panelTarea.Controls.Add(this.label2);
            this.panelTarea.Location = new System.Drawing.Point(22, 82);
            this.panelTarea.Name = "panelTarea";
            this.panelTarea.Size = new System.Drawing.Size(935, 255);
            this.panelTarea.TabIndex = 18;
            // 
            // DTPFechaFin
            // 
            this.DTPFechaFin.Location = new System.Drawing.Point(596, 125);
            this.DTPFechaFin.Name = "DTPFechaFin";
            this.DTPFechaFin.Size = new System.Drawing.Size(316, 26);
            this.DTPFechaFin.TabIndex = 18;
            // 
            // DTPFechaInicio
            // 
            this.DTPFechaInicio.Location = new System.Drawing.Point(245, 125);
            this.DTPFechaInicio.Name = "DTPFechaInicio";
            this.DTPFechaInicio.Size = new System.Drawing.Size(328, 26);
            this.DTPFechaInicio.TabIndex = 17;
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
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
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
            // TxtEstado
            // 
            this.TxtEstado.Location = new System.Drawing.Point(46, 125);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(178, 26);
            this.TxtEstado.TabIndex = 12;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(199, 41);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(713, 26);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtIdTarea
            // 
            this.TxtIdTarea.Location = new System.Drawing.Point(46, 42);
            this.TxtIdTarea.Name = "TxtIdTarea";
            this.TxtIdTarea.Size = new System.Drawing.Size(127, 26);
            this.TxtIdTarea.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
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
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVTarea);
            this.Controls.Add(this.panelTarea);
            this.Controls.Add(this.label1);
            this.Name = "FrmTarea";
            this.Text = "Formulario Tarea";
            this.Load += new System.EventHandler(this.FrmTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTarea)).EndInit();
            this.panelTarea.ResumeLayout(false);
            this.panelTarea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVTarea;
        private System.Windows.Forms.Panel panelTarea;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtIdTarea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFechaFin;
        private System.Windows.Forms.DateTimePicker DTPFechaInicio;
    }
}