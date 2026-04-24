using AgendaContactos.DAL;
using AgendaContactos.EL;

namespace AgendaContactos.BLL
{
  public class UsuarioBLL
  {
    // Cambiamos UsuarioDAL por UsuarioDALBase para que coincida con tu otro archivo
    UsuarioDALBase dal = new UsuarioDALBase();

    public bool Login(Usuario u)
    {
      return dal.Login(u);
    }
  }
}
