using System;
using System.Windows.Forms;

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
            // Configuracion Inicial del DataGridView
            ConfigurarDataGridView();

            // Aquí más adelante cargarás los contactos desde la BLL
            MessageBox.Show("Lista de contactos cargada (simulación)", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ejemplo temporal de columnas
            dgvContactos.Columns.Add("Id", "ID");
            dgvContactos.Columns.Add("Nombre", "Nombre");
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns.Add("Email", "Email");
            dgvContactos.Columns.Add("Categoria", "Categoría");
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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista actualizada (simulación)", "Actualizar");
            // Aquí más adelante llamarás a la BLL para recargar los datos
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Abre el formulario para agregar contacto
            FrmAgregarContactos frm = new FrmAgregarContactos();
            frm.ShowDialog();

            // Después de cerrar, puedes actualizar la lista automáticamente
            // btnActualizar_Click(null, null);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class FrmAgregarContactos : Form
    {
        public FrmAgregarContactos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // Implementación mínima para que compile; sustituir por el diseñador cuando proceda
            this.Text = "Agregar Contacto";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 600;
            this.Height = 400;
        }
    }
}