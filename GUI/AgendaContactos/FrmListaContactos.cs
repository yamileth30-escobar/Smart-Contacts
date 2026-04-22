using AgendaContactos.GUI.Contactos;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI.AgendaContactos
{
    public partial class FrmListaContactos : Form
    {
        private readonly string connectionString;
        private object DgvContactos;

        public object DgvContactos1 { get => DgvContactos; set => DgvContactos = value; }

        public FrmListaContactos(object dgvContactos)
        {
            DgvContactos = dgvContactos;
        }

        public FrmListaContactos()
        {
            InitializeComponent();
            this.Text = "Lista de Contactos";

            // Leer la cadena de conexión de forma segura
            var connStringSetting = ConfigurationManager.ConnectionStrings["AgendaContactosDB"];
            connectionString = connStringSetting?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("No se encontró la cadena de conexión 'AgendaContactosDB' en el App.config",
                                "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void FrmListaContactos_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(connectionString))
                return;

            CargarContactos();
        }

        private void CargarContactos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                        c.IdContacto AS ID,
                                        c.Nombre + ' ' + ISNULL(c.Apellido, '') AS [Nombre Completo],
                                        c.Telefono,
                                        c.Correo AS Email,
                                        cat.NombreCategoria AS Categoria
                                     FROM Contactos c
                                     LEFT JOIN Categorias cat ON c.IdCategoria = cat.IdCategoria
                                     ORDER BY c.Nombre";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        AgendaContactos.DgvContactos.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contactos:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            using (FrmAgregarContacto frm = new FrmAgregarContacto())
            {
                frm.ShowDialog();
            }
            CargarContactos();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    internal class DgvContactos
    {
        internal static DataTable DataSource;
    }
}