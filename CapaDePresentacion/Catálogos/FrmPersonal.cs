using CapaDeNegocio.CN_CRUD;
using Entidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmPersonal : Form
    {
        // Variables
        private PersonalCN personalCN;
        private Personal personal;
        private bool editar = false;
        private int personalid;

        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            MostrarPersonal();
        }

        // Obtener el personal desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarPersonal()
        {
            personalCN = new PersonalCN();
            DGVPersonal.DataSource = personalCN.ObtenerPersonal();
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdPersonal.Text = "";
            TxtNombre1.Text = "";
            TxtNombre2.Text = "";
            TxtApellidoPaterno.Text = "";
            TxtApellidoMaterno.Text = "";
            TxtCargo.Text = "";
            DTPFechaContratacion.Value = DateTime.Now; // Resetea al valor actual
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la fecha del DateTimePicker
                DateTime fechaContratacion = DTPFechaContratacion.Value;


                // Si es nuevo
                if (editar == false)
                {
                    personal = new Personal(TxtIdPersonal.Text, TxtNombre1.Text, TxtNombre2.Text, TxtApellidoPaterno.Text, TxtApellidoMaterno.Text, TxtCargo.Text, fechaContratacion);

                    if (personalCN.Insertar(personal))
                    {
                        LimpiarDatos();
                        MostrarPersonal();
                    }
                    else
                    {
                        MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // Es uno existente
                {
                    editar = false;
                    personal = new Personal(TxtIdPersonal.Text,TxtNombre1.Text,TxtNombre2.Text, TxtApellidoPaterno.Text,TxtApellidoMaterno.Text,TxtCargo.Text,fechaContratacion);

                    if (personalCN.Editar(personal))
                    {
                        LimpiarDatos();
                        MostrarPersonal();
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

                if (DGVPersonal.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtIdPersonal.Text = DGVPersonal.CurrentRow.Cells["id_personal"].Value.ToString();
                    TxtNombre1.Text = DGVPersonal.CurrentRow.Cells["nombre1"].Value.ToString();
                    TxtNombre2.Text = DGVPersonal.CurrentRow.Cells["nombre2"].Value.ToString();
                    TxtApellidoPaterno.Text = DGVPersonal.CurrentRow.Cells["apellidoPaterno"].Value.ToString();
                    TxtApellidoMaterno.Text = DGVPersonal.CurrentRow.Cells["apellidoMaterno"].Value.ToString();
                    TxtCargo.Text = DGVPersonal.CurrentRow.Cells["cargo"].Value.ToString();
                    DTPFechaContratacion.Text = DGVPersonal.CurrentRow.Cells["fecha_contratacion"].Value.ToString();


                    personalid = int.Parse(DGVPersonal.CurrentRow.Cells["id_personal"].Value.ToString());

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
                if (DGVPersonal.SelectedRows.Count > 0)
                {
                    int personalid = int.Parse(DGVPersonal.CurrentRow.Cells["id_personal"].Value.ToString());

                    if (personalCN.Eliminar(personalid))
                    {
                        LimpiarDatos();
                        MostrarPersonal();
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


