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

        private void dialogue_Click(object sender, EventArgs e)
        {
            //folder browser and label displaying selected path
            if (pictureFolderDialogue.ShowDialog() == DialogResult.OK)
            {
                folderName.Visible = true;
                folderName.Text = Path.GetFileName(pictureFolderDialogue.SelectedPath);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            //open slideshow form and start
            Form slideshow = new SlideShow();
            slideshow.ShowDialog(this);
        }
    }
}
