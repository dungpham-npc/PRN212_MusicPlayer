using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicApp
{
    public partial class PlayVideoPage : Form
    {

        private List<string> videoPaths = new List<string>();

        public PlayVideoPage()
        {
            InitializeComponent();
            Initialize();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form and return to the previous one
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true; // Allow multiple files to be selected
            openFileDialog.Filter = "Video Files (*.mp4;*.avi;*.mkv)|*.mp4;*.avi;*.mkv"; // Set filter for video files

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    videoPaths.Add(file);
                    listVideo.Items.Add(Path.GetFileName(file)); // Add only the file name to the list
                }
            }
        }

        private void Initialize()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }

        private void listVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listVideo.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < videoPaths.Count)
            {
                mediaPlayer.URL = videoPaths[selectedIndex]; // Load the selected video
                mediaPlayer.Ctlcontrols.play(); // Automatically play it
            }
        }
    }
}
