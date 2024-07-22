using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using VideoLibrary;

namespace MusicApp
{
    public partial class MusicHomePage : Form
    {

        private enum PlayMode
        {
            Normal,
            Repeat,
            Shuffle
        }

        private PlayMode currentPlayMode = PlayMode.Normal;
        private static string musicPath = "";
        static string[]? files;
        static List<String>? paths = new List<string>();
        public MusicHomePage()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            lbl_volume.Text = "50%";
            this.Size = new Size(1050, 600);
            this.MinimumSize = this.Size;
            LoadMusicPathFromSettings();
        }

        private void LoadMusicFiles(string musicPath)
        {
            if (Directory.Exists(musicPath))
            {
                string[] audioExtensions = { ".mp3", ".wav", ".wma", ".flac", ".mp4" };

                foreach (string file in Directory.EnumerateFiles(musicPath, "*", SearchOption.AllDirectories))
                {
                    if (audioExtensions.Contains(Path.GetExtension(file).ToLower()))
                    {
                        paths.Add(file);
                        track_list.Items.Add(Path.GetFileName(file));
                    }
                }
            }
            else
            {
                MessageBox.Show("Music path not found! Please check the path.");
            }
        }


        //method to open media files
        private void open_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Music Files (*.mp3;*.wav;*.wma;*.flac;*.mp4)|*.mp3;*.wav;*.wma;*.flac;*.mp4"; // Set filter for music extensions

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<string> validMusicFiles = new List<string>();

                foreach (string file in openFileDialog.FileNames)
                {
                    string extension = Path.GetExtension(file).ToLower();
                    if (IsSupportedMusicExtension(extension))
                    {
                        validMusicFiles.Add(file);
                        track_list.Items.Add(Path.GetFileName(file));
                    }
                    else
                    {
                        MessageBox.Show($"The file '{file}' has an unsupported extension. Only MP3, WAV, WMA, and FLAC files are allowed.");
                    }
                }

