using System;
using System.Windows.Forms;

namespace AppEscritorio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Aquí le indicamos que el primer formulario en abrirse será el Login
            Application.Run(new Login());
        }
    }
}