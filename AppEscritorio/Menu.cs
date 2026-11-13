using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ingresarPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reintegrarLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vista Formbusqueda = new Vista();
            Formbusqueda.ShowDialog();
        }

        private void gbMenu_Enter(object sender, EventArgs e)
        {

        }

        private void busquedaLibrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaLibros formBusqueda = new BusquedaLibros();
            formBusqueda.ShowDialog();
        }

        private void prestamoDeLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPrestamos formBusqueda = new GestionPrestamos();
            formBusqueda.ShowDialog();
        }
    }
}
