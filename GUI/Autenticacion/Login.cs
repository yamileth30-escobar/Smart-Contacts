using GUI;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Autenticacion
{
  public partial class Login : Form
  {
    public Login()
    {
      InitializeComponent();
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void Login_Load(object sender, EventArgs e)
    {
      txtUsuario.Focus();
    }

    private void btnIniciarSesion_Click_1(object sender, EventArgs e)
    {
      // 1. Validación de campos vacíos
      if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
      {
        MessageBox.Show("Por favor, llena todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
      }

      // 2. ACCESO DE EMERGENCIA (Si la base de datos falla o no tiene datos)
      if (txtUsuario.Text == "admin" && txtContraseña.Text == "1234")
      {
        EntrarAlSistema();
        return;
      }

      // 3. INTENTO CON BASE DE DATOS
      try
      {
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // IMPORTANTE: Si te da error de "Invalid Column", revisa si en SQL
          // pusiste 'Usuario' en vez de 'NombreUsuario' o 'Clave' en vez de 'Contrasena'
          string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @user AND Contrasena = @pass";

          SqlCommand cmd = new SqlCommand(query, conexion);
          cmd.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
          cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());

          int resultado = (int)cmd.ExecuteScalar();

          if (resultado > 0)
          {
            EntrarAlSistema();
          }
          else
          {
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
      catch (Exception ex)
      {
        // Si la base de datos falla, te avisamos pero no bloqueamos el admin/1234
        MessageBox.Show("Aviso de Base de Datos: " + ex.Message + "\n\n(Intenta usar admin/1234)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    // Método para no repetir código
    private void EntrarAlSistema()
    {
      MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
      MainForm menu = new MainForm();
      menu.Show();
      this.Hide();
    }
  }
}
