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
    public partial class GestionPrestamos : Form
    {
        public GestionPrestamos()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private List<PrestamoDTO> _prestamosOriginales = new List<PrestamoDTO>();
        private async void GestionPrestamos_Load(object sender, EventArgs e)
        {
            await CargarPrestamosDesdeApi();
        }

        private async Task CargarPrestamosDesdeApi()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = "https://localhost:7141/api/Prestamos";

                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // 1. Leemos el texto JSON una sola vez
                        string json = await response.Content.ReadAsStringAsync();

                        // 2. Mostramos el mensaje para inspeccionar qué datos llegaron de la API
                        MessageBox.Show("JSON recibido: " + json, "Inspección de Préstamos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3. Deserializamos el texto a nuestra lista de Préstamos
                        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                        _prestamosOriginales = JsonSerializer.Deserialize<List<PrestamoDTO>>(json, options) ?? new List<PrestamoDTO>();

                        // 4. Llenamos la tabla
                        dgvPrestamos.DataSource = null;
                        dgvPrestamos.DataSource = _prestamosOriginales;
                    }
                    else
                    {
                        MessageBox.Show("Error al descargar los préstamos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la API de préstamos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNuevoPrestamo_Click(object sender, EventArgs e)
        {
            AgregarPrestamo formPrestamo = new AgregarPrestamo();
            if (formPrestamo.ShowDialog() == DialogResult.OK)
            {
                _ = CargarPrestamosDesdeApi();
            }
        }

        private async void btReintegrar_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                
                var prestamoSeleccionado = (PrestamoDTO)dgvPrestamos.SelectedRows[0].DataBoundItem;

             
                if (prestamoSeleccionado.Estado == "R")
                {
                    MessageBox.Show("Este préstamo ya fue reintegrado anteriormente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    $"¿Estás seguro de que deseas reintegrar el préstamo con ID {prestamoSeleccionado.IdPrestamo}?",
                    "Confirmar devolución",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        using (HttpClient client = new HttpClient())
                        {
                            string url = $"https://localhost:7141/api/Prestamos/{prestamoSeleccionado.IdPrestamo}";

                            
                            var prestamoActualizado = new
                            {
                                IdPrestamo = prestamoSeleccionado.IdPrestamo,
                                FechaPrestamo = prestamoSeleccionado.FechaPrestamo,
                                FechaDevolucionE = prestamoSeleccionado.FechaDevolucionE,
                                FechaDevolucionR = DateTime.Now,
                                Estado = "R", // Cambia a Reintegrado
                                Codlibro = prestamoSeleccionado.Codlibro,
                                Idlector = prestamoSeleccionado.Idlector,
                                IdEmpleado = prestamoSeleccionado.IdEmpleado
                            };

                            string json = JsonSerializer.Serialize(prestamoActualizado);
                            var content = new StringContent(json, Encoding.UTF8, "application/json");

                            HttpResponseMessage response = await client.PutAsync(url, content);

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("¡Libro reintegrado exitosamente! El inventario ha sido actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                              
                                await CargarPrestamosDesdeApi();
                            }
                            else
                            {
                                string errorContenido = await response.Content.ReadAsStringAsync();
                                MessageBox.Show("Error al reintegrar el libro: " + errorContenido, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor, selecciona un préstamo de la tabla para reintegrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        
    }

        private void btregresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    public class PrestamoDTO
    {
        public int IdPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucionE { get; set; }
        public DateTime? FechaDevolucionR { get; set; }
        public string Estado { get; set; }
        public int Codlibro { get; set; }
        public string NombreLibro { get; set; } // Recibe el nombre del libro desde la API
        public int Idlector { get; set; }
        public string NombreLector { get; set; } // Recibe el nombre del lector desde la API
        public int IdEmpleado { get; set; }
        public JsonElement? Multa { get; set; }
    }
}
