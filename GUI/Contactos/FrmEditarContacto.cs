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
      this.Text = "Editar / Eliminar Contacto";
    }

    // --- BOTÓN ACTUALIZAR DATOS ---
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      // 1. Validamos que el ID no esté vacío o en cero
      if (string.IsNullOrWhiteSpace(txtIdEditar.Text) || txtIdEditar.Text == "0")
      {
        MessageBox.Show("Debe seleccionar un contacto válido desde el buscador.", "ID Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // 2. Validamos que el nombre no esté vacío
      if (string.IsNullOrWhiteSpace(txtNombre.Text))
      {
        MessageBox.Show("El campo 'Nombre' es obligatorio para actualizar.", "Aviso");
        return;
      }

      try
      {
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // CORRECCIÓN: Usamos "Id" en lugar de "IdContacto" para coincidir con tu SQL
          string query = "UPDATE Contactos SET Nombre = @nom, Apellido = @ape, Telefono = @tel " +
                         "WHERE Id = @id";

          SqlCommand cmd = new SqlCommand(query, conexion);

          cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
          cmd.Parameters.AddWithValue("@ape", txtApellido.Text.Trim());
          cmd.Parameters.AddWithValue("@tel", mskTelefono.Text.Trim());
          cmd.Parameters.AddWithValue("@id", txtIdEditar.Text.Trim());

          int filasAfectadas = cmd.ExecuteNonQuery();

          if (filasAfectadas > 0)
          {
            MessageBox.Show("¡Contacto actualizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
          }
          else
          {
            MessageBox.Show("No se pudo realizar la actualización. Verifique el ID.", "Error");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al actualizar en SQL: " + ex.Message, "Error Crítico");
      }
    }

    // --- BOTÓN ELIMINAR CONTACTO ---
    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtIdEditar.Text) || txtIdEditar.Text == "0")
      {
        MessageBox.Show("No hay un contacto seleccionado para eliminar.", "Aviso");
        return;
      }

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

            // CORRECCIÓN: Usamos "Id" en lugar de "IdContacto"
            string query = "DELETE FROM Contactos WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@id", txtIdEditar.Text.Trim());

            int filas = cmd.ExecuteNonQuery();

            if (filas > 0)
            {
              MessageBox.Show("Contacto eliminado correctamente.", "Borrado");
              this.Close();
            }
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show("Error al eliminar: " + ex.Message, "Error");
        }
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void FrmEditarContacto_Load(object sender, EventArgs e)
    {
      // Opcional: Podrías poner txtIdEditar.ReadOnly = true; aquí 
      // para que nadie lo cambie manualmente.
    }
  }
}
