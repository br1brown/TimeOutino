using System;
using System.IO;
using System.Windows.Forms;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        public TimeOutino()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            customtimer = new CustomTimer { InTimeEvent = OnTimeEvent };
            btnconfig.Paint += OnBtnConfigPaint;
            AbilitaDoubleBuffering(btnconfig);

            BindEnumCombo(restartcomb, Enum.GetValues(typeof(TipoRestart)));
            BindEnumCombo(notifiycomb, Enum.GetValues(typeof(TipoNotifica)));

            txtFrasi.Text = string.Join(Environment.NewLine, NotificaFrase.InitDataSet);

            ControllaAggiornamenti();
        }

        private void RefreshDisplay()
        {
            if (customtimer.Running)
            {
                SetButtonImage(imgStop);
                prgrbr.Value = ClampPercentuale(customtimer.Percentage);
                statuslab.Text = customtimer.ToString();
                IconaBassa.Text = prgrbr.Value + "%";
                this.Text = "(" + IconaBassa.Text + ") - " + statuslab.Text;
                btnconfig.Invalidate();
            }
            else
            {
                if (!NotificaPartita)
                {
                    SetTabsEnabled(true);
                    SetButtonImage(imgAvvia);
                }

                statuslab.Text = "---";
                this.Text = "TimeOutino";
                prgrbr.Value = 0;
                IconaBassa.Text = "TimeOutino";
            }
        }

        private void ToggleBTNClick(object sender, EventArgs e)
        {
            bool avvia;
            if (customtimer.Running)
            {
                customtimer.Stop();
                avvia = false;
            }
            else if (NotificaPartita)
            {
                avvia = notifica.TipoRestart != TipoRestart.Mai;
                notifica.Stop();
            }
            else
            {
                notifica = BuildNotifica();
                avvia = notifica != null;
            }

            if (avvia)
                SetTimeToClock(TimeSpan.FromMinutes((double)nMinutiTot.Value));

            RefreshDisplay();
        }

        private void SceglifileEvent(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Scegli notifica",
                Filter = "WAV Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3"
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    AudioLocalePath = dlg.FileName;
                    txtAudioLocale.Text = Path.GetFileName(dlg.FileName);
                }
            }
        }

        private void CambiaTipoNotifica(object sender, EventArgs e)
        {
            if (notifiycomb.SelectedItem is TipoNotifica tipo)
            {
                panelLocal.Visible = tipo == TipoNotifica.AudioLocale;
                panelFrasi.Visible = tipo == TipoNotifica.Frase;
            }
        }

        private void RiapriDaNascosto(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            IconaBassa.Visible = false;
        }

        private void RidimensionaForm(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                IconaBassa.Visible = true;
            }
        }

        private void FormInChiusura(object sender, FormClosingEventArgs e)
        {
            if (!customtimer.Running)
                return;

            DialogResult decisione = MessageBox.Show(
                "Vuoi mantenere attivo il timer in background?", "Chiudi tutto",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            switch (decisione)
            {
                case DialogResult.Yes:
                    IconaBassa.Visible = true;
                    this.Hide();
                    e.Cancel = true;
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
