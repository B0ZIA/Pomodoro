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
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.Navigation = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(56)))), ((int)(((byte)(57)))));
            this.currentTimeLabel.Location = new System.Drawing.Point(289, 139);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(284, 108);
            this.currentTimeLabel.TabIndex = 1;
            this.currentTimeLabel.Text = "30:00";
            this.currentTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Navigation
            // 
            this.Navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.Navigation.CausesValidation = false;
            this.Navigation.Location = new System.Drawing.Point(-1, 386);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(865, 138);
            this.Navigation.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.currentTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Panel Navigation;
    }
}

