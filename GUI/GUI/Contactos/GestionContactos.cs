using System;
using System.Windows.Forms;
using AgendaContactos.BLL; // Importante
using AgendaContactos.EL;  // Importante

namespace AgendaContactos.GUI.Contactos
{
    public partial class GestionContactos : Form
    {
        // Esta línea es vital para que reconozca 'contactoBll'
        private ContactoBLL contactoBll = new ContactoBLL();

        // Corrige tipos: antes estaban declarados como 'object' lo que provocaba CS1061
        private DataGridView dvListadoClientes;
        private TextBox txtID;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private TextBox txtNombre;

        public GestionContactos()
        {
            InitializeComponent();

            // Asegurarse de que los controles existen (si el diseñador no los creó con estos nombres)
            if (dvListadoClientes == null)
            {
                dvListadoClientes = new DataGridView { Name = "dvListadoClientes", Dock = DockStyle.Fill };
                this.Controls.Add(dvListadoClientes);
            }
            if (txtID == null)
            {
                txtID = new TextBox { Name = "txtID" };
                this.Controls.Add(txtID);
            }
            if (txtCorreo == null)
            {
                txtCorreo = new TextBox { Name = "txtCorreo" };
                this.Controls.Add(txtCorreo);
            }
            if (txtTelefono == null)
            {
                txtTelefono = new TextBox { Name = "txtTelefono" };
                this.Controls.Add(txtTelefono);
            }
            if (txtNombre == null)
            {
                txtNombre = new TextBox { Name = "txtNombre" };
                this.Controls.Add(txtNombre);
            }

            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                dvListadoClientes.DataSource = contactoBll.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void GuardarContacto()
        {
            try
            {
                ContactoEL contacto = new ContactoEL();
                contacto.Nombre = txtID.Text;
                contacto.Apellido = txtNombre.Text;
                contacto.Correo = txtCorreo.Text;
                contacto.Telefono = txtTelefono.Text;
                contacto.CategoriaId = 1; // Ajusta según tu lógica
                contacto.UsuarioId = 1;   // Ajusta según tu lógica

                contactoBll.Guardar(contacto);
                MessageBox.Show("Guardado con éxito");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e) => GuardarContacto();
    }
}