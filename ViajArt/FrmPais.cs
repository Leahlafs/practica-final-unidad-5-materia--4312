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
    public partial class FrmPais : Form
    {
        AgenciaToursDBEntities db = new AgenciaToursDBEntities();

        public FrmPais()
        {
            InitializeComponent();
        }



        private void FrmPais_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            db = new AgenciaToursDBEntities(); // refrescar contexto
            dgvPais.DataSource = db.Pais.ToList();

            dgvPais.Columns["Destinos"].Visible = false;
            dgvPais.Columns["Tours"].Visible = false;


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

                Pais p = new Pais();
                p.Nombre = txtNombre.Text;

                db.Pais.Add(p);
                db.SaveChanges();

                MessageBox.Show("País agregado correctamente.");
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
                var pais = db.Pais.FirstOrDefault(x => x.PaisID == id);

                if (pais != null)
                {
                    if (string.IsNullOrWhiteSpace(txtNombreActualizar.Text))
                    {
                        MessageBox.Show("Debe escribir un nuevo nombre.");
                        return;
                    }

                    pais.Nombre = txtNombreActualizar.Text;
                    db.SaveChanges();

                    MessageBox.Show("País actualizado correctamente.");
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
                if (txtIDpais.Text == "")
                {
                    MessageBox.Show("Debe escribir un ID para eliminar.");
                    return;
                }

                int id = int.Parse(txtIDpais.Text);
                var pais = db.Pais.FirstOrDefault(x => x.PaisID == id);

                if (pais != null)
                {
                    db.Pais.Remove(pais);
                    db.SaveChanges();

                    MessageBox.Show("País eliminado correctamente.");
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
    }
}
    