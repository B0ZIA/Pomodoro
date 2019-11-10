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
        public static Pomodoro Instance;

        private readonly PomodoroTimer pomodoroTimer;
        private readonly PomodoroNavigation pomodoroNavigation;
        private readonly PomodoroNotifyIcon pomodoroNotifyIcon;



        public Label GetTimeLabel()
        {
            return currentTimeLabel;
        }

        public Pomodoro()
        {
            if (Instance == null)
                Instance = this;
            else
                Application.Exit();

            InitializeComponent();

            pomodoroNavigation = new PomodoroNavigation(Navigation);
            pomodoroTimer = new PomodoroTimer(pomodoroNavigation);
            pomodoroNotifyIcon = new PomodoroNotifyIcon(notifyIcon);
        }

        public void ShowToTaskbar()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                pomodoroNotifyIcon.Show();
            }
        }

        private void Pomodoro_Resize(object sender, EventArgs e)
        {
            ShowToTaskbar();
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //SoundPlayer player = new SoundPlayer();
        //private void TimeoutSoundEffect()
        //{
        //    player.SoundLocation = @"D:\_Application_Pomodoro\Pomodoro\Pomodoro\timeout.wav";
        //    player.Play();
        //}
    }
}
