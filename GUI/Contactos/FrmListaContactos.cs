using AgendaContactos.GUI.Contactos;
using DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI.Contactos
{
  public partial class FrmListaContactos : Form
  {
    public FrmListaContactos()
    {
      InitializeComponent();
      this.Text = "Lista de Contactos - Smart Contacts";
    }

    private void FrmListaContactos_Load(object sender, EventArgs e)
    {
      CargarContactos();
    }

    private void CargarContactos()
    {
      try
      {
        // CAMBIO AQUÍ: Quita el "new" y los paréntesis de Conexion
        using (SqlConnection conn = DAL.Conexion.ObtenerConexion())
        {
          conn.Open();
          string query = "SELECT Id AS ID, Nombre, Apellido, Telefono FROM Contactos";
          SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
          DataTable dt = new DataTable();
          adapter.Fill(dt);
          dgvContactos.DataSource = dt;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar la lista: " + ex.Message);
      }
    }

    // ESTE ES EL QUE DABA ERROR - YA ESTÁ CORREGIDO:
    private void btnActualizar_Click(object sender, EventArgs e)
    {
      CargarContactos();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
      if (dgvContactos.CurrentRow != null)
      {
        FrmEditarContacto frm = new FrmEditarContacto();
        frm.txtIdEditar.Text = dgvContactos.CurrentRow.Cells["ID"].Value?.ToString();
        frm.txtNombre.Text = dgvContactos.CurrentRow.Cells["Nombre"].Value?.ToString();
        frm.txtApellido.Text = dgvContactos.CurrentRow.Cells["Apellido"].Value?.ToString();
        frm.mskTelefono.Text = dgvContactos.CurrentRow.Cells["Telefono"].Value?.ToString();

        frm.ShowDialog();
        CargarContactos();
      }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
