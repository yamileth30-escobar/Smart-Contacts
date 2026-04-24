using System;
using System.Data.SqlClient;

namespace DAL
{
  internal class Conexion
  {
    // Esta es la llave que abre tu base de datos
    // Usamos .\SQL como me dijiste
    private string cadena = @"Data Source=.\SQL;Initial Catalog=AgendaContactos;Integrated Security=True";

    public Conexion(string cadena)
    {
      this.cadena = cadena;
    }

    public Conexion()
    {
    }

    // Este es el método que tus compañeros dejaron vacío
     SqlConnection ObtenerConexion()
    {
      // Aquí devolvemos la conexión real hacia tu servidor
      return new SqlConnection(cadena);
    }
  }
}
