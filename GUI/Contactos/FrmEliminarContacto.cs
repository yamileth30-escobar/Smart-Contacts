using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
  public partial class FrmEliminarContacto : Form
  {
    public FrmEliminarContacto()
    {
      InitializeComponent();
      // Centramos la ventana al abrir
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Eliminar Registro - Smart Contacts";
    }

    // --- BOTÓN ELIMINAR ---
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      // 1. Validamos que el cuadro de texto del ID no esté vacío
      if (string.IsNullOrWhiteSpace(txtIdEliminar.Text))
      {
        MessageBox.Show("Por favor, escriba el ID del contacto que desea eliminar.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // 2. Confirmación de seguridad
      DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este contacto de forma permanente?",
          "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

      if (respuesta == DialogResult.Yes)
      {
        try
        {
          // 3. Obtenemos la conexión desde el App.config
          string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

          using (SqlConnection conexion = new SqlConnection(cadena))
          {
            conexion.Open();

            // 4. Query corregido: Usamos "Id" porque así se llama en tu base de datos
            string query = "DELETE FROM Contactos WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conexion);

            // 5. Pasamos el ID del cuadro de texto
            cmd.Parameters.AddWithValue("@id", txtIdEliminar.Text.Trim());

            int filasAfectadas = cmd.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
              MessageBox.Show("¡Contacto eliminado con éxito!", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
              txtIdEliminar.Clear(); // Limpiamos el campo después de borrar
            }
            else
            {
              MessageBox.Show("No se encontró ningún contacto con el ID ingresado.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error crítico al conectar con SQL: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    // --- BOTÓN CANCELAR / SALIR ---
    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
