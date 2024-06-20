using CapaDeDatos;
using CapaDeNegocio.CN_CRUD;
using Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDePresentacion.Catálogos
{
    public partial class FrmProyecto : Form
    {
        // Variables
        private ProyectoCN proyectoCN;
        private Proyecto proyecto;
        private bool editar = false;
        private int proyectoid;
        private ConexionCD conexionCD;
        private SqlDataReader LectorDatos;

        public FrmProyecto()
        {
            InitializeComponent();
            proyectoCN = new ProyectoCN();
            conexionCD = new ConexionCD();
        }

        private void FrmProyecto_Load(object sender, EventArgs e)
        {
            MostrarProyecto();
        }

        // Obtener el proyecto desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarProyecto()
        {
            try
            {
                proyectoCN = new ProyectoCN();
                DGVProyecto.DataSource = proyectoCN.ObtenerProyecto();
                DGVProyecto.Columns["id_proyecto"].Visible = false;
                DGVProyecto.Columns["id_cliente"].Visible = false;
                DGVProyecto.Columns["id_responsable"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al mostrar los proyectos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtBuscar.Clear();  
            TxtCodigo.Clear();
            
            TxtDescripcion.Clear();
            TxtEstado.Clear();
            DTPFechaInicio.Value = DateTime.Now;
            DTPFechaFin.Value = DateTime.Now;
            TxtCodigo.Focus();
            editar = false;
            proyectoid = 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarInputs())
                {
                    proyecto = new Proyecto(proyectoid,TxtCodigo.Text,0,0, TxtDescripcion.Text, DTPFechaInicio.Value, DTPFechaFin.Value, TxtEstado.Text);

                    if (!editar)
                    {
                        proyectoCN.ValidarAntesDeCrear(proyecto);
                        if (proyectoCN.Insertar(proyecto))
                        {
                            LimpiarDatos();
                            MostrarProyecto();
                            MessageBox.Show("Proyecto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se insertó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        proyectoCN.ValidarAntesDeEditar(proyecto);
                        if (proyectoCN.Editar(proyecto))
                        {
                            LimpiarDatos();
                            MostrarProyecto();
                            MessageBox.Show("Proyecto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se editó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar los datos del proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVProyecto.SelectedRows.Count > 0)
                {
                    editar = true;
                    TxtCodigo.Text = DGVProyecto.CurrentRow.Cells["codigo"].Value.ToString();
           
                    TxtDescripcion.Text = DGVProyecto.CurrentRow.Cells["descripcion"].Value.ToString();
                    DTPFechaInicio.Value = Convert.ToDateTime(DGVProyecto.CurrentRow.Cells["fecha_inicio"].Value);
                    DTPFechaFin.Value = Convert.ToDateTime(DGVProyecto.CurrentRow.Cells["fecha_fin"].Value);
                    TxtEstado.Text = DGVProyecto.CurrentRow.Cells["estado"].Value.ToString();
                    proyectoid = int.Parse(DGVProyecto.CurrentRow.Cells["id_proyecto"].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar editar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DGVProyecto.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Está seguro que desea eliminar este proyecto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int proyectoid = int.Parse(DGVProyecto.CurrentRow.Cells["id_proyecto"].Value.ToString());
                        proyectoCN.ValidarAntesDeEliminar(proyectoid);
                        if (proyectoCN.Eliminar(proyectoid))
                        {
                            LimpiarDatos();
                            MostrarProyecto();
                            MessageBox.Show("Proyecto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El registro no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            llenar_grid();
            LimpiarDatos();
        }

        private bool ValidarInputs()
        {
            if (string.IsNullOrWhiteSpace(TxtCodigo.Text) ||
                string.IsNullOrWhiteSpace(TxtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(TxtEstado.Text))
            {
                MessageBox.Show("Todos los campos marcados con * son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (DTPFechaInicio.Value > DTPFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void iconButtonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión a la base de datos
                SqlConnection conexion = conexionCD.AbrirConexion();

                // Construir la consulta SQL con parámetros
                string consulta = "SELECT * FROM Proyecto WHERE codigo = @codigo";

                // Crear y configurar el comando SQL
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@codigo", TxtBuscar.Text);

                // Crear el adaptador y llenar el DataTable
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                // Asignar el DataTable al DataGridView
                DGVProyecto.DataSource = dt;

                // Cerrar la conexión
                conexionCD.CerrarConexion();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocurrió un error al buscar los datos del equipo." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            llenar_grid();
            LimpiarDatos();
        }
        private void llenar_grid()
        {
            // Abrir la conexión a la base de datos
            SqlConnection conexion = conexionCD.AbrirConexion();
            string consulta = "SELECT * FROM Proyecto";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGVProyecto.DataSource = dt;
        }

        private void panelProyecto_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
