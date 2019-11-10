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



        public PomodoroNotifyIcon(NotifyIcon notifyIcon)
        {
            this.notifyIcon = notifyIcon;

            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, Pomodoro.Instance.Exit);
            this.notifyIcon.MouseDoubleClick += notifyIcon_MouseDoubleClick;
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

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Hide();
            Pomodoro.Instance.Show();
            Pomodoro.Instance.WindowState = FormWindowState.Normal;
        }
    }
}
