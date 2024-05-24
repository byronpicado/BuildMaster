namespace CapaDePresentacion.Catálogos
{
    partial class FrmProyectoDetalle
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
            this.DGVProyectoDetalle = new System.Windows.Forms.DataGridView();
            this.panelProyectoDetalle = new System.Windows.Forms.Panel();
            this.DTPFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtIdProyectoDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProyectoDetalle)).BeginInit();
            this.panelProyectoDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Proyecto Detalle";
            // 
            // DGVProyectoDetalle
            // 
            this.DGVProyectoDetalle.AllowUserToAddRows = false;
            this.DGVProyectoDetalle.AllowUserToDeleteRows = false;
            this.DGVProyectoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProyectoDetalle.Location = new System.Drawing.Point(21, 354);
            this.DGVProyectoDetalle.Name = "DGVProyectoDetalle";
            this.DGVProyectoDetalle.ReadOnly = true;
            this.DGVProyectoDetalle.RowHeadersWidth = 62;
            this.DGVProyectoDetalle.RowTemplate.Height = 28;
            this.DGVProyectoDetalle.Size = new System.Drawing.Size(935, 318);
            this.DGVProyectoDetalle.TabIndex = 19;
            this.DGVProyectoDetalle.Tag = "";
            // 
            // panelProyectoDetalle
            // 
            this.panelProyectoDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelProyectoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProyectoDetalle.Controls.Add(this.DTPFechaRegistro);
            this.panelProyectoDetalle.Controls.Add(this.BtnEliminar);
            this.panelProyectoDetalle.Controls.Add(this.BtnEditar);
            this.panelProyectoDetalle.Controls.Add(this.BtnGuardar);
            this.panelProyectoDetalle.Controls.Add(this.TxtDescripcion);
            this.panelProyectoDetalle.Controls.Add(this.TxtIdProyectoDetalle);
            this.panelProyectoDetalle.Controls.Add(this.label4);
            this.panelProyectoDetalle.Controls.Add(this.label3);
            this.panelProyectoDetalle.Controls.Add(this.label2);
            this.panelProyectoDetalle.Location = new System.Drawing.Point(21, 82);
            this.panelProyectoDetalle.Name = "panelProyectoDetalle";
            this.panelProyectoDetalle.Size = new System.Drawing.Size(935, 255);
            this.panelProyectoDetalle.TabIndex = 18;
            // 
            // DTPFechaRegistro
            // 
            this.DTPFechaRegistro.Location = new System.Drawing.Point(56, 110);
            this.DTPFechaRegistro.Name = "DTPFechaRegistro";
            this.DTPFechaRegistro.Size = new System.Drawing.Size(336, 26);
            this.DTPFechaRegistro.TabIndex = 17;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(615, 199);
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
            this.BtnEditar.Location = new System.Drawing.Point(388, 199);
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
            this.BtnGuardar.Location = new System.Drawing.Point(190, 199);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(204, 42);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(714, 26);
            this.TxtDescripcion.TabIndex = 8;
            // 
            // TxtIdProyectoDetalle
            // 
            this.TxtIdProyectoDetalle.Location = new System.Drawing.Point(56, 42);
            this.TxtIdProyectoDetalle.Name = "TxtIdProyectoDetalle";
            this.TxtIdProyectoDetalle.Size = new System.Drawing.Size(132, 26);
            this.TxtIdProyectoDetalle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha del registro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id ";
            // 
            // FrmProyectoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVProyectoDetalle);
            this.Controls.Add(this.panelProyectoDetalle);
            this.Controls.Add(this.label1);
            this.Name = "FrmProyectoDetalle";
            this.Text = "Formulario Proyecto Detalle";
            this.Load += new System.EventHandler(this.FrmProyectoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProyectoDetalle)).EndInit();
            this.panelProyectoDetalle.ResumeLayout(false);
            this.panelProyectoDetalle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVProyectoDetalle;
        private System.Windows.Forms.Panel panelProyectoDetalle;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtIdProyectoDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTPFechaRegistro;
    }
}