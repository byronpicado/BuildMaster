
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

    public partial class FrmRecurso : Form
    {
        // Variables
        private RecursoCN recursoCN;
        private Recurso recurso;
        private bool editar = false;
        private int recursoid;
        public FrmRecurso()
        {
            InitializeComponent();
        }

        private void FrmRecurso_Load(object sender, EventArgs e)
        {
            MostrarRecurso();
        }
        // Obtener el proyecto desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarRecurso()
        {
            recursoCN = new RecursoCN();
            DGVRecurso.DataSource = recursoCN.ObtenerRecurso();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdRecurso.Text = "";
            TxtTipo.Text = "";
            TxtDescripcion.Text = "";
            TxtCosto.Text = "";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
         
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVRecurso.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdRecurso.Text = DGVRecurso.CurrentRow.Cells["id_recurso"].Value.ToString();
                    TxtTipo.Text = DGVRecurso.CurrentRow.Cells["tipo"].Value.ToString();
                    TxtDescripcion.Text = DGVRecurso.CurrentRow.Cells["descripcion"].Value.ToString();
                    TxtCosto.Text = DGVRecurso.CurrentRow.Cells["costo"].Value.ToString();


                    recursoid = int.Parse(DGVRecurso.CurrentRow.Cells["id_cliente"].Value.ToString());

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
                if (DGVRecurso.SelectedRows.Count > 0)
                {
                    int recursoid = int.Parse(DGVRecurso.CurrentRow.Cells["id_recurso"].Value.ToString());
                    // clienteCN.ValidarAntesDeEliminar(clienteid);

                    // Llamada al método Eliminar en ClienteCN
                    if (recursoCN.Eliminar(recursoid))
                    {
                        LimpiarDatos();
                        MostrarRecurso();
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