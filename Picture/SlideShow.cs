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

namespace Picture
{
    public partial class SlideShow : Form
    {
        Timer slideTimer;
        int interval = 10000;
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        //Image img = Image.FromFile("C:\\Users\\Kareem\\Desktop\\Art pics and pdfs\\Female Character Pinup\\Female Character Pinup\\æÑßß¿n íÑº ¡áºóá¡¿n3350.jpg");
        
        public SlideShow()
        {
            InitializeComponent();
            slideTimer = new Timer();
            if (menu.radioButton1.Checked) {
                interval = 30000;
            }
            if (menu.radioButton2.Checked)
            {
                interval = 60000;
            }
            if (menu.radioButton3.Checked)
            {
                interval = 300000;
            }
            if (menu.radioButton4.Checked)
            {
                interval = 600000;
            }
            slideTimer.Interval = interval;
            //this.pictureBox1.Image = img;
           
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
