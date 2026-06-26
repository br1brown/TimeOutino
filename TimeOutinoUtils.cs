using System;
using System.Linq;
using System.Windows.Forms;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        private CustomTimer customtimer;
        private Notifica notifica;

        private string AudioLocalePath;

        // Immagini di stato del bottone, caricate una sola volta: Properties.Resources
        // restituisce un nuovo Bitmap a ogni accesso, quindi le mettiamo in cache per
        // evitare allocazioni inutili (e poter assegnare l'immagine solo quando cambia).
        private readonly System.Drawing.Image imgAvvia = Properties.Resources.Avvia;
        private readonly System.Drawing.Image imgStop = Properties.Resources.Stop;
        private readonly System.Drawing.Image imgSnooze = Properties.Resources.snooze;
        private readonly System.Drawing.Image imgOK = Properties.Resources.OK;

        private void SetButtonImage(System.Drawing.Image img)
        {
            if (btnconfig.BackgroundImage != img)
                btnconfig.BackgroundImage = img;
        }

        private bool NotificaPartita => notifica != null && notifica.Attiva;

        /// <summary>
        /// Popola una ComboBox con i valori di un enum mostrandone la descrizione;
        /// <c>SelectedItem</c> restituirà direttamente il valore enum selezionato.
        /// </summary>
        private static void BindEnumCombo(ComboBox combo, Array enumValues)
        {
            combo.Format += (sender, e) => e.Value = ((Enum)e.ListItem).ToDescriptionString();
            combo.DataSource = enumValues;
        }

        private void SetTabsEnabled(bool enabled)
        {
            foreach (TabPage tab in tabTutto.TabPages)
                tab.Enabled = enabled;
        }

        private static int ClampPercentuale(double percentuale)
        {
            int value = (int)Math.Round(percentuale);
            return Math.Min(100, Math.Max(0, value));
        }

        private Notifica BuildNotifica()
        {
            try
            {
                var restart = (TipoRestart)restartcomb.SelectedItem;
                var tipo = (TipoNotifica)notifiycomb.SelectedItem;

                switch (tipo)
                {
                    case TipoNotifica.Generica:
                        return new NotificaGenerica { TipoRestart = restart };

                    case TipoNotifica.Frase:
                        return new NotificaFrase
                        {
                            DataSet = txtFrasi.Lines.Where(l => !string.IsNullOrWhiteSpace(l)).ToArray(),
                            TipoRestart = restart
                        };

                    case TipoNotifica.AudioLocale:
                        return new NotificaAudioLocale(AudioLocalePath) { TipoRestart = restart };

                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Notifica: " + ex.Message, "Errore",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void StartNotify()
        {
            notifica.Start();
            tabPrincipale.Focus();
            tabTutto.SelectedIndex = 0;

            SetButtonImage(notifica.TipoRestart == TipoRestart.Snooze ? imgSnooze : imgOK);

            RiapriDaNascosto(null, null);
        }

        private void OnTimeEvent(bool finito)
        {
            if (finito)
                StartNotify();

            RefreshDisplay();
        }

        private void SetTimeToClock(TimeSpan time)
        {
            SetButtonImage(imgStop);
            customtimer.StartTimer(time);

            RefreshDisplay();

            SetTabsEnabled(false);
            tabTutto.TabPages[0].Enabled = true;
        }
    }
}
