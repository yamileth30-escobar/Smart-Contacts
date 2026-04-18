using GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Autenticacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Esto es para que el cursor aparezca de un solo en el cuadro de usuario
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            // 1. Validamos que no dejen los campos vacíos
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Por favor, llena todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Jalamos la conexión de tu App.config
                string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

                using (SqlConnection conexion = new SqlConnection(cadena))
                {
                    conexion.Open();

                    // 3. Consulta SQL CORREGIDA: Cambiamos 'Clave' por 'Contrasena'
                    // Esto tiene que ser IGUAL a como está en tu tabla de SQL Server
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario = @user AND Contrasena = @pass";

                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@user", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());

                    int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                    // 4. Si el resultado es mayor a 0, los datos son correctos
                    if (resultado > 0)
                    {
                        MessageBox.Show("¡Inicio de sesión exitoso!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abrimos el menú principal
                        MainForm menu = new MainForm();
                        menu.Show();

                        // Ocultamos el login
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContraseña.Clear();
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                // Si sale error aquí, revisá que el nombre en App.config sea "AgendaContactos"
                MessageBox.Show("Error de conexión: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}