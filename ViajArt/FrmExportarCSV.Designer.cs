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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.btnExportarTodo = new System.Windows.Forms.Button();
            this.btnExportarTours = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exportar todas las listas en un archivo CSV";
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(71, 88);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(193, 32);
            this.btnVistaPrevia.TabIndex = 1;
            this.btnVistaPrevia.Text = "Ver vista previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // dgvTodo
            // 
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Location = new System.Drawing.Point(12, 203);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.RowTemplate.Height = 28;
            this.dgvTodo.Size = new System.Drawing.Size(1023, 355);
            this.dgvTodo.TabIndex = 2;
            // 
            // btnExportarTodo
            // 
            this.btnExportarTodo.Location = new System.Drawing.Point(270, 88);
            this.btnExportarTodo.Name = "btnExportarTodo";
            this.btnExportarTodo.Size = new System.Drawing.Size(193, 32);
            this.btnExportarTodo.TabIndex = 3;
            this.btnExportarTodo.Text = "Exportar todo a CSV";
            this.btnExportarTodo.UseVisualStyleBackColor = true;
            this.btnExportarTodo.Click += new System.EventHandler(this.btnExportarTodo_Click);
            // 
            // btnExportarTours
            // 
            this.btnExportarTours.Location = new System.Drawing.Point(478, 88);
            this.btnExportarTours.Name = "btnExportarTours";
            this.btnExportarTours.Size = new System.Drawing.Size(193, 32);
            this.btnExportarTours.TabIndex = 4;
            this.btnExportarTours.Text = "ExportarTours";
            this.btnExportarTours.UseVisualStyleBackColor = true;
            this.btnExportarTours.Click += new System.EventHandler(this.btnExportarTours_Click);
            // 
            // FrmExportarCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 605);
            this.Controls.Add(this.btnExportarTours);
            this.Controls.Add(this.btnExportarTodo);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.label1);
            this.Name = "FrmExportarCSV";
            this.Text = "FrmExportarCSV";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Button btnExportarTodo;
        private System.Windows.Forms.Button btnExportarTours;
    }
}