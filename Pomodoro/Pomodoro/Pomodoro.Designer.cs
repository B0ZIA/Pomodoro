namespace Pomodoro
{
    partial class Pomodoro
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.Navigation = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Segoe Script", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.White;
            this.currentTimeLabel.Location = new System.Drawing.Point(265, 132);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(374, 153);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "30:00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Navigation
            // 
            this.Navigation.BackColor = System.Drawing.Color.Maroon;
            this.Navigation.CausesValidation = false;
            this.Navigation.Location = new System.Drawing.Point(-1, 386);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(865, 138);
            this.Navigation.TabIndex = 7;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Pomodoro";
            // 
            // Quit
            // 
            this.Quit.BackColor = System.Drawing.Color.Maroon;
            this.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quit.Font = new System.Drawing.Font("Segoe Script", 20F);
            this.Quit.ForeColor = System.Drawing.Color.Silver;
            this.Quit.Location = new System.Drawing.Point(819, 0);
            this.Quit.Margin = new System.Windows.Forms.Padding(0);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(45, 44);
            this.Quit.TabIndex = 9;
            this.Quit.Text = "X";
            this.Quit.UseVisualStyleBackColor = false;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.currentTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomodoro";
            this.Resize += new System.EventHandler(this.Pomodoro_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Panel Navigation;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button Quit;
    }
}

