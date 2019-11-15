using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    class PomodoroNotifyIcon
    {
        private NotifyIcon notifyIcon;
        private Pomodoro pomodoro;


        public PomodoroNotifyIcon(NotifyIcon notifyIcon, Pomodoro pomodoro)
        {
            this.notifyIcon = notifyIcon;
            this.pomodoro = pomodoro;

            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, pomodoro.Exit);
            this.notifyIcon.MouseDoubleClick += MouseDoubleClick;
        }

        public void Show()
        {
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(2, "Pomodoro", "Program counts down in the background!", ToolTipIcon.Info);
        }

        public void Hide()
        {
            notifyIcon.Visible = false;
        }

        private void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Hide();
            pomodoro.Show();
            pomodoro.WindowState = FormWindowState.Normal;
        }
    }
}
