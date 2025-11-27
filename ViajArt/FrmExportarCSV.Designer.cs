namespace ViajArt
{
    partial class FrmExportarCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExportarCSV));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.btnExportarTodo = new System.Windows.Forms.Button();
            this.btnExportarTours = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(954, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar todas las listas a CSV";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.BackColor = System.Drawing.Color.DarkOrange;
            this.btnVistaPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVistaPrevia.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVistaPrevia.ForeColor = System.Drawing.Color.White;
            this.btnVistaPrevia.Location = new System.Drawing.Point(1648, 90);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(202, 57);
            this.btnVistaPrevia.TabIndex = 1;
            this.btnVistaPrevia.Text = "Listar Todo";
            this.btnVistaPrevia.UseVisualStyleBackColor = false;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // dgvTodo
            // 
            this.dgvTodo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(21, 192);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowHeadersWidth = 62;
            this.dgvTodo.RowTemplate.Height = 28;
            this.dgvTodo.Size = new System.Drawing.Size(1899, 1027);
            this.dgvTodo.TabIndex = 2;
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExportarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTodo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarTodo.ForeColor = System.Drawing.Color.White;
            this.btnExportarTodo.Location = new System.Drawing.Point(1418, 53);
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(202, 58);
            this.btnExportarTodo.TabIndex = 3;
            this.btnExportarTodo.Text = "Exportar a CSV";
            this.btnExportarTodo.UseVisualStyleBackColor = false;
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportarTodo_Click);
            // 
            // btnExportarTours
            // 
            this.btnExportarTours.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExportarTours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTours.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarTours.ForeColor = System.Drawing.Color.White;
            this.btnExportarTours.Location = new System.Drawing.Point(1647, 17);
            this.btnExportarTours.Name = "btnExportarTours";
            this.btnExportarTours.Size = new System.Drawing.Size(203, 59);
            this.btnExportarTours.TabIndex = 4;
            this.btnExportarTours.Text = "Listar Tours";
            this.btnExportarTours.UseVisualStyleBackColor = false;
            this.btnExportarTours.Click += new System.EventHandler(this.btnExportarTours_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExportarTours);
            this.panel1.Controls.Add(this.btnVistaPrevia);
            this.panel1.Controls.Add(this.btnExportarTodo);
            this.panel1.Location = new System.Drawing.Point(-6, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1926, 168);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ViajArt.Properties.Resources.informes;
            this.pictureBox1.Location = new System.Drawing.Point(110, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExportarCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1932, 1231);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTodo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExportarCSV";
            this.Text = "FrmExportarCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Button btnExportarTodo;
        private System.Windows.Forms.Button btnExportarTours;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}