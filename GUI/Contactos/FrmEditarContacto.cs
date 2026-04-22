using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
    public partial class FrmEditarContacto : Form
    {
        public FrmEditarContacto()
        {
            InitializeComponent();
        }

        // --- BOTÓN ACTUALIZAR DATOS ---
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtIdEditar.Text))
            {
                MessageBox.Show("No podés dejar el nombre vacío", "Aviso");
                return;
            }

            try
            {
                // 2. Conexión desde el App.config
                string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    // 3. Query SQL de Actualización (Update)
                    string query = "UPDATE Contactos SET Nombre = @nom, Apellido = @ape, Telefono = @tel " +
                                   "WHERE IdContacto = @id";

                    SqlCommand cmd = new SqlCommand(query, conexion);

                    // 4. Pasamos los valores de tus cuadros de texto y el label
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@ape", txtApellido.Text.Trim());
                    cmd.Parameters.AddWithValue("@tel", texTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtIdEditar.Text); // El ID que está en el label

                    // 5. Ejecutamos la orden
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("¡Contacto actualizado con éxito!", "Hecho");
                        this.Close(); // Cerramos la ventana después de editar
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el contacto para actualizar.", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Clavo al actualizar en SQL: " + ex.Message, "Error Crítico");
            }
        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

        private void btnCancelar_Click(object sender, EventArgs e)
    {
      // Solo cerramos la ventana sin hacer nada en la base de datos
      this.Close();
    }

    private void FrmEditarContacto_Load(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      // 1. Preguntamos antes de cometer una locura
      DialogResult respuesta = MessageBox.Show("¿Estás seguro de que querés eliminar este contacto? Esta acción no se puede deshacer.",
          "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

      if (respuesta == DialogResult.Yes)
      {
        try
        {
          string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;
          using (SqlConnection conexion = new SqlConnection(cadena))
          {
            conexion.Open();

            // Query para borrar por ID
            string query = "DELETE FROM Contactos WHERE IdContacto = @id";
            SqlCommand cmd = new SqlCommand(query, conexion);

            // Usamos el ID que ya tenemos en el label
            cmd.Parameters.AddWithValue("@id", txtIdEditar.Text);

            int filas = cmd.ExecuteNonQuery();

            if (filas > 0)
            {
              MessageBox.Show("Contacto eliminado correctamente.");
              this.Close(); // Cerramos la ventana porque el contacto ya no existe
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al eliminar: " + ex.Message);
        }
      }
      // Si dice que "No", no pasa nada y la ventana se queda abierta
    }
  }
  
  
}
