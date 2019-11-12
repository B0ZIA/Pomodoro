using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pomodoro
{
    public class PomodoroTimer : Timer
    {
        public static PomodoroTimer Instance;
        public const int BREAK_TIME = 300;    //5 min
        public const int WORK_TIME = 1800;    //30 min

        State state;
        State stateBeforeLastPause;

        static PomodoroNavigation pomodoroNavigation;



        public PomodoroTimer(PomodoroNavigation pomodoroNavigation)
        {
            Instance = this;
            PomodoroTimer.pomodoroNavigation = pomodoroNavigation;
        }

        public override void Timeout()
        {
            Skip();
        }

        public override void LastMinute()
        {
            //TODO: Sound Effect
        }

        public void Work()
        {
            Pomodoro.Instance.Visible = true;
            state = State.Work;
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringCountdown);
            StartClock(WORK_TIME);
        }

        public void Rest()
        {
            TimeoutScreen timeout = new TimeoutScreen();
            timeout.Show();
            if (clock != null)
                clock.Stop();

            state = State.Rest;
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringCountdown);
            StartClock(BREAK_TIME);
        }

        public void Skip()
        {
            clock.Stop();

            switch (state)
            {
                case State.Work:
                    Rest();
                    break;
                case State.Rest:
                    Work();
                    break;
                case State.Pause:
                    if (stateBeforeLastPause == State.Work)
                        Rest();
                    else if (stateBeforeLastPause == State.Rest)
                        Work();
                    break;
                default:
                    break;
            }
        }

        public void Pause()
        {
            if (state == State.Rest || state == State.Work)
            {
                clock.Stop();
                stateBeforeLastPause = state;
                state = State.Pause;
            }
            else if (state == State.Pause)
            {
                clock.Start();
                state = stateBeforeLastPause;
            }
        }

        public void Cancel()
        {
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringIdle);
            clock.Stop();
            Pomodoro.Instance.GetTimeLabel().Text = "00:00";
        }

        enum State
        {
            Work,
            Rest,
            Pause
        }
    }
}
