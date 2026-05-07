using AgendaContactos.GUI.Contactos;
using System;
using System.Windows.Forms;

namespace GUI.Contactos
{
  partial class FrmListaContactos
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaContactos));
      this.label1 = new System.Windows.Forms.Label();
      this.dgvContactos = new System.Windows.Forms.DataGridView();
      this.btnActualizar = new System.Windows.Forms.Button();
      this.btnNuevo = new System.Windows.Forms.Button();
      this.btnEditar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnCerrar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Location = new System.Drawing.Point(34, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(221, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "Lista de Contactos";
      // 
      // dgvContactos
      // 
      this.dgvContactos.AllowUserToAddRows = false;
      this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
      | System.Windows.Forms.AnchorStyles.Left)
      | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvContactos.Location = new System.Drawing.Point(29, 64);
      this.dgvContactos.Name = "dgvContactos";
      this.dgvContactos.RowHeadersWidth = 51;
      this.dgvContactos.Size = new System.Drawing.Size(537, 243);
      this.dgvContactos.TabIndex = 1;
      // 
      // btnActualizar
      // 
      this.btnActualizar.BackColor = System.Drawing.Color.SeaGreen;
      this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnActualizar.ForeColor = System.Drawing.Color.White;
      this.btnActualizar.Location = new System.Drawing.Point(39, 326);
      this.btnActualizar.Name = "btnActualizar";
      this.btnActualizar.Size = new System.Drawing.Size(82, 32);
      this.btnActualizar.TabIndex = 2;
      this.btnActualizar.Text = "Actualizar";
      this.btnActualizar.UseVisualStyleBackColor = false;
      this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
      // 
      // btnNuevo
      // 
      this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
      this.btnNuevo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNuevo.ForeColor = System.Drawing.Color.White;
      this.btnNuevo.Location = new System.Drawing.Point(151, 326);
      this.btnNuevo.Name = "btnNuevo";
      this.btnNuevo.Size = new System.Drawing.Size(82, 32);
      this.btnNuevo.TabIndex = 3;
      this.btnNuevo.Text = "Nuevo";
      this.btnNuevo.UseVisualStyleBackColor = false;
      this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
      // 
      // btnEditar
      // 
      this.btnEditar.BackColor = System.Drawing.Color.DarkCyan;
      this.btnEditar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEditar.ForeColor = System.Drawing.Color.White;
      this.btnEditar.Location = new System.Drawing.Point(272, 326);
      this.btnEditar.Name = "btnEditar";
      this.btnEditar.Size = new System.Drawing.Size(82, 32);
      this.btnEditar.TabIndex = 4;
      this.btnEditar.Text = "Editar";
      this.btnEditar.UseVisualStyleBackColor = false;
      this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
      // 
      // btnEliminar
      // 
      this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
      this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnEliminar.ForeColor = System.Drawing.Color.White;
      this.btnEliminar.Location = new System.Drawing.Point(386, 326);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(82, 32);
      this.btnEliminar.TabIndex = 5;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = false;
      this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
      // 
      // btnCerrar
      // 
      this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
      this.btnCerrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCerrar.ForeColor = System.Drawing.Color.White;
      this.btnCerrar.Location = new System.Drawing.Point(494, 326);
      this.btnCerrar.Name = "btnCerrar";
      this.btnCerrar.Size = new System.Drawing.Size(82, 32);
      this.btnCerrar.TabIndex = 6;
      this.btnCerrar.Text = "Cerrar";
      this.btnCerrar.UseVisualStyleBackColor = false;
      this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
      // 
      // FrmListaContactos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(600, 365);
      this.Controls.Add(this.btnCerrar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnEditar);
      this.Controls.Add(this.btnNuevo);
      this.Controls.Add(this.btnActualizar);
      this.Controls.Add(this.dgvContactos);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FrmListaContactos";
      this.Text = " Smart Contacts |  FrmListaContactos";
      ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    #endregion

    private Label label1;
    private DataGridView dgvContactos;
    private Button btnCerrar;
    public Button btnActualizar;
    public Button btnNuevo;
    public Button btnEditar;
    public Button btnEliminar;
  }
}
