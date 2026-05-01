using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
  public partial class FrmBuscarContacto : Form
  {
    public FrmBuscarContacto()
    {
      InitializeComponent();
      this.Text = "Buscador de Contactos - Smart Contacts";
    }

    // --- BOTÓN BUSCAR ---
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      // Validamos que el cuadro de texto no esté vacío
      if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
      {
        MessageBox.Show("Por favor, escriba un nombre para buscar.", "Aviso");
        return;
      }

      try
      {
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // Query usando "Id" como está en tu tabla
          string query = "SELECT Id AS [ID], Nombre, Apellido, Telefono, Correo " +
                         "FROM Contactos WHERE Nombre LIKE @nom + '%'";

          SqlCommand cmd = new SqlCommand(query, conexion);
          cmd.Parameters.AddWithValue("@nom", txtBusqueda.Text.Trim());

          SqlDataAdapter adapter = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          adapter.Fill(dt);

          // Llenamos la tabla
          dvgResultado.DataSource = dt;

          if (dt.Rows.Count == 0)
          {
            MessageBox.Show("No se encontraron contactos con ese nombre.", "Sin resultados");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al buscar: " + ex.Message, "Error Crítico");
      }
    }

    // --- EVENTO PARA EVITAR EL ERROR DE TEXTCHANGED ---
    // Lo dejamos vacío para que si Visual Studio lo busca, no se trabe
    private void txtBusqueda_TextChanged(object sender, EventArgs e)
    {
    }

    // --- DOBLE CLIC PARA EDITAR ---
    private void dvgResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        FrmEditarContacto frm = new FrmEditarContacto();

        // Pasamos los datos a la ventana de editar
        frm.txtIdEditar.Text = dvgResultado.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        frm.txtNombre.Text = dvgResultado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        frm.txtApellido.Text = dvgResultado.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
        frm.mskTelefono.Text = dvgResultado.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

        frm.ShowDialog();
        btnBuscar_Click(null, null); // Refresca la tabla
      }
    }
  }
}
