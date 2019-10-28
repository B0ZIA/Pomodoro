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
        public int currentTime = 1800;    //default 30 min
        static bool exitFlag = false;


        public virtual void Tick(Object myObject, EventArgs myEventArgs)
        {
            currentTime -= 1;
            TimeSpan time = TimeSpan.FromSeconds(currentTime);
            Pomodoro.TimeLabel.Text = time.ToString(@"mm\:ss");
        }

        protected void StartClock(int seconds)
        {
            clock = new System.Windows.Forms.Timer();
            currentTime = seconds;

            for (int i = 0; i <= seconds; i++)
            {
                clock.Tick += new EventHandler(Tick);

                clock.Interval = 1000;
                clock.Start();

                while (exitFlag == false)
                {
                    Application.DoEvents();
                }
            }
        }
    }
}
