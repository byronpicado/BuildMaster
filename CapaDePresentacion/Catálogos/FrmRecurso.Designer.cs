namespace CapaDePresentacion.Catálogos
{
    partial class FrmRecurso
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
            this.DGVRecurso = new System.Windows.Forms.DataGridView();
            this.panelRecurso = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.TxtIdRecurso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecurso)).BeginInit();
            this.panelRecurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVRecurso
            // 
            this.DGVRecurso.AllowUserToAddRows = false;
            this.DGVRecurso.AllowUserToDeleteRows = false;
            this.DGVRecurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRecurso.Location = new System.Drawing.Point(22, 356);
            this.DGVRecurso.Name = "DGVRecurso";
            this.DGVRecurso.ReadOnly = true;
            this.DGVRecurso.RowHeadersWidth = 62;
            this.DGVRecurso.RowTemplate.Height = 28;
            this.DGVRecurso.Size = new System.Drawing.Size(935, 318);
            this.DGVRecurso.TabIndex = 22;
            this.DGVRecurso.Tag = "";
            // 
            // panelRecurso
            // 
            this.panelRecurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(122)))), ((int)(((byte)(191)))));
            this.panelRecurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRecurso.Controls.Add(this.BtnEliminar);
            this.panelRecurso.Controls.Add(this.BtnEditar);
            this.panelRecurso.Controls.Add(this.BtnGuardar);
            this.panelRecurso.Controls.Add(this.TxtCosto);
            this.panelRecurso.Controls.Add(this.TxtDescripcion);
            this.panelRecurso.Controls.Add(this.TxtTipo);
            this.panelRecurso.Controls.Add(this.TxtIdRecurso);
            this.panelRecurso.Controls.Add(this.label5);
            this.panelRecurso.Controls.Add(this.label4);
            this.panelRecurso.Controls.Add(this.label3);
            this.panelRecurso.Controls.Add(this.label2);
            this.panelRecurso.Location = new System.Drawing.Point(22, 84);
            this.panelRecurso.Name = "panelRecurso";
            this.panelRecurso.Size = new System.Drawing.Size(935, 255);
            this.panelRecurso.TabIndex = 21;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.Location = new System.Drawing.Point(687, 201);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(85, 30);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnEditar.Location = new System.Drawing.Point(392, 201);
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
            this.BtnGuardar.Location = new System.Drawing.Point(67, 201);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(85, 30);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(571, 41);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(272, 26);
            this.TxtCosto.TabIndex = 10;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(46, 120);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(835, 26);
            this.TxtDescripcion.TabIndex = 9;
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(199, 41);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(289, 26);
            this.TxtTipo.TabIndex = 8;
            // 
            // TxtIdRecurso
            // 
            this.TxtIdRecurso.Location = new System.Drawing.Point(46, 42);
            this.TxtIdRecurso.Name = "TxtIdRecurso";
            this.TxtIdRecurso.Size = new System.Drawing.Size(132, 26);
            this.TxtIdRecurso.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 97);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 20;
            this.label1.Text = "Catálogo de Recurso";
            // 
            // FrmRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 684);
            this.Controls.Add(this.DGVRecurso);
            this.Controls.Add(this.panelRecurso);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecurso";
            this.Text = "FrmRecurso";
            this.Load += new System.EventHandler(this.FrmRecurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRecurso)).EndInit();
            this.panelRecurso.ResumeLayout(false);
            this.panelRecurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVRecurso;
        private System.Windows.Forms.Panel panelRecurso;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.TextBox TxtIdRecurso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}