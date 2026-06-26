using System;
using System.ComponentModel;
using System.IO;
using System.Speech.Synthesis;
using NAudio.Wave;

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

    public abstract class Notifica
    {
        /// <summary>Comportamento del timer dopo che la notifica è scattata.</summary>
        public TipoRestart TipoRestart { get; set; }

        /// <summary>Tipo concreto della notifica.</summary>
        public TipoNotifica Tipo { get; protected set; }

        /// <summary>Indica se la notifica è attualmente in riproduzione.</summary>
        public bool Attiva { get; protected set; }

        public abstract void Start();
        public abstract void Stop();

        public void Toggle()
        {
            if (Attiva)
                Stop();
            else
                Start();
        }
    }

    /// <summary>Notifica vocale che pronuncia una frase casuale tra quelle configurate.</summary>
    public class NotificaFrase : Notifica
    {
        public static readonly string[] InitDataSet =
        {
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

        // Un'unica istanza condivisa: creare un nuovo Random a ogni notifica può produrre
        // lo stesso valore se le chiamate sono ravvicinate (stesso seed temporale).
        private static readonly Random Random = new Random();

        private readonly SpeechSynthesizer parlante = new SpeechSynthesizer();

        /// <summary>Frasi tra cui scegliere; se vuoto si ricade su <see cref="InitDataSet"/>.</summary>
        public string[] DataSet { get; set; }

        public NotificaFrase()
        {
            Tipo = TipoNotifica.Frase;
        }

        public override void Start()
        {
            Attiva = true;

            string[] frasi = (DataSet != null && DataSet.Length > 0) ? DataSet : InitDataSet;
            string daDire = frasi[Random.Next(frasi.Length)];

            parlante.SpeakAsync(daDire);
        }

        public override void Stop()
        {
            Attiva = false;
            parlante.SpeakAsyncCancelAll();
        }
    }

    /// <summary>
    /// Notifica che riproduce in loop un file audio (wav/mp3) presente sul PC,
    /// tramite NAudio (nessuna dipendenza COM da Windows Media Player).
    /// </summary>
    public class NotificaAudioLocale : Notifica
    {
        private readonly string pathFile;

        private WaveOutEvent output;
        private LoopStream loop;

        public NotificaAudioLocale(string pathFile)
        {
            Tipo = TipoNotifica.AudioLocale;

            if (string.IsNullOrEmpty(pathFile) || !File.Exists(pathFile))
                throw new FileNotFoundException("File audio non trovato.", pathFile);

            this.pathFile = pathFile;
        }

        public override void Start()
        {
            Stop();
            Attiva = true;

            loop = new LoopStream(new AudioFileReader(pathFile));
            output = new WaveOutEvent();
            output.Init(loop);
            output.Play();
        }

        public override void Stop()
        {
            Attiva = false;

            output?.Dispose();
            output = null;

            loop?.Dispose(); // chiude anche l'AudioFileReader sottostante
            loop = null;
        }
    }

    /// <summary>
    /// Avvolge un <see cref="WaveStream"/> e lo fa ripartire da capo a fine traccia,
    /// così la riproduzione va in loop continuo.
    /// </summary>
    internal class LoopStream : WaveStream
    {
        private readonly WaveStream source;

        public LoopStream(WaveStream source)
        {
            this.source = source;
        }

        public override WaveFormat WaveFormat => source.WaveFormat;
        public override long Length => source.Length;

        public override long Position
        {
            get => source.Position;
            set => source.Position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalRead = 0;

            while (totalRead < count)
            {
                int read = source.Read(buffer, offset + totalRead, count - totalRead);
                if (read == 0)
                {
                    if (source.Position == 0)
                        break; // sorgente vuota: evita loop infinito a vuoto
                    source.Position = 0; // riavvolge e continua
                }
                totalRead += read;
            }

            return totalRead;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                source.Dispose();
            base.Dispose(disposing);
        }
    }

    /// <summary>Notifica predefinita basata sul suono di allarme di Windows.</summary>
    public class NotificaGenerica : NotificaAudioLocale
    {
        public NotificaGenerica() : base(@"C:\Windows\Media\Alarm01.wav")
        {
            Tipo = TipoNotifica.Generica;
        }
    }
}
