﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Picture
{
    public partial class SlideShow : Form
    {
        //variable used to keep track of images in list
        int imageTracker = 0;
        //variable used to display time remaining on label 1
        int timeElapsed = 0;
        //timer interval variable
        int interval = 10000;
        List<string> images = new List<string> { };
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        
        public SlideShow()
        {
            InitializeComponent();
            this.Text = "PoseSharp";
            //setup interval according to main menu radio buttons
            if (menu.thirtySec.Checked) {
                interval = 30000;
            }
            if (menu.oneMin.Checked)
            {
                interval = 60000;
            }
            if (menu.fiveMin.Checked)
            {
                interval = 300000;
            }
            if (menu.tenMin.Checked)
            {
                interval = 600000;
            }
            pictureTimer.Interval = interval;
            pictureTimer.Start();
            timerTimer.Start();
            //add image paths to list from selected path in browser dialog
          
           foreach (string image in Directory.GetFiles(menu.pictureFolderDialogue.SelectedPath))
             {
                 images.Add(image);
             }

            
       
            //scale images to picture box
            gestures.SizeMode = PictureBoxSizeMode.Zoom;
            gestures.Image = Image.FromFile(images[imageTracker]);
            
            //timeElapsed variable and time left label initialized
            timeElapsed = pictureTimer.Interval / 1000;
            timeLeft.Text = timeElapsed.ToString();

        }
        private void end_Click(object sender, EventArgs e)
        {
            //End button
            this.Close();
            pictureTimer.Stop();
            timerTimer.Stop();
        }
        private void skip_Click(object sender, EventArgs e)
        {
            //Skip button, same failsafe used in timer
            if (imageTracker == images.Count-1)
            {
                pictureTimer.Stop();
                timerTimer.Stop();
                gestures.Image = null;
                timeLeft.Text = "Done!";
            }
            else
            {
                imageTracker++;
                gestures.Image = Image.FromFile(images[imageTracker]);
                pictureTimer.Stop();
                pictureTimer.Start();
                timerTimer.Stop();
                timerTimer.Start();
                timeElapsed = pictureTimer.Interval/1000;
                timeLeft.Text = timeElapsed.ToString();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //timeElapsed = pictureTimer.Interval / 1000;
            //timeLeft.Text = timeElapsed.ToString();
            //flip through images on the interval as long as the i variable has not exceeded the image count
            if (imageTracker == images.Count-1)
            {
                pictureTimer.Stop();
                timerTimer.Stop();
                gestures.Image = null;
                timeLeft.Text = "Done!";
            }
           else 
            {
                imageTracker++;
                gestures.Image = Image.FromFile(images[imageTracker]);
            }
        }
        private void SlideShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureTimer.Stop();
            timerTimer.Stop();
        }
        //Seperate timer created to showcase the time left on each gesture
        private void timerTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            timeLeft.Text = timeElapsed.ToString();
            if(timeElapsed == 0)
            {
                timeLeft.Text = "";
                timeElapsed = pictureTimer.Interval/1000;
                timeLeft.Text += timeElapsed.ToString();
            }
            
        }
    }
}