using AgendaContactos.GUI.Contactos;
// Importante: Esto le dice al programa que busque dentro de tu carpeta de Contactos
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

      // CONFIGURACIÓN PROFESIONAL
      this.IsMdiContainer = true; // Permite que las ventanas se abran adentro
      this.WindowState = FormWindowState.Maximized; // Abre en pantalla completa
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

    //  MENÚ CONTACTOS (REDIRECCIONES)
   

    // 1. Ver Lista
    private void listaDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmListaContactos frm = new FrmListaContactos();
      frm.MdiParent = this;
      frm.Show();
    }

    // 2. Agregar Nuevo
    private void agregarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmAgregarContacto frm = new FrmAgregarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // 3. Buscar
    private void buscarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmBuscarContacto frm = new FrmBuscarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // 4. Editar (Agregado)
    private void editarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      IdLid frm = new IdLid();
      frm.MdiParent = this;
      frm.Show();
    }

    // 5. Eliminar (Agregado)
    private void eliminarContactoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FrmEliminarContacto frm = new FrmEliminarContacto();
      frm.MdiParent = this;
      frm.Show();
    }

    // ==========================================
    //  MENÚ OTROS / AYUDA
    // ==========================================
    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Smart Contacts v1.0\n\n" +
                      "Sistema de Gestión de Contactos\n\n" +
                      "Proyecto Académico UNAB - 2026",
                      "Acerca de Smart Contacts",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      // Se deja vacío para evitar errores del diseñador visual
    }
  }
}
