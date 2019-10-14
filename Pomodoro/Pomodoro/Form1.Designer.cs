namespace Pomodoro
{
    partial class Form1
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
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.Work = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.WorkOrRestPanel = new System.Windows.Forms.Panel();
            this.SkipPauseCancelPanel = new System.Windows.Forms.Panel();
            this.Pause = new System.Windows.Forms.Button();
            this.Skip = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WorkOrRestPanel.SuspendLayout();
            this.SkipPauseCancelPanel.SuspendLayout();
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
            // Work
            // 
            this.Work.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Work.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Work.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Work.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.Work.Location = new System.Drawing.Point(188, 35);
            this.Work.Name = "Work";
            this.Work.Size = new System.Drawing.Size(155, 82);
            this.Work.TabIndex = 2;
            this.Work.Text = "WORK";
            this.Work.UseVisualStyleBackColor = false;
            this.Work.Click += new System.EventHandler(this.Work_Click);
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Rest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rest.Font = new System.Drawing.Font("Arial", 20.25F);
            this.Rest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.Rest.Location = new System.Drawing.Point(507, 37);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(163, 82);
            this.Rest.TabIndex = 3;
            this.Rest.Text = "REST";
            this.Rest.UseVisualStyleBackColor = false;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // WorkOrRestPanel
            // 
            this.WorkOrRestPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.WorkOrRestPanel.CausesValidation = false;
            this.WorkOrRestPanel.Controls.Add(this.Rest);
            this.WorkOrRestPanel.Controls.Add(this.Work);
            this.WorkOrRestPanel.Location = new System.Drawing.Point(2, 383);
            this.WorkOrRestPanel.Name = "WorkOrRestPanel";
            this.WorkOrRestPanel.Size = new System.Drawing.Size(861, 140);
            this.WorkOrRestPanel.TabIndex = 4;
            // 
            // SkipPauseCancelPanel
            // 
            this.SkipPauseCancelPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.SkipPauseCancelPanel.CausesValidation = false;
            this.SkipPauseCancelPanel.Controls.Add(this.Pause);
            this.SkipPauseCancelPanel.Controls.Add(this.Skip);
            this.SkipPauseCancelPanel.Controls.Add(this.Cancel);
            this.SkipPauseCancelPanel.Location = new System.Drawing.Point(5, 383);
            this.SkipPauseCancelPanel.Name = "SkipPauseCancelPanel";
            this.SkipPauseCancelPanel.Size = new System.Drawing.Size(858, 137);
            this.SkipPauseCancelPanel.TabIndex = 5;
            this.SkipPauseCancelPanel.Visible = false;
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Pause.Font = new System.Drawing.Font("Arial", 20.25F);
            this.Pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.Pause.Location = new System.Drawing.Point(346, 37);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(155, 82);
            this.Pause.TabIndex = 4;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Skip
            // 
            this.Skip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Skip.Font = new System.Drawing.Font("Arial", 20.25F);
            this.Skip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.Skip.Location = new System.Drawing.Point(134, 37);
            this.Skip.Name = "Skip";
            this.Skip.Size = new System.Drawing.Size(155, 82);
            this.Skip.TabIndex = 2;
            this.Skip.Text = "Skip";
            this.Skip.UseVisualStyleBackColor = false;
            this.Skip.Click += new System.EventHandler(this.Skip_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Cancel.Font = new System.Drawing.Font("Arial", 20.25F);
            this.Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(159)))));
            this.Cancel.Location = new System.Drawing.Point(570, 37);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(163, 82);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(41)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(863, 524);
            this.Controls.Add(this.currentTimeLabel);
            this.Controls.Add(this.SkipPauseCancelPanel);
            this.Controls.Add(this.WorkOrRestPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WorkOrRestPanel.ResumeLayout(false);
            this.SkipPauseCancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Button Work;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Panel WorkOrRestPanel;
        private System.Windows.Forms.Panel SkipPauseCancelPanel;
        private System.Windows.Forms.Button Skip;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

