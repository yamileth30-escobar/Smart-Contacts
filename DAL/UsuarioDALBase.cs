using AgendaContactos.EL;
using DAL;
using System;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
  public class UsuarioDALBase
  {

    public void AsegurarUsuarioPorDefecto()
    {

      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();

        // Verificamos si existe el usuario "yamileth"
        string checkSql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u";
        int existe = 0;

        using (SqlCommand cmdCheck = new SqlCommand(checkSql, con))
        {
          cmdCheck.Parameters.AddWithValue("@u", "yamileth");
          existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
        }

        // Si no existe, lo insertamos
        if (existe == 0)
        {
          string insertSql = "INSERT INTO Usuarios (Username, Password) VALUES (@u, @p)";
          using (SqlCommand cmdInsert = new SqlCommand(insertSql, con))
          {
            cmdInsert.Parameters.AddWithValue("@u", "yamileth");
            cmdInsert.Parameters.AddWithValue("@p", "Tokio25**");
            cmdInsert.ExecuteNonQuery();
          }
        }
      }
    }

    // Se eliminó la variable "private readonly Conexion conexion" porque no es necesaria

    public bool Login(Usuario u)
    {
      // Cambiado a Conexion.ObtenerConexion() (Estático)
      using (SqlConnection con = Conexion.ObtenerConexion())

        // 1. Creamos la "llave" para entrar a la base de datos
        // Esto arregla el error de "referencia de objeto para el campo no estático"
        Conexion conector = new Conexion();

    public bool Login(Usuario u)
    {
      // 2. Usamos 'conector' (el objeto) en lugar de 'Conexion' (la clase)
      using (SqlConnection con = conector.ObtenerConexion())
>>>>>>> 4657f19576bb05a053bc88068d6f5614ddb20795
      {
        con.Open();
        string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
<<<<<<< HEAD
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);
=======
          // Asegúrate de que los nombres de las propiedades coincidan con tu clase Usuario
          cmd.Parameters.AddWithValue("@u", u.Username ?? string.Empty);
          cmd.Parameters.AddWithValue("@p", u.Password ?? string.Empty);
>>>>>>> 4657f19576bb05a053bc88068d6f5614ddb20795

          int count = Convert.ToInt32(cmd.ExecuteScalar());
          return count > 0;
        }
      }
    }
  }
}