using AgendaContactos.EL;
using DAL;
using System;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
  public class UsuarioDALBaseBase
  {

    // Se eliminó la variable "private readonly Conexion conexion" porque no es necesaria

    public bool Login(Usuario u)
    {
      // Cambiado a Conexion.ObtenerConexion() (Estático)
      using (SqlConnection con = Conexion.ObtenerConexion())
      {

        // 1. Creamos la "llave" para entrar a la base de datos
        // Esto arregla el error de "referencia de objeto para el campo no estático"
        Conexion conexion = new Conexion();
        Conexion conector = conexion;
      }
    public bool Login(Usuario u)
    {
      // 2. Usamos 'conector' (el objeto) en lugar de 'Conexion' (la clase)
      using (SqlConnection con = conector.ObtenerConexion())

      {
        con.Open();
        string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {

          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);

          // Asegúrate de que los nombres de las propiedades coincidan con tu clase Usuario
          cmd.Parameters.AddWithValue("@u", u.Username ?? string.Empty);
          cmd.Parameters.AddWithValue("@p", u.Password ?? string.Empty);


          int count = Convert.ToInt32(cmd.ExecuteScalar());
          return count > 0;
        }
      }
    }
  }
}