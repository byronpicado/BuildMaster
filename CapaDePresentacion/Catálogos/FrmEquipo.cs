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
    public partial class FrmEquipo : Form
    {
        // Variables
        private EquipoCN equipoCN;
        private Equipo equipo;
        private bool editar = false;
        private int equipoid;
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            MostrarEquipos();

        }
        // Obtener los equipos desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarEquipos()
        {
            equipoCN = new EquipoCN();
            DGVEquipo.DataSource = equipoCN.ObetenerEquipo();
         
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdEquipo.Text = "";
            TxtTipo.Text = "";
            TxtMarca.Text = "";
            DTPFecha_Adquisicion.Text = "";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha del DateTimePicker
                DateTime fechaAdquisicion = DTPFecha_Adquisicion.Value;

                // Si es nuevo
                if (editar == false)
                {
                    equipo = new Equipo(TxtIdEquipo.Text, TxtTipo.Text, TxtMarca.Text, fechaAdquisicion);

                    if (equipoCN.Insertar(equipo))
                    {
                        LimpiarDatos();
                        MostrarEquipos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    equipo = new Equipo(TxtIdEquipo.Text, TxtTipo.Text, TxtMarca.Text, fechaAdquisicion);

                    if (equipoCN.Editar(equipo))
                    {
                        LimpiarDatos();
                        MostrarEquipos();
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

                if (DGVEquipo.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdEquipo.Text = DGVEquipo.CurrentRow.Cells["id_equipo"].Value.ToString();
                    TxtTipo.Text = DGVEquipo.CurrentRow.Cells["tipo"].Value.ToString();
                    TxtMarca.Text = DGVEquipo.CurrentRow.Cells["marca"].Value.ToString();
                    DTPFecha_Adquisicion.Text = DGVEquipo.CurrentRow.Cells["fecha_adquisicion"].Value.ToString();
                 

                    equipoid = int.Parse(DGVEquipo.CurrentRow.Cells["id_equipo"].Value.ToString());

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
                if (DGVEquipo.SelectedRows.Count > 0)
                {
                    int clienteid = int.Parse(DGVEquipo.CurrentRow.Cells["id_equipo"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (equipoCN.Eliminar(clienteid))
                    {
                        LimpiarDatos();
                        MostrarEquipos();
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
 