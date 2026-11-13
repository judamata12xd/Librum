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

    public partial class Vista : Form
    {
        public Vista()
        {
            InitializeComponent();
        }

        private List<HistorialDTO> _historialCompleto = new List<HistorialDTO>();

        private async void Vista_Load(object sender, EventArgs e)
        {
            await CargarHistorialDesdeApi();
        }

        private async Task CargarHistorialDesdeApi()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Historial";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Leemos el contenido
                        string json = await response.Content.ReadAsStringAsync();

                        // 1. Mostrar qué llegó exactamente de la API
                        MessageBox.Show("Datos recibidos: \n" + json.Substring(0, Math.Min(json.Length, 500)), "Inspección", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        _historialCompleto = JsonSerializer.Deserialize<List<HistorialDTO>>(json, options) ?? new List<HistorialDTO>();

                        dgvHistorial.DataSource = null;
                        dgvHistorial.DataSource = _historialCompleto;
                    }
                    else
                    {
                        // 2. Si la API falla, mostramos el código de error y el mensaje
                        string errorContenido = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"La API respondió con error ({response.StatusCode}): \n{errorContenido}", "Error de API", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // 3. Si hay un error de conversión (JSON) o de red, lo capturamos aquí
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        public class HistorialDTO
        {
            public string DocumentoLector { get; set; }
            public string NombreLector { get; set; }
            public string TipoLector { get; set; }
            public int CodigoLibro { get; set; }
            public string NombreLibro { get; set; }
            public DateTime FechaPrestamo { get; set; }
            public DateTime FechaEsperada { get; set; }
            public string EstadoPrestamo { get; set; }
        }
    }

