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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarContacto));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LdLid
            // 
            this.LdLid.AutoSize = true;
            this.LdLid.BackColor = System.Drawing.Color.Transparent;
            this.LdLid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdLid.ForeColor = System.Drawing.Color.Black;
            this.LdLid.Location = new System.Drawing.Point(22, 88);
            this.LdLid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LdLid.Name = "LdLid";
            this.LdLid.Size = new System.Drawing.Size(79, 16);
            this.LdLid.TabIndex = 0;
            this.LdLid.Text = "ID Contacto:";
            // 
            // txtIdEditar
            // 
            this.txtIdEditar.Location = new System.Drawing.Point(105, 87);
            this.txtIdEditar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEditar.Name = "txtIdEditar";
            this.txtIdEditar.ReadOnly = true;
            this.txtIdEditar.Size = new System.Drawing.Size(245, 20);
            this.txtIdEditar.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 118);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(245, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // IdLNombre
            // 
            this.IdLNombre.AutoSize = true;
            this.IdLNombre.BackColor = System.Drawing.Color.Transparent;
            this.IdLNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLNombre.ForeColor = System.Drawing.Color.Black;
            this.IdLNombre.Location = new System.Drawing.Point(22, 121);
            this.IdLNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLNombre.Name = "IdLNombre";
            this.IdLNombre.Size = new System.Drawing.Size(56, 16);
            this.IdLNombre.TabIndex = 3;
            this.IdLNombre.Text = "Nombre:";
            // 
            // IblApellido
            // 
            this.IblApellido.AutoSize = true;
            this.IblApellido.BackColor = System.Drawing.Color.Transparent;
            this.IblApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblApellido.ForeColor = System.Drawing.Color.Black;
            this.IblApellido.Location = new System.Drawing.Point(22, 150);
            this.IblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IblApellido.Name = "IblApellido";
            this.IblApellido.Size = new System.Drawing.Size(57, 16);
            this.IblApellido.TabIndex = 4;
            this.IblApellido.Text = "Apellido:";
            // 
            // IblTelefono
            // 
            this.IblTelefono.AutoSize = true;
            this.IblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.IblTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTelefono.ForeColor = System.Drawing.Color.Black;
            this.IblTelefono.Location = new System.Drawing.Point(22, 185);
            this.IblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IblTelefono.Name = "IblTelefono";
            this.IblTelefono.Size = new System.Drawing.Size(58, 16);
            this.IblTelefono.TabIndex = 5;
            this.IblTelefono.Text = "Telefono:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(105, 147);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(245, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // texTelefono
            // 
            this.texTelefono.Location = new System.Drawing.Point(105, 182);
            this.texTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(245, 20);
            this.texTelefono.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(26, 316);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(141, 27);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar Datos";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(522, 311);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 32);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Brown;
            this.btnEliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(266, 314);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(141, 27);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar Contacto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID Contacto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmEditarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(634, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarContacto";
            this.Text = "Smart Contacts | ID Contacto";
            this.Load += new System.EventHandler(this.FrmEditarContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    private System.Windows.Forms.PictureBox pictureBox1;
    public System.Windows.Forms.Label label1;
  }
}
