namespace CapaDePresentacion.Catálogos
{
    partial class FrmEquipo
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
            this.DGVEquipo = new System.Windows.Forms.DataGridView();
            this.panelEquipo = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtFechaAdquisicion = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.TxtIdEquipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipo)).BeginInit();
            this.panelEquipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Equipo";
            // 
            // DGVEquipo
            // 
            this.DGVEquipo.AllowUserToAddRows = false;
            this.DGVEquipo.AllowUserToDeleteRows = false;
            this.DGVEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEquipo.Location = new System.Drawing.Point(22, 264);
            this.DGVEquipo.Name = "DGVEquipo";
            this.DGVEquipo.ReadOnly = true;
            this.DGVEquipo.RowHeadersWidth = 62;
            this.DGVEquipo.RowTemplate.Height = 28;
            this.DGVEquipo.Size = new System.Drawing.Size(935, 373);
            this.DGVEquipo.TabIndex = 19;
            this.DGVEquipo.Tag = "";
            // 
            // panelEquipo
            // 
            this.panelEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEquipo.Controls.Add(this.BtnEliminar);
            this.panelEquipo.Controls.Add(this.BtnEditar);
            this.panelEquipo.Controls.Add(this.BtnGuardar);
            this.panelEquipo.Controls.Add(this.TxtFechaAdquisicion);
            this.panelEquipo.Controls.Add(this.TxtMarca);
            this.panelEquipo.Controls.Add(this.TxtTipo);
            this.panelEquipo.Controls.Add(this.TxtIdEquipo);
            this.panelEquipo.Controls.Add(this.label5);
            this.panelEquipo.Controls.Add(this.label4);
            this.panelEquipo.Controls.Add(this.label3);
            this.panelEquipo.Controls.Add(this.label2);
            this.panelEquipo.Location = new System.Drawing.Point(22, 47);
            this.panelEquipo.Name = "panelEquipo";
            this.panelEquipo.Size = new System.Drawing.Size(935, 190);
            this.panelEquipo.TabIndex = 18;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(700, 120);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 30);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEditar.Location = new System.Drawing.Point(405, 120);
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
            this.BtnGuardar.Location = new System.Drawing.Point(80, 120);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // TxtFechaAdquisicion
            // 
            this.TxtFechaAdquisicion.Location = new System.Drawing.Point(664, 41);
            this.TxtFechaAdquisicion.Name = "TxtFechaAdquisicion";
            this.TxtFechaAdquisicion.Size = new System.Drawing.Size(179, 26);
            this.TxtFechaAdquisicion.TabIndex = 10;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(414, 41);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(194, 26);
            this.TxtMarca.TabIndex = 9;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(199, 41);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(168, 26);
            this.TxtTipo.TabIndex = 8;
            // 
            // TxtIdEquipo
            // 
            this.TxtIdEquipo.Location = new System.Drawing.Point(46, 42);
            this.TxtIdEquipo.Name = "TxtIdEquipo";
            this.TxtIdEquipo.Size = new System.Drawing.Size(100, 26);
            this.TxtIdEquipo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Adquisición";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
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
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVEquipo);
            this.Controls.Add(this.panelEquipo);
            this.Controls.Add(this.label1);
            this.Name = "FrmEquipo";
            this.Text = "Formulario Equipo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEquipo)).EndInit();
            this.panelEquipo.ResumeLayout(false);
            this.panelEquipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVEquipo;
        private System.Windows.Forms.Panel panelEquipo;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtFechaAdquisicion;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.TextBox TxtIdEquipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}