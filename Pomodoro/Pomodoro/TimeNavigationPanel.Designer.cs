namespace Pomodoro
{
    partial class TimeNavigationPanel
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PauseBtn = new System.Windows.Forms.Button();
            this.SkipBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.RestBtn = new System.Windows.Forms.Button();
            this.WorkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PauseBtn
            // 
            this.PauseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PauseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PauseBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.PauseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.PauseBtn.Location = new System.Drawing.Point(346, 37);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(155, 82);
            this.PauseBtn.TabIndex = 4;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = false;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // SkipBtn
            // 
            this.SkipBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SkipBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SkipBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.SkipBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.SkipBtn.Location = new System.Drawing.Point(132, 37);
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.Size = new System.Drawing.Size(155, 82);
            this.SkipBtn.TabIndex = 2;
            this.SkipBtn.Text = "Skip";
            this.SkipBtn.UseVisualStyleBackColor = false;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.CancelBtn.Location = new System.Drawing.Point(570, 37);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(163, 82);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // RestBtn
            // 
            this.RestBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RestBtn.Font = new System.Drawing.Font("Arial", 20.25F);
            this.RestBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.RestBtn.Location = new System.Drawing.Point(570, 37);
            this.RestBtn.Name = "RestBtn";
            this.RestBtn.Size = new System.Drawing.Size(163, 82);
            this.RestBtn.TabIndex = 3;
            this.RestBtn.Text = "Rest";
            this.RestBtn.UseVisualStyleBackColor = false;
            this.RestBtn.Click += new System.EventHandler(this.RestBtn_Click);
            // 
            // WorkBtn
            // 
            this.WorkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.WorkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WorkBtn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WorkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.WorkBtn.Location = new System.Drawing.Point(132, 37);
            this.WorkBtn.Name = "WorkBtn";
            this.WorkBtn.Size = new System.Drawing.Size(155, 82);
            this.WorkBtn.TabIndex = 2;
            this.WorkBtn.Text = "WORK";
            this.WorkBtn.UseVisualStyleBackColor = false;
            this.WorkBtn.Click += new System.EventHandler(this.WorkBtn_Click);
            // 
            // TimeNavigationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SkipBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.RestBtn);
            this.Controls.Add(this.WorkBtn);
            this.Controls.Add(this.CancelBtn);
            this.Name = "TimeNavigationPanel";
            this.Size = new System.Drawing.Size(863, 136);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button RestBtn;
        private System.Windows.Forms.Button WorkBtn;
    }
}
