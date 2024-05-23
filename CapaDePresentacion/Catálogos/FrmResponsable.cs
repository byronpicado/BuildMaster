using System;
using System.Windows.Forms;
using CapaDeDatos.CRUD;
using CapaDeNegocio.CN_CRUD;
using Entidades;


namespace CapaDePresentacion.Catálogos
{
    public partial class FrmResponsable : Form
    {
        // Variables
        private ResponsableCN responsableCN;
        private Responsable responsable;
        private bool editar = false;
        private int responsableid;
        public FrmResponsable()
        {
            InitializeComponent();
        }

        private void FrmResponsable_Load(object sender, EventArgs e)
        {
            MostrarClientes();

        }
        // Obtener los responsables desde la Capa de Negocio y la vamos a enviar al DGV
        private void MostrarClientes()
        {
            responsableCN = new ResponsableCN();
            DGVResponsable.DataSource = responsableCN.ObtenerResponsable();
            //DGVCliente.Columns["id"].Visible = false;
        }

        // Limpiar los controles de texto
        private void LimpiarDatos()
        {
            TxtIdResponsable.Text = "";
            TxtNombre1.Text = "";
            TxtNombre2.Text = "";
            TxtApellidoPaterno.Text = "";
            TxtApellidoMaterno.Text = "";
            TxtCargo.Text = "";

        }
    }
}
