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
        int i = 1;
        //variable used to display time remaining on label 1
        int timeElapsed = 0;
        //timer interval variable
        int interval = 30000;
        List<string> images = new List<string> { };
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        
        public SlideShow()
        {
            InitializeComponent();
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
            timer1.Interval = interval;
            timer1.Start();
            //add image paths to list from selected path in browser dialog
            foreach (string image in Directory.GetFiles(menu.folderBrowserDialog1.SelectedPath)){
                images.Add(image);
            }
            //scale images to picture box
            gestures.SizeMode = PictureBoxSizeMode.Zoom;
            gestures.Image = Image.FromFile(images[0]);
            timeLeft.Text = (timer1.Interval/1000).ToString();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //End button
            this.Close();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Skip button, same failsafe used in timer
            if (i == images.Count)
            {
                timer1.Stop();
                gestures.Image = null;
            }
            else
            {
                i++;
                gestures.Image = Image.FromFile(images[i]);
                i++;
                timer1.Stop();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed = timer1.Interval / 1000;
            timeLeft.Text = timeElapsed.ToString();
            //flip through images on the interval as long as the i variable has not exceeded the image count
            if (i == images.Count)
            {
                timer1.Stop();
                gestures.Image = null;

            }
            else
            {
                gestures.Image = Image.FromFile(images[i]);
                i++;
            }

        }
        private void SlideShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
    }
}
