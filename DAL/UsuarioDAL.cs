using DAL;
using AgendaContactos.EL;
using System;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
  public class UsuarioDAL
  {
    // 1. Creamos la "llave" para entrar a la base de datos
    // Esto arregla el error de "referencia de objeto para el campo no estático"
    Conexion conector = new Conexion();

    public bool Login(Usuario u)
    {
      // 2. Usamos 'conector' (el objeto) en lugar de 'Conexion' (la clase)
      using (SqlConnection con = conector.ObtenerConexion())
      {
        con.Open();
        string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          // Asegúrate de que los nombres de las propiedades coincidan con tu clase Usuario
          cmd.Parameters.AddWithValue("@u", u.Username ?? string.Empty);
          cmd.Parameters.AddWithValue("@p", u.Password ?? string.Empty);

          int count = Convert.ToInt32(cmd.ExecuteScalar());
          return count > 0;
        }
      }
    }

    public void AsegurarUsuarioPorDefecto()
    {
      // 3. También cambiamos aquí para que no de error
      using (SqlConnection con = conector.ObtenerConexion())
      {
        con.Open();
        string sql = "IF NOT EXISTS (SELECT * FROM Usuarios WHERE Username='admin') " +
                     "INSERT INTO Usuarios (Username, Password) VALUES ('admin', 'admin123')";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.ExecuteNonQuery();
        }
      }
    }
  }
}
