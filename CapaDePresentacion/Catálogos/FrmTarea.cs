using System;
using System.Data;
using System.Windows.Forms;
using CapaDeNegocio.CN_CRUD;
using Entidades;
using Entidades.Entidades;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmTarea : Form
    {
        private TareaCN tareaCN;
        private Tarea tarea;
        private bool editar = false;
        private int tareaid;

        public FrmTarea()
        {
            InitializeComponent();
            tareaCN = new TareaCN();
        }

        private void FrmTarea_Load(object sender, EventArgs e)
        {
            MostrarTareas();
        }

        private void MostrarTareas()
        {
            try
            {
                tareaCN = new TareaCN();
                DGVTarea.DataSource = tareaCN.ObtenerTarea();
                DGVTarea.Columns["id_tarea"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarDatos()
        {
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            DTPFechaInicio.Value = DateTime.Now;
            DTPFechaFin.Value = DateTime.Now;
            TxtEstado.Clear();
            TxtCodigo.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInputs())
                {
                    tarea = new Tarea(tareaid,TxtCodigo.Text, TxtDescripcion.Text, DTPFechaInicio.Value, DTPFechaFin.Value, TxtEstado.Text);

                    if (!editar)
                    {
                        tareaCN.ValidarAntesDeCrear(tarea);
                        if (tareaCN.Insertar(tarea))
                        {
                            LimpiarDatos();
                            MostrarTareas();
                            MessageBox.Show("Tarea agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        tareaCN.ValidarAntesDeEliminar(tareaid);
                        if (tareaCN.Editar(tarea))
                        {
                            LimpiarDatos();
                            MostrarTareas();
                            MessageBox.Show("Tarea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ocurrió un error al guardar los datos de la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTarea.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtCodigo.Text = DGVTarea.CurrentRow.Cells["codigo"].Value.ToString();
                    TxtDescripcion.Text = DGVTarea.CurrentRow.Cells["descripcion"].Value.ToString();
                    DTPFechaInicio.Value = Convert.ToDateTime(DGVTarea.CurrentRow.Cells["fecha_inicio"].Value);
                    DTPFechaFin.Value = Convert.ToDateTime(DGVTarea.CurrentRow.Cells["fecha_fin"].Value);
                    TxtEstado.Text = DGVTarea.CurrentRow.Cells["estado"].Value.ToString();
                    tareaid = int.Parse(DGVTarea.CurrentRow.Cells["id_tarea"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ocurrió un error al intentar editar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVTarea.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar esta tarea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int tareaid = int.Parse(DGVTarea.CurrentRow.Cells["id_tarea"].Value.ToString());
                        tareaCN.ValidarAntesDeEliminar(tareaid);
                        if (tareaCN.Eliminar(tareaid))
                        {
                            LimpiarDatos();
                            MostrarTareas();
                            MessageBox.Show("Tarea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("La tarea no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ocurrió un error al eliminar la tarea.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (DGVTarea.SelectedRows.Count > 0)
            {
                DGVTarea.ClearSelection();
            }
            else
            {
                LimpiarDatos();
            }
        }

        private bool ValidarInputs()
        {
            if (string.IsNullOrWhiteSpace(TxtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TxtEstado.Text))
            {
                MessageBox.Show("Todos los campos marcados con * son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LogError(Exception ex)
        {
            // Log the exception (e.g., write to a log file or database)
            Console.WriteLine(ex.ToString());
        }
    }
}
