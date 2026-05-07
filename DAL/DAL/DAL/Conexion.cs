using System;
using System.Data.SqlClient;

namespace DAL
{
  // Cambiamos 'internal' por 'public' para que todos puedan ver la clase
  public class Conexion
  {
    // Tu cadena de conexión hacia el servidor SQL
    private static string cadena = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AgendaContactos;Integrated Security=True";

    public Conexion()
    {
    }

    // AGREGAMOS 'public static': Esto es lo que quita los 10 errores de un solo
    public static SqlConnection ObtenerConexion()
    {
      return new SqlConnection(cadena);
    }
  }
}
