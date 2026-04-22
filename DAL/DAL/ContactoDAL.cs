using AgendaContactos.EL;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AgendaContactos.DAL
{
    public class ContactoDAL
    {
        private readonly Conexion conexion = new Conexion();

        // 1. LISTAR SIRVE PARA MOSTRAR LOS CONTACTOS EN EL DATAGRIDVIEW
        public DataTable Listar()
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id, Nombre, Apellido, Telefono, Correo, CategoriaId FROM Contactos ORDER BY Id DESC", con))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // 2. INSERTAR GUARDAR UN NUEVO CONTACTO EN LA BASE DE DATOS
        public void Insertar(ContactoEL c)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, CategoriaId, UsuarioId) VALUES (@n, @a, @t, @c, @cat, @u)", con))
            {
                // El operador ?? evita que el programa falle si un campo está vacío
                cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("@a", c.Apellido ?? string.Empty);
                cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
                cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
                cmd.Parameters.AddWithValue("@cat", c.CategoriaId);
                cmd.Parameters.AddWithValue("@u", c.UsuarioId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 3. ACTUALIZAR EDITAR UN CONTACTO EXISTENTE EN LA BASE DE DATOS
        public void Actualizar(ContactoEL c)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Contactos SET Nombre=@n, Apellido=@a, Telefono=@t, Correo=@c, CategoriaId=@cat WHERE Id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.Parameters.AddWithValue("@n", c.Nombre ?? string.Empty);
                cmd.Parameters.AddWithValue("@a", c.Apellido ?? string.Empty);
                cmd.Parameters.AddWithValue("@t", c.Telefono ?? string.Empty);
                cmd.Parameters.AddWithValue("@c", c.Correo ?? string.Empty);
                cmd.Parameters.AddWithValue("@cat", c.CategoriaId);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // 4. ELIMINAR UN CONTACTO DE LA BASE DE DATOS
        public void Eliminar(int id)
        {
            using (SqlConnection con = conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("DELETE FROM Contactos WHERE Id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Buscar(string valor)
        {
            throw new NotImplementedException();
        }
    }
}