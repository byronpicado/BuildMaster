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
    public partial class FrmProgreso : Form
    {
        // Variables
        private ProgresoCN progresoCN;
        private Progreso progreso;
        private bool editar = false;
        private int progresoid;
        public FrmProgreso()
        {
            InitializeComponent();
        }
        private void TxtIdProgreso_TextChanged(object sender, EventArgs e)
        {
           
        }
        // Obtener el progreso desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarProgreso()
        {
            progresoCN = new ProgresoCN();
            DGVProgreso.DataSource = progresoCN.ObtenerProgreso();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdProgreso.Text = "";
            TxtDescripcion.Text = "";
            DTPFechaRegistro.Value = DateTime.Now; // Resetea al valor actual
        }

        private void FrmProgreso_Load(object sender, EventArgs e)
        {
            MostrarProgreso();
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
                    progreso = new Progreso(TxtIdProgreso.Text, TxtDescripcion.Text, fechaRegistro);

                    if (progresoCN.Insertar(progreso))
                    {
                        LimpiarDatos();
                        MostrarProgreso();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    progreso = new Progreso(TxtIdProgreso.Text, TxtDescripcion.Text, fechaRegistro);

                    if (progresoCN.Editar(progreso))
                    {
                        LimpiarDatos();
                        MostrarProgreso();
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

                if (DGVProgreso.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdProgreso.Text = DGVProgreso.CurrentRow.Cells["id_progreso"].Value.ToString();
                    TxtDescripcion.Text = DGVProgreso.CurrentRow.Cells["descripcion"].Value.ToString();
                    DTPFechaRegistro.Text = DGVProgreso.CurrentRow.Cells["fecha_registro"].Value.ToString();
            


                    progresoid = int.Parse(DGVProgreso.CurrentRow.Cells["id_progreso"].Value.ToString());

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
                if (DGVProgreso.SelectedRows.Count > 0)
                {
                    int progresoid = int.Parse(DGVProgreso.CurrentRow.Cells["id_progreso"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (progresoCN.Eliminar(progresoid))
                    {
                        LimpiarDatos();
                        MostrarProgreso();
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

