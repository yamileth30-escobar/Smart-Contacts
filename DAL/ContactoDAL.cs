using DAL;
using AgendaContactos.EL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
  public class ContactoDAL
  {
    // 1. Creamos una instancia de la conexión para poder usarla en toda la clase
    // Esto arregla el error CS0120 (Se requiere referencia de objeto)
    Conexion conector = new Conexion();

    public DataTable Listar()
    {
      DataTable dt = new DataTable();
      // Usamos 'conector' en lugar de 'Conexion'
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        using (SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos ORDER BY Id DESC", con))
        {
          da.Fill(dt);
        }
      }
      return dt;
    }

    // 2. Especificamos que el Contacto viene de AgendaContactos.EL
    // Esto arregla el error CS0104 (Referencia ambigua)
    public void Insertar(AgendaContactos.EL.Contacto c)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        string sql = "INSERT INTO Contactos (Nombre, Telefono, Correo, Direccion) VALUES (@n, @t, @c, @d)";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
          cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
          cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
          cmd.Parameters.AddWithValue("@d", c.Direccion ?? string.Empty);

          con.Open();
          cmd.ExecuteNonQuery();
        }
      }
    }

    public void Actualizar(AgendaContactos.EL.Contacto c)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        string sql = "UPDATE Contactos SET Nombre=@n, Telefono=@t, Correo=@c, Direccion=@d WHERE Id=@id";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@id", c.Id);
          cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
          cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
          cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
          cmd.Parameters.AddWithValue("@d", c.Direccion ?? string.Empty);

          con.Open();
          cmd.ExecuteNonQuery();
        }
      }
    }

    public void Eliminar(int id)
    {
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        string sql = "DELETE FROM Contactos WHERE Id=@id";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
          cmd.Parameters.AddWithValue("@id", id);
          con.Open();
          cmd.ExecuteNonQuery();
        }
      }
    }

    public DataTable Buscar(string valor)
    {
      DataTable dt = new DataTable();
      using (SqlConnection con = Conexion.ObtenerConexion())
      {
        string sql = "SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos " +
                     "WHERE Nombre LIKE @b OR Telefono LIKE @b OR Correo LIKE @b OR Direccion LIKE @b " +
                     "ORDER BY Id DESC";
        using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
        {
          da.SelectCommand.Parameters.AddWithValue("@b", "%" + valor + "%");
          da.Fill(dt);
        }
      }
      return dt;
    }
  }
}
