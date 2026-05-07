using System.Data;
using AgendaContactos.EL;
using AgendaContactos.DAL;

namespace AgendaContactos.BLL
{
    public class CategoriaBLL
    {
        private CategoriaDAL dal = new CategoriaDAL();

        public void Guardar(CategoriaEL entidad)
        {
            if (!string.IsNullOrEmpty(entidad.Nombre))
            {
                dal.Insertar(entidad);
            }
        }

        public DataTable Listar() => dal.Listar();
    }
}