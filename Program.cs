using System;
using System.Windows.Forms;
using Velopack;

namespace TimeOutino
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Deve essere la primissima cosa eseguita: gestisce i ganci di
            // installazione/aggiornamento di Velopack (install, update, uninstall).
            VelopackApp.Build().Run();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TimeOutino());
        }
    }
}
