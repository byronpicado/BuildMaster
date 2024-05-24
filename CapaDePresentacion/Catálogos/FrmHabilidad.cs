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
    public partial class FrmHabilidad : Form
    {
        // Variables
        private HabilidadCN habilidadCN;
        private Habilidad habilidad;
        private bool editar = false;
        private int habilidadid;
        public FrmHabilidad()
        {
            InitializeComponent();
        }

    

        private void FrmHabilidad_Load(object sender, EventArgs e)
        {
            MostrarHabilidad();
        }
        // Obtener las clientes desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarHabilidad()
        {
            habilidadCN = new HabilidadCN();
            DGVCliente.DataSource = habilidadCN.ObtenerHabilidad();

        }

        //Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtId_habilidad.Text = "";
            TxtDescripcion.Text = "";
            TxtId_habilidad.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Si es nuevo
                if (editar == false)
                {

                    habilidad = new Habilidad(TxtId_habilidad.Text, TxtDescripcion.Text);

                  //  habilidadCN.ValidarAntesDeCrear(habilidad);

                    if (habilidadCN.Insertar(habilidad))
                    {
                        LimpiarDatos();
                        MostrarHabilidad();
                    }
                    else
                        MessageBox.Show("El registro no se inserto correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else //Es uno existente
                {
                    editar = false;
                    habilidad = new Habilidad(TxtId_habilidad.Text, TxtDescripcion.Text);

                    //categoriaCN.ValidarAntesDeEditar(categoria);

                    if (habilidadCN.Editar(habilidad))
                    {
                        LimpiarDatos();
                        MostrarHabilidad();
                    }
                    else
                        MessageBox.Show("El registro no se edito correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    TxtId_habilidad.Text = DGVCliente.CurrentRow.Cells["id_habilidad"].Value.ToString();
                    TxtDescripcion.Text = DGVCliente.CurrentRow.Cells["descripcion"].Value.ToString();
                    habilidadid = int.Parse(DGVCliente.CurrentRow.Cells["id_habilidad"].Value.ToString());

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
                        habilidadid = int.Parse(DGVCliente.CurrentRow.Cells["id_habilidad"].Value.ToString());

                       // habilidadCN.ValidarAntesDeEliminar(habilidadid);

                        if (habilidadCN.Eliminar(habilidadid))
                        {
                            LimpiarDatos();
                            MostrarHabilidad();
                        MessageBox.Show("El registro se eliminó correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        else
                            MessageBox.Show("El registro no se elimino correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }