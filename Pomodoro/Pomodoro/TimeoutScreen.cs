﻿using System;
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

        public TimeoutScreen()
        {
            Instance = this;

            InitializeComponent();
            time = timeLabel;

            Pomodoro.Instance.Visible = false;
        }
    }
}
