using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
  public partial class FrmAgregarContacto : Form
  {
    public FrmAgregarContacto()
    {
      InitializeComponent();
      this.Text = "Agregar Nuevo Contacto - Smart Contacts";
      this.StartPosition = FormStartPosition.CenterScreen;

      // Cargamos las categorías apenas se abra la ventana
      CargarCategorias();
    }

    // --- MÉTODO PARA LLENAR EL COMBOBOX DESDE LA BASE DE DATOS ---
    private void CargarCategorias()
    {
      try
      {
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;
        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // NOTA: Si en tu base de datos la columna no se llama ID, cámbiala aquí
          string query = "SELECT * FROM Categorias";

          SqlDataAdapter da = new SqlDataAdapter(query, conexion);
          DataTable dt = new DataTable();
          da.Fill(dt);

          // Vinculamos los datos al ComboBox
          comboBox1.DataSource = dt;
          comboBox1.DisplayMember = "Nombre";    // Lo que el usuario ve

          // Aquí usamos la primera columna de tu tabla (normalmente el ID)
          comboBox1.ValueMember = dt.Columns[0].ColumnName;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("No se pudieron cargar las categorías: " + ex.Message, "Error");
      }
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

          string query = "INSERT INTO Contactos (Nombre, Apellido, Telefono, Correo, Direccion, CategoriaId, UsuarioId) " +
                          "VALUES (@nom, @ape, @tel, @cor, @dir, @cat, 1)";

          SqlCommand cmd = new SqlCommand(query, conexion);

          cmd.Parameters.AddWithValue("@nom", textBox1.Text.Trim());
          cmd.Parameters.AddWithValue("@ape", textBox5.Text.Trim());
          cmd.Parameters.AddWithValue("@tel", textBox4.Text.Trim());
          cmd.Parameters.AddWithValue("@cor", textBox3.Text.Trim());
          cmd.Parameters.AddWithValue("@dir", textBox2.Text.Trim());

          // Si no hay nada seleccionado, mandamos null o un valor por defecto
          if (comboBox1.SelectedValue != null)
            cmd.Parameters.AddWithValue("@cat", comboBox1.SelectedValue);
          else
            cmd.Parameters.AddWithValue("@cat", DBNull.Value);

          cmd.ExecuteNonQuery();

          MessageBox.Show("¡Contacto guardado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
          this.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al guardar: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e) { }
    private void label3_Click(object sender, EventArgs e) { }
  }
}
