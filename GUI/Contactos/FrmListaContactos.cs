using System;
using System.Windows.Forms;

namespace GUI.Contactos
{
    public partial class FrmListaContactos : Form
    {
        public FrmListaContactos()
        {
            InitializeComponent();          // método generado por el Designer
            InitializeCustomComponents();   // tu inicialización adicional
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Lista de Contactos";
            this.WindowState = FormWindowState.Maximized;

            this.dgvContactos = new DataGridView
            {
                Name = "dgvContactos",
                Dock = DockStyle.Fill
            };
            this.Controls.Add(this.dgvContactos);
        }

        private void FrmListaContactos_Load(object sender, EventArgs e)
        {
            // Aquí más adelante cargarás los contactos desde la BLL
            MessageBox.Show("Lista de contactos cargada (simulación)", "Información");

            // Ejemplo temporal de columnas
            dgvContactos.Columns.Add("Id", "ID");
            dgvContactos.Columns.Add("Nombre", "Nombre");
            dgvContactos.Columns.Add("Telefono", "Teléfono");
            dgvContactos.Columns.Add("Email", "Email");
            dgvContactos.Columns.Add("Categoria", "Categoría");
        }
    }
}