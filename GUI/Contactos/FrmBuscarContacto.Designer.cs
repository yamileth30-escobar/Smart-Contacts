using System;
using System.Windows.Forms;

namespace AgendaContactos.GUI.Contactos
{
  partial class FrmBuscarContacto
  {
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarContacto));
      this.IblInstruccion = new System.Windows.Forms.Label();
      this.txtBusqueda = new System.Windows.Forms.TextBox();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.dvgResultado = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dvgResultado)).BeginInit();
      this.SuspendLayout();
      // 
      // IblInstruccion
      // 
      this.IblInstruccion.AutoSize = true;
      this.IblInstruccion.BackColor = System.Drawing.Color.Transparent;
      this.IblInstruccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.IblInstruccion.ForeColor = System.Drawing.Color.Black;
      this.IblInstruccion.Location = new System.Drawing.Point(30, 75);
      this.IblInstruccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.IblInstruccion.Name = "IblInstruccion";
      this.IblInstruccion.Size = new System.Drawing.Size(118, 16);
      this.IblInstruccion.TabIndex = 0;
      this.IblInstruccion.Text = "Escriba el Nombre:";
      // 
      // txtBusqueda
      // 
      this.txtBusqueda.Location = new System.Drawing.Point(171, 75);
      this.txtBusqueda.Margin = new System.Windows.Forms.Padding(2);
      this.txtBusqueda.Name = "txtBusqueda";
      this.txtBusqueda.Size = new System.Drawing.Size(403, 20);
      this.txtBusqueda.TabIndex = 1;
      // 
      // btnBuscar
      // 
      this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBuscar.ForeColor = System.Drawing.Color.White;
      this.btnBuscar.Location = new System.Drawing.Point(612, 71);
      this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(82, 32);
      this.btnBuscar.TabIndex = 2;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = false;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // dvgResultado
      // 
      this.dvgResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dvgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dvgResultado.Location = new System.Drawing.Point(11, 126);
      this.dvgResultado.Margin = new System.Windows.Forms.Padding(2);
      this.dvgResultado.Name = "dvgResultado";
      this.dvgResultado.RowHeadersWidth = 62;
      this.dvgResultado.RowTemplate.Height = 28;
      this.dvgResultado.Size = new System.Drawing.Size(698, 277);
      this.dvgResultado.TabIndex = 3;
      this.dvgResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgResultado_CellDoubleClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(27, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(314, 31);
      this.label1.TabIndex = 4;
      this.label1.Text = "Administración de Contacto";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // FrmBuscarContacto
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(720, 414);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dvgResultado);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.txtBusqueda);
      this.Controls.Add(this.IblInstruccion);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmBuscarContacto";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Smart Contacts | Buscador";
      ((System.ComponentModel.ISupportInitialize)(this.dvgResultado)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label IblInstruccion;
    private System.Windows.Forms.TextBox txtBusqueda;
    private System.Windows.Forms.Button btnBuscar;
    private System.Windows.Forms.DataGridView dvgResultado;
    public System.Windows.Forms.Label label1;
  }
}
