﻿
using CapaDeNegocio.CN_CRUD;
using Entidades;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            mantenimientoCN = new MantenimientoCN();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            MostrarMantenimiento();
        }
        // Obtener las clientes desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarMantenimiento()
        {
            try
            {
                mantenimientoCN = new MantenimientoCN();
                DGVMantenimiento.DataSource = mantenimientoCN.ObtenerMantenimiento();
                DGVMantenimiento.Columns["id_mantenimiento"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtCodigo.Clear();
            TxtDescripcion.Clear();
            DTPFechaMantenimiento.Value = DateTime.Now;
            TxtCodigo.Focus();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInputs())
                {
                    mantenimiento = new Mantenimiento(mantenimientoid, TxtCodigo.Text, DTPFechaMantenimiento.Value, TxtDescripcion.Text);
                    if (!editar)
                    {
                        mantenimientoCN.ValidarAntesDeCrear(mantenimiento);
                        if (mantenimientoCN.Insertar(mantenimiento))
                        {
                            LimpiarDatos();
                            MostrarMantenimiento();
                            MessageBox.Show("Mantenimiento agregado correctamente", "´Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("el registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        mantenimientoCN.ValidarAntesDeEditar(mantenimiento);
                        if (mantenimientoCN.Editar(mantenimiento))
                        {
                            LimpiarDatos();
                            MostrarMantenimiento();
                            MessageBox.Show("Mantenimiento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

                catch(Exception ex ) 
                {
                    LogError(ex);
                    MessageBox.Show("Ocurrió un error al guardar los datos del mantenimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (DGVMantenimiento.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtCodigo.Text = DGVMantenimiento.CurrentRow.Cells["codigo"].Value.ToString();
                    DTPFechaMantenimiento.Text = DGVMantenimiento.CurrentRow.Cells["fecha_mantenimiento"].Value.ToString();
                    TxtDescripcion.Text = DGVMantenimiento.CurrentRow.Cells["descripcion"].Value.ToString();
                    mantenimientoid = int.Parse(DGVMantenimiento.CurrentRow.Cells["id_mantenimiento"].Value.ToString());

                }
                else
                    MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                LogError(ex);
                MessageBox.Show("Ocurrió un error al intentar editar el mantenimiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVMantenimiento.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este mantenimiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int mantenimientoid = int.Parse(DGVMantenimiento.CurrentRow.Cells["id_mantenimiento"].Value.ToString());
                        mantenimientoCN.ValidarAntesDeEliminar(mantenimientoid);
                        if (mantenimientoCN.Eliminar(mantenimientoid))
                        {
                            LimpiarDatos();
                            MostrarMantenimiento();
                            MessageBox.Show("Mantenimiento eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El mantenimiento no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            if (DGVMantenimiento.SelectedRows.Count > 0)
            {
                DGVMantenimiento.ClearSelection();
            }
            else
            {
                LimpiarDatos();
            }
        }
        private bool ValidarInputs()
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos marcados con * son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    
        
        private void LogError(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}
