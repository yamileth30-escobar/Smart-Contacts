using System;
using System.Windows.Forms;

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
            // Validar las credenciales (las que ya tenías)
            if (txtUsuario.Text.Trim().Equals("yami") && txtContraseña.Text.Trim().Equals("tokio25"))
            {
                // === CONEXIÓN CON EL MENÚ PRINCIPAL ===
                this.Hide();                    // Ocultamos el Login

                // Creamos y mostramos el formulario principal
                MainForm frmPrincipal = new MainForm();
                frmPrincipal.ShowDialog();      // Mostramos el menú principal

                // Cuando el usuario cierre el MainForm, también cerramos el Login
                this.Close();
            }
            else
            {
                // Mostrar mensaje de error
                MessageBox.Show("Credenciales incorrectas.", "Smart Contacts | Inicio de Sesión",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Limpiar campos y enfocar usuario
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Opcional: puedes poner aquí código que se ejecute al cargar el login
        }
    }
}