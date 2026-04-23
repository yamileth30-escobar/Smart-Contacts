using System;
using System.Data.SqlClient;

namespace DAL
{
  internal class Conexion
  {
    // 1. Aquí guardamos la ruta a tu SQL Server
    
    string cadenaConexion = @"Data Source=.\SQL;Initial Catalog=AgendaContactos;Integrated Security=True";

    public Conexion()
    {
    }

    internal SqlConnection ObtenerConexion()
    {
      // 2. Quitamos el error y devolvemos la conexión real
      return new SqlConnection(cadenaConexion);
    }
  }
}
