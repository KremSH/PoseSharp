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
        
        int interval = 30000;
        public MainMenu menu = (MainMenu)Application.OpenForms["MainMenu"];
        //Image img = Image.FromFile("C:\\Users\\Kareem\\Desktop\\Art pics and pdfs\\Female Character Pinup\\Female Character Pinup\\æÑßß¿n íÑº ¡áºóá¡¿n3350.jpg");
        
        public SlideShow()
        {
            InitializeComponent();
          
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
            timer1.Interval = interval;
            timer1.Start();
       
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}
