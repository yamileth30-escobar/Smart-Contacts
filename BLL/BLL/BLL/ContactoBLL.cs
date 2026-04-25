using AgendaContactos.DAL;
using AgendaContactos.EL;
using System.Data;

namespace AgendaContactos.BLL
{
    public class ContactoBLL
    {
        private readonly ContactoDAL dal = new ContactoDAL();
        public void Guardar(ContactoEL c) => dal.Insertar(c);
        public DataTable Listar() => dal.Listar();
        public void Editar(ContactoEL c) => dal.Actualizar(c);
        public void Eliminar(int id) => dal.Eliminar(id);
    }
}