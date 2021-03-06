﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class PomodoroNavigation : UserControl
    {
        public readonly List<Button> butttonsDuringIdle;
        public readonly List<Button> buttonsDuringCountdown;

        private PomodoroTimer pomodoroTimer;


        public PomodoroNavigation(Control parent, PomodoroTimer pomodoroTimer)
        {
            InitializeComponent();
            this.pomodoroTimer = pomodoroTimer;
            Parent = parent;
            butttonsDuringIdle = new List<Button> { SkipBtn, PauseBtn, CancelBtn };
            buttonsDuringCountdown = new List<Button> { WorkBtn, RestBtn};

            SetPanel(Possibilities.DuringIdle);
        }

        public enum Possibilities
        {
            DuringIdle,
            DuringCountdown
        }

        public void SetPanel(Possibilities options)
        {
            bool[] solution = new bool[2];

            switch (options)
            {
                case Possibilities.DuringIdle:
                    solution[0] = false;
                    break;
                case Possibilities.DuringCountdown:
                    solution[0] = true;
                    break;
            }

            solution[1] = !solution[0];

            foreach (var button in butttonsDuringIdle)
            {
                button.Visible = solution[0];
            }
            foreach (var button in buttonsDuringCountdown)
            {
                button.Visible = solution[1];
            }
        }

        private void SkipBtn_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Skip();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Pause();
        }

        private void RestBtn_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Rest();
        }

        private void WorkBtn_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Work();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            pomodoroTimer.Cancel();
        }
    }
}
