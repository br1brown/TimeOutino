using System;
using System.IO;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TimeOutino
{
    public partial class TimeOutino : Form
    {
        public TimeOutino()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customtimer = new CustomTimer();
            customtimer.InTimeEvent = OnTimeEvent;
            restartcomb.DataSource = UtilsEnums.TipoRestart_sz;
            notifiycomb.DataSource = UtilsEnums.TipoNotifica_sz;

            txtFrasi.Text = string.Join("\r\n", NotificaFrase.InitDataSet);
        }

        private void RefreshDisplay()
        {

            if (customtimer.Running)
            {
                btnconfig.BackgroundImage = Properties.Resources.Stop;
                double percentuale = customtimer.Percentage;
                prgrbr.Value = (int)Math.Round(percentuale);

                statuslab.Text = customtimer.ToString();
                IconaBassa.Text = prgrbr.Value + "%";

                this.Text = "(" + IconaBassa.Text + ") - " + statuslab.Text;
            }
            else
            {
                if (!NotificaPartita)
                {
                    foreach (TabPage tab in tabTutto.TabPages)
                    {
                        tab.Enabled = true;
                    }
                    btnconfig.BackgroundImage = Properties.Resources.Avvia;
                }

                statuslab.Text = "---";
                this.Text = "TimeOutino";
                prgrbr.Value = 0;
                IconaBassa.Text = "TimeOutino";
            }
        }

        private void ToggleBTNClick(object sender, EventArgs e)
        {
            bool avvia = true;
            if (customtimer.Running)
            {
                avvia = false;
                customtimer.Stop();
            }
            else if (NotificaPartita)
            {
                avvia = notifica.TipoRestart != TipoRestart.Mai;
                notifica.stop();
            }
            else
            {
                notifica = BuildNotifica();
                avvia = (notifica != null);
            }
            if (avvia)
                SetTimeToClock(TimeSpan.FromMinutes(decimal.ToDouble(nMinutiTot.Value)));

            RefreshDisplay();
        }

        private void SceglifileEvent(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Title = "Scegli notifica",
                Filter = "WAV Files (*.wav)|*.wav|MP3 Files (*.mp3)|*.mp3"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                AudioLocalePath = dlg.FileName;
                txtAudioLocale.Text = Path.GetFileName(dlg.FileName);
            }
        }

        private void CambiaTipoNotifica(object sender, EventArgs e)
        {
            panelLocal.Visible = notifiycomb.SelectedItem.ToString() == TipoNotifica.AudioLocale.ToDescriptionString();
            panelFrasi.Visible = notifiycomb.SelectedItem.ToString() == TipoNotifica.Frase.ToDescriptionString();
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
            if (customtimer.Running)
            {
                var decisione = MessageBox.Show("Vuoi mantenere attivo il timer in background?", "Chiudi tutto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                switch (decisione)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        IconaBassa.Visible = true;
                        this.Hide();
                        goto case System.Windows.Forms.DialogResult.Cancel;
                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
