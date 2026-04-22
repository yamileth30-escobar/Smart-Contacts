namespace AgendaContactos.GUI.Contactos
{
  partial class FrmEditarContacto
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
            this.LdLid = new System.Windows.Forms.Label();
            this.txtIdEditar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.IdLNombre = new System.Windows.Forms.Label();
            this.IblApellido = new System.Windows.Forms.Label();
            this.IblTelefono = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.texTelefono = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LdLid
            // 
            this.LdLid.AutoSize = true;
            this.LdLid.Location = new System.Drawing.Point(-2, 9);
            this.LdLid.Name = "LdLid";
            this.LdLid.Size = new System.Drawing.Size(99, 20);
            this.LdLid.TabIndex = 0;
            this.LdLid.Text = "ID Contacto:";
            // 
            // txtIdEditar
            // 
            this.txtIdEditar.Location = new System.Drawing.Point(103, 6);
            this.txtIdEditar.Name = "txtIdEditar";
            this.txtIdEditar.ReadOnly = true;
            this.txtIdEditar.Size = new System.Drawing.Size(366, 26);
            this.txtIdEditar.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(366, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // IdLNombre
            // 
            this.IdLNombre.AutoSize = true;
            this.IdLNombre.Location = new System.Drawing.Point(-2, 60);
            this.IdLNombre.Name = "IdLNombre";
            this.IdLNombre.Size = new System.Drawing.Size(69, 20);
            this.IdLNombre.TabIndex = 3;
            this.IdLNombre.Text = "Nombre:";
            // 
            // IblApellido
            // 
            this.IblApellido.AutoSize = true;
            this.IblApellido.Location = new System.Drawing.Point(-2, 105);
            this.IblApellido.Name = "IblApellido";
            this.IblApellido.Size = new System.Drawing.Size(69, 20);
            this.IblApellido.TabIndex = 4;
            this.IblApellido.Text = "Apellido:";
            // 
            // IblTelefono
            // 
            this.IblTelefono.AutoSize = true;
            this.IblTelefono.Location = new System.Drawing.Point(-2, 159);
            this.IblTelefono.Name = "IblTelefono";
            this.IblTelefono.Size = new System.Drawing.Size(75, 20);
            this.IblTelefono.TabIndex = 5;
            this.IblTelefono.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(103, 99);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(366, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // texTelefono
            // 
            this.texTelefono.Location = new System.Drawing.Point(103, 153);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(366, 26);
            this.texTelefono.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(2, 406);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(211, 41);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Datos.";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(577, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(211, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(498, 220);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(290, 58);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Cpntacto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.texTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.IblTelefono);
            this.Controls.Add(this.IblApellido);
            this.Controls.Add(this.IdLNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIdEditar);
            this.Controls.Add(this.LdLid);
            this.Name = "FrmEditarContacto";
            this.Text = "ID Contacto";
            this.Load += new System.EventHandler(this.FrmEditarContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label LdLid;
    private System.Windows.Forms.Label IdLNombre;
    private System.Windows.Forms.Label IblApellido;
    private System.Windows.Forms.Label IblTelefono;
    private System.Windows.Forms.Button btnActualizar;
    public System.Windows.Forms.TextBox txtIdEditar;
    public System.Windows.Forms.TextBox txtNombre;
    public System.Windows.Forms.TextBox txtApellido;
    public System.Windows.Forms.TextBox texTelefono;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnEliminar;
  }
}
