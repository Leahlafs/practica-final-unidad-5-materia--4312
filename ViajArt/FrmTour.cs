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
    

    public partial class FrmTour : Form
    {
        AgenciaToursDBEntities db = new AgenciaToursDBEntities();

        public FrmTour()
        {
            InitializeComponent();
        }

        private void FrmTour_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarPaises();

        }

        private void CargarDatos()
        {
            var tours = db.Tours
    .ToList() // Trae los datos primero
    .Select(t => new
    {
        t.TourID,
        t.Nombre,
        Pais = t.Pais.Nombre,
        Destino = t.Destinos.Nombre,
        Fecha = t.Fecha.ToString("dd/MM/yyyy"),
        Hora = t.Hora.ToString(@"hh\:mm"),
        Precio = t.Precio,
        ITBIS = t.Precio * 0.18m,
        Duracion = t.DuracionDias + " días " + t.DuracionHoras + " horas",
        FechaHoraFin = t.FechaHoraFin.HasValue
            ? t.FechaHoraFin.Value.ToString("dd/MM/yyyy HH:mm")
            : "No calculada",
        Estado = DateTime.Now < t.FechaHoraFin ? "Vigente" : "No vigente"
    })
    .ToList();

            dgvTour.DataSource = tours;
            dgvTour.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarPaises()
        {
            // Cargar lista de países
            var paises = db.Pais.ToList();
            cmbPais.DataSource = paises;
            cmbPais.DisplayMember = "Nombre";
            cmbPais.ValueMember = "PaisID";

            // Evento para cargar destinos según el país seleccionado
            cmbPais.SelectedIndexChanged += (s, e) =>
            {
                if (cmbPais.SelectedValue != null && cmbPais.SelectedValue is int paisId)
                {
                    var destinos = db.Destinos.Where(d => d.PaisID == paisId).ToList();
                    cmbDestino.DataSource = destinos;
                    cmbDestino.DisplayMember = "Nombre";
                    cmbDestino.ValueMember = "DestinoID";
                }
            };

            // Para actualizar
            cmbPaisActualizar.DataSource = paises;
            cmbPaisActualizar.DisplayMember = "Nombre";
            cmbPaisActualizar.ValueMember = "PaisID";

            cmbPaisActualizar.SelectedIndexChanged += (s, e) =>
            {
                if (cmbPaisActualizar.SelectedValue != null && cmbPaisActualizar.SelectedValue is int paisId)
                {
                    var destinos = db.Destinos.Where(d => d.PaisID == paisId).ToList();
                    cmbDestinoActualizar.DataSource = destinos;
                    cmbDestinoActualizar.DisplayMember = "Nombre";
                    cmbDestinoActualizar.ValueMember = "DestinoID";
                }
            };
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Tours tour = new Tours();
                tour.Nombre = txtNombre.Text;
                tour.PaisID = (int)cmbPais.SelectedValue;
                tour.DestinoID = (int)cmbDestino.SelectedValue;
                tour.Fecha = dtpFecha.Value.Date;
                tour.Hora = dtpHora.Value.TimeOfDay;
                tour.Precio = (decimal)nudPrecio.Value;

                // Cálculos automáticos
                tour.ITBIS = tour.Precio * 0.18m;

                var destino = db.Destinos.FirstOrDefault(d => d.DestinoID == tour.DestinoID);
                if (destino != null)
                {
                    tour.DuracionDias = destino.DuracionDias;
                    tour.DuracionHoras = destino.DuracionHoras;
                }

                tour.FechaHoraFin = tour.Fecha
                    .AddDays(tour.DuracionDias)
                    .AddHours(tour.DuracionHoras)
                    .Add(tour.Hora);

                tour.Estado = DateTime.Now < tour.FechaHoraFin ? "Vigente" : "No vigente";

                db.Tours.Add(tour);
                db.SaveChanges();

                MessageBox.Show("Tour agregado correctamente.");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnActualizr_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtIdActualizar.Text);
                var tour = db.Tours.FirstOrDefault(x => x.TourID == id);

                if (tour != null)
                {
                    tour.Nombre = txtNombreActualizar.Text;
                    tour.PaisID = (int)cmbPaisActualizar.SelectedValue;
                    tour.DestinoID = (int)cmbDestinoActualizar.SelectedValue;
                    tour.Fecha = dtpFechaActualizar.Value.Date;
                    tour.Hora = dtpHoraActualizar.Value.TimeOfDay;
                    tour.Precio = (decimal)nudPrecioActualizar.Value;

                    // Recalcular
                    tour.ITBIS = tour.Precio * 0.18m;

                    var destino = db.Destinos.FirstOrDefault(d => d.DestinoID == tour.DestinoID);
                    if (destino != null)
                    {
                        tour.DuracionDias = destino.DuracionDias;
                        tour.DuracionHoras = destino.DuracionHoras;
                    }

                    tour.FechaHoraFin = tour.Fecha
                        .AddDays(tour.DuracionDias)
                        .AddHours(tour.DuracionHoras)
                        .Add(tour.Hora);

                    tour.Estado = DateTime.Now < tour.FechaHoraFin ? "Vigente" : "No vigente";

                    db.SaveChanges();

                    MessageBox.Show("Tour actualizado correctamente.");
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
                int id = int.Parse(txtIdEliminar.Text);
                var tour = db.Tours.FirstOrDefault(x => x.TourID == id);

                if (tour != null)
                {
                    db.Tours.Remove(tour);
                    db.SaveChanges();

                    MessageBox.Show("Tour eliminado correctamente.");
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // ruta del video
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\PC\Downloads\O Brasil em 3 minutos.mp4"; // ruta del video
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}


