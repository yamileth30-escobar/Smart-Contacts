using AgendaContactos.GUI.Contactos;
using DAL; // Usando tu capa de datos
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
      this.Text = "Lista de Contactos";
      // Esto hará que se vea genial en tu MSI Katana
      this.WindowState = FormWindowState.Maximized;
    }

    private void FrmListaContactos_Load(object sender, EventArgs e)
    {
      // 1. Cargamos los datos en cuanto se abre la ventana
      CargarContactos();
    }

    /// <summary>
    /// Método principal para traer la info de SQL a la tabla
    /// </summary>
    private void CargarContactos()
    {
      try
      {
        // Usamos tu clase de conexión de la capa DAL
        using (SqlConnection conn = new DAL.Conexion().ObtenerConexion())
        {
          conn.Open();

          // Consulta SQL
          string query = "SELECT IdContacto AS ID, Nombre, Apellido, Telefono, Correo FROM Contactos";

          SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
          DataTable dt = new DataTable();
          adapter.Fill(dt);

          // Importante: Usamos el nombre que me confirmaste 'dvgContactos'
          dgvContactos.DataSource = dt;

          // Mejoramos el aspecto de la tabla
          ConfigurarAparienciaTabla();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("❌ Error al cargar contactos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void ConfigurarAparienciaTabla()
    {
      // Ajustes para que la tabla se vea pro
      dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgvContactos.AllowUserToAddRows = false;
      dgvContactos.ReadOnly = true;

      // Opcional: Cambiar encabezados si querés que se vean más bonitos
      if (dgvContactos.Columns.Count > 0)
      {
        dgvContactos.Columns["ID"].Width = 50;
        dgvContactos.Columns["Correo"].HeaderText = "Correo Electrónico";
      }
    }

    // --- BOTONES DEL DISEÑO ---

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      CargarContactos(); // Refresca la lista
      MessageBox.Show("🔄 Lista actualizada correctamente.", "Sincronizado");
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      // Abrimos tu ventana de Agregar (FrmAgregarContacto)
      // Nota: Asegurate que el nombre coincida con tu archivo (normalmente es sin la 's' al final)
      FrmAgregarContacto frm = new FrmAgregarContacto();
      frm.ShowDialog();

      // Al volver de agregar, refrescamos automáticamente
      CargarContactos();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // --- EXTRAS PARA EL DOBLE CLIC (Lo que hablamos antes) ---

    private void dvgContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        FrmEditarContacto frm = new FrmEditarContacto();

        // Pasamos los datos a la ventana de editar
        frm.txtIdEditar.Text = dgvContactos.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        frm.txtNombre.Text = dgvContactos.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        frm.txtApellido.Text = dgvContactos.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
        frm.texTelefono.Text = dgvContactos.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

        frm.ShowDialog();
        CargarContactos(); // Refrescamos al terminar de editar
      }
    }

    private void dgvContactos_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      CargarContactos();
    }

    private void btnActualizar_Click1(object sender, EventArgs e)
    {
      // Borrá el 'throw new...' y poné esto:
      CargarContactos();
      MessageBox.Show("🔄 Lista actualizada correctamente.", "Sincronizado");
    }

    private void btnCerrar_Click_1(object sender, EventArgs e)
    {
      this.Close();
    }

     private void btnEditar_Click(object sender, EventArgs e)
    {
      // Verificamos si hay una fila seleccionada
      if (dgvContactos.SelectedRows.Count > 0)
      {
        FrmEditarContacto frm = new FrmEditarContacto();

        // Pasamos los datos de la fila marcada a los cuadros de la ventana editar
        frm.txtIdEditar.Text = dgvContactos.CurrentRow.Cells["ID"].Value.ToString();
        frm.txtNombre.Text = dgvContactos.CurrentRow.Cells["Nombre"].Value.ToString();
        frm.txtApellido.Text = dgvContactos.CurrentRow.Cells["Apellido"].Value.ToString();
        frm.texTelefono.Text = dgvContactos.CurrentRow.Cells["Telefono"].Value.ToString();

        frm.ShowDialog();
        CargarContactos(); // Refresca la lista al cerrar
      }
      else
      {
        MessageBox.Show("Por favor, selecciona un contacto de la lista primero.");
      }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      if (dgvContactos.SelectedRows.Count > 0)
      {
        string id = dgvContactos.CurrentRow.Cells["ID"].Value.ToString();
        string nombre = dgvContactos.CurrentRow.Cells["Nombre"].Value.ToString();

        DialogResult res = MessageBox.Show("¿Seguro que querés borrar a " + nombre + "?",
            "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        if (res == DialogResult.Yes)
        {
          try
          {
            using (SqlConnection conn = new DAL.Conexion().ObtenerConexion())
            {
              conn.Open();
              string sql = "DELETE FROM Contactos WHERE IdContacto = @id";
              SqlCommand cmd = new SqlCommand(sql, conn);
              cmd.Parameters.AddWithValue("@id", id);
              cmd.ExecuteNonQuery();

              MessageBox.Show("Contacto borrado.");
              CargarContactos(); // Refresca la tabla
            }
          }
          catch (Exception ex)
          {
            MessageBox.Show("Error: " + ex.Message);
          }
        }
      }
      else
      {
        MessageBox.Show("Selecciona a quién querés eliminar.");
      }
    }
  }
  
  
}
