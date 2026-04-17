using GUI;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

// Este es el espacio donde vive tu Login
namespace AgendaContactos.GUI.Autenticacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña", "Campos vacíos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["AgendaContactosDB"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", txtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtContraseña.Text.Trim());

                        int existe = (int)cmd.ExecuteScalar();

                        if (existe > 0)
                        {
                            MessageBox.Show("Inicio de sesión exitoso", "Bienvenido",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();

                            // --- SOLUCIÓN DEFINITIVA ---
                            // Buscamos el MainForm en la raíz del proyecto GUI
                            // Si MainForm está dentro de otra carpeta, asegúrate de que sea 'public'
                            MainForm frmPrincipal = new MainForm();

                            frmPrincipal.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtContraseña.Clear();
                            txtUsuario.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n" + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }
    }
}