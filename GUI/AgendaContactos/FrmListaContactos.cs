using AgendaContactos;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI.Contactos
{
    public partial class FrmListaContactos : Form
    {
        private readonly string connectionString;

        public FrmListaContactos()
        {
            InitializeComponent();
            this.Text = "Lista de Contactos";

            // Leer la cadena de conexión desde App.config
            connectionString = ConfigurationManager.ConnectionStrings["AgendaContactosDB"].ConnectionString;
        }

        private void FrmListaContactos_Load(object sender, EventArgs e)
        {
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

                        dgvContactos.DataSource = dt;   // ← Aquí debe estar tu DataGridView
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los contactos:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarContacto frm = new FrmAgregarContacto();
            frm.ShowDialog();
            CargarContactos();   // Actualiza la lista después de agregar
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}