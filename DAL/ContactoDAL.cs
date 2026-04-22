using AgendaContactos.EL; // Asegúrate que este sea el nombre correcto de tu capa de entidades
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContactos.DAL
{
    public class ContactoDAL
    {
        // Eliminamos la línea "private readonly Conexion conexion..." porque no es necesaria para métodos estáticos

        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            // Cambiado: conexion.ObtenerConexion() -> Conexion.ObtenerConexion()
            using (SqlConnection con = Conexion.ObtenerConexion())
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre, Telefono, Correo, Direccion FROM Contactos ORDER BY Id DESC", con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public void Insertar(Contacto c)
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

        public void Actualizar(Contacto c)
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
