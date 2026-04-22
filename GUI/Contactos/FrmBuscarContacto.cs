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
      this.Text = "Buscador de Contactos";
    }

    // ESTE MÉTODO ES EL QUE SE ACTIVA AL DAR CLIC AL BOTÓN
    private void btnBuscar_Click(object sender, EventArgs e)
    {
      // 1. Validamos el cuadro de texto (txtBusqueda)
      if (string.IsNullOrWhiteSpace(txtBusqueda.Text))
      {
        MessageBox.Show("Escribí al menos una letra para buscar", "Aviso");
        return;
      }

      try
      {
        // 2. Conexión desde el archivo App.config
        string cadena = ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;

        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();

          // 3. Consulta SQL para buscar por nombre
          string query = "SELECT IdContacto AS [ID], Nombre, Apellido, Telefono, Correo " +
                         "FROM Contactos WHERE Nombre LIKE @nom + '%'";

          SqlCommand cmd = new SqlCommand(query, conexion);
          cmd.Parameters.AddWithValue("@nom", txtBusqueda.Text.Trim());

          // 4. Llenamos la tabla virtual
          SqlDataAdapter adapter = new SqlDataAdapter(cmd);
          DataTable dt = new DataTable();
          adapter.Fill(dt);

          // 5. MOSTRAR RESULTADOS EN LA TABLA
        
          dvgResultado.DataSource = dt;

          // 6. Mensaje si no hay resultados
          if (dt.Rows.Count == 0)
          {
            MessageBox.Show("No encontré a nadie con ese nombre.", "Sin resultados");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Se trabó la carreta: " + ex.Message, "Error Crítico");
      }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void txtBusqueda_TextChanged(object sender, EventArgs e) { }

    private void dvgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

     private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      // 1. Verificamos que no hayas dado clic en el encabezado (fila -1)
      if (e.RowIndex >= 0)
      {
        // 2. Creamos la instancia de la ventana de editar
        FrmEditarContacto frm = new FrmEditarContacto();

        // 3. Pasamos los datos usando el nombre correcto: dvgResultado
        frm.txtIdEditar.Text = dvgResultado.Rows[e.RowIndex].Cells["ID"].Value.ToString();
        frm.txtNombre.Text = dvgResultado.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
        frm.txtApellido.Text = dvgResultado.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
        frm.texTelefono.Text = dvgResultado.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
        // 4. Mostramos la ventana de editar
        frm.ShowDialog();

        // 5. Cuando cerrés la ventana de editar, refrescamos la tabla para ver los cambios
        btnBuscar_Click(null, null);
      }
    }
  }
  
}
