namespace GUI.Contactos
{
    partial class FrmListaContactos
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
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.ListadeContactos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(297, 60);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.RowTemplate.Height = 24;
            this.dgvContactos.Size = new System.Drawing.Size(240, 150);
            this.dgvContactos.TabIndex = 0;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListadeContactos
            // 
            this.ListadeContactos.AutoSize = true;
            this.ListadeContactos.Location = new System.Drawing.Point(63, 19);
            this.ListadeContactos.Name = "ListadeContactos";
            this.ListadeContactos.Size = new System.Drawing.Size(44, 16);
            this.ListadeContactos.TabIndex = 1;
            this.ListadeContactos.Text = "label1";
            this.ListadeContactos.Click += new System.EventHandler(this.Lista_Click);
            // 
            // FrmListaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListadeContactos);
            this.Controls.Add(this.dgvContactos);
            this.Name = "FrmListaContactos";
            this.Text = "FrmListaContactos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label ListadeContactos;
    }
}