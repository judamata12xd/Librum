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
    public partial class AgregarPrestamo : Form
    {
        public AgregarPrestamo()
        {
            InitializeComponent();
        }

        private async void AgregarPrestamo_Load(object sender, EventArgs e)
        {
            await CargarLibrosComboBox();
            await CargarLectoresComboBox();

        }

        private async Task CargarLibrosComboBox()
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
                        var listaLibros = JsonSerializer.Deserialize<List<LibroDTOSelect>>(json, options);

                        cmbLibros.DataSource = listaLibros;
                        cmbLibros.DisplayMember = "Nombre";
                        cmbLibros.ValueMember = "Codlibro";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task CargarLectoresComboBox()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Lectores";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        var listaLectores = JsonSerializer.Deserialize<List<LectorDTOSelect>>(json, options);

                        cmbLectores.DataSource = listaLectores;
                        cmbLectores.DisplayMember = "Nombre";
                        cmbLectores.ValueMember = "Idlector";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar lectores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbLibros.SelectedValue == null || cmbLectores.SelectedValue == null || string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Armamos el objeto que espera el método PostPrestamo de la API
                var nuevoPrestamo = new
                {
                    Codlibro = Convert.ToInt32(cmbLibros.SelectedValue),
                    Idlector = Convert.ToInt32(cmbLectores.SelectedValue),
                    IdEmpleado = int.Parse(txtIdEmpleado.Text.Trim()),
                    FechaDevolucionE = dtpFechaDevolucion.Value,
                    Estado = "A" // Estado activo por defecto
                };

                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Prestamos";
                    string json = JsonSerializer.Serialize(nuevoPrestamo);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("¡Préstamo registrado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        string errorContenido = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al registrar el préstamo: " + errorContenido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class LibroDTOSelect
    {
        public int Codlibro { get; set; }
        public string Nombre { get; set; }
    }

    public class LectorDTOSelect
    {
        public int Idlector { get; set; }
        public string Nombre { get; set; }
    }
}
