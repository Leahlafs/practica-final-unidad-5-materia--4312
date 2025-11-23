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
    public partial class FrmDestino : Form
    {

        AgenciaToursDBEntities db = new AgenciaToursDBEntities();

        public FrmDestino()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmDestino_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPaises();

        }

        private void CargarDatos()
        {
            var destinos = db.Destinos
                .Select(d => new
                {
                    d.DestinoID,
                    d.Nombre,
                    Pais = d.Pais.Nombre,
                    d.DuracionDias,
                    d.DuracionHoras
                })
                .ToList();

            dgvDestino.DataSource = destinos;
        }

        private void CargarPaises()
        {
            var paises = db.Pais.ToList();
            cmbPais.DataSource = paises;
            cmbPais.DisplayMember = "Nombre";
            cmbPais.ValueMember = "PaisID";

            cmbPaisActualizar.DataSource = paises;
            cmbPaisActualizar.DisplayMember = "Nombre";
            cmbPaisActualizar.ValueMember = "PaisID";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe escribir un nombre.");
                    return;
                }

                Destinos d = new Destinos();
                d.Nombre = txtNombre.Text;
                d.PaisID = (int)cmbPais.SelectedValue;
                d.DuracionDias = (int)nudDias.Value;
                d.DuracionHoras = (int)nudHoras.Value;

                db.Destinos.Add(d);
                db.SaveChanges();

                MessageBox.Show("Destino agregado correctamente.");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdActualizar.Text))
                {
                    MessageBox.Show("Debe escribir un ID para actualizar.");
                    return;
                }

                int id = int.Parse(txtIdActualizar.Text);
                var destino = db.Destinos.FirstOrDefault(x => x.DestinoID == id);

                if (destino != null)
                {
                    destino.Nombre = txtNombreActualizar.Text;
                    destino.PaisID = (int)cmbPaisActualizar.SelectedValue;
                    destino.DuracionDias = (int)nudDiasActualizar.Value;
                    destino.DuracionHoras = (int)nudHorasActualizar.Value;

                    db.SaveChanges();

                    MessageBox.Show("Destino actualizado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("El ID no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEliminar.Text))
                {
                    MessageBox.Show("Debe escribir un ID para eliminar.");
                    return;
                }

                int id = int.Parse(txtIdEliminar.Text);
                var destino = db.Destinos.FirstOrDefault(x => x.DestinoID == id);

                if (destino != null)
                {
                    db.Destinos.Remove(destino);
                    db.SaveChanges();

                    MessageBox.Show("Destino eliminado correctamente.");
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("El ID no existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
