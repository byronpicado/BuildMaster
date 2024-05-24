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
    public partial class FrmProyectoDetalle : Form
    {

        // Variables
        private ProyectoDetalleCN proyectoDetalleCN;
        private ProyectoDetalle proyectoDetalle;
        private bool editar = false;
        private int proyectoDetalleid;
        public FrmProyectoDetalle()
        {
            InitializeComponent();
        }

        private void FrmProyectoDetalle_Load(object sender, EventArgs e)
        {
            MostrarProyectoDetalle();
        }
        // Obtener el proyecto desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarProyectoDetalle()
        {
            proyectoDetalleCN = new ProyectoDetalleCN();
            DGVProyectoDetalle.DataSource = proyectoDetalleCN.ObtenerProyectoDetalle();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdProyectoDetalle.Text = "";
            TxtDescripcion.Text = "";
            TxtDescripcion.Text = "";    
            DTPFechaRegistro.Text = ""; // Resetea al valor actual
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha del DateTimePicker
                DateTime fechaRegistro = DTPFechaRegistro.Value;
            

                // Si es nuevo
                if (editar == false)
                {
                    proyectoDetalle = new ProyectoDetalle(TxtIdProyectoDetalle.Text, TxtDescripcion.Text, fechaRegistro);

                    if (proyectoDetalleCN.Insertar(proyectoDetalle))
                    {
                        LimpiarDatos();
                        MostrarProyectoDetalle();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    proyectoDetalle = new ProyectoDetalle(TxtIdProyectoDetalle.Text, TxtDescripcion.Text, fechaRegistro);

                    if (proyectoDetalleCN.Editar(proyectoDetalle))
                    {
                        LimpiarDatos();
                        MostrarProyectoDetalle();
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

                if (DGVProyectoDetalle.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdProyectoDetalle.Text = DGVProyectoDetalle.CurrentRow.Cells["id_proyectoDetalle"].Value.ToString();
                    TxtDescripcion.Text = DGVProyectoDetalle.CurrentRow.Cells["descripcion"].Value.ToString();
                    DTPFechaRegistro.Text = DGVProyectoDetalle.CurrentRow.Cells["fecha_registro"].Value.ToString();
                 



                    proyectoDetalleid = int.Parse(DGVProyectoDetalle.CurrentRow.Cells["id_proyectoDetalle"].Value.ToString());

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
                if (DGVProyectoDetalle.SelectedRows.Count > 0)
                {
                    int proyectoDetalleid = int.Parse(DGVProyectoDetalle.CurrentRow.Cells["id_proyectoDetalle"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (proyectoDetalleCN.Eliminar(proyectoDetalleid))
                    {
                        LimpiarDatos();
                        MostrarProyectoDetalle();
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