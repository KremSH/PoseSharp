using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //folder browser and label displaying selected path
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Visible = true;
                label2.Text = Path.GetFileName(folderBrowserDialog1.SelectedPath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //open slideshow form and start
            Form slideshow = new SlideShow();
            slideshow.ShowDialog(this);
        }
    }
}
