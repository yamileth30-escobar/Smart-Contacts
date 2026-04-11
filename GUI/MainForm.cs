using System;
using System.Windows.Forms;

namespace AgendaContactos.GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Configuración del formulario principal
            IsMdiContainer = true;
            WindowState = FormWindowState.Maximized;
            Text = "Smart Contacts - Agenda de Contactos";
            StartPosition = FormStartPosition.CenterScreen;
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
            AgendaContactos.FrmListaContactos frm = new AgendaContactos.FrmListaContactos();
            frm.MdiParent = this;
            frm.Show();
        }

        private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaContactos.FrmAgregarContacto frm = new AgendaContactos.FrmAgregarContacto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void buscarContactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgendaContactos.FrmBuscarContacto frm = new AgendaContactos.FrmBuscarContacto();
            frm.MdiParent = this;
            frm.Show();
        }

        // MENÚ CATEGORÍAS 
        private void gestionarCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias.FrmGestionarCategorias frm = new Categorias.FrmGestionarCategorias();
            frm.MdiParent = this;
            frm.Show();
        }

        //  MENÚ AYUDA 
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smart Contacts v1.0\n\n" +
                            "Sistema de Gestión de Contactos\n\n" +
                            "Proyecto Académico - 2026",
                            "Acerca de Smart Contacts",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}