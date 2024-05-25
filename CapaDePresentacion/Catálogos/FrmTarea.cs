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
    public partial class FrmTarea : Form
    {
        // Variables
        private TareaCN tareaCN;
        private Tarea tarea;
        private bool editar = false;
        private int tareaid;

        public FrmTarea()
        {
            InitializeComponent();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            // Inicializar DataGridView llamando al método de carga de datos
            MostrarTareas();
        }

        // Método para cargar los datos en el DataGridView
        private void MostrarTareas()
        {
            tareaCN = new TareaCN();
            DGVTarea.DataSource = tareaCN.ObtenerTarea();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdTarea.Text = "";
            TxtDescripcion.Text = "";
            DTPFechaInicio.Text = "";
            DTPFechaFin.Text = "";
            TxtEstado.Text = "";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener la fecha del DateTimePicker
            DateTime fechaInicio = DTPFechaInicio.Value;
            DateTime fechaFin = DTPFechaFin.Value;

            try
            {
                // Si es nuevo
                if (editar == false)
                {
                    tarea = new Tarea(TxtIdTarea.Text, TxtDescripcion.Text, fechaInicio, fechaFin, TxtEstado.Text);

                    // clienteCN.ValidarAntesDeCrear(cliente);

                    if (tareaCN.Insertar(tarea))
                    {
                        LimpiarDatos();
                        MostrarTareas();
                    }
                    else
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // Es uno existente
                {
                    editar = false;
                    tarea = new Tarea(TxtIdTarea.Text, TxtDescripcion.Text, fechaInicio, fechaFin, TxtEstado.Text);

                    // clienteCN.ValidarAntesDeEditar(cliente);

                    if (tareaCN.Editar(tarea))
                    {
                        LimpiarDatos();
                        MostrarTareas();
                    }
                    else
                        MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTarea.SelectedRows.Count > 0)
                {
                    editar = true;
                    DataGridViewRow selectedRow = DGVTarea.SelectedRows[0];

                    if (selectedRow != null)
                    {
                        TxtIdTarea.Text = selectedRow.Cells["id_tarea"].Value?.ToString();
                        TxtDescripcion.Text = selectedRow.Cells["descripcion"].Value?.ToString();
                        DTPFechaInicio.Value = Convert.ToDateTime(selectedRow.Cells["fecha_inicio"].Value);
                        DTPFechaFin.Value = Convert.ToDateTime(selectedRow.Cells["fecha_fin"].Value);
                        TxtEstado.Text = selectedRow.Cells["estado"].Value?.ToString();

                        tareaid = Convert.ToInt32(selectedRow.Cells["id_tarea"].Value);
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ninguna fila.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la fila seleccionada: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTarea.SelectedRows.Count > 0)
                {
                    int tareaid = int.Parse(DGVTarea.CurrentRow.Cells["id_tarea"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (tareaCN.Eliminar(tareaid))
                    {
                        LimpiarDatos();
                        MostrarTareas();
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

