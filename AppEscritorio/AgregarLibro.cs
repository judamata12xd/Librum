using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;

namespace AppEscritorio
{
    public partial class cbAutor : Form
    {
        private int? _codLibroEdicion = null;

        public cbAutor()
        {
            InitializeComponent();
        }

        public cbAutor(int codLibro)
        {
            InitializeComponent();
            _codLibroEdicion = codLibro;
        }

        private async void FrmLibro_Load(object sender, EventArgs e)
        {
            await CargarAutoresEnComboBox();

            if (_codLibroEdicion.HasValue)
            {
                this.Text = "Editar Libro";
                txCodLibro.Enabled = false; 
                await CargarDatosLibroParaEditar(_codLibroEdicion.Value);
            }
        }

        private async Task CargarAutoresEnComboBox()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Autores";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                        var listaAutores = JsonSerializer.Deserialize<List<AutorDTO>>(json, options);

                       
                        cmbAutor.DataSource = listaAutores;
                        cmbAutor.DisplayMember = "Nombre"; 
                        cmbAutor.ValueMember = "Idautor";   
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los autores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarDatosLibroParaEditar(int codLibro)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://localhost:7141/api/Libros/{codLibro}";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var libro = JsonSerializer.Deserialize<LibroModeloUnico>(json, options);

                        if (libro != null)
                        {
                            txCodLibro.Text = libro.Codlibro.ToString();
                            txTitulo.Text = libro.Nombre;
                            txDisponibles.Text = libro.Disponible.ToString();
                            cmbAutor.SelectedValue = libro.Idautor;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del libro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void txCodLibro_TextChanged(object sender, EventArgs e) { }

        private async void btGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txCodLibro.Text) ||
                string.IsNullOrWhiteSpace(txTitulo.Text) ||
                string.IsNullOrWhiteSpace(txDisponibles.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var libroData = new
                {
                    Codlibro = int.Parse(txCodLibro.Text),
                    Nombre = txTitulo.Text.Trim(),
                    Disponible = int.Parse(txDisponibles.Text),
                    Idautor = (int)cmbAutor.SelectedValue
                };

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response;
                    string json = JsonSerializer.Serialize(libroData);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    if (!_codLibroEdicion.HasValue)
                    {
                        // MODO CREAR (POST)
                        string url = "https://localhost:7141/api/Libros";
                        response = await client.PostAsync(url, content);
                    }
                    else
                    {
                        // MODO EDITAR (PUT)
                        string url = $"https://localhost:7141/api/Libros/{_codLibroEdicion.Value}";
                        response = await client.PutAsync(url, content);
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        string mensaje = _codLibroEdicion.HasValue ? "¡Libro actualizado con éxito!" : "¡Libro agregado exitosamente!";
                        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string errorContenido = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al guardar el libro: " + errorContenido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class AutorDTO
    {
        public int Idautor { get; set; }
        public string Nombre { get; set; }
    }

    public class LibroModeloUnico
    {
        public int Codlibro { get; set; }
        public string Nombre { get; set; }
        public int? Disponible { get; set; }
        public int? Idautor { get; set; }
    }
}