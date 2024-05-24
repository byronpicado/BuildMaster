using CapaDeDatos.CRUD;
using CapaDeNegocio.CN_CRUD;
using Entidades;
using Entidades.Entidades;
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
    public partial class FrmMantenimiento : Form
    {
        // Variables
        private MantenimientoCN mantenimientoCN;
        private Mantenimiento mantenimiento;
        private bool editar = false;
        private int mantenimientoid;
        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            MostrarMantenimiento();
        }
        // Obtener las clientes desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarMantenimiento()
        {
            mantenimientoCN = new MantenimientoCN();
            DGVMantenimiento.DataSource = mantenimientoCN.ObtenerMantenimiento();

        }

        //Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtId_habilidad.Text = "";
            TxtDescripcion.Text = "";
            DTPFechaMantenimiento.Text = "";
            TxtId_habilidad.Focus();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha del DateTimePicker
                DateTime fechaMantenimiento = DTPFechaMantenimiento.Value;

                // Si es nuevo
                if (editar == false)
                {
                    mantenimiento = new Mantenimiento(TxtId_habilidad.Text, fechaMantenimiento, TxtDescripcion.Text);

                    if (mantenimientoCN.Insertar(mantenimiento))
                    {
                        LimpiarDatos();
                        MostrarMantenimiento();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    mantenimiento = new Mantenimiento(TxtId_habilidad.Text,fechaMantenimiento, TxtDescripcion.Text);

                    if (mantenimientoCN.Editar(mantenimiento))
                    {
                        LimpiarDatos();
                        MostrarMantenimiento();
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

                if (DGVMantenimiento.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtId_habilidad.Text = DGVMantenimiento.CurrentRow.Cells["id_mantenimiento"].Value.ToString();
                    DTPFechaMantenimiento.Text = DGVMantenimiento.CurrentRow.Cells["fecha_mantenimiento"].Value.ToString();
                    TxtDescripcion.Text = DGVMantenimiento.CurrentRow.Cells["descripcion"].Value.ToString();
                    mantenimientoid = int.Parse(DGVMantenimiento.CurrentRow.Cells["id_mantenimiento"].Value.ToString());

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
                if (DGVMantenimiento.SelectedRows.Count > 0)
                {
                    int mantenimientoid = int.Parse(DGVMantenimiento.CurrentRow.Cells["id_mantenimiento"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (mantenimientoCN.Eliminar(mantenimientoid))
                    {
                        LimpiarDatos();
                        MostrarMantenimiento();
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

