using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmCliente();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmEquipo();
            Frm.ShowDialog();
            Frm.Dispose();
        }

 

        private void habilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmHabilidad();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmMantenimiento();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmPersonal();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void proyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmProyecto();
            Frm.ShowDialog();
            Frm.Dispose();
        }



        private void progresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmProgreso();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void proyectoDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmProyectoDetalle();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void recursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
        }

        private void responsableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmResponsable();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void tareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmTarea();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 118;
            }
            else
                MenuVertical.Width = 250;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmPersonal();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmCliente();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void BtnEquipo_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmEquipo();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void BtnHabilidad_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmHabilidad();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmMantenimiento();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void BtnProgreso_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmProgreso();
            Frm.ShowDialog();
            Frm.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Frm = new Catálogos.FrmResponsable();
            Frm.ShowDialog();
            Frm.Dispose();
        }
    }
}
