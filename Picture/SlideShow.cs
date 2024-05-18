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
        int i = 1;
        int timeElapsed = 0;
        int interval = 30000;
        List<string> images = new List<string> { };
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        //Image img = Image.FromFile("C:\\Users\\Kareem\\Desktop\\Art pics and pdfs\\Female Character Pinup\\Female Character Pinup\\æÑßß¿n íÑº ¡áºóá¡¿n3350.jpg");
        
        public SlideShow()
        {
            InitializeComponent();
          
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
            foreach (string image in Directory.GetFiles(menu.folderBrowserDialog1.SelectedPath)){
                images.Add(image);
            }
            gestures.SizeMode = PictureBoxSizeMode.Zoom;
            gestures.Image = Image.FromFile(images[0]);
            timeLeft.Text = timer1.Interval.ToString();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            gestures.Image = Image.FromFile(images[i]);
            i++;
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed = timer1.Interval / 1000;
            timeLeft.Text = timeElapsed.ToString();
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
    }
}
