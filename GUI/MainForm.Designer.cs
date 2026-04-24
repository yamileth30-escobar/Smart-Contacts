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
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarContactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeSmartContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.contactosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.salirToolStripMenuItem.Text = "Salir";
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
            this.contactosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.contactosToolStripMenuItem.Text = "Contactos";
            // 
            // agregarNuevoContactoToolStripMenuItem
            // 
            this.agregarNuevoContactoToolStripMenuItem.Name = "agregarNuevoContactoToolStripMenuItem";
            this.agregarNuevoContactoToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.agregarNuevoContactoToolStripMenuItem.Text = "Agregar Nuevo Contacto";
            this.agregarNuevoContactoToolStripMenuItem.Click += new System.EventHandler(this.agregarContactoToolStripMenuItem_Click);
            // 
            // verListaDeContactoToolStripMenuItem
            // 
            this.verListaDeContactoToolStripMenuItem.Name = "verListaDeContactoToolStripMenuItem";
            this.verListaDeContactoToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.verListaDeContactoToolStripMenuItem.Text = "Ver Lista de Contacto";
            this.verListaDeContactoToolStripMenuItem.Click += new System.EventHandler(this.listaDeContactosToolStripMenuItem_Click);
            // 
            // buscarContactoToolStripMenuItem
            // 
            this.buscarContactoToolStripMenuItem.Name = "buscarContactoToolStripMenuItem";
            this.buscarContactoToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.buscarContactoToolStripMenuItem.Text = "Buscar Contacto";
            this.buscarContactoToolStripMenuItem.Click += new System.EventHandler(this.buscarContactoToolStripMenuItem_Click);
            // 
            // editarContactoToolStripMenuItem
            // 
            this.editarContactoToolStripMenuItem.Name = "editarContactoToolStripMenuItem";
            this.editarContactoToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.editarContactoToolStripMenuItem.Text = "Editar Contacto";
            this.editarContactoToolStripMenuItem.Visible = false;
            this.editarContactoToolStripMenuItem.Click += new System.EventHandler(this.editarContactoToolStripMenuItem_Click);
            // 
            // eliminarContactoToolStripMenuItem
            // 
            this.eliminarContactoToolStripMenuItem.Name = "eliminarContactoToolStripMenuItem";
            this.eliminarContactoToolStripMenuItem.Size = new System.Drawing.Size(312, 34);
            this.eliminarContactoToolStripMenuItem.Text = "Eliminar Contacto";
            this.eliminarContactoToolStripMenuItem.Visible = false;
            this.eliminarContactoToolStripMenuItem.Click += new System.EventHandler(this.eliminarContactoToolStripMenuItem_Click);
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // gestionarCategoríasToolStripMenuItem
            // 
            this.gestionarCategoríasToolStripMenuItem.Name = "gestionarCategoríasToolStripMenuItem";
            this.gestionarCategoríasToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.gestionarCategoríasToolStripMenuItem.Text = "Gestionar Categorías";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.herramientasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeSmartContactsToolStripMenuItem});
            this.ayudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeSmartContactsToolStripMenuItem
            // 
            this.acercaDeSmartContactsToolStripMenuItem.Name = "acercaDeSmartContactsToolStripMenuItem";
            this.acercaDeSmartContactsToolStripMenuItem.Size = new System.Drawing.Size(317, 34);
            this.acercaDeSmartContactsToolStripMenuItem.Text = "Acerca de Smart Contacts";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Smart Contacts";
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
    }
}