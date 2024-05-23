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
        // Obtener las clientes desde la Capa de Negocio y la vamos a enviar al DGV
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
            TxtFechaAdquisicion.Text = "";

        }
    }
}
