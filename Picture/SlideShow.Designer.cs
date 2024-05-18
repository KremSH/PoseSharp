namespace Picture
{
    partial class SlideShow
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
            this.components = new System.ComponentModel.Container();
            this.gestures = new System.Windows.Forms.PictureBox();
            this.skipButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.timeLeft = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gestures)).BeginInit();
            this.SuspendLayout();
            // 
            // gestures
            // 
            this.gestures.Location = new System.Drawing.Point(79, 48);
            this.gestures.Name = "gestures";
            this.gestures.Size = new System.Drawing.Size(547, 557);
            this.gestures.TabIndex = 0;
            this.gestures.TabStop = false;
            // 
            // skipButton
            // 
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.skipButton.Location = new System.Drawing.Point(314, 630);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(83, 35);
            this.skipButton.TabIndex = 1;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // endButton
            // 
            this.endButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.endButton.Location = new System.Drawing.Point(543, 630);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(83, 29);
            this.endButton.TabIndex = 2;
            this.endButton.Text = "End Session";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.Location = new System.Drawing.Point(645, 320);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(70, 25);
            this.timeLeft.TabIndex = 3;
            this.timeLeft.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 714);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.gestures);
            this.Name = "SlideShow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gestures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox gestures;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Timer timer1;
    }
}

