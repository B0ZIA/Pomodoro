using System;

namespace Pomodoro
{
    public class PomodoroTimer : Timer
    {
        public const int BREAK_TIME = 300;    //5 min
        public const int WORK_TIME = 1800;    //30 min

        private readonly Pomodoro pomodoro;
        private readonly PomodoroNavigation pomodoroNavigation;

        private State state;
        private State stateBeforeLastPause;



        public PomodoroTimer(Pomodoro pomodoro)
        {
            this.pomodoro = pomodoro;

            pomodoroNavigation = new PomodoroNavigation(this.pomodoro.BottomPanel, this);

        }

        public override void Tick(object myObject, EventArgs myEventArgs)
        {
            TimeSpan time = TimeSpan.FromSeconds(currentTime);
            pomodoro.SetTimeLabel(time.ToString(@"mm\:ss"));

            if (TimeoutScreen.time != null)
            {
                TimeoutScreen.time.Text = time.ToString(@"mm\:ss");
            }

            base.Tick(myObject, myEventArgs);
        }

        public override void Timeout()
        {
            if (state == State.Rest)
            {
                if (TimeoutScreen.Instance != null)
                    TimeoutScreen.Instance.Close();
            }

            Skip();
        }

        public override void BeforeTimeout()
        {
            //TODO: Sound Effect
        }

        public void Work()
        {
            pomodoro.Visible = true;
            state = State.Work;
            pomodoroNavigation.SetPanel(PomodoroNavigation.Possibilities.DuringCountdown);
            StartClock(WORK_TIME);
        }

        public void Rest()
        {
            TimeoutScreen timeout = new TimeoutScreen(pomodoro);
            timeout.Show();

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
            pomodoro.SetTimeLabel();
        }

        enum State
        {
            Work,
            Rest,
            Pause
        }
    }
}
