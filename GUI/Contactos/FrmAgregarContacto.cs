using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace AgendaContactos.GUI.Contactos
{
  public partial class FrmAgregarContacto : Form
  {
    public FrmAgregarContacto()
    {
      InitializeComponent();
      this.Text = "Agregar Nuevo Contacto";
    }

    // --- BOTÓN GUARDAR (LA MAGIA) ---
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      // 1. Validación: Que no dejen el nombre vacío
      if (string.IsNullOrWhiteSpace(textBox1.Text))
      {
        MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        // 2. Conexión: Buscamos el cable en el App.config
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // 3. La orden para SQL Server
          string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo) " +
                         "VALUES (@nom, @ape, @tel, @cor)";

          SqlCommand cmd = new SqlCommand(query, conexion);

          // 4. Pasamos los datos de tus cuadros de texto (TextBoxes)
          cmd.Parameters.AddWithValue("@nom", textBox1.Text.Trim());
          cmd.Parameters.AddWithValue("@ape", textBox2.Text.Trim());
          cmd.Parameters.AddWithValue("@tel", textBox3.Text.Trim());
          cmd.Parameters.AddWithValue("@cor", textBox4.Text.Trim());

          // 5. ¡Ejecutamos la orden!
          cmd.ExecuteNonQuery();

          MessageBox.Show("¡Contacto guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

          this.Close(); // Cerramos la ventana al terminar
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se trabó la carreta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // --- BOTÓN CANCELAR (EL QUE TE FALTABA) ---
    private void btnCancelar_Click(object sender, EventArgs e)
    {
      // Preguntamos para que no se cierre por error
      DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas cancelar? Se perderán los datos ingresados.",
                          "Confirmar",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

      if (respuesta == DialogResult.Yes)
      {
        this.Close(); // Cerramos solo esta ventanita
      }
    }

    // Estos métodos se quedan así por si les diste doble clic por error en el diseño
    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void label3_Click(object sender, EventArgs e) { }
    private void button2_Click(object sender, EventArgs e) { this.Close(); }
  }
}
