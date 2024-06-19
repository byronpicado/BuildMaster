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
            this.iconButtonResponsable = new FontAwesome.Sharp.IconButton();
            this.iconButtonProgreso = new FontAwesome.Sharp.IconButton();
            this.iconButtonPersonal = new FontAwesome.Sharp.IconButton();
            this.iconButtonMantenimiento = new FontAwesome.Sharp.IconButton();
            this.iconButtonHabilidad = new FontAwesome.Sharp.IconButton();
            this.iconButtonEquipo = new FontAwesome.Sharp.IconButton();
            this.iconButtonCliente = new FontAwesome.Sharp.IconButton();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconButtonRecurso = new FontAwesome.Sharp.IconButton();
            this.iconButtonTarea = new FontAwesome.Sharp.IconButton();
            this.iconButtonProyecto = new FontAwesome.Sharp.IconButton();
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
            this.MenuVertical.Controls.Add(this.iconButtonResponsable);
            this.MenuVertical.Controls.Add(this.iconButtonProgreso);
            this.MenuVertical.Controls.Add(this.iconButtonPersonal);
            this.MenuVertical.Controls.Add(this.iconButtonMantenimiento);
            this.MenuVertical.Controls.Add(this.iconButtonHabilidad);
            this.MenuVertical.Controls.Add(this.iconButtonEquipo);
            this.MenuVertical.Controls.Add(this.iconButtonCliente);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(315, 872);
            this.MenuVertical.TabIndex = 1;
            // 
            // iconButtonResponsable
            // 
            this.iconButtonResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonResponsable.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.iconButtonResponsable.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonResponsable.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonResponsable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonResponsable.Location = new System.Drawing.Point(-1, 537);
            this.iconButtonResponsable.Name = "iconButtonResponsable";
            this.iconButtonResponsable.Size = new System.Drawing.Size(315, 60);
            this.iconButtonResponsable.TabIndex = 38;
            this.iconButtonResponsable.Text = "Responsable";
            this.iconButtonResponsable.UseVisualStyleBackColor = false;
            this.iconButtonResponsable.Click += new System.EventHandler(this.iconButtonResponsable_Click);
            // 
            // iconButtonProgreso
            // 
            this.iconButtonProgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProgreso.IconChar = FontAwesome.Sharp.IconChar.ChartGantt;
            this.iconButtonProgreso.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonProgreso.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonProgreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProgreso.Location = new System.Drawing.Point(-1, 471);
            this.iconButtonProgreso.Name = "iconButtonProgreso";
            this.iconButtonProgreso.Size = new System.Drawing.Size(315, 60);
            this.iconButtonProgreso.TabIndex = 37;
            this.iconButtonProgreso.Text = " Progreso";
            this.iconButtonProgreso.UseVisualStyleBackColor = false;
            this.iconButtonProgreso.Click += new System.EventHandler(this.iconButtonProgreso_Click);
            // 
            // iconButtonPersonal
            // 
            this.iconButtonPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPersonal.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButtonPersonal.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonPersonal.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPersonal.Location = new System.Drawing.Point(-1, 405);
            this.iconButtonPersonal.Name = "iconButtonPersonal";
            this.iconButtonPersonal.Size = new System.Drawing.Size(315, 60);
            this.iconButtonPersonal.TabIndex = 36;
            this.iconButtonPersonal.Text = "Personal";
            this.iconButtonPersonal.UseVisualStyleBackColor = false;
            this.iconButtonPersonal.Click += new System.EventHandler(this.iconButtonPersonal_Click);
            // 
            // iconButtonMantenimiento
            // 
            this.iconButtonMantenimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.iconButtonMantenimiento.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonMantenimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMantenimiento.Location = new System.Drawing.Point(-1, 338);
            this.iconButtonMantenimiento.Name = "iconButtonMantenimiento";
            this.iconButtonMantenimiento.Size = new System.Drawing.Size(315, 60);
            this.iconButtonMantenimiento.TabIndex = 35;
            this.iconButtonMantenimiento.Text = "Mantenimiento";
            this.iconButtonMantenimiento.UseVisualStyleBackColor = false;
            this.iconButtonMantenimiento.Click += new System.EventHandler(this.iconButtonMantenimiento_Click);
            // 
            // iconButtonHabilidad
            // 
            this.iconButtonHabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonHabilidad.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButtonHabilidad.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonHabilidad.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonHabilidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHabilidad.Location = new System.Drawing.Point(-1, 272);
            this.iconButtonHabilidad.Name = "iconButtonHabilidad";
            this.iconButtonHabilidad.Size = new System.Drawing.Size(315, 60);
            this.iconButtonHabilidad.TabIndex = 34;
            this.iconButtonHabilidad.Text = "Habilidad";
            this.iconButtonHabilidad.UseVisualStyleBackColor = false;
            this.iconButtonHabilidad.Click += new System.EventHandler(this.iconButtonHabilidad_Click);
            // 
            // iconButtonEquipo
            // 
            this.iconButtonEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonEquipo.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            this.iconButtonEquipo.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonEquipo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonEquipo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonEquipo.Location = new System.Drawing.Point(0, 206);
            this.iconButtonEquipo.Name = "iconButtonEquipo";
            this.iconButtonEquipo.Size = new System.Drawing.Size(315, 60);
            this.iconButtonEquipo.TabIndex = 33;
            this.iconButtonEquipo.Text = "Equipo";
            this.iconButtonEquipo.UseVisualStyleBackColor = false;
            this.iconButtonEquipo.Click += new System.EventHandler(this.iconButtonEquipo_Click);
            // 
            // iconButtonCliente
            // 
            this.iconButtonCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCliente.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconButtonCliente.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonCliente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCliente.Location = new System.Drawing.Point(0, 140);
            this.iconButtonCliente.Name = "iconButtonCliente";
            this.iconButtonCliente.Rotation = 1D;
            this.iconButtonCliente.Size = new System.Drawing.Size(315, 60);
            this.iconButtonCliente.TabIndex = 32;
            this.iconButtonCliente.Text = "Cliente";
            this.iconButtonCliente.UseVisualStyleBackColor = false;
            this.iconButtonCliente.Click += new System.EventHandler(this.iconButtonCliente_Click);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnlogoInicio.Image")));
            this.btnlogoInicio.Location = new System.Drawing.Point(0, 0);
            this.btnlogoInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(90, 107);
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
            this.BarraTitulo.Controls.Add(this.iconButtonRecurso);
            this.BarraTitulo.Controls.Add(this.iconButtonTarea);
            this.BarraTitulo.Controls.Add(this.iconButtonProyecto);
            this.BarraTitulo.Controls.Add(this.pictureBox1);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(315, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1203, 108);
            this.BarraTitulo.TabIndex = 3;
            // 
            // iconButtonRecurso
            // 
            this.iconButtonRecurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRecurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRecurso.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
            this.iconButtonRecurso.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonRecurso.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonRecurso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRecurso.Location = new System.Drawing.Point(764, 23);
            this.iconButtonRecurso.Name = "iconButtonRecurso";
            this.iconButtonRecurso.Rotation = 1D;
            this.iconButtonRecurso.Size = new System.Drawing.Size(315, 60);
            this.iconButtonRecurso.TabIndex = 41;
            this.iconButtonRecurso.Text = "Recurso";
            this.iconButtonRecurso.UseVisualStyleBackColor = false;
            this.iconButtonRecurso.Click += new System.EventHandler(this.iconButtonRecurso_Click);
            // 
            // iconButtonTarea
            // 
            this.iconButtonTarea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonTarea.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.iconButtonTarea.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonTarea.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonTarea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonTarea.Location = new System.Drawing.Point(443, 23);
            this.iconButtonTarea.Name = "iconButtonTarea";
            this.iconButtonTarea.Rotation = 1D;
            this.iconButtonTarea.Size = new System.Drawing.Size(315, 60);
            this.iconButtonTarea.TabIndex = 40;
            this.iconButtonTarea.Text = "Tarea";
            this.iconButtonTarea.UseVisualStyleBackColor = false;
            this.iconButtonTarea.Click += new System.EventHandler(this.iconButtonTarea_Click);
            // 
            // iconButtonProyecto
            // 
            this.iconButtonProyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonProyecto.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            this.iconButtonProyecto.IconColor = System.Drawing.Color.LightGreen;
            this.iconButtonProyecto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButtonProyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonProyecto.Location = new System.Drawing.Point(127, 23);
            this.iconButtonProyecto.Name = "iconButtonProyecto";
            this.iconButtonProyecto.Rotation = 1D;
            this.iconButtonProyecto.Size = new System.Drawing.Size(315, 60);
            this.iconButtonProyecto.TabIndex = 39;
            this.iconButtonProyecto.Text = "Proyecto";
            this.iconButtonProyecto.UseVisualStyleBackColor = false;
            this.iconButtonProyecto.Click += new System.EventHandler(this.iconButtonProyecto_Click);
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
            this.lblFecha.Location = new System.Drawing.Point(870, 816);
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
            this.lblhora.Location = new System.Drawing.Point(899, 647);
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
            this.ClientSize = new System.Drawing.Size(1518, 872);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.MenuVertical);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "Build Master Construction SoftWare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private PictureBox btnlogoInicio;
        private PictureBox btnMenu;
        private Panel BarraTitulo;
        private PictureBox pictureBox1;
        private Label lblFecha;
        private Label lblhora;
        private Timer timer1;
        private FontAwesome.Sharp.IconButton iconButtonCliente;
        private FontAwesome.Sharp.IconButton iconButtonEquipo;
        private FontAwesome.Sharp.IconButton iconButtonHabilidad;
        private FontAwesome.Sharp.IconButton iconButtonMantenimiento;
        private FontAwesome.Sharp.IconButton iconButtonPersonal;
        private FontAwesome.Sharp.IconButton iconButtonResponsable;
        private FontAwesome.Sharp.IconButton iconButtonProgreso;
        private FontAwesome.Sharp.IconButton iconButtonProyecto;
        private FontAwesome.Sharp.IconButton iconButtonRecurso;
        private FontAwesome.Sharp.IconButton iconButtonTarea;
    }
}

