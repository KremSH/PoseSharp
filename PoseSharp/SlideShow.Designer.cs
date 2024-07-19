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
            this.pictureTimer = new System.Windows.Forms.Timer(this.components);
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.minLabel = new System.Windows.Forms.Label();
            this.secLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.doneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gestures)).BeginInit();
            this.SuspendLayout();
            // 
            // gestures
            // 
            this.gestures.Location = new System.Drawing.Point(55, 49);
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
            this.skipButton.Click += new System.EventHandler(this.skip_Click);
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
            this.endButton.Click += new System.EventHandler(this.end_Click);
            // 
            // pictureTimer
            // 
            this.pictureTimer.Enabled = true;
            this.pictureTimer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerTimer
            // 
            this.timerTimer.Interval = 1000;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(608, 363);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(52, 17);
            this.minLabel.TabIndex = 4;
            this.minLabel.Text = "label1";
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secLabel.Location = new System.Drawing.Point(685, 363);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(52, 17);
            this.secLabel.TabIndex = 5;
            this.secLabel.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(666, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = ":";
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.Location = new System.Drawing.Point(630, 393);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(0, 25);
            this.doneLabel.TabIndex = 7;
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 714);
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.minLabel);
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
        private System.Windows.Forms.Timer pictureTimer;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label secLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label doneLabel;
    }
}

