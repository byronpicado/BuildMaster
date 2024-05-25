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
            try
            {
                // Si es nuevo
                if (!editar)
                {
                    decimal costo;
                    if (decimal.TryParse(TxtCosto.Text, out costo))
                    {
                        // El valor de TxtCosto se pudo convertir correctamente a decimal
                        recurso = new Recurso(TxtIdRecurso.Text, TxtTipo.Text, TxtDescripcion.Text, costo);

                        // Intentamos insertar el recurso
                        if (recursoCN.Insertar(recurso))
                        {
                            LimpiarDatos();
                            MostrarRecurso();
                            MessageBox.Show("El registro se insertó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // El valor de TxtCosto no es un número decimal válido
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para el costo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    decimal costo;
                    if (decimal.TryParse(TxtCosto.Text, out costo))
                    {
                        // El valor de TxtCosto se pudo convertir correctamente a decimal
                        recurso = new Recurso(TxtIdRecurso.Text, TxtTipo.Text, TxtDescripcion.Text, costo);

                        // Intentamos editar el recurso
                        if (recursoCN.Editar(recurso))
                        {
                            LimpiarDatos();
                            MostrarRecurso();
                            MessageBox.Show("El registro se editó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // El valor de TxtCosto no es un número decimal válido
                        MessageBox.Show("Por favor, ingrese un valor numérico válido para el costo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el recurso: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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