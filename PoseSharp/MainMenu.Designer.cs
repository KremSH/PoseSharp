namespace Picture
{
    partial class MainMenu
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
            this.pictureFolderDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDialogue = new System.Windows.Forms.Button();
            this.thirtySec = new System.Windows.Forms.RadioButton();
            this.oneMin = new System.Windows.Forms.RadioButton();
            this.fiveMin = new System.Windows.Forms.RadioButton();
            this.tenMin = new System.Windows.Forms.RadioButton();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.folderName = new System.Windows.Forms.Label();
            this.timeRadioButtonsPanel = new System.Windows.Forms.Panel();
            this.custom = new System.Windows.Forms.RadioButton();
            this.customBox = new System.Windows.Forms.TextBox();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.timeRadioButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderDialogue
            // 
            this.folderDialogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderDialogue.Location = new System.Drawing.Point(230, 113);
            this.folderDialogue.Name = "folderDialogue";
            this.folderDialogue.Size = new System.Drawing.Size(114, 36);
            this.folderDialogue.TabIndex = 0;
            this.folderDialogue.Text = "Choose Folder";
            this.folderDialogue.UseVisualStyleBackColor = true;
            this.folderDialogue.Click += new System.EventHandler(this.dialogue_Click);
            // 
            // thirtySec
            // 
            this.thirtySec.AutoSize = true;
            this.thirtySec.Location = new System.Drawing.Point(10, 12);
            this.thirtySec.Name = "thirtySec";
            this.thirtySec.Size = new System.Drawing.Size(42, 17);
            this.thirtySec.TabIndex = 1;
            this.thirtySec.TabStop = true;
            this.thirtySec.Text = "30s";
            this.thirtySec.UseVisualStyleBackColor = true;
            // 
            // oneMin
            // 
            this.oneMin.AutoSize = true;
            this.oneMin.Location = new System.Drawing.Point(127, 12);
            this.oneMin.Name = "oneMin";
            this.oneMin.Size = new System.Drawing.Size(39, 17);
            this.oneMin.TabIndex = 2;
            this.oneMin.TabStop = true;
            this.oneMin.Text = "1m";
            this.oneMin.UseVisualStyleBackColor = true;
            // 
            // fiveMin
            // 
            this.fiveMin.AutoSize = true;
            this.fiveMin.Location = new System.Drawing.Point(250, 12);
            this.fiveMin.Name = "fiveMin";
            this.fiveMin.Size = new System.Drawing.Size(39, 17);
            this.fiveMin.TabIndex = 3;
            this.fiveMin.TabStop = true;
            this.fiveMin.Text = "5m";
            this.fiveMin.UseVisualStyleBackColor = true;
            // 
            // tenMin
            // 
            this.tenMin.AutoSize = true;
            this.tenMin.Location = new System.Drawing.Point(361, 12);
            this.tenMin.Name = "tenMin";
            this.tenMin.Size = new System.Drawing.Size(45, 17);
            this.tenMin.TabIndex = 4;
            this.tenMin.TabStop = true;
            this.tenMin.Text = "10m";
            this.tenMin.UseVisualStyleBackColor = true;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(62, 198);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(48, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Time:";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(230, 305);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(114, 36);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start_Click);
            // 
            // folderName
            // 
            this.folderName.AutoSize = true;
            this.folderName.Location = new System.Drawing.Point(230, 156);
            this.folderName.Name = "folderName";
            this.folderName.Size = new System.Drawing.Size(61, 13);
            this.folderName.TabIndex = 7;
            this.folderName.Text = "folderName";
            this.folderName.Visible = false;
            // 
            // timeRadioButtonsPanel
            // 
            this.timeRadioButtonsPanel.Controls.Add(this.custom);
            this.timeRadioButtonsPanel.Controls.Add(this.thirtySec);
            this.timeRadioButtonsPanel.Controls.Add(this.oneMin);
            this.timeRadioButtonsPanel.Controls.Add(this.fiveMin);
            this.timeRadioButtonsPanel.Controls.Add(this.tenMin);
            this.timeRadioButtonsPanel.Location = new System.Drawing.Point(41, 232);
            this.timeRadioButtonsPanel.Name = "timeRadioButtonsPanel";
            this.timeRadioButtonsPanel.Size = new System.Drawing.Size(528, 42);
            this.timeRadioButtonsPanel.TabIndex = 8;
            // 
            // custom
            // 
            this.custom.AutoSize = true;
            this.custom.Location = new System.Drawing.Point(459, 12);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(60, 17);
            this.custom.TabIndex = 5;
            this.custom.TabStop = true;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.CheckedChanged += new System.EventHandler(this.custom_CheckedChanged);
            // 
            // customBox
            // 
            this.customBox.Location = new System.Drawing.Point(469, 280);
            this.customBox.Name = "customBox";
            this.customBox.Size = new System.Drawing.Size(100, 20);
            this.customBox.TabIndex = 9;
            this.customBox.Visible = false;
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(350, 120);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(75, 23);
            this.shuffleButton.TabIndex = 10;
            this.shuffleButton.Text = "Shuffle";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Visible = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 444);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.customBox);
            this.Controls.Add(this.timeRadioButtonsPanel);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.folderDialogue);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.timeRadioButtonsPanel.ResumeLayout(false);
            this.timeRadioButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button folderDialogue;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel timeRadioButtonsPanel;
        public System.Windows.Forms.RadioButton thirtySec;
        public System.Windows.Forms.RadioButton oneMin;
        public System.Windows.Forms.RadioButton fiveMin;
        public System.Windows.Forms.RadioButton tenMin;
        public System.Windows.Forms.Label folderName;
        public System.Windows.Forms.FolderBrowserDialog pictureFolderDialogue;
        public System.Windows.Forms.RadioButton custom;
        public System.Windows.Forms.TextBox customBox;
        private System.Windows.Forms.Button shuffleButton;
    }
}