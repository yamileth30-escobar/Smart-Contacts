using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgendaContactos.GUI.Categorias
{
  public partial class FrmAgregarCategoria : Form
  {
    // Asegúrate de que el nombre de la base de datos sea 'AgendaContactos'
    string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AgendaContactos;Integrated Security=True;";

    public FrmAgregarCategoria()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      // 1. Validación: Usamos .Text para revisar el contenido
      if (string.IsNullOrWhiteSpace(txtNombre.Text))
      {
        MessageBox.Show("Por favor, ingrese el nombre de la categoría.", "Atención");
        return;
      }

      try
      {
        using (SqlConnection conexion = new SqlConnection(cadenaConexion))
        {
          conexion.Open();
          // Asegúrate de que tu tabla se llame 'Categorias' y la columna 'Nombre'
          string query = "INSERT INTO Categorias (Nombre) VALUES (@nombre)";

          using (SqlCommand comando = new SqlCommand(query, conexion))
          {
            // CORRECCIÓN AQUÍ: Agregamos .Text al final de txtNombre
            comando.Parameters.AddWithValue("@nombre", txtNombre.Text);

            comando.ExecuteNonQuery();
          }
        }

        MessageBox.Show("¡Guardado en la Base de Datos con éxito!", "Éxito");
        this.DialogResult = DialogResult.OK; // Esto es clave para que la otra ventana sepa que hubo cambios
        this.Close();
      }
      catch (Exception ex)
      {
        // Esto te dirá exactamente qué falló (si la tabla no existe o el servidor está apagado)
        MessageBox.Show("No se pudo guardar: " + ex.Message, "Error de SQL");
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // Redirección de eventos del diseñador
    private void btnGuardar_Click_1(object sender, EventArgs e) { btnGuardar_Click(sender, e); }
    private void btnCancelar_Click_1(object sender, EventArgs e) { btnCancelar_Click(sender, e); }
  }
}
