using AgendaContactos.EL;
using DAL;
using System;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
  public class UsuarioDALBase
  {
    // Método para crear el usuario por defecto si no existe
    public void AsegurarUsuarioPorDefecto()
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();

        string checkSql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u";
        int existe = 0;

        using (SqlCommand cmdCheck = new SqlCommand(checkSql, con))
        {
          cmdCheck.Parameters.AddWithValue("@u", "yamileth");
          existe = Convert.ToInt32(cmdCheck.ExecuteScalar());
        }

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

    // Método para validar el Login
    public bool Login(Usuario u)
    {
      // Usamos directamente la clase Conexion que ya tenés en tu proyecto
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          // Usamos ?? "" para evitar errores si el usuario manda datos vacíos
          cmd.Parameters.AddWithValue("@u", u.Username ?? "");
          cmd.Parameters.AddWithValue("@p", u.Password ?? "");

          int count = Convert.ToInt32(cmd.ExecuteScalar());

          // Si count > 0 devuelve true, si no, devuelve false
          return count > 0;
        }
      }
    }
  }
}
