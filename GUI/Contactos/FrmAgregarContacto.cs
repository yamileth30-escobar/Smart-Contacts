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
      this.Text = "Agregar Nuevo Contacto - Smart Contacts";
    }
    // --- BOTÓN GUARDAR ---
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(textBox1.Text))
      {
        MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      if (string.IsNullOrWhiteSpace(textBox4.Text))
      {
        MessageBox.Show("El teléfono es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      try
      {
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // CORRECCIÓN AQUÍ: Agregamos UsuarioId en la lista de columnas para que el "1" tenga donde caer
          string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Direccion, CategoriaId, UsuarioId) " +
                          "VALUES (@nom, @ape, @tel, @cor, @dir, @cat, 1)";

          SqlCommand cmd = new SqlCommand(query, conexion);

          cmd.Parameters.AddWithValue("@nom", textBox1.Text.Trim());
          cmd.Parameters.AddWithValue("@ape", textBox5.Text.Trim());
          cmd.Parameters.AddWithValue("@tel", textBox4.Text.Trim());
          cmd.Parameters.AddWithValue("@cor", textBox3.Text.Trim());
          cmd.Parameters.AddWithValue("@dir", textBox2.Text.Trim());

          // Como CategoriaId es número, le mandamos el 1 por ahora para que no falle
          cmd.Parameters.AddWithValue("@cat", 1);

          cmd.ExecuteNonQuery();

          MessageBox.Show("¡Contacto guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se trabó la carreta: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    // --- BOTÓN CANCELAR ---
    private void btnCancelar_Click(object sender, EventArgs e)
    {
      DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas cancelar? Se perderán los datos ingresados.",
                          "Confirmar",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);

      if (respuesta == DialogResult.Yes)
      {
        this.Close();
      }
    }

    // --- EXTRAS (Eventos vacíos por si acaso) ---
    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void label3_Click(object sender, EventArgs e) { }
  }
}
