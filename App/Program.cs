using System;
using System.Windows.Forms;
using UberFrba.Modelo;

namespace UberFrba
{
    static class Program
    {
        /// <summary>
        /// Usuario actual del sistema.
        /// </summary>

        public static Usuario user = new Usuario();

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
