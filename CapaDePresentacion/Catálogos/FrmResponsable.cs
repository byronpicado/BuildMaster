using System;
using System.Windows.Forms;
using CapaDeDatos.CRUD;
using CapaDeNegocio.CN_CRUD;
using Entidades;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmResponsable : Form
    {
        // Variables
        private ResponsableCN _responsableCN;
        private Responsable _responsable;
        private bool _editar = false;

        public FrmResponsable()
        {
            InitializeComponent();
        }

        private void FrmResponsable_Load(object sender, EventArgs e)
        {
            MostrarResponsables();
        }

        // Obtener los responsables desde la Capa de Negocio y enviar al DataGridView
        private void MostrarResponsables()
        {
            _responsableCN = new ResponsableCN();
            DGVResponsable.DataSource = _responsableCN.ObtenerResponsable();
            //DGVCliente.Columns["id"].Visible = false;
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdResponsable.Clear();
            TxtNombre1.Clear();
            TxtNombre2.Clear();
            TxtApellidoPaterno.Clear();
            TxtApellidoMaterno.Clear();
            TxtCargo.Clear();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TxtIdResponsable.Text) ||
                    string.IsNullOrWhiteSpace(TxtNombre1.Text) ||
                    string.IsNullOrWhiteSpace(TxtApellidoPaterno.Text) ||
                    string.IsNullOrWhiteSpace(TxtApellidoMaterno.Text) ||
                    string.IsNullOrWhiteSpace(TxtCargo.Text))
                {
                    MessageBox.Show("Todos los campos deben ser llenados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _responsable = new Responsable(TxtIdResponsable.Text, TxtNombre1.Text, TxtNombre2.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, TxtCargo.Text);

                if (_editar)
                {
                    EditarResponsable();
                }
                else
                {
                    InsertarResponsable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertarResponsable()
        {
            try
            {
                if (_responsableCN.Insertar(_responsable))
                {
                    LimpiarDatos();
                    MostrarResponsables();
                    MessageBox.Show("El registro se insertó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditarResponsable()
        {
            try
            {
                _editar = false;
                if (_responsableCN.Editar(_responsable))
                {
                    LimpiarDatos();
                    MostrarResponsables();
                    MessageBox.Show("El registro se editó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DGVResponsable.SelectedRows.Count > 0)
            {
                _editar = true;
                CargarDatosParaEditar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarDatosParaEditar()
        {
            try
            {
                TxtIdResponsable.Text = DGVResponsable.CurrentRow.Cells["id_responsable"].Value.ToString();
                TxtNombre1.Text = DGVResponsable.CurrentRow.Cells["Nombre1"].Value.ToString();
                TxtNombre2.Text = DGVResponsable.CurrentRow.Cells["Nombre2"].Value.ToString();
                TxtApellidoPaterno.Text = DGVResponsable.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
                TxtApellidoMaterno.Text = DGVResponsable.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
                TxtCargo.Text = DGVResponsable.CurrentRow.Cells["cargo"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGVResponsable.SelectedRows.Count > 0)
            {
                EliminarResponsable();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarResponsable()
        {
            try
            {
                int responsableId = int.Parse(DGVResponsable.CurrentRow.Cells["id_responsable"].Value.ToString());
                if (_responsableCN.Eliminar(responsableId))
                {
                    LimpiarDatos();
                    MostrarResponsables();
                    MessageBox.Show("El registro se eliminó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El registro no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
