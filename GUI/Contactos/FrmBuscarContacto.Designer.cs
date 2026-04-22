namespace AgendaContactos.GUI.Contactos
{
    partial class FrmBuscarContacto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IblInstruccion = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dvgResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // IblInstruccion
            // 
            this.IblInstruccion.AutoSize = true;
            this.IblInstruccion.Location = new System.Drawing.Point(1, 0);
            this.IblInstruccion.Name = "IblInstruccion";
            this.IblInstruccion.Size = new System.Drawing.Size(138, 20);
            this.IblInstruccion.TabIndex = 0;
            this.IblInstruccion.Text = "Escriba el Nombre";
            this.IblInstruccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(141, 0);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(381, 26);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(528, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dvgResultado
            // 
            this.dvgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgResultado.Location = new System.Drawing.Point(-3, 43);
            this.dvgResultado.Name = "dvgResultado";
            this.dvgResultado.RowHeadersWidth = 62;
            this.dvgResultado.RowTemplate.Height = 28;
            this.dvgResultado.Size = new System.Drawing.Size(801, 404);
            this.dvgResultado.TabIndex = 3;
            // 
            // FrmBuscarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.IblInstruccion);
            this.Name = "FrmBuscarContacto";
            this.Text = "FrmBuscarContacto";
            ((System.ComponentModel.ISupportInitialize)(this.dvgResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.Label IblInstruccion;
    private System.Windows.Forms.TextBox txtBusqueda;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.DataGridView dvgResultado;
  }
}