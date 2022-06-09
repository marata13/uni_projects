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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerText1
            // 
            this.timerText1.AutoSize = true;
            this.timerText1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(118)))), ((int)(((byte)(39)))));
            this.timerText1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerText1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.timerText1.Location = new System.Drawing.Point(1078, 481);
            this.timerText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerText1.Name = "timerText1";
            this.timerText1.Size = new System.Drawing.Size(32, 38);
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
            this.spinButton.Location = new System.Drawing.Point(926, 466);
            this.spinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(155, 54);
            this.spinButton.TabIndex = 16;
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // bet
            // 
            this.bet.BackColor = System.Drawing.SystemColors.InfoText;
            this.bet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bet.Font = new System.Drawing.Font("Rockwell Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bet.ForeColor = System.Drawing.SystemColors.Window;
            this.bet.Location = new System.Drawing.Point(696, 481);
            this.bet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bet.Name = "bet";
            this.bet.Size = new System.Drawing.Size(208, 38);
            this.bet.TabIndex = 23;
            // 
            // scoreButton
            // 
            this.scoreButton.BackgroundImage = global::slot_machine.Properties.Resources.score;
            this.scoreButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scoreButton.FlatAppearance.BorderSize = 0;
            this.scoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreButton.Location = new System.Drawing.Point(225, 480);
            this.scoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(166, 40);
            this.scoreButton.TabIndex = 24;
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::slot_machine.Properties.Resources.settings;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Location = new System.Drawing.Point(121, 459);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(79, 78);
            this.settingsButton.TabIndex = 25;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 900;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1099, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::slot_machine.Properties.Resources.slot31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.bet);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.timerText1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine";
            this.Shown += new System.EventHandler(this.mainForm_Shown);
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
        private Button button1;
    }
}