using System;
using System.Windows.Forms;
using AgendaContactos.GUI;

namespace Categorias
{
    public partial class FrmGestionarCategorias : Form
    {
        public DataGridView dgvCategorias;
        public Button btnNuevaCategoria;
        public Button btnCerrar;
        public Label label1;

        public FrmGestionarCategorias()
        {
            // If a designer exists, InitializeComponent();
            InitializeComponent();
            this.Text = "Gestión de Categorias";
            this.WindowState = FormWindowState.Maximized;
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión de Categorias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(43, 84);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(764, 356);
            this.dgvCategorias.TabIndex = 1;
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Location = new System.Drawing.Point(212, 479);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(160, 37);
            this.btnNuevaCategoria.TabIndex = 2;
            this.btnNuevaCategoria.Text = "Nueva Categoria";
            this.btnNuevaCategoria.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(472, 479);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 37);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // FrmGestionarCategorias
            // 
            this.ClientSize = new System.Drawing.Size(853, 528);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnNuevaCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionarCategorias";
            this.Text = "FrmGestionarCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionarCategorias_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario de Categorias cargando correctamente", "Éxito");
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Use the inherited Show() and MdiParent (from Form). Remove manual implementations.
    }
}   