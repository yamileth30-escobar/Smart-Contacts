namespace GUI
{
  partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.respaldoDeDatosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSmartContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUusuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem,
            this.respaldoDeDatosToolStripMenuItem,
            this.respaldoDeDatosToolStripMenuItem1,
            this.restaurarBaseDeDatosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.salirToolStripMenuItem.Text = "Configuracion del Servidor";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion ";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // respaldoDeDatosToolStripMenuItem
            // 
            this.respaldoDeDatosToolStripMenuItem.Name = "respaldoDeDatosToolStripMenuItem";
            this.respaldoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(212, 6);
            this.respaldoDeDatosToolStripMenuItem.Click += new System.EventHandler(this.respaldoDeDatosToolStripMenuItem_Click);
            // 
            // respaldoDeDatosToolStripMenuItem1
            // 
            this.respaldoDeDatosToolStripMenuItem1.Name = "respaldoDeDatosToolStripMenuItem1";
            this.respaldoDeDatosToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.respaldoDeDatosToolStripMenuItem1.Text = "Respaldo de Datos";
            this.respaldoDeDatosToolStripMenuItem1.Click += new System.EventHandler(this.respaldoDeDatosToolStripMenuItem1_Click);
            // 
            // restaurarBaseDeDatosToolStripMenuItem
            // 
            this.restaurarBaseDeDatosToolStripMenuItem.Name = "restaurarBaseDeDatosToolStripMenuItem";
            this.restaurarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.restaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de Datos";
            this.restaurarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.restaurarBaseDeDatosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(212, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoContactoToolStripMenuItem,
            this.verListaDeContactoToolStripMenuItem,
            this.buscarContactoToolStripMenuItem,
            this.editarContactoToolStripMenuItem,
            this.eliminarContactoToolStripMenuItem});
            this.contactosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // agregarNuevoContactoToolStripMenuItem
            // 
            this.agregarNuevoContactoToolStripMenuItem.Name = "agregarNuevoContactoToolStripMenuItem";
            this.agregarNuevoContactoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.agregarNuevoContactoToolStripMenuItem.Text = "Agregar Nuevo Contacto";
            this.agregarNuevoContactoToolStripMenuItem.Click += new System.EventHandler(this.agregarContactoToolStripMenuItem_Click);
            // 
            // verListaDeContactoToolStripMenuItem
            // 
            this.verListaDeContactoToolStripMenuItem.Name = "verListaDeContactoToolStripMenuItem";
            this.verListaDeContactoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.verListaDeContactoToolStripMenuItem.Text = "Ver Lista de Contacto";
            this.verListaDeContactoToolStripMenuItem.Click += new System.EventHandler(this.listaDeContactosToolStripMenuItem_Click);
            // 
            // buscarContactoToolStripMenuItem
            // 
            this.buscarContactoToolStripMenuItem.Name = "buscarContactoToolStripMenuItem";
            this.buscarContactoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.buscarContactoToolStripMenuItem.Text = "Buscar Contacto";
            this.buscarContactoToolStripMenuItem.Click += new System.EventHandler(this.buscarContactoToolStripMenuItem_Click);
            // 
            // editarContactoToolStripMenuItem
            // 
            this.editarContactoToolStripMenuItem.Name = "editarContactoToolStripMenuItem";
            this.editarContactoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.editarContactoToolStripMenuItem.Text = "Editar Contacto";
            this.editarContactoToolStripMenuItem.Click += new System.EventHandler(this.editarContactoToolStripMenuItem_Click);
            // 
            // eliminarContactoToolStripMenuItem
            // 
            this.eliminarContactoToolStripMenuItem.Name = "eliminarContactoToolStripMenuItem";
            this.eliminarContactoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.eliminarContactoToolStripMenuItem.Text = "Eliminar Contacto";
            this.eliminarContactoToolStripMenuItem.Click += new System.EventHandler(this.eliminarContactoToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCategoríasToolStripMenuItem,
            this.verEstadisticaToolStripMenuItem});
            this.categoríasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // gestionarCategoríasToolStripMenuItem
            // 
            this.gestionarCategoríasToolStripMenuItem.Name = "gestionarCategoríasToolStripMenuItem";
            this.gestionarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionarCategoríasToolStripMenuItem.Text = "Gestionar Categorías";
            this.gestionarCategoríasToolStripMenuItem.Click += new System.EventHandler(this.gestionarCategoríasToolStripMenuItem_Click);
            // 
            // verEstadisticaToolStripMenuItem
            // 
            this.verEstadisticaToolStripMenuItem.Name = "verEstadisticaToolStripMenuItem";
            this.verEstadisticaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.verEstadisticaToolStripMenuItem.Text = "Ver Estadistica";
            this.verEstadisticaToolStripMenuItem.Click += new System.EventHandler(this.verEstadisticaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.calendarioToolStripMenuItem});
            this.herramientasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.configuraciónToolStripMenuItem.Text = "Bitacora de Sistema";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.calendarioToolStripMenuItem.Text = "Calendario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeSmartContactsToolStripMenuItem,
            this.manualDeUusuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeSmartContactsToolStripMenuItem
            // 
            this.acercaDeSmartContactsToolStripMenuItem.Name = "acercaDeSmartContactsToolStripMenuItem";
            this.acercaDeSmartContactsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.acercaDeSmartContactsToolStripMenuItem.Text = "Acerca de Smart Contacts";
            this.acercaDeSmartContactsToolStripMenuItem.Click += new System.EventHandler(this.acercaDeSmartContactsToolStripMenuItem_Click);
            // 
            // manualDeUusuarioToolStripMenuItem
            // 
            this.manualDeUusuarioToolStripMenuItem.Name = "manualDeUusuarioToolStripMenuItem";
            this.manualDeUusuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.manualDeUusuarioToolStripMenuItem.Text = "Manual de Uusuario";
            this.manualDeUusuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUusuarioToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = " Smart Contacts | Smart Contacts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem agregarNuevoContactoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem verListaDeContactoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem buscarContactoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editarContactoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem eliminarContactoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gestionarCategoríasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem acercaDeSmartContactsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator respaldoDeDatosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem respaldoDeDatosToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem restaurarBaseDeDatosToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem verEstadisticaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem manualDeUusuarioToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
  }
}
