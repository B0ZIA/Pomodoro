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
    public partial class Pomodoro : Form
    {
        public static TimeNavigationPanel timeManager;
        public static PomodoroTimer pomodoroTimer;
        public static Label TimeLabel;


        public Pomodoro()
        {
            InitializeComponent();
            timeManager = new TimeNavigationPanel(Navigation);
            pomodoroTimer = new PomodoroTimer(timeManager);
            timeManager.SetPanel(TimeNavigationPanel.Possibilities.DuringIdle);
            TimeLabel = currentTimeLabel;
        }

        //SoundPlayer player = new SoundPlayer();
        //private void TimeoutSoundEffect()
        //{
        //    player.SoundLocation = @"D:\_Application_Pomodoro\Pomodoro\Pomodoro\timeout.wav";
        //    player.Play();
        //}
    }
}
