using AgendaContactos.EL;
using AgendaContactos.DAL;
using System.Data;

namespace AgendaContactos.BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL dal = new UsuarioDAL();

        public bool Login(UsuarioEL u) => dal.Login(u);
        public void AsegurarUsuarioPorDefecto() => dal.AsegurarUsuarioPorDefecto();
    }
}
