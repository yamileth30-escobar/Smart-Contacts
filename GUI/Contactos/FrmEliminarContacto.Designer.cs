namespace AgendaContactos.GUI.Contactos
{
  partial class FrmEliminarContacto
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
            this.IBLIdBorrar = new System.Windows.Forms.Label();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IBLIdBorrar
            // 
            this.IBLIdBorrar.AutoSize = true;
            this.IBLIdBorrar.Location = new System.Drawing.Point(12, 30);
            this.IBLIdBorrar.Name = "IBLIdBorrar";
            this.IBLIdBorrar.Size = new System.Drawing.Size(185, 20);
            this.IBLIdBorrar.TabIndex = 0;
            this.IBLIdBorrar.Text = "ID del Contacto a Borrar:";
            this.IBLIdBorrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(214, 30);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(365, 26);
            this.txtIdEliminar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Location = new System.Drawing.Point(561, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(227, 55);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar Contacto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // FrmEliminarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtIdEliminar);
            this.Controls.Add(this.IBLIdBorrar);
            this.Name = "FrmEliminarContacto";
            this.Text = "FrmEliminarContacto";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label IBLIdBorrar;
    private System.Windows.Forms.TextBox txtIdEliminar;
    private System.Windows.Forms.Button btnEliminar;
  }
}