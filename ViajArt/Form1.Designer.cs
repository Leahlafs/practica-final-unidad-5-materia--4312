namespace ViajArt
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viajArtMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPaísesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarDestinosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarListasACSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viajArtMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1692, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viajArtMenuToolStripMenuItem
            // 
            this.viajArtMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPaísesToolStripMenuItem,
            this.gestionarDestinosToolStripMenuItem,
            this.gestionarToursToolStripMenuItem,
            this.exportarListasACSVToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.viajArtMenuToolStripMenuItem.Name = "viajArtMenuToolStripMenuItem";
            this.viajArtMenuToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.viajArtMenuToolStripMenuItem.Text = "ViajArt Menu";
            // 
            // gestionarPaísesToolStripMenuItem
            // 
            this.gestionarPaísesToolStripMenuItem.Name = "gestionarPaísesToolStripMenuItem";
            this.gestionarPaísesToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.gestionarPaísesToolStripMenuItem.Text = "Gestionar Países";
            this.gestionarPaísesToolStripMenuItem.Click += new System.EventHandler(this.gestionarPaísesToolStripMenuItem_Click);
            // 
            // gestionarDestinosToolStripMenuItem
            // 
            this.gestionarDestinosToolStripMenuItem.Name = "gestionarDestinosToolStripMenuItem";
            this.gestionarDestinosToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.gestionarDestinosToolStripMenuItem.Text = "Gestionar Destinos";
            this.gestionarDestinosToolStripMenuItem.Click += new System.EventHandler(this.gestionarDestinosToolStripMenuItem_Click);
            // 
            // gestionarToursToolStripMenuItem
            // 
            this.gestionarToursToolStripMenuItem.Name = "gestionarToursToolStripMenuItem";
            this.gestionarToursToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.gestionarToursToolStripMenuItem.Text = "Gestionar Tours";
            this.gestionarToursToolStripMenuItem.Click += new System.EventHandler(this.gestionarToursToolStripMenuItem_Click);
            // 
            // exportarListasACSVToolStripMenuItem
            // 
            this.exportarListasACSVToolStripMenuItem.Name = "exportarListasACSVToolStripMenuItem";
            this.exportarListasACSVToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.exportarListasACSVToolStripMenuItem.Text = "Exportar Listas a CSV";
            this.exportarListasACSVToolStripMenuItem.Click += new System.EventHandler(this.exportarListasACSVToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(303, 34);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ViajArt.Properties.Resources.ViajArt;
            this.ClientSize = new System.Drawing.Size(1692, 881);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ViajArt";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viajArtMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarPaísesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarDestinosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarListasACSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

