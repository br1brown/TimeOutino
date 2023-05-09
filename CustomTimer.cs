using System;

namespace TimeOutino
{
    internal class CustomTimer
    {
        private System.Windows.Forms.Timer timer;
        private TimeSpan countdownClock = TimeSpan.Zero;
        private TimeSpan Starting = TimeSpan.Zero;

        public double Percentage
        {
            get
            {
                return countdownClock.TotalSeconds / Starting.TotalSeconds * 100;
            }
        }

        public bool Running
        {
            get
            {
                return timer.Enabled;
            }
        }

        public override string ToString()
        {
            return countdownClock.ToString(@"hh\:mm\:ss");
        }
        public CustomTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = (int)TimeSpan.FromSeconds(1).TotalMilliseconds;
            timer.Tick += OnTimeEvent;

            InTimeEvent = (d) => { };
        }

        /// <summary>
        /// Bool - is finished
        /// </summary>
        public Action<bool> InTimeEvent { get; set; }

        private void OnTimeEvent(object sender, EventArgs e)
        {
            countdownClock = countdownClock.Subtract(TimeSpan.FromMilliseconds(timer.Interval));
            bool ending = countdownClock.TotalMilliseconds <= 0;

            if (ending)
            {
                countdownClock = TimeSpan.Zero;
                timer.Stop();
            }
            this.InTimeEvent(ending);

        }

        public void StartTimer(TimeSpan time)
        {
            countdownClock = time;
            Starting = time;
            
            if (!Running) timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

    }
}
