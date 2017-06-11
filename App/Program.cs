using System;
using System.Windows.Forms;
using UberFrba.Modelo;
using UberFrba.Logueo;
using System.Configuration;

namespace UberFrba
{
    static class Program
    {
        /// <summary>
        /// Usuario actual del sistema.
        /// </summary>

        public static Usuario user = new Usuario();

        // Porcentaje de Rendición para los choferes.
        public static decimal pcjRend;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
 
        [STAThread]
        static void Main()
        {
            /*var culture = new System.Globalization.CultureInfo("en-US");
            System.Globalization.CultureInfo.DefaultThreadCurrentCulture = culture;
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = culture;*/
            pcjRend = Convert.ToDecimal(ConfigurationManager.AppSettings["pcjRend"]
                                        ,new System.Globalization.CultureInfo("en-US"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
