using System;
using System.Data;
using System.Windows.Forms;
using CapaDeDatos.CRUD;
using CapaDeNegocio.CN_CRUD;
using Entidades;
using Entidades.Entidades;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmCliente : Form
    {
        // Variables
        private ClienteCN clienteCN;
        private Cliente cliente;
        private bool editar = false;
        private int clienteid;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

            MostrarClientes();
        }

        // Obtener las clientes desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarClientes()
        {
            clienteCN = new ClienteCN();
            DGVCliente.DataSource = clienteCN.ObtenerCliente();
            //  DGVCliente.Columns["id_cliente"].Visible = false;
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdCliente.Text = "";
            TxtNombre1.Text = "";
            TxtNombre2.Text = "";
            TxtApellidoPaterno.Text = "";
            TxtApellidoMaterno.Text = "";
            TxtTelefono.Text = "";
            TxtCorreo.Text = "";
            TxtIdCliente.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si es nuevo
                if (editar == false)
                {
                    cliente = new Cliente(TxtIdCliente.Text, TxtNombre1.Text, TxtNombre2.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, TxtTelefono.Text, TxtCorreo.Text);

                    // clienteCN.ValidarAntesDeCrear(cliente);

                    if (clienteCN.Insertar(cliente))
                    {
                        LimpiarDatos();
                        MostrarClientes();
                    }
                    else
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else // Es uno existente
                {
                    editar = false;
                    cliente = new Cliente(TxtIdCliente.Text, TxtNombre1.Text, TxtNombre2.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, TxtTelefono.Text, TxtCorreo.Text);

                    // clienteCN.ValidarAntesDeEditar(cliente);

                    if (clienteCN.Editar(cliente))
                    {
                        LimpiarDatos();
                        MostrarClientes();
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
                if (DGVCliente.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdCliente.Text = DGVCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                    TxtNombre1.Text = DGVCliente.CurrentRow.Cells["Nombre1"].Value.ToString();
                    TxtNombre2.Text = DGVCliente.CurrentRow.Cells["Nombre2"].Value.ToString();
                    TxtApellidoPaterno.Text = DGVCliente.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
                    TxtApellidoMaterno.Text = DGVCliente.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
                    TxtTelefono.Text = DGVCliente.CurrentRow.Cells["telefono"].Value.ToString();
                    TxtCorreo.Text = DGVCliente.CurrentRow.Cells["correo"].Value.ToString();

                    clienteid = int.Parse(DGVCliente.CurrentRow.Cells["id_cliente"].Value.ToString());

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
                if (DGVCliente.SelectedRows.Count > 0)
                {
                    int clienteid = int.Parse(DGVCliente.CurrentRow.Cells["id_cliente"].Value.ToString());
                   // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (clienteCN.Eliminar(clienteid))
                    {
                        LimpiarDatos();
                        MostrarClientes();
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