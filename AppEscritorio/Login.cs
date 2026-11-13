using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace AppEscritorio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioForm = txUsuario.Text;
            string contrasenaForm = txContraseña.Text;

            // 1. Validar que no estén vacíos en la pantalla
            if (string.IsNullOrWhiteSpace(usuarioForm) || string.IsNullOrWhiteSpace(contrasenaForm))
            {
                MessageBox.Show("Por favor, ingresa tu usuario y contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    
                    string apiUrl = "https://localhost:7141/api/Login/iniciar-sesion";

                    var credenciales = new
                    {
                        Usuario = usuarioForm,
                        Clave = contrasenaForm
                    };
                    string json = JsonSerializer.Serialize(credenciales);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string respuesta = await response.Content.ReadAsStringAsync();

                        MessageBox.Show("¡Login exitoso! Bienvenido.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Menu menuForm = new Menu();
                        menuForm.FormClosed += (s, args) => this.Close();
                        menuForm.Show();
                        this.Hide();
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error inesperado al iniciar sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con la API: " + ex.Message, "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
