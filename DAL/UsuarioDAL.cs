using AgendaContactos.EL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration; // Asegurate de tener esta referencia

namespace AgendaContactos.DAL
{
  public class UsuarioDAL
  {
    // Este método sustituye al que te daba error. 
    // Aquí ponés tu cadena de conexión de SQL Server
    public SqlConnection Conectar()
    {
      // Cambiá "TU_SERVIDOR" por el nombre de tu instancia de SQL (ej: DESKTOP-XXXX\SQLEXPRESS)
      string cadena = "Data Source=localhost;Initial Catalog=AgendaContactos;Integrated Security=True";
      return new SqlConnection(cadena);
    }

    // CREATE - Insertar un nuevo usuario
    public int InsertarUsuario(Usuario u)
    {
      int resultado = 0;
      using (SqlConnection con = Conectar())
      {
        con.Open();
        string sql = "INSERT INTO Usuarios (Username, Password) VALUES (@u, @p)";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@u", u.Username);
          cmd.Parameters.AddWithValue("@p", u.Password);
          resultado = cmd.ExecuteNonQuery();
        }
      }
      return resultado;
    }

    // READ - Obtener todos los usuarios
    public List<Usuario> ObtenerTodos()
    {
      List<Usuario> lista = new List<Usuario>();
      using (SqlConnection con = Conectar())
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
              // Ajustado a los nombres que tenés en tu EL
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

    // UPDATE - Actualizar usuario
    public void Actualizar(Usuario u)
    {
      using (SqlConnection con = Conectar())
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

    // DELETE - Eliminar usuario
    public void Eliminar(int id)
    {
      using (SqlConnection con = Conectar())
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
