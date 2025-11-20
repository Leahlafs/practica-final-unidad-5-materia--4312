using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajArt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionarPaísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais();
            frm.MdiParent = this;  
            frm.Show();
        }

        private void gestionarDestinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDestino frm = new FrmDestino();
            frm.MdiParent = this;
            frm.Show();
        }

        private void gestionarToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTour frm = new FrmTour();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exportarListasACSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportarCSV frm = new FrmExportarCSV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
