using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AgendaContactos.BLL;
using AgendaContactos.EL;   // Importamos la entidad (asegúrate de que la clase 'Categoria' exista en este namespace)

namespace AgendaContactos.GUI.Categorias
{
    public partial class ListadoCategorias : Form
    {
        // Usamos la lógica, NO la conexión directa
        CategoriaBLL bll = new CategoriaBLL();
        // Cambiado de object a TextBox para acceder a .Text y .Clear correctamente
        private TextBox txtNombreCat;
        // Declaración del DataGridView que faltaba
        private DataGridView dgvCategorias;

        public ListadoCategorias()
        {
            InitializeComponent();

            // Intentar enlazar con controles creados por el diseñador (si existen)
            dgvCategorias = this.Controls.Find("dgvCategorias", true).FirstOrDefault() as DataGridView;
            if (dgvCategorias == null)
            {
                // Si no existe en el diseñador, crear uno mínimo para evitar CS0103
                dgvCategorias = new DataGridView
                {
                    Name = "dgvCategorias",
                    Dock = DockStyle.Top,
                    Height = 200,
                    AllowUserToAddRows = false,
                    ReadOnly = true
                };
                this.Controls.Add(dgvCategorias);
            }

            txtNombreCat = this.Controls.Find("txtNombreCat", true).FirstOrDefault() as TextBox;
            if (txtNombreCat == null)
            {
                // Si no existe en el diseñador, crear uno mínimo para poder usarlo en el código
                txtNombreCat = new TextBox
                {
                    Name = "txtNombreCat",
                    Top = dgvCategorias.Bottom + 8,
                    Left = 8,
                    Width = 200
                };
                this.Controls.Add(txtNombreCat);
            }
        }

        private void ListadoCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                // Llamamos al método que ya hicimos en la BLL
                dgvCategorias.DataSource = bll.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar
                if (string.IsNullOrWhiteSpace(txtNombreCat.Text))
                {
                    MessageBox.Show("Ingrese un nombre");
                    return;
                }

                // 2. Llenar entidad (uso de inicializador de objeto simplificado)
                var entidad = new CategoriaEL { Nombre = txtNombreCat.Text };

                // 3. Guardar usando la BLL
                bll.Guardar(entidad);

                MessageBox.Show("¡Guardado!");
                txtNombreCat.Clear();
                CargarCategorias(); // Refrescar la tabla
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            btnGuardar_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoCategorias_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}