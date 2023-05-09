using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace TimeOutino
{

    public enum TipoNotifica
    {
        //[Description("Link Youtube")]
        //YT,
        [Description("Notifiche di Windows")]
        Generica,
        [Description("Frase Random")]
        Frase,
        [Description("Audio su PC")]
        AudioLocale
    }

    abstract public class Notifica
    {
        public TipoRestart TipoRestart;
        public TipoNotifica Tipo;
        public bool Attiva;

        abstract public void start();
        abstract public void stop();

        public void Toogle()
        {
            if (Attiva)
                stop();
            else
                start();
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

        SpeechSynthesizer Parlante = new SpeechSynthesizer();
        public NotificaFrase()
        {
            Tipo = TipoNotifica.Frase;
        }

        public override void start()
        {
            Attiva = true;
            Random random = new Random();
            string dadire;
            if (DataSet.Length > 0)
            {
                int start2 = random.Next(0, DataSet.Length);
                dadire = DataSet[start2];
            }
            else
            {
                int start2 = random.Next(0, InitDataSet.Length);
                dadire = InitDataSet[start2];
            }
            Parlante.SpeakAsync(dadire);
        }

        public override void stop()
        {
            Attiva = false;
            Parlante.SpeakAsyncCancelAll();
        }
    }


    public class NotificaAudioLocale : Notifica
    {
        WMPLib.WindowsMediaPlayer NotificaCustom = null;
        public NotificaAudioLocale(string PathFile)
        {
            Tipo = TipoNotifica.AudioLocale;

            if (!File.Exists(PathFile))
                throw new Exception("File non trovato!");

            NotificaCustom = new WMPLib.WindowsMediaPlayer();
            NotificaCustom.URL = PathFile;
            NotificaCustom.controls.stop(); //parte da solo ok ??
        }

        public override void start()
        {
            Attiva = true;
            if (NotificaCustom != null)
            {
                NotificaCustom.settings.setMode("loop", true);
                NotificaCustom.controls.play();
            }
        }

        public override void stop()
        {
            Attiva = false;
            if (NotificaCustom != null) NotificaCustom.controls.stop();
        }
    }

    public class NotificaGenerica : NotificaAudioLocale
    {
        public NotificaGenerica(): base(@"C:\Windows\Media\Alarm01.wav")
        {
            Tipo = TipoNotifica.Generica;
        }
    }
}
