using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Notifica BuildNotifica()
        {
            try
            {
                TipoRestart restart = TipoRestart.Mai;

                foreach (TipoRestart tipor in Enum.GetValues(typeof(TipoRestart)))
                {
                    if (restartcomb.SelectedValue.ToString() == tipor.ToDescriptionString())
                        restart = tipor;
                }


                foreach (TipoNotifica tipo in Enum.GetValues(typeof(TipoNotifica)))
                {
                    if (notifiycomb.SelectedValue.ToString() == tipo.ToDescriptionString())
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
                                    DataSet = txtFrasi.Text.Split('\r'),
                                    TipoRestart = restart
                                };
                            case TipoNotifica.AudioLocale:
                                return new NotificaAudioLocale(AudioLocalePath)
                                {
                                    TipoRestart = restart
                                };
                        }
                }
                return null;
            }
            catch (Exception ee)
            {

                MessageBox.Show("Notifica: " + ee.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return null;
            }
        }

        private void StartNotify()
        {
            notifica.start();
            tabPrincipale.Focus();
            tabTutto.SelectedIndex = 0;
            if (notifica.TipoRestart == TipoRestart.Snoooze)
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
