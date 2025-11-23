using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajArt
{
    public partial class FrmExportarCSV : Form
    {
        AgenciaToursDBEntities db = new AgenciaToursDBEntities();
        public FrmExportarCSV()
        {
            InitializeComponent();
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            var paises = db.Pais
                .ToList()
                .Select(p => new
                {
                    Tipo = "País",
                    ID = p.PaisID,
                    Nombre = p.Nombre,
                    Extra1 = "",
                    Extra2 = ""
                });

            var destinos = db.Destinos
                .ToList()
                .Select(d => new
                {
                    Tipo = "Destino",
                    ID = d.DestinoID,
                    Nombre = d.Nombre,
                    Extra1 = "PaísID: " + d.PaisID,
                    Extra2 = $"Duración: {d.DuracionDias} días {d.DuracionHoras} horas"
                });

            var tours = db.Tours
                .ToList()
                .Select(t => new
                {
                    Tipo = "Tour",
                    ID = t.TourID,
                    Nombre = t.Nombre,
                    Extra1 = $"Destino: {t.Destinos.Nombre}",
                    Extra2 = $"Fecha: {t.Fecha:dd/MM/yyyy} {t.Hora:hh\\:mm} | Estado: {(DateTime.Now < t.FechaHoraFin ? "Vigente" : "No vigente")}"
                });

            var todo = paises.Concat(destinos).Concat(tours).ToList();
            dgvTodo.DataSource = todo;

        }

        private void btnExportarTodo_Click(object sender, EventArgs e)
        {
            var tours = db.Tours
                .ToList()
                .Select(t => new
                {
                    ID = t.TourID,
                    Nombre = t.Nombre,
                    Pais = t.Pais.Nombre,
                    Destino = t.Destinos.Nombre,
                    Fecha = t.Fecha.ToString("dd/MM/yyyy"),
                    Hora = string.Format("{0:hh\\:mm}", t.Hora),
                    Precio = t.Precio,
                    ITBIS = t.Precio * 0.18m,
                    Duracion = $"{t.DuracionDias} días {t.DuracionHoras} horas",
                    FechaHoraFin = t.FechaHoraFin.HasValue
                        ? t.FechaHoraFin.Value.ToString("dd/MM/yyyy HH:mm")
                        : "No calculada",
                    Estado = DateTime.Now < t.FechaHoraFin ? "Vigente" : "No vigente"
                })
                .ToList();

            dgvTodo.DataSource = tours;

            // Exportar directamente a CSV
            ExportarCSV(dgvTodo, "ToursRegistrados.csv");
        }

        private void ExportarCSV(DataGridView dgv, string nombreArchivo)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar archivo CSV";
            saveFileDialog.FileName = nombreArchivo;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    // Encabezados
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();

                    // Filas
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.IsNewRow) continue;
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString());
                            if (i < dgv.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Datos exportados correctamente.");
            }
        }


        private void btnExportarTours_Click(object sender, EventArgs e)
        {
            var tours = db.Tours
                .ToList()
                .Select(t => new
                {
                    ID = t.TourID,
                    Nombre = t.Nombre,
                    Pais = t.Pais.Nombre,
                    Destino = t.Destinos.Nombre,
                    Fecha = t.Fecha.ToString("dd/MM/yyyy"),
                    Hora = string.Format("{0:hh\\:mm}", t.Hora),
                    Precio = t.Precio,
                    ITBIS = t.Precio * 0.18m,
                    Duracion = $"{t.DuracionDias} días {t.DuracionHoras} horas",
                    FechaHoraFin = t.FechaHoraFin.HasValue
                        ? t.FechaHoraFin.Value.ToString("dd/MM/yyyy HH:mm")
                        : "No calculada",
                    Estado = DateTime.Now < t.FechaHoraFin ? "Vigente" : "No vigente"
                })
                .ToList();

            dgvTodo.DataSource = tours;

        }
    }
}
