using System;
using System.Windows.Forms;
namespace CapaDePresentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progresoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectoDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.catálogosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(978, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.equipoToolStripMenuItem,
            this.habilidadToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.proyectoToolStripMenuItem,
            this.progresoToolStripMenuItem,
            this.proyectoDetalleToolStripMenuItem,
            this.responsableToolStripMenuItem,
            this.tareaToolStripMenuItem});
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.equipoToolStripMenuItem.Text = "Equipo";
            this.equipoToolStripMenuItem.Click += new System.EventHandler(this.equipoToolStripMenuItem_Click);
            // 
            // habilidadToolStripMenuItem
            // 
            this.habilidadToolStripMenuItem.Name = "habilidadToolStripMenuItem";
            this.habilidadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.habilidadToolStripMenuItem.Text = "Habilidad";
            this.habilidadToolStripMenuItem.Click += new System.EventHandler(this.habilidadToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // proyectoToolStripMenuItem
            // 
            this.proyectoToolStripMenuItem.Name = "proyectoToolStripMenuItem";
            this.proyectoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.proyectoToolStripMenuItem.Text = "Proyecto";
            this.proyectoToolStripMenuItem.Click += new System.EventHandler(this.proyectoToolStripMenuItem_Click);
            // 
            // progresoToolStripMenuItem
            // 
            this.progresoToolStripMenuItem.Name = "progresoToolStripMenuItem";
            this.progresoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.progresoToolStripMenuItem.Text = "Progreso";
            this.progresoToolStripMenuItem.Click += new System.EventHandler(this.progresoToolStripMenuItem_Click);
            // 
            // proyectoDetalleToolStripMenuItem
            // 
            this.proyectoDetalleToolStripMenuItem.Name = "proyectoDetalleToolStripMenuItem";
            this.proyectoDetalleToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.proyectoDetalleToolStripMenuItem.Text = "Proyecto Detalle";
            this.proyectoDetalleToolStripMenuItem.Click += new System.EventHandler(this.proyectoDetalleToolStripMenuItem_Click);
            // 
            // responsableToolStripMenuItem
            // 
            this.responsableToolStripMenuItem.Name = "responsableToolStripMenuItem";
            this.responsableToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.responsableToolStripMenuItem.Text = "Responsable";
            this.responsableToolStripMenuItem.Click += new System.EventHandler(this.responsableToolStripMenuItem_Click);
            // 
            // tareaToolStripMenuItem
            // 
            this.tareaToolStripMenuItem.Name = "tareaToolStripMenuItem";
            this.tareaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tareaToolStripMenuItem.Text = "Tarea";
            this.tareaToolStripMenuItem.Click += new System.EventHandler(this.tareaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmPrincipal";
            this.Text = "BuildMaster";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem progresoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectoDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tareaToolStripMenuItem;
    }
}

