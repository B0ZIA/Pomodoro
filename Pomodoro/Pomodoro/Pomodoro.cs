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
        private readonly PomodoroTimer pomodoroTimer;
        private readonly PomodoroNotifyIcon pomodoroNotifyIcon;
        public Panel BottomPanel { get { return Navigation; } }


        public Pomodoro()
        {
            InitializeComponent();
            pomodoroTimer = new PomodoroTimer(this);
            pomodoroNotifyIcon = new PomodoroNotifyIcon(notifyIcon, this);
        }

        public void SetTimeLabel(string text = "00:00")
        {
            currentTimeLabel.Text = text;
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
            Close();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
