namespace CapaDePresentacion.Catálogos
{
    partial class FrmResponsable
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
            this.panelResponsable = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.TxtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.TxtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.TxtNombre2 = new System.Windows.Forms.TextBox();
            this.TxtNombre1 = new System.Windows.Forms.TextBox();
            this.TxtIdResponsable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVResponsable = new System.Windows.Forms.DataGridView();
            this.panelResponsable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResponsable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catálogo de Responsable";
            // 
            // panelResponsable
            // 
            this.panelResponsable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResponsable.Controls.Add(this.BtnEliminar);
            this.panelResponsable.Controls.Add(this.BtnEditar);
            this.panelResponsable.Controls.Add(this.BtnGuardar);
            this.panelResponsable.Controls.Add(this.TxtCargo);
            this.panelResponsable.Controls.Add(this.TxtApellidoMaterno);
            this.panelResponsable.Controls.Add(this.TxtApellidoPaterno);
            this.panelResponsable.Controls.Add(this.TxtNombre2);
            this.panelResponsable.Controls.Add(this.TxtNombre1);
            this.panelResponsable.Controls.Add(this.TxtIdResponsable);
            this.panelResponsable.Controls.Add(this.label7);
            this.panelResponsable.Controls.Add(this.label6);
            this.panelResponsable.Controls.Add(this.label5);
            this.panelResponsable.Controls.Add(this.label4);
            this.panelResponsable.Controls.Add(this.label3);
            this.panelResponsable.Controls.Add(this.label2);
            this.panelResponsable.Location = new System.Drawing.Point(22, 82);
            this.panelResponsable.Name = "panelResponsable";
            this.panelResponsable.Size = new System.Drawing.Size(935, 255);
            this.panelResponsable.TabIndex = 18;
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
            this.TxtApellidoPaterno.Location = new System.Drawing.Point(664, 41);
            this.TxtApellidoPaterno.Name = "TxtApellidoPaterno";
            this.TxtApellidoPaterno.Size = new System.Drawing.Size(179, 26);
            this.TxtApellidoPaterno.TabIndex = 10;
            // 
            // TxtNombre2
            // 
            this.TxtNombre2.Location = new System.Drawing.Point(414, 41);
            this.TxtNombre2.Name = "TxtNombre2";
            this.TxtNombre2.Size = new System.Drawing.Size(194, 26);
            this.TxtNombre2.TabIndex = 9;
            // 
            // TxtNombre1
            // 
            this.TxtNombre1.Location = new System.Drawing.Point(199, 41);
            this.TxtNombre1.Name = "TxtNombre1";
            this.TxtNombre1.Size = new System.Drawing.Size(168, 26);
            this.TxtNombre1.TabIndex = 8;
            // 
            // TxtIdResponsable
            // 
            this.TxtIdResponsable.Location = new System.Drawing.Point(46, 42);
            this.TxtIdResponsable.Name = "TxtIdResponsable";
            this.TxtIdResponsable.Size = new System.Drawing.Size(100, 26);
            this.TxtIdResponsable.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cargo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido paterno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Segundo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Primer nombre";
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
            // DGVResponsable
            // 
            this.DGVResponsable.AllowUserToAddRows = false;
            this.DGVResponsable.AllowUserToDeleteRows = false;
            this.DGVResponsable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVResponsable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResponsable.Location = new System.Drawing.Point(22, 362);
            this.DGVResponsable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVResponsable.Name = "DGVResponsable";
            this.DGVResponsable.ReadOnly = true;
            this.DGVResponsable.RowHeadersWidth = 51;
            this.DGVResponsable.RowTemplate.Height = 24;
            this.DGVResponsable.Size = new System.Drawing.Size(935, 261);
            this.DGVResponsable.TabIndex = 17;
            // 
            // FrmResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVResponsable);
            this.Controls.Add(this.panelResponsable);
            this.Controls.Add(this.label1);
            this.Name = "FrmResponsable";
            this.Text = "Formulario Responsable";
            this.Load += new System.EventHandler(this.FrmResponsable_Load);
            this.panelResponsable.ResumeLayout(false);
            this.panelResponsable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResponsable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResponsable;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCargo;
        private System.Windows.Forms.TextBox TxtApellidoMaterno;
        private System.Windows.Forms.TextBox TxtApellidoPaterno;
        private System.Windows.Forms.TextBox TxtNombre2;
        private System.Windows.Forms.TextBox TxtNombre1;
        private System.Windows.Forms.TextBox TxtIdResponsable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVResponsable;
    }
}