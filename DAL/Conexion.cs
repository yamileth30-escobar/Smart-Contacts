using System;
using System.Data.SqlClient;

namespace DAL
{
  public class Conexion
  {
    // Usamos el nombre de la instancia que acabas de iniciar en el CMD
    // Prueba con esta cadena que es más "fuerte" para LocalDB
    private static string cadena = @"Server=(localdb)\MSSQLLocalDB;Database=AgendaContactos;Trusted_Connection=True;Connect Timeout=30;";

    public Conexion()
    {
    }

    // Método estático corregido
    public static SqlConnection ObtenerConexion()
    {
      return new SqlConnection(cadena);
    }
  }
}
