using AgendaContactos.EL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace AgendaContactos.DAL
{
  public class UsuarioDAL
  {
    // CREATE
    public int InsertarUsuario(Usuario u)
    {
      int resultado = 0; // 1. Declaras la variable
      using (SqlConnection con = Conexion())
      {
        con.Open();
        string sql = "INSERT INTO Usuarios (Username, Password) VALUES (@u, @p)";

        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);
          resultado = cmd.ExecuteNonQuery(); // 2. Guardas las filas afectadas
        }
      }
      return resultado; // 3. Retornas el valor
    }

    private SqlConnection Conexion()
    {
      throw new NotImplementedException();
    }

    // READ
    public List<Usuario> ObtenerTodos()
    {
      List<Usuario> lista = new List<Usuario>();

      using (SqlConnection con = Conexion())
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

    // UPDATE
    public void Actualizar(Usuario u)
    {
      using (SqlConnection con = Conexion())
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

    // DELETE
    public void Eliminar(int id)
    {
      using (SqlConnection con = Conexion())
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
