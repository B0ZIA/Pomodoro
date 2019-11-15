using System;

namespace Pomodoro
{
    public abstract class Timer
    {
        private const int LAST_TIME_BEFORE_TIMEOUT = 60;

        protected System.Windows.Forms.Timer clock;
        protected int currentTime;



        protected void StartClock(int millisecond)
        {
            if (clock != null)
                clock.Stop();

            clock = new System.Windows.Forms.Timer();
            currentTime = millisecond;

            clock.Tick += new EventHandler(Tick);

            clock.Interval = 1000;
            clock.Start();
        }

        public virtual void Tick(Object myObject, EventArgs myEventArgs)
        {
            currentTime -= 1;

            if (currentTime == LAST_TIME_BEFORE_TIMEOUT)
                BeforeTimeout();

            if (currentTime == 0)
                Timeout();
        }

        public abstract void BeforeTimeout();

        public abstract void Timeout();
    }
}
