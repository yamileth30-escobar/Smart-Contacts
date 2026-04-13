using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAL;                    // Asegúrate que este namespace coincida con tu capa DAL

namespace GUI.Contactos
{
    public partial class FrmListaContactos : Form
    {
        public FrmListaContactos()
        {
            InitializeComponent();
            this.Text = "Lista de Contactos";
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmListaContactos_Load(object sender, EventArgs e)
        {
            // Probar conexión a la base de datos al cargar el formulario
            ProbarConexionBaseDatos();

            // Configuración inicial del DataGridView
            ConfigurarDataGridView();

            // TODO: Aquí más adelante cargarás los contactos reales desde la BLL
            // CargarContactos();
        }

        /// <summary>
        /// Prueba la conexión a la base de datos
        /// </summary>
        private void ProbarConexionBaseDatos()
        {
            try
            {
                using (SqlConnection conn = new DAL.Conexion().ObtenerConexion())   // Versión más explícita
                {
                    conn.Open();
                    MessageBox.Show("✅ ¡Conexión exitosa a la base de datos!\n\n" +
                                   "Servidor: GUADALUPE\\GUADALUPE\n" +
                                   "Base de datos: AgendaContactos",
                                   "Conexión Exitosa",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error de conexión:\n\n" + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void ConfigurarDataGridView()
        {
            dgvContactos.Columns.Clear();
            dgvContactos.Columns.Add("Id", "ID");
            dgvContactos.Columns.Add("Nombre", "Nombre Completo");
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns.Add("Email", "Correo Electrónico");
            dgvContactos.Columns.Add("Categoria", "Categoría");

            // Ajustar ancho de columnas
            dgvContactos.Columns["Id"].Width = 60;
            dgvContactos.Columns["Nombre"].Width = 200;
            dgvContactos.Columns["Telefono"].Width = 120;
            dgvContactos.Columns["Email"].Width = 180;
            dgvContactos.Columns["Categoria"].Width = 120;

            // Opcional: Mejorar apariencia
            dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.MultiSelect = false;
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.ReadOnly = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Lista actualizada (simulación)", "Actualizar");
            // TODO: Llamar al método que carga los contactos desde la BLL
            // CargarContactos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarContactos frm = new FrmAgregarContactos();
            frm.ShowDialog();

            // Después de agregar un contacto, actualizamos la lista automáticamente
            btnActualizar_Click(null, null);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==================== MÉTODO FUTURO ====================
        // private void CargarContactos()
        // {
        //     // Aquí iría la llamada a la BLL
        // }
    }

    // ==================== CLASE TEMPORAL (Eliminar cuando tengas el diseñador) ====================
    public class FrmAgregarContactos : Form
    {
        public FrmAgregarContactos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Agregar Contacto";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 600;
            this.Height = 400;
        }
    }
}