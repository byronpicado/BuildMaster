using CapaDeDatos.CRUD;
using CapaDeNegocio.CN_CRUD;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmProyecto : Form
    {
        // Variables
        private ProyectoCN proyectoCN;
        private Proyecto proyecto;
        private bool editar = false;
        private int proyectoid;
        public FrmProyecto()
        {
            InitializeComponent();
        }


        private void FrmProyecto_Load(object sender, EventArgs e)
        {
            MostrarProyecto();
        }
        // Obtener el proyecto desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarProyecto()
        {
            proyectoCN = new ProyectoCN();
            DGVProyecto.DataSource = proyectoCN.ObtenerProyecto();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdProyecto.Text = "";
            TxtNombre.Text = "";
            TxtDescripcion.Text = "";
            TxtEstado.Text = "";
            DTPFechaInicio.Text = ""; // Resetea al valor actual
            DTPFechaFin.Text= "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha del DateTimePicker
                DateTime fechaInicio = DTPFechaInicio.Value;
                DateTime fechaFin = DTPFechaFin.Value;

                // Si es nuevo
                if (editar == false)
                {
                    proyecto = new Proyecto(TxtIdProyecto.Text, TxtNombre.Text,TxtDescripcion.Text, fechaInicio,fechaFin,TxtEstado.Text);

                    if (proyectoCN.Insertar(proyecto))
                    {
                        LimpiarDatos();
                        MostrarProyecto();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    proyecto = new Proyecto(TxtIdProyecto.Text, TxtNombre.Text, TxtDescripcion.Text, fechaInicio, fechaFin, TxtEstado.Text);

                    if (proyectoCN.Editar(proyecto))
                    {
                        LimpiarDatos();
                        MostrarProyecto();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGVProyecto.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdProyecto.Text = DGVProyecto.CurrentRow.Cells["id_proyecto"].Value.ToString();
                    TxtNombre.Text = DGVProyecto.CurrentRow.Cells["nombre"].Value.ToString();
                    TxtDescripcion.Text = DGVProyecto.CurrentRow.Cells["descripcion"].Value.ToString();
                    DTPFechaInicio.Text = DGVProyecto.CurrentRow.Cells["fecha_inicio"].Value.ToString();
                    DTPFechaFin.Text = DGVProyecto.CurrentRow.Cells["fecha_fin"].Value.ToString();
                    TxtEstado.Text = DGVProyecto.CurrentRow.Cells["Estado"].Value.ToString();



                    proyectoid = int.Parse(DGVProyecto.CurrentRow.Cells["id_proyecto"].Value.ToString());

                }
                else
                    MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVProyecto.SelectedRows.Count > 0)
                {
                    int proyectoid = int.Parse(DGVProyecto.CurrentRow.Cells["id_proyecto"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (proyectoCN.Eliminar(proyectoid))
                    {
                        LimpiarDatos();
                        MostrarProyecto();
                        MessageBox.Show("El registro se eliminó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El registro no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}