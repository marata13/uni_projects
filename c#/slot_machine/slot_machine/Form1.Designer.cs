namespace slot_machine
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerText1 = new System.Windows.Forms.Label();
            this.spinButton = new System.Windows.Forms.Button();
            this.bet = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerText1
            // 
            this.timerText1.AutoSize = true;
            this.timerText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(118)))), ((int)(((byte)(39)))));
            this.timerText1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timerText1.Location = new System.Drawing.Point(862, 385);
            this.timerText1.Name = "timerText1";
            this.timerText1.Size = new System.Drawing.Size(26, 31);
            this.timerText1.TabIndex = 12;
            this.timerText1.Text = "3";
            this.timerText1.Visible = false;
            // 
            // spinButton
            // 
            this.spinButton.BackgroundImage = global::slot_machine.Properties.Resources.spin1;
            this.spinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spinButton.FlatAppearance.BorderSize = 0;
            this.spinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spinButton.Location = new System.Drawing.Point(741, 373);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(124, 43);
            this.spinButton.TabIndex = 16;
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // bet
            // 
            this.bet.BackColor = System.Drawing.SystemColors.InfoText;
            this.bet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bet.Font = new System.Drawing.Font("Rockwell Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bet.ForeColor = System.Drawing.SystemColors.Window;
            this.bet.Location = new System.Drawing.Point(557, 385);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(166, 32);
            this.bet.TabIndex = 23;
            // 
            // scoreButton
            // 
            this.scoreButton.BackgroundImage = global::slot_machine.Properties.Resources.score;
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(180, 384);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(133, 32);
            this.scoreButton.TabIndex = 24;
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::slot_machine.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(97, 367);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(63, 62);
            this.settingsButton.TabIndex = 25;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::slot_machine.Properties.Resources.slot31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 493);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.timerText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label timerText1;
        private Button spinButton;
        private TextBox bet;
        private Button scoreButton;
        private Button settingsButton;
        private System.Windows.Forms.Timer timer;
    }
}