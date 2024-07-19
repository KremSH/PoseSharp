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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Picture
{
    public partial class MainMenu : Form
    {
        public List<string> images = new List<string> { };
        public MainMenu()
        {
            InitializeComponent();
            this.Icon = PoseSharp.Properties.Resources.Icon1;
            this.Text = "PoseSharp";
            
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
            //add image paths to list from selected path in browser dialog
            //Check if images are found in folder, otherwise alert the user
            if (pictureFolderDialogue.SelectedPath != "")
            {
                foreach (string image in Directory.GetFiles(this.pictureFolderDialogue.SelectedPath))
                {
                    if (Path.GetExtension(image) == ".jpg" || Path.GetExtension(image) == ".png" || Path.GetExtension(image) == ".jpeg" ||
                        Path.GetExtension(image) == ".avif" || Path.GetExtension(image) == ".svg")
                    {
                        images.Add(image);
                    }
                }
                if (images.Count > 0)
                {
                    //Check if the custom time is checked and then checks if the value entered is an integer
                    if (custom.Checked)
                    {
                        if (!int.TryParse(customBox.Text, out int value))
                        {
                            MessageBox.Show("Please enter a valid value");
                        }
                        else
                        {
                            Form slideshow = new SlideShow();
                            slideshow.ShowDialog(this);
                        }
                    }
                    //if the custom time rdio button is not checked then start the slideshow anyway
                    else
                    {
                        Form slideshow = new SlideShow();
                        slideshow.ShowDialog(this);
                    }
                }
                else
                {
                    MessageBox.Show("No images in folder", "Error");

                }
                
            }
            else
            {
                MessageBox.Show("No folder selected", "Error");
            }
            
        }

        private void custom_CheckedChanged(object sender, EventArgs e)
        {
            //Only show the custom textbox when the radio button is checked
            if (custom.Checked)
            {
                customBox.Visible = true;
            }
            else
            {
                customBox.Visible = false;
            }
        }
    }
}
