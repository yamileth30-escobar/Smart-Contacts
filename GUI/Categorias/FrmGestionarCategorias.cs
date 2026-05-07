using AgendaContactos.GUI;
using AgendaContactos.GUI.Categorias;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Categorias
{
  public partial class FrmGestionarCategorias : Form
  {
    public DataGridView dgvCategorias;
    public Button btnNuevaCategoria;
    public Button btnCerrar;
    private PictureBox pictureBox1;
    public Label label1;

    public FrmGestionarCategorias()
    {
      InitializeComponent();
      this.Text = "Gestión de Categorias";
      this.StartPosition = FormStartPosition.CenterScreen;

      // CONEXIÓN DEL EVENTO LOAD: Esto hace que cargue al abrir
      this.Load += new System.EventHandler(this.FrmGestionarCategorias_Load);
    }

    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionarCategorias));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión de Categorias";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(26, 82);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(297, 181);
            this.dgvCategorias.TabIndex = 2;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevaCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCategoria.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCategoria.Location = new System.Drawing.Point(77, 316);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(160, 35);
            this.btnNuevaCategoria.TabIndex = 1;
            this.btnNuevaCategoria.Text = "Nueva Categoria";
            this.btnNuevaCategoria.UseVisualStyleBackColor = false;
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(388, 316);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(345, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGestionarCategorias
            // 
            this.ClientSize = new System.Drawing.Size(632, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevaCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionarCategorias";
            this.Text = "Smart Contacts | FrmGestionarCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    // --- SE EJECUTA AL ABRIR LA VENTANA ---
    private void FrmGestionarCategorias_Load(object sender, EventArgs e)
    {
      CargarCategorias();
    }

    // --- ABRE LA VENTANA Y ACTUALIZA AL CERRAR ---
    private void btnNuevaCategoria_Click(object sender, EventArgs e)
    {
      FrmAgregarCategoria formulario = new FrmAgregarCategoria();
      formulario.ShowDialog();

      // Después de cerrar la ventana de agregar, refrescamos la tabla
      CargarCategorias();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    // --- MÉTODO QUE TRAE LOS DATOS DE SQL ---
    private void CargarCategorias()
    {
      try
      {
        string cadena = System.Configuration.ConfigurationManager.ConnectionStrings["AgendaContactos"].ConnectionString;
        using (SqlConnection conexion = new SqlConnection(cadena))
        {
          conexion.Open();
          // Usamos Id y Nombre según tu script de SQL
          string query = "SELECT Id, Nombre FROM Categorias";

          SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
          DataTable dt = new DataTable();
          adaptador.Fill(dt);

          dgvCategorias.DataSource = dt;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error al cargar categorías: " + ex.Message);
      }
    }
  }
}
