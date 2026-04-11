using System;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
    public partial class FrmAgregarContacto : Form
    {
        public FrmAgregarContacto()
        {
            InitializeComponent();
            this.Text = "Agregar Nuevo Contacto";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            MessageBox.Show("Contacto guardado correctamente (simulación)", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Cierra el formulario después de guardar (simulación)
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cancelar? Se perderán los datos ingresados.",
                                "Confirmar cancelación",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}