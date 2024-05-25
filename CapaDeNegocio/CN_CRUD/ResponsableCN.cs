using CapaDeDatos.CRUD;
using Entidades;
using System.Data;

namespace CapaDeNegocio.CN_CRUD
{
    public class ResponsableCN
    {
        private ResponsableCD responsableCD = new ResponsableCD();

        public DataTable ObtenerResponsable()
        {
            return responsableCD.ObtenerResponsable();
        }

        public bool Insertar(Responsable responsable)
        {
            return responsableCD.Insertar(responsable);
        }

        public bool Editar(Responsable responsable)
        {
            return responsableCD.Editar(responsable);
        }

        public bool Eliminar(int responsableId)
        {
            return responsableCD.Eliminar(responsableId);
        }
    }
}
