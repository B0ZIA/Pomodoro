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

        static TimeNavigationPanel timeManager;

        public override void Tick(Object myObject, EventArgs myEventArgs)
        {
            base.Tick(myObject, myEventArgs);
            //Pomodoro.TimeLabel.Text = currentTime.ToString(@"mm\:ss");
        }

        public PomodoroTimer(TimeNavigationPanel _timeManager)
        {
            Instance = this;
            timeManager = _timeManager;
        }

        public void Work()
        {
            state = PomodoroState.Work;
            timeManager.SetPanel(TimeNavigationPanel.Possibilities.DuringCountdown);
            StartClock(WORK_TIME);
        }

        public void Rest()
        {
            state = PomodoroState.Rest;
            timeManager.SetPanel(TimeNavigationPanel.Possibilities.DuringCountdown);
            StartClock(BREAK_TIME);
        }

        public void Skip()
        {
            clock.Stop();

            switch (state)
            {
                case PomodoroState.Work:
                    state = PomodoroState.Rest;
                    StartClock(BREAK_TIME);
                    break;
                case PomodoroState.Rest:
                    state = PomodoroState.Work;
                    StartClock(WORK_TIME);
                    break;
                case PomodoroState.Pause:
                    if (_steteBeforePause == PomodoroState.Work)
                        Rest();
                    break;
                default:
                    break;
            }

            if (state == PomodoroState.Work)
            {
                state = PomodoroState.Rest;
                StartClock(BREAK_TIME);
            }
            else if (state == PomodoroState.Rest)
            {
                state = PomodoroState.Work;
                StartClock(WORK_TIME);
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
            timeManager.SetPanel(TimeNavigationPanel.Possibilities.DuringIdle);
            clock.Stop();
            Pomodoro.TimeLabel.Text = "00:00";
        }

        enum PomodoroState
        {
            Work,
            Rest,
            Pause
        }
    }
}