                if (validMusicFiles.Count > 0)
                {
                    files = validMusicFiles.ToArray();
                    paths?.Clear(); // Clear existing paths if any
                    foreach (string file in files)
                    {
                        paths?.Add(file);
                    }
                }
            }
        }

        private bool IsSupportedMusicExtension(string extension)
        {
            string[] supportedExtensions = { ".mp3", ".wav", ".wma", ".flac", ".mp4" };
            return supportedExtensions.Contains(extension);
        }


        private async void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && track_list.SelectedIndex < paths.Count)
            {
                string selectedPath = paths[track_list.SelectedIndex];
                Debug.WriteLine($"Playing: {selectedPath}");

                try
                {
                    //player.URL = selectedPath;
                    //player.Ctlcontrols.play();

                    // Extract artist and title for lyrics search (Assure filename format: "Artist - Title.mp3")
                    string fileName = Path.GetFileNameWithoutExtension(selectedPath);
                    var parts = fileName.Split('-');
                    if (parts.Length == 2)
                    {
                        string artist = parts[0].Trim();
                        string title = parts[1].Trim();
                        txtLyrics.Text = await FetchLyricsAsync(artist, title);
                    }
                    else
                    {
                        txtLyrics.Text = "Cannot determine artist and title for lyrics search.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error playing media: {ex.Message}");
                }
            }
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
            if (paths?.Count > 0 && track_list.SelectedIndex >= 0)
            {
                string selectedPath = paths[track_list.SelectedIndex];
                player.URL = selectedPath;
                player.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Please open some music files first!");
            }
        }


        private void next_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex++;
            }
        }

        private void preview_btn_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex--;
            }
        }
        private void p_bar_Click(object sender, EventArgs e)
        {
            if (player.currentMedia == null)
            {
                MessageBox.Show("No media is currently loaded.");
                return;
            }
            MouseEventArgs me = (MouseEventArgs)e;
            double positionRatio = (double)me.X / p_bar.Width;
            double newPosition = player.currentMedia.duration * positionRatio;
            player.Ctlcontrols.currentPosition = newPosition;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                int duration = (int)player.currentMedia.duration;
                int currentPosition = (int)player.Ctlcontrols.currentPosition;

                p_bar.Maximum = Math.Max(duration, 1);

                p_bar.Value = Math.Min(currentPosition, p_bar.Maximum);

                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.currentMedia.durationString;
                if (currentPosition >= duration)
                {
                    PlayNextTrack();
                }
            }
        }

        private void PlayNextTrack()
        {
            switch (currentPlayMode)
            {
                case PlayMode.Normal:
                    if (track_list.SelectedIndex < track_list.Items.Count - 1)
                    {
                        track_list.SelectedIndex++;
                    }
                    else
                    {
                        track_list.SelectedIndex = 0;
                    }
                    break;
                case PlayMode.Repeat:
                    break;
                case PlayMode.Shuffle:
                    Random rand = new Random();
                    track_list.SelectedIndex = rand.Next(0, track_list.Items.Count);
                    break;
            }

            if (track_list.SelectedIndex >= 0 && track_list.SelectedIndex < paths?.Count)
            {
                Debug.WriteLine($"Playing: {paths[track_list.SelectedIndex]}");
                player.URL = paths[track_list.SelectedIndex];
                player.Ctlcontrols.play();
            }
        }


        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
            lbl_volume.Text = trackVolume.Value.ToString() + "%";
        }



        private void player_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_track_end_Click(object sender, EventArgs e)
        {

        }

        private void changeMusicPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Select your music folder";
            folderBrowserDialog.ShowNewFolderButton = false;

            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                musicPath = selectedPath;
                paths.Clear();
                track_list.Items.Clear();
                LoadMusicFiles(selectedPath);
                SaveMusicPathToSettings(selectedPath);
            }
        }



        private void SaveMusicPathToSettings(string path)
        {
            string settingsFile = "D:\\music_path.json";

            try
            {
                using (StreamWriter writer = new StreamWriter(settingsFile))
                {
                    writer.Write(JsonSerializer.Serialize(path));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving music path: {ex.Message}");
            }
        }

        private void LoadMusicPathFromSettings()
        {
            string settingsFile = "D:\\music_path.json";

            try
            {
                if (File.Exists(settingsFile))
                {
                    using (StreamReader reader = new StreamReader(settingsFile))
                    {
                        musicPath = JsonSerializer.Deserialize<string>(reader.ReadToEnd());
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading music path: {ex.Message}");
                musicPath = "";
            }

            if (!string.IsNullOrEmpty(musicPath))
            {
                LoadMusicFiles(musicPath);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayMode_Click(object sender, EventArgs e)
        {
            currentPlayMode = (PlayMode)(((int)currentPlayMode + 1) % Enum.GetNames(typeof(PlayMode)).Length);

            btnPlayMode.Text = currentPlayMode.ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to quit?",
                "Confirm Quit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (player.currentMedia == null)
            {
                MessageBox.Show("No media is currently loaded.");
                return;
            }

            // Calculate the new position based on TrackBar value
            double positionRatio = (double)trackBar1.Value / trackBar1.Maximum;
            double newPosition = player.currentMedia.duration * positionRatio;

            // Set the player's current position to the new position
            player.Ctlcontrols.currentPosition = newPosition;
        }

        private void MusicHomePage_Load(object sender, EventArgs e)
        {

        }

        private async void btnYoutubeSearch_Click(object sender, EventArgs e)
        {
            string query = youtube_searchbar.Text;
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            try
            {
                var videoItems = await SearchYouTubeVideosAsync(query);
                youtube_search_result.DataSource = videoItems;
                youtube_search_result.DisplayMember = "Title";
                youtube_search_result.ValueMember = "VideoId";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching YouTube: {ex.Message}");
            }
        }


        private void youtube_searchbar_TextChanged(object sender, EventArgs e)
        {

        }

        private void youtube_search_result_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnAddYoutubeTrack_Click(object sender, EventArgs e)
        {
            if (youtube_search_result.SelectedItem is VideoItem selectedItem)
            {
                string videoUrl = $"https://www.youtube.com/watch?v={selectedItem.VideoId}";

                try
                {
                    string downloadedFilePath = await DownloadVideoAsync(videoUrl);

                    if (!string.IsNullOrEmpty(downloadedFilePath))
                    {
                        if (!paths.Contains(downloadedFilePath))
                        {
                            paths.Add(downloadedFilePath);
                            track_list.Items.Add(Path.GetFileName(downloadedFilePath));
                        }
                        else
                        {
                            MessageBox.Show("This track is already in the list.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding video to track list: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select a video from the search results.");
            }
        }


        private async Task<List<VideoItem>> SearchYouTubeVideosAsync(string query)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer
            {
                ApiKey = "AIzaSyBmyjUoh3ikMPLyhfqe24T9K5-Tk9ZRc6g",
                ApplicationName = "MusicApp"
            });

            var searchRequest = youtubeService.Search.List("snippet");
            searchRequest.Q = query;
            searchRequest.MaxResults = 10;

            var searchResponse = await searchRequest.ExecuteAsync();
            var videoItems = searchResponse.Items
                .Where(item => item.Id.Kind == "youtube#video")
                .Select(item => new VideoItem
                {
                    Title = item.Snippet.Title,
                    VideoId = item.Id.VideoId
                })
                .ToList();

            return videoItems;
        }


        public class VideoItem
        {
            public string Title { get; set; }
            public string VideoId { get; set; }
        }

        private string GetMusicDirectoryPath()
        {
            string settingsFile = "D:\\music_path.json";

            try
            {
                if (File.Exists(settingsFile))
                {
                    using (StreamReader reader = new StreamReader(settingsFile))
                    {

                        string path = JsonSerializer.Deserialize<string>(reader.ReadToEnd());


                        if (Directory.Exists(path))
                        {
                            Debug.WriteLine(path);
                            return path;
                        }
                        else
                        {
                            MessageBox.Show($"The directory path in the settings file does not exist: {path}");
                            return ""; 
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Settings file not found.");
                    return ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading settings file: {ex.Message}");
                return ""; 
            }
        }



        private async Task<string> DownloadVideoAsync(string videoUrl)
        {
            try
            {
                var youTube = YouTube.Default;
                var video = await youTube.GetVideoAsync(videoUrl);


                string directoryPath = GetMusicDirectoryPath();


                if (string.IsNullOrEmpty(directoryPath))
                {
                    MessageBox.Show("Unable to determine the save directory.");
                    return string.Empty;
                }


                string filePath = Path.Combine(directoryPath, video.FullName);

                File.WriteAllBytes(filePath, await video.GetBytesAsync());

                return filePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error downloading video: {ex.Message}");
                return string.Empty;
            }
        }

        private async Task<string> FetchLyricsAsync(string artist, string track)
        {
            string apiKey = "d68cb25f0b9d39f050fbca805191783e";
            string searchUrl = $"https://api.musixmatch.com/ws/1.1/matcher.lyrics.get?q_track={Uri.EscapeDataString(track)}&q_artist={Uri.EscapeDataString(artist)}&apikey={apiKey}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(searchUrl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject searchResult = JObject.Parse(json);
                    var lyrics = searchResult["message"]["body"]["lyrics"]["lyrics_body"].ToString();


                    if (lyrics.Contains("..."))
                    {
                        lyrics += "\n\n[Truncated lyrics. Full lyrics available on Musixmatch]";
                    }

                    return lyrics;
                }
            }
            return "Lyrics not found.";
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            PlayVideoPage playVideoPage = new PlayVideoPage();
            playVideoPage.Show();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex >= 0 && track_list.SelectedIndex < paths.Count)
            {
                int selectedIndex = track_list.SelectedIndex;
                string filePath = paths[selectedIndex];


                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{Path.GetFileName(filePath)}' from the list and your music directory?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        track_list.Items.RemoveAt(selectedIndex);
                        paths.RemoveAt(selectedIndex);


                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                            Debug.WriteLine($"Deleted file: {filePath}");
                        }
                        else
                        {
                            Debug.WriteLine($"File not found: {filePath}");
                        }

                        if (player.URL == filePath)
                        {
                            player.Ctlcontrols.stop();
                            player.URL = "";

                            if (paths.Count > 0)
                            {

                                track_list.SelectedIndex = Math.Min(selectedIndex, paths.Count - 1);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting file: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a track to delete.");
            }
        }
    }
}
