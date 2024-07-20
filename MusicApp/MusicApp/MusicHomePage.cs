using System.Diagnostics;
using System.IO;

namespace MusicApp
{
    public partial class MusicHomePage : Form
    {
        public MusicHomePage()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            lbl_volume.Text = "50%";
        }
        string[] paths, files;

        //method to open media files
        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                paths = openFileDialog.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    track_list.Items.Add(files[x]);
                }
            }

        }

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();
            
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
        }

        //Method for progressbar to show show the Media Playing status such as track 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.currentMedia.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.currentMedia.durationString;
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
            lbl_volume.Text = trackVolume.Value.ToString() + "%";
        }

        private void p_bar_Click(object sender, EventArgs e)
        {
            // Tính toán vị trí được click trên ProgressBar và thay đổi vị trí phát nhạc tương ứng
            MouseEventArgs me = (MouseEventArgs)e;
            double positionRatio = (double)me.X / p_bar.Width;
            double newPosition = player.currentMedia.duration * positionRatio;
            player.Ctlcontrols.currentPosition = newPosition;
        }

        private void player_Enter(object sender, EventArgs e)
        {

        }
    }
}
