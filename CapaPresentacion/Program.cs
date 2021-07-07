using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FORM_PEDIDO());
            // Application.Run(new FORM_VENTAS());
            ///Application.Run(new FORM_COMISIONES());
            ///// Application.Run(new FORM_VENTAS());
             Application.Run(new FORM_PRINCIPAL());
        }
    }
}
