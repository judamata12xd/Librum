using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class BusquedaLibros : Form
    {
        private List<LibroDTO> _librosOriginales = new List<LibroDTO>();

        public BusquedaLibros()
        {
            InitializeComponent();
        }

        // Este es el único evento Load que usaremos
        private async void BusquedaLibros_Load(object sender, EventArgs e)
        {
            await CargarLibrosDesdeApi();
        }

        private async Task CargarLibrosDesdeApi()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Libros";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                        _librosOriginales = JsonSerializer.Deserialize<List<LibroDTO>>(json, options) ?? new List<LibroDTO>();

                        dgvLibros.DataSource = null;
                        dgvLibros.DataSource = _librosOriginales;
                    }
                    else
                    {
                        MessageBox.Show("La API respondió con error: " + response.StatusCode, "Error HTTP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción al conectar con la API: " + ex.Message, "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void btAgregarLibro_Click(object sender, EventArgs e)
        {
            cbAutor formLibro = new cbAutor();

            if (formLibro.ShowDialog() == DialogResult.OK)
            {
                _ = CargarLibrosDesdeApi();
            }
        }
        private void gbGestionDeLibros_Enter(object sender, EventArgs e) { }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                var libroSeleccionado = (LibroDTO)dgvLibros.SelectedRows[0].DataBoundItem;

                cbAutor formLibro = new cbAutor(libroSeleccionado.Codlibro);

                if (formLibro.ShowDialog() == DialogResult.OK)
                {
                    _ = CargarLibrosDesdeApi();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                var libroSeleccionado = (LibroDTO)dgvLibros.SelectedRows[0].DataBoundItem;


                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de que deseas eliminar el libro '{libroSeleccionado.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            string url = $"https://localhost:7141/api/Libros/{libroSeleccionado.Codlibro}";

                            HttpResponseMessage response = await client.DeleteAsync(url);

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("¡Libro eliminado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                await CargarLibrosDesdeApi();
                            }
                            else
                            {
                                string errorContenido = await response.Content.ReadAsStringAsync();
                                MessageBox.Show("Error al eliminar el libro: " + errorContenido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error de red: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txBuscarLibro.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(filtro))
            {
                
                dgvLibros.DataSource = null;
                dgvLibros.DataSource = _librosOriginales;
            }
            else
            {
                
                var listaFiltrada = _librosOriginales.Where(l =>
                    (!string.IsNullOrEmpty(l.Nombre) && l.Nombre.ToLower().Contains(filtro)) ||
                    (!string.IsNullOrEmpty(l.NombreAutor) && l.NombreAutor.ToLower().Contains(filtro)) ||
                    l.Codlibro.ToString().Contains(filtro)
                ).ToList();

                dgvLibros.DataSource = null;
                dgvLibros.DataSource = listaFiltrada;
            }
        }

        public class LibroDTO
        {
            public int Codlibro { get; set; }
            public string Nombre { get; set; }
            public int? Disponible { get; set; }
            public int? Idautor { get; set; }
            public string NombreAutor { get; set; }
        }
    }
}