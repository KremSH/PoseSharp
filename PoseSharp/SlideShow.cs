using System;
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
        //variable used to display time remaining on minLabel and secLabel
        int timeElapsed = 0;
        int timeElapsedMin = 0;
        int timeElapsedSec = 0;
        //timer interval variable
        int interval = 10000;
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        
        public SlideShow()
        {
            InitializeComponent();
            this.Icon = PoseSharp.Properties.Resources.Icon1;
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
            if (menu.custom.Checked)
            {
                int.TryParse(menu.customBox.Text, out interval);
                interval = interval * 1000;
            }
            pictureTimer.Interval = interval;
            pictureTimer.Start();
            timerTimer.Start();
            
            //scale images to picture box
            gestures.SizeMode = PictureBoxSizeMode.Zoom;
            gestures.Image = Image.FromFile(menu.images[imageTracker]);
            
            
            //timeElapsed variable and time left label initialized
            timeElapsed = pictureTimer.Interval / 1000;
            //timeElapsed used to create a minute and second variable to display a more clear timer
            timeElapsedMin = timeElapsed / 60;
            timeElapsedSec = timeElapsed%60;
            minLabel.Text = timeElapsedMin.ToString("00");
            secLabel.Text = timeElapsedSec.ToString("00");
            
            
        }
        private void end_Click(object sender, EventArgs e)
        {
            //End button
            this.Close();
            pictureTimer.Stop();
            timerTimer.Stop();
            menu.images.Clear();
        }
        private void skip_Click(object sender, EventArgs e)
        {
            //Skip button, same failsafe used in timer
            if (imageTracker == menu.images.Count-1)
            {
                pictureTimer.Stop();
                timerTimer.Stop();
                gestures.Image = null;
                doneLabel.Text = "Done!";
            }
            else
            {
                imageTracker++;
                gestures.Image = Image.FromFile(menu.images[imageTracker]);
                pictureTimer.Stop();
                pictureTimer.Start();
                timerTimer.Stop();
                timerTimer.Start();
                timeElapsed = pictureTimer.Interval/1000;
                timeElapsedMin = timeElapsed / 60;
                timeElapsedSec = timeElapsed % 60;
                minLabel.Text = timeElapsedMin.ToString("00");
                secLabel.Text = timeElapsedSec.ToString("00");
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //timeElapsed = pictureTimer.Interval / 1000;
            //timeLeft.Text = timeElapsed.ToString();
            //flip through images on the interval as long as the i variable has not exceeded the image count
            if (imageTracker == menu.images.Count-1)
            {
                pictureTimer.Stop();
                timerTimer.Stop();
                gestures.Image = null;
                doneLabel.Text = "Done!";
            }
           else 
            {
                imageTracker++;
                gestures.Image = Image.FromFile(menu.images[imageTracker]);
            }
        }
        private void SlideShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            pictureTimer.Stop();
            timerTimer.Stop();
            menu.images.Clear();

        }
        //Seperate timer created to showcase the time left on each gesture
        private void timerTimer_Tick(object sender, EventArgs e)
        {
            timeElapsed--;
            timeElapsedMin = timeElapsed / 60;
            timeElapsedSec = timeElapsed % 60;
            minLabel.Text = timeElapsedMin.ToString("00");
            secLabel.Text = timeElapsedSec.ToString("00");
            if(timeElapsed == 0)
            {
                
                timeElapsed = pictureTimer.Interval/1000;
                minLabel.Text = "";
                secLabel.Text = "";
                timeElapsedMin = timeElapsed / 60;
                timeElapsedSec = timeElapsed % 60;
                minLabel.Text = timeElapsedMin.ToString("00");
                secLabel.Text = timeElapsedSec.ToString("00");
                
            }
         
        }
    }
}
