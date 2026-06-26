using System;
using System.Windows.Forms;

namespace TimeOutino
{
    /// <summary>
    /// Timer a conto alla rovescia con tick al secondo, basato su <see cref="Timer"/>.
    /// </summary>
    internal class CustomTimer
    {
        private readonly Timer timer;
        private TimeSpan remaining = TimeSpan.Zero;
        private TimeSpan total = TimeSpan.Zero;

        public CustomTimer()
        {
            timer = new Timer
            {
                Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds
            };
            timer.Tick += OnTick;

            InTimeEvent = isFinished => { };
        }

        /// <summary>
        /// Invocato a ogni tick; il parametro indica se il conto alla rovescia è arrivato a zero.
        /// </summary>
        public Action<bool> InTimeEvent { get; set; }

        public bool Running => timer.Enabled;

        /// <summary>Percentuale di tempo ancora da scorrere (0-100).</summary>
        public double Percentage =>
            total.TotalSeconds <= 0 ? 0 : remaining.TotalSeconds / total.TotalSeconds * 100;

        public override string ToString() => remaining.ToString(@"hh\:mm\:ss");

        public void StartTimer(TimeSpan time)
        {
            remaining = time;
            total = time;

            if (!Running)
                timer.Start();
        }

        public void Stop() => timer.Stop();

        private void OnTick(object sender, EventArgs e)
        {
            remaining = remaining.Subtract(TimeSpan.FromMilliseconds(timer.Interval));
            bool finished = remaining.TotalMilliseconds <= 0;

            if (finished)
            {
                remaining = TimeSpan.Zero;
                timer.Stop();
            }

            InTimeEvent(finished);
        }
    }
}
