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
      this.StartPosition = FormStartPosition.CenterScreen;
    }

    private void FrmListaContactos_Load(object sender, EventArgs e)
    {
      CargarContactos();
    }

    private void CargarContactos()
    {
      try
      {
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

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      FrmAgregarContacto frm = new FrmAgregarContacto();
      frm.ShowDialog();
      CargarContactos();
    }

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
      else
      {
        MessageBox.Show("Por favor, selecciona un contacto para editar.");
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (dgvContactos.CurrentRow != null)
      {
        DialogResult res = MessageBox.Show("¿Deseas eliminar este contacto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (res == DialogResult.Yes)
        {
          try
          {
            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["ID"].Value);
            using (SqlConnection conn = DAL.Conexion.ObtenerConexion())
            {
              conn.Open();
              string query = "DELETE FROM Contactos WHERE Id = @id";
              SqlCommand cmd = new SqlCommand(query, conn);
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Contacto eliminado correctamente.");
            CargarContactos();
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error al eliminar: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Selecciona un contacto para eliminar.");
      }
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
