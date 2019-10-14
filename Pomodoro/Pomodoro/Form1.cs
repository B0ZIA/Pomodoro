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
    public partial class Form1 : Form
    {
        static System.Windows.Forms.Timer currentTimer;
        static bool exitFlag = false;

        private PomodoroState state;
        private PomodoroState _steteBeforePause;

        public int currentTime = 1800;    //default 30 min
        public const int BREAK_TIME = 300;    //5 min
        public const int WORK_TIME = 1800;    //30 min

        SoundPlayer player = new SoundPlayer();


        public Form1()
        {
            InitializeComponent();

        }

        private void Tick(Object myObject, EventArgs myEventArgs)
        {
            currentTime -= 1;
            TimeSpan time = TimeSpan.FromSeconds(currentTime);
            currentTimeLabel.Text = time.ToString(@"mm\:ss");
        }

        private void StartClock(int seconds)
        {
            currentTimer = new System.Windows.Forms.Timer();
            currentTime = seconds;

            for (int i = 0; i <= seconds; i++)
            {
                if (i == seconds)
                    TimeoutSoundEffect();

                currentTimer.Tick += new EventHandler(Tick);

                // Sets the timer interval to 1 seconds.
                currentTimer.Interval = 1000;
                currentTimer.Start();

                // Runs the timer, and raises the event.
                while (exitFlag == false)
                {
                    // Processes all the events in the queue.
                    Application.DoEvents();
                }
            }
        }

        private void TimeoutSoundEffect()
        {
            player.SoundLocation = @"D:\_Application_Pomodoro\Pomodoro\Pomodoro\timeout.wav";
            player.Play();
        }

        private void Work_Click(object sender, EventArgs e)
        {
            state = PomodoroState.Work;
            SetTimeOptions(TimeOptions.SkipPauseCancel);
            StartClock(WORK_TIME);
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            state = PomodoroState.Rest;
            SetTimeOptions(TimeOptions.SkipPauseCancel);
            StartClock(BREAK_TIME);
        }

        void SetTimeOptions(TimeOptions options)
        {
            switch (options)
            {
                case TimeOptions.StartWorkOrBreak:
                    WorkOrRestPanel.Visible = true;
                    SkipPauseCancelPanel.Visible = false;
                    break;
                case TimeOptions.SkipPauseCancel:
                    WorkOrRestPanel.Visible = false;
                    SkipPauseCancelPanel.Visible = true;
                    break;
            }
        }

        enum TimeOptions
        {
            StartWorkOrBreak,
            SkipPauseCancel
        }

        enum PomodoroState
        {
            Work,
            Rest,
            Pause
        }


        private void Skip_Click(object sender, EventArgs e)
        {
            currentTimer.Stop();
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

        private void Pause_Click(object sender, EventArgs e)
        {
            if (state == PomodoroState.Rest || state == PomodoroState.Work)
            {
                currentTimer.Stop();
                _steteBeforePause = state;
                state = PomodoroState.Pause;
            }
            else if (state == PomodoroState.Pause)
            {
                currentTimer.Start();
                state = _steteBeforePause;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            SetTimeOptions(TimeOptions.StartWorkOrBreak);
            currentTimer.Stop();
        }
    }
}
