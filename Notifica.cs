using System;
using System.ComponentModel;
using System.IO;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TimeOutino
{
    public enum TipoNotifica
    {
        [Description("Notifiche di Windows")]
        Generica,
        [Description("Frase Random")]
        Frase,
        [Description("Audio su PC")]
        AudioLocale
    }

    public abstract class Notifica : IDisposable
    {
        public TipoRestart TipoRestart { get; set; }
        public TipoNotifica Tipo { get; protected set; }
        public bool Attiva { get; protected set; }

        public abstract void start();
        public abstract void stop();

        public void Toggle()
        {
            if (Attiva)
                stop();
            else
                start();
        }


        public virtual void Dispose()
        {
        }
    }

    public class NotificaFrase : Notifica
    {
        public static string[] InitDataSet = new string[] {
                    "Il computer è come una droga: ti fa dimenticare che esiste un mondo là fuori!",
                    "Stai così tanto davanti allo schermo che il tuo corpo sta iniziando a diventare piatto come un monitor.",
                    "Fai una pausa, anche il tuo mouse ha bisogno di riposare ogni tanto!",
                    "Sai cosa è più rinfrescante della luce dello schermo? La luce del sole!",
                    "Se passi così tanto tempo davanti al computer, presto avrai bisogno di un antivirus per il tuo corpo!",
                    "Sei così abituato a stare seduto che le tue gambe hanno dimenticato come funziona camminare.",
                    "Ricordi com'era la vita prima di diventare un cyborg?",
                    "Il tuo computer ti ama, ma non come ti amerebbe un amico di carne e ossa.",
                    "Stare troppo davanti al computer è come mettere in pausa la vita reale.",
                    "Non dimenticare di sgranchirti le gambe, non vorrai mica arrugginire!",
                    "Gli alberi non crescono solo in Minecraft, esci e scopri il mondo!",
                    "Il tuo computer ti tiene compagnia, ma non può giocare a calcio con te.",
                    "A forza di stare seduto, rischi di diventare un'icona sul desktop!",
                    "Stacca gli occhi dallo schermo e prova a guardare il mondo attraverso una finestra vera, non una di Windows!",
                    "Stare troppo davanti al computer è come mangiare troppo cioccolato: prima o poi ti farà male.",
                    "Sei così vicino allo schermo che potresti finire dentro!",
                    "Dopo tanto tempo davanti al computer, stai diventando un po' troppo pixelato.",
                    "Sei così abituato a stare al computer che quando incontri persone dal vivo cerchi il tasto 'Invia'.",
                    "Perché non provi a fare una pausa e a chiedere al tuo cervello di fare un aggiornamento?",
                    "La tua vita sociale non dovrebbe dipendere solo da un cavo di rete.",
                    "Sai che c'è una funzione chiamata 'Off' sul tuo computer? Magari è il momento di usarla!",
                    "Perché non provi a sgranchirti le gambe e a fare una passeggiata? La natura ha una grafica 4K!",
                    "Non dimenticare che il mondo fuori dalla porta è più grande di qualsiasi schermo!"
        };

        public string[] DataSet { get; set; }

        private readonly SpeechSynthesizer parlante = new SpeechSynthesizer();
        private readonly Random random = new Random();

        public NotificaFrase()
        {
            Tipo = TipoNotifica.Frase;
            DataSet = Array.Empty<string>();
        }

        public override void start()
        {
            Attiva = true;
            string[] source = DataSet != null && DataSet.Length > 0 ? DataSet : InitDataSet;
            string daDire = source[random.Next(0, source.Length)];
            parlante.SpeakAsync(daDire);
        }

        public override void stop()
        {
            Attiva = false;
            parlante.SpeakAsyncCancelAll();
        }

        public override void Dispose()
        {
            parlante.Dispose();
        }
    }

    public class NotificaAudioLocale : Notifica
    {
        private WMPLib.WindowsMediaPlayer notificaCustom;

        public NotificaAudioLocale(string pathFile)
        {
            Tipo = TipoNotifica.AudioLocale;

            if (string.IsNullOrWhiteSpace(pathFile))
                throw new ArgumentException("Seleziona un file audio locale.", nameof(pathFile));

            if (!File.Exists(pathFile))
                throw new FileNotFoundException("File audio non trovato.", pathFile);

            notificaCustom = new WMPLib.WindowsMediaPlayer();
            notificaCustom.URL = pathFile;
            notificaCustom.controls.stop();
        }

        public override void start()
        {
            Attiva = true;
            if (notificaCustom != null)
            {
                notificaCustom.settings.setMode("loop", true);
                notificaCustom.controls.play();
            }
        }

        public override void stop()
        {
            Attiva = false;
            if (notificaCustom != null)
                notificaCustom.controls.stop();
        }

        public override void Dispose()
        {
            if (notificaCustom != null)
            {
                notificaCustom.controls.stop();
                notificaCustom.close();
                notificaCustom = null;
            }
        }
    }

    public class NotificaGenerica : Notifica
    {
        private readonly Timer beepTimer;

        public NotificaGenerica()
        {
            Tipo = TipoNotifica.Generica;
            beepTimer = new Timer();
            beepTimer.Interval = 3000;
            beepTimer.Tick += (s, e) => SystemSounds.Exclamation.Play();
        }

        public override void start()
        {
            Attiva = true;
            SystemSounds.Exclamation.Play();
            beepTimer.Start();
        }

        public override void stop()
        {
            Attiva = false;
            beepTimer.Stop();
        }

        public override void Dispose()
        {
            beepTimer.Stop();
            beepTimer.Dispose();
        }
    }
}
