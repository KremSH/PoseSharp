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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderDialogue = new System.Windows.Forms.Button();
            this.thirtySec = new System.Windows.Forms.RadioButton();
            this.oneMin = new System.Windows.Forms.RadioButton();
            this.fiveMin = new System.Windows.Forms.RadioButton();
            this.tenMin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
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
            this.folderDialogue.Click += new System.EventHandler(this.button1_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time:";
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
            this.startButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thirtySec);
            this.panel1.Controls.Add(this.oneMin);
            this.panel1.Controls.Add(this.fiveMin);
            this.panel1.Controls.Add(this.tenMin);
            this.panel1.Location = new System.Drawing.Point(65, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 42);
            this.panel1.TabIndex = 8;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 444);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folderDialogue);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button folderDialogue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton thirtySec;
        public System.Windows.Forms.RadioButton oneMin;
        public System.Windows.Forms.RadioButton fiveMin;
        public System.Windows.Forms.RadioButton tenMin;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}