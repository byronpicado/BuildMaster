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
            var Frm = new Catálogos.FrmRecurso();
            Frm.ShowDialog();
            Frm.Dispose();
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
    }
}
