using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AgendaContactos.EL;
using AgendaContactos.DAL;

namespace AgendaContactos.DAL
{
  public class UsuarioDAL
  {
    // Se eliminó la variable "private readonly Conexion conexion" porque no es necesaria

    public bool Login(Usuario u)
    {
      // Cambiado a Conexion.ObtenerConexion() (Estático)
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "SELECT COUNT(*) FROM Usuarios WHERE Username=@u AND Password=@p";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);

          int count = Convert.ToInt32(cmd.ExecuteScalar());
          return count > 0;
        }
      }
    }

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

    // Método para insertar un nuevo usuario CREATE
    public void InsertarUsuario(Usuario u)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "INSERT INTO Usuarios (Username, Password) VALUES (@u, @p)";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);
          cmd.ExecuteNonQuery();
        }
      }
    }


    // Método para obtener un usuario por su ID READ
    public List<Usuario> ObtenerTodos()
    {
      List<Usuario> lista = new List<Usuario>();

      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "SELECT * FROM Usuarios";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        using (SqlDataReader dr = cmd.ExecuteReader())
        {
          while (dr.Read())
          {
            Usuario u = new Usuario
            {
              IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
              Username = dr["Username"].ToString(),
              Password = dr["Password"].ToString()
            };

            lista.Add(u);
          }
        }
      }

      return lista;
    }

    // Método para actualizar un usuario existente UPDATE
    public void Actualizar(Usuario u)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "UPDATE Usuarios SET Username=@u, Password=@p WHERE IdUsuario=@id";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);
          cmd.Parameters.AddWithValue("@id", u.IdUsuario);
          cmd.ExecuteNonQuery();
        }
      }
    }

    // Método para eliminar un usuario por su ID DELETE
    public void Eliminar(int id)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        con.Open();
        string sql = "DELETE FROM Usuarios WHERE IdUsuario=@id";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@id", id);
          cmd.ExecuteNonQuery();
        }
      }
    }
  }
}
