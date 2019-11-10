using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pomodoro
{
    public class Timer
    {
        protected static System.Windows.Forms.Timer clock;
        private int _currentTime = 1800;    //default 30 min
        private static bool exitFlag = false;

        

        public virtual void Tick(Object myObject, EventArgs myEventArgs)
        {
            _currentTime -= 1;
            TimeSpan time = TimeSpan.FromSeconds(_currentTime);
            Pomodoro.Instance.GetTimeLabel().Text = time.ToString(@"mm\:ss");

            if (TimeoutScreen.time != null)
            {
                TimeoutScreen.time.Text = time.ToString(@"mm\:ss");

                if (_currentTime == 0)
                    TimeoutScreen.Timeout += TimeoutScreen.Instance.Quit();
            }

            if (_currentTime == 60)
                LastMinute();

            if (_currentTime == 0)
                Timeout();
        }

        public virtual void Timeout()
        {
            ;
        }

        public virtual void LastMinute()
        {
            ;
        }

        protected void StartClock(int seconds)
        {
            if (clock != null)
                clock.Stop();
            clock = new System.Windows.Forms.Timer();
            _currentTime = seconds;

            for (int i = 0; i <= seconds; i++)
            {
                clock.Tick += new EventHandler(Tick);

                clock.Interval = 1;
                clock.Start();

                while (exitFlag == false)
                {
                    Application.DoEvents();
                }
            }
        }
    }
}
