using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        CustomTimer customtimer;
        Notifica notifica;

        private string AudioLocalePath = null;

        bool NotificaPartita
        {
            get
            {
                if (notifica != null)
                    return notifica.Attiva;
                return false;
            }
        }

        private TipoRestart GetSelectedRestartType()
        {
            if (restartcomb.SelectedValue is TipoRestart restart)
                return restart;

            return TipoRestart.Mai;
        }

        private TipoNotifica GetSelectedNotificaType()
        {
            if (notifiycomb.SelectedValue is TipoNotifica tipo)
                return tipo;

            return TipoNotifica.Generica;
        }

        private string[] BuildFrasiDataSet()
        {
            return txtFrasi.Text
                .Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .ToArray();
        }

        private Notifica BuildNotifica()
        {
            var restart = GetSelectedRestartType();
            var tipo = GetSelectedNotificaType();

            try
            {
                switch (tipo)
                {
                    case TipoNotifica.Generica:
                        return new NotificaGenerica()
                        {
                            TipoRestart = restart
                        };
                    case TipoNotifica.Frase:
                        return new NotificaFrase()
                        {
                            DataSet = BuildFrasiDataSet(),
                            TipoRestart = restart
                        };
                    case TipoNotifica.AudioLocale:
                        return new NotificaAudioLocale(AudioLocalePath)
                        {
                            TipoRestart = restart
                        };
                    default:
                        return null;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Impostazioni non valide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Audio non trovato: " + ex.FileName, "Errore file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Errore notifica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void StartNotify()
        {
            if (notifica == null)
                return;

            notifica.start();
            tabPrincipale.Focus();
            tabTutto.SelectedIndex = 0;
            if (notifica.TipoRestart == TipoRestart.Snooze)
                btnconfig.BackgroundImage = Properties.Resources.snooze;
            else
                btnconfig.BackgroundImage = Properties.Resources.OK;

            RiapriDaNascosto(null, null);
        }

        private void OnTimeEvent(bool Finito)
        {
            if (Finito) StartNotify();

            RefreshDisplay();
        }

        private void SetTimeToClock(TimeSpan time)
        {
            btnconfig.BackgroundImage = Properties.Resources.Stop;
            customtimer.StartTimer(time);

            RefreshDisplay();

            foreach (TabPage tab in tabTutto.TabPages)
            {
                tab.Enabled = false;
            }
            (tabTutto.TabPages[0] as TabPage).Enabled = true;

        }
    }
}
