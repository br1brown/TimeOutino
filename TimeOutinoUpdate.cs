using System;
using System.Windows.Forms;
using Velopack;
using Velopack.Sources;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        private const string RepoUrl = "https://github.com/br1brown/TimeOutino";

        /// <summary>
        /// Controlla in background se c'è una versione più recente pubblicata nelle
        /// GitHub Releases; se sì la scarica e propone di riavviare per aggiornare.
        /// In esecuzione "non installata" (es. avvio da Visual Studio) non fa nulla.
        /// </summary>
        private async void ControllaAggiornamenti()
        {
            try
            {
                var mgr = new UpdateManager(new GithubSource(RepoUrl, null, false));

                if (!mgr.IsInstalled)
                    return;

                UpdateInfo aggiornamento = await mgr.CheckForUpdatesAsync();
                if (aggiornamento == null)
                    return;

                await mgr.DownloadUpdatesAsync(aggiornamento);

                DialogResult scelta = MessageBox.Show(
                    "È disponibile una nuova versione di TimeOutino.\nVuoi aggiornare e riavviare ora?",
                    "Aggiornamento disponibile",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (scelta == DialogResult.Yes)
                    mgr.ApplyUpdatesAndRestart(aggiornamento);
            }
            catch
            {
                // Offline, nessuna release, o errore di rete: l'aggiornamento è
                // opzionale, quindi ignoriamo silenziosamente.
            }
        }
    }
}
