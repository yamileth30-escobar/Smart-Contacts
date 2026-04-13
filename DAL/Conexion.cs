using System.Configuration;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{

    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadenaConexion = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;
            return new SqlConnection(cadenaConexion);
        }
    }
}