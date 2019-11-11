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

        PomodoroState state;
        PomodoroState _steteBeforePause;

        static PomodoroNavigation pomodoroNavigation;



        public PomodoroTimer(PomodoroNavigation _timeManager)
        {
            Instance = this;
            pomodoroNavigation = _timeManager;
        }

        public override void Tick(Object myObject, EventArgs myEventArgs)
        {
            base.Tick(myObject, myEventArgs);
        }

        public override void Timeout()
        {
            if (state == PomodoroState.Work)
            {
                Rest();
            }
            else if (state == PomodoroState.Rest)
            {
                //MessageBox.Show("Time to work!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pomodoro.Instance.Visible = true;
            }

            base.Timeout();
            Skip();
        }

        public override void LastMinute()
        {
            //TODO: Sound Effect
            base.LastMinute();
        }

        public void Work()
        {
            state = PomodoroState.Work;
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringCountdown);
            StartClock(WORK_TIME);
        }

        public void Rest()
        {
            TimeoutScreen timeout = new TimeoutScreen();
            timeout.Show();
            if (clock != null)
                clock.Stop();
            //MessageBox.Show("Time to rest!", "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            state = PomodoroState.Rest;
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringCountdown);
            StartClock(BREAK_TIME);
        }

        public void Skip()
        {
            clock.Stop();

            switch (state)
            {
                case PomodoroState.Work:
                    Rest();
                    break;
                case PomodoroState.Rest:
                    Work();
                    break;
                case PomodoroState.Pause:
                    if (_steteBeforePause == PomodoroState.Work)
                        Rest();
                    else if (_steteBeforePause == PomodoroState.Rest)
                        Work();
                    break;
                default:
                    break;
            }
        }

        public void Pause()
        {
            if (state == PomodoroState.Rest || state == PomodoroState.Work)
            {
                clock.Stop();
                _steteBeforePause = state;
                state = PomodoroState.Pause;
            }
            else if (state == PomodoroState.Pause)
            {
                clock.Start();
                state = _steteBeforePause;
            }
        }

        public void Cancel()
        {
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringIdle);
            clock.Stop();
            Pomodoro.Instance.GetTimeLabel().Text = "00:00";
        }

        enum PomodoroState
        {
            Work,
            Rest,
            Pause
        }
    }
}
