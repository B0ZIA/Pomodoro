using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pomodoro
{
    public partial class TimeoutScreen : Form
    {
        public static TimeoutScreen Instance;
        public static Label time;

        private Pomodoro pomodoro;

        public TimeoutScreen(Pomodoro pomodoro)
        {
            Instance = this;

            this.pomodoro = pomodoro;
            InitializeComponent();
            time = timeLabel;

            pomodoro.Visible = false;
        }

        public void Timeout()
        {
            pomodoro.Visible = true;

        }
    }
}
