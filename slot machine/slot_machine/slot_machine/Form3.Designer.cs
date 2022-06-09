namespace slot_machine
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fruitBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnBox
            // 
            this.columnBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnBox.FormattingEnabled = true;
            this.columnBox.Location = new System.Drawing.Point(94, 72);
            this.columnBox.Name = "columnBox";
            this.columnBox.Size = new System.Drawing.Size(151, 28);
            this.columnBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Αριθμός στηλών";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Αριθμός φρούτων";
            // 
            // fruitBox
            // 
            this.fruitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fruitBox.FormattingEnabled = true;
            this.fruitBox.Location = new System.Drawing.Point(94, 148);
            this.fruitBox.Name = "fruitBox";
            this.fruitBox.Size = new System.Drawing.Size(151, 28);
            this.fruitBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "ΟΚ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(227, 263);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 29);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "LOGOUT";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 343);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fruitBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ρυθμίσεις";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox columnBox;
        private Label label1;
        private Label label2;
        private ComboBox fruitBox;
        private Button button1;
        private Button logoutButton;
    }
}