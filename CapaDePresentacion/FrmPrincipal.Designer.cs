using System.Windows.Forms;
using System;

namespace CapaDePresentacion
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnProgreso = new System.Windows.Forms.Button();
            this.BtnPersonal = new System.Windows.Forms.Button();
            this.BtnMantenimiento = new System.Windows.Forms.Button();
            this.BtnHabilidad = new System.Windows.Forms.Button();
            this.BtnEquipo = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.MenuVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuVertical.Controls.Add(this.button1);
            this.MenuVertical.Controls.Add(this.BtnProgreso);
            this.MenuVertical.Controls.Add(this.BtnPersonal);
            this.MenuVertical.Controls.Add(this.BtnMantenimiento);
            this.MenuVertical.Controls.Add(this.BtnHabilidad);
            this.MenuVertical.Controls.Add(this.BtnEquipo);
            this.MenuVertical.Controls.Add(this.BtnCliente);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(367, 764);
            this.MenuVertical.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 620);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 62);
            this.button1.TabIndex = 18;
            this.button1.Text = " Responsable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnProgreso
            // 
            this.BtnProgreso.FlatAppearance.BorderSize = 0;
            this.BtnProgreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnProgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProgreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProgreso.ForeColor = System.Drawing.Color.Black;
            this.BtnProgreso.Image = ((System.Drawing.Image)(resources.GetObject("BtnProgreso.Image")));
            this.BtnProgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProgreso.Location = new System.Drawing.Point(0, 548);
            this.BtnProgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnProgreso.Name = "BtnProgreso";
            this.BtnProgreso.Size = new System.Drawing.Size(375, 62);
            this.BtnProgreso.TabIndex = 6;
            this.BtnProgreso.Text = " Progreso";
            this.BtnProgreso.UseVisualStyleBackColor = true;
            this.BtnProgreso.Click += new System.EventHandler(this.BtnProgreso_Click);
            // 
            // BtnPersonal
            // 
            this.BtnPersonal.FlatAppearance.BorderSize = 0;
            this.BtnPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPersonal.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonal.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersonal.Image")));
            this.BtnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonal.Location = new System.Drawing.Point(0, 477);
            this.BtnPersonal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPersonal.Name = "BtnPersonal";
            this.BtnPersonal.Size = new System.Drawing.Size(375, 62);
            this.BtnPersonal.TabIndex = 5;
            this.BtnPersonal.Text = " Personal";
            this.BtnPersonal.UseVisualStyleBackColor = true;
            this.BtnPersonal.Click += new System.EventHandler(this.button5_Click);
            // 
            // BtnMantenimiento
            // 
            this.BtnMantenimiento.FlatAppearance.BorderSize = 0;
            this.BtnMantenimiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMantenimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMantenimiento.ForeColor = System.Drawing.Color.Black;
            this.BtnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("BtnMantenimiento.Image")));
            this.BtnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMantenimiento.Location = new System.Drawing.Point(0, 406);
            this.BtnMantenimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnMantenimiento.Name = "BtnMantenimiento";
            this.BtnMantenimiento.Size = new System.Drawing.Size(375, 62);
            this.BtnMantenimiento.TabIndex = 4;
            this.BtnMantenimiento.Text = " Mantenimiento";
            this.BtnMantenimiento.UseVisualStyleBackColor = true;
            this.BtnMantenimiento.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnHabilidad
            // 
            this.BtnHabilidad.FlatAppearance.BorderSize = 0;
            this.BtnHabilidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnHabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHabilidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHabilidad.ForeColor = System.Drawing.Color.Black;
            this.BtnHabilidad.Image = ((System.Drawing.Image)(resources.GetObject("BtnHabilidad.Image")));
            this.BtnHabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHabilidad.Location = new System.Drawing.Point(0, 335);
            this.BtnHabilidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnHabilidad.Name = "BtnHabilidad";
            this.BtnHabilidad.Size = new System.Drawing.Size(375, 62);
            this.BtnHabilidad.TabIndex = 3;
            this.BtnHabilidad.Text = " Habilidad";
            this.BtnHabilidad.UseVisualStyleBackColor = true;
            this.BtnHabilidad.Click += new System.EventHandler(this.BtnHabilidad_Click);
            // 
            // BtnEquipo
            // 
            this.BtnEquipo.FlatAppearance.BorderSize = 0;
            this.BtnEquipo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEquipo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEquipo.ForeColor = System.Drawing.Color.Black;
            this.BtnEquipo.Image = ((System.Drawing.Image)(resources.GetObject("BtnEquipo.Image")));
            this.BtnEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEquipo.Location = new System.Drawing.Point(0, 265);
            this.BtnEquipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEquipo.Name = "BtnEquipo";
            this.BtnEquipo.Size = new System.Drawing.Size(375, 62);
            this.BtnEquipo.TabIndex = 2;
            this.BtnEquipo.Text = "Equipo";
            this.BtnEquipo.UseVisualStyleBackColor = true;
            this.BtnEquipo.Click += new System.EventHandler(this.BtnEquipo_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCliente.Image")));
            this.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCliente.Location = new System.Drawing.Point(0, 194);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(361, 62);
            this.BtnCliente.TabIndex = 1;
            this.BtnCliente.Text = "Cliente";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 0);
            this.btnlogoInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(117, 117);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnlogoInicio.TabIndex = 0;
            this.btnlogoInicio.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(403, 14);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(52, 54);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(367, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1531, 108);
            this.BarraTitulo.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblFecha.Location = new System.Drawing.Point(569, 467);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(771, 61);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Miercoles, 10  noviembre  2017";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.CausesValidation = false;
            this.lblhora.Font = new System.Drawing.Font("Century Gothic", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(598, 298);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(567, 155);
            this.lblhora.TabIndex = 30;
            this.lblhora.Text = "10:59:58";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // FrmPrincipal
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1898, 764);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.MenuVertical);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "BuildMaster";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private Panel MenuVertical;
        private Button BtnProgreso;
        private Button BtnPersonal;
        private Button BtnMantenimiento;
        private Button BtnHabilidad;
        private Button BtnEquipo;
        private Button BtnCliente;
        private PictureBox btnlogoInicio;
        private PictureBox btnMenu;
        private Panel BarraTitulo;
        private PictureBox pictureBox1;
        private Button button1;
        private Label lblFecha;
        private Label lblhora;
        private Timer timer1;
    }
}

