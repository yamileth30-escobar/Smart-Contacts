using AgendaContactos.GUI.Contactos;
// Esta línea es la clave para que encuentre tus otros formularios
using GUI.Contactos;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Configuración del formulario principal
            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Smart Contacts - Agenda de Contactos";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //  MENÚ ARCHIVO 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?",
                                "Confirmar salida",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // MENÚ CONTACTOS
        private void listaDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CORRECCIÓN: Quitamos la 'S' extra y usamos el nombre correcto
            FrmListaContactos frm = new FrmListaContactos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarContacto frm = new FrmAgregarContacto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarContacto frm = new FrmBuscarContacto();
            frm.MdiParent = this;
            frm.Show();
        }

        // MENÚ CATEGORÍAS 
        private void gestionarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Si tienes una carpeta Categorias, asegúrate de tener el 'using' arriba
            // o llámalo directamente si el nombre es correcto:
            // Categorias.FrmGestionarCategorias frm = new Categorias.FrmGestionarCategorias();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smart Contacts v1.0\n\n" +
                            "Sistema de Gestión de Contactos\n\n" +
                            "Proyecto Académico - 2026",
                            "Acerca de Smart Contacts",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}