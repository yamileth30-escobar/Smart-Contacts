using System.Data;
using System.Data.SqlClient;
using AgendaContactos.EL;

namespace AgendaContactos.DAL
{
    public class CategoriaDAL
    {
        Conexion con = new Conexion();

        public void Insertar(CategoriaEL entidad)
        {
            using (SqlConnection cn = con.ObtenerConexion())
            {
                string sql = "INSERT INTO Categorias (Nombre) VALUES (@nom)";
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@nom", entidad.Nombre);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable Listar()
        {
            using (SqlConnection cn = con.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT Id, Nombre FROM Categorias", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}