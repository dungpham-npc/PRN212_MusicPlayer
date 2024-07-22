namespace MusicApp
{
    partial class MusicHomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicHomePage));
            preview_btn = new Button();
            next_btn = new Button();
            play_btn = new Button();
            pause_btn = new Button();
            stop_btn = new Button();
            open_btn = new Button();
            p_bar = new ProgressBar();
            track_list = new ListBox();
            pic_art = new PictureBox();
            trackVolume = new TrackBar();
            volume_label = new Label();
            lbl_volume = new Label();
            player = new AxWMPLib.AxWindowsMediaPlayer();
            lbl_track_start = new Label();
            lbl_track_end = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            changeMusicPathToolStripMenuItem = new ToolStripMenuItem();
            btnPlayMode = new Button();
            label1 = new Label();
            btnQuit = new Button();
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            youtube_search_result = new ListBox();
            label2 = new Label();
            youtube_searchbar = new TextBox();
            btnYoutubeSearch = new Button();
            btnAddYoutubeTrack = new Button();
            txtLyrics = new TextBox();
            btnPlayVideo = new Button();
            btnRemoveItem = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_art).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // preview_btn
            // 
            preview_btn.FlatStyle = FlatStyle.Flat;
            preview_btn.Location = new Point(85, 640);
            preview_btn.Name = "preview_btn";
            preview_btn.Size = new Size(103, 43);
            preview_btn.TabIndex = 0;
            preview_btn.Text = "Previous";
            preview_btn.UseVisualStyleBackColor = true;
            preview_btn.Click += preview_btn_Click;
            // 
            // next_btn
            // 
            next_btn.FlatStyle = FlatStyle.Flat;
            next_btn.Location = new Point(194, 640);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(103, 43);
            next_btn.TabIndex = 1;
            next_btn.Text = "Next";
            next_btn.UseVisualStyleBackColor = true;
            next_btn.Click += next_btn_Click;
            // 
            // play_btn
            // 
            play_btn.FlatStyle = FlatStyle.Flat;
            play_btn.Location = new Point(303, 640);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(103, 43);
            play_btn.TabIndex = 2;
            play_btn.Text = "Play";
            play_btn.UseVisualStyleBackColor = true;
            play_btn.Click += play_btn_Click;
            // 
            // pause_btn
            // 
            pause_btn.FlatStyle = FlatStyle.Flat;
            pause_btn.Location = new Point(411, 640);
            pause_btn.Name = "pause_btn";
            pause_btn.Size = new Size(103, 43);
            pause_btn.TabIndex = 3;
            pause_btn.Text = "Pause";
            pause_btn.UseVisualStyleBackColor = true;
            pause_btn.Click += pause_btn_Click;
            // 
            // stop_btn
            // 
            stop_btn.FlatStyle = FlatStyle.Flat;
            stop_btn.Location = new Point(521, 640);
            stop_btn.Name = "stop_btn";
            stop_btn.Size = new Size(103, 43);
            stop_btn.TabIndex = 4;
            stop_btn.Text = "Stop";
            stop_btn.UseVisualStyleBackColor = true;
            stop_btn.Click += stop_btn_Click;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(654, 621);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(186, 61);
            open_btn.TabIndex = 5;
            open_btn.Text = "Choose File";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // p_bar
            // 
            p_bar.Location = new Point(55, 584);
            p_bar.Name = "p_bar";
            p_bar.Size = new Size(736, 15);
            p_bar.TabIndex = 6;
            p_bar.Click += p_bar_Click;
            // 
            // track_list
            // 
            track_list.BackColor = Color.Gray;
            track_list.ForeColor = Color.Maroon;
            track_list.FormattingEnabled = true;
            track_list.Location = new Point(413, 287);
            track_list.Name = "track_list";
            track_list.Size = new Size(359, 264);
            track_list.TabIndex = 7;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // pic_art
            // 
            pic_art.Image = (Image)resources.GetObject("pic_art.Image");
            pic_art.Location = new Point(106, 287);
            pic_art.Name = "pic_art";
            pic_art.Size = new Size(301, 264);
            pic_art.TabIndex = 8;
            pic_art.TabStop = false;
            // 
            // trackVolume
            // 
            trackVolume.Location = new Point(1253, 203);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Orientation = Orientation.Vertical;
            trackVolume.Size = new Size(56, 207);
            trackVolume.TabIndex = 10;
            trackVolume.TickStyle = TickStyle.TopLeft;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // volume_label
            // 
            volume_label.AutoSize = true;
            volume_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volume_label.Location = new Point(1232, 403);
            volume_label.Name = "volume_label";
            volume_label.Size = new Size(114, 37);
            volume_label.TabIndex = 11;
            volume_label.Text = "Volume";
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.Location = new Point(1253, 180);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(45, 20);
            lbl_volume.TabIndex = 12;
            lbl_volume.Text = "100%";
            // 
            // player
            // 
            player.AllowDrop = true;
            player.Dock = DockStyle.Top;
            player.Enabled = true;
            player.Location = new Point(0, 30);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(1353, 142);
            player.TabIndex = 9;
            player.Visible = false;
            player.Enter += player_Enter;
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.BackColor = SystemColors.ActiveCaptionText;
            lbl_track_start.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_start.ForeColor = Color.Lime;
            lbl_track_start.Location = new Point(0, 37);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(242, 91);
            lbl_track_start.TabIndex = 13;
            lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.BackColor = SystemColors.ActiveCaptionText;
            lbl_track_end.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_end.ForeColor = Color.Lime;
            lbl_track_end.Location = new Point(952, 37);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(242, 91);
            lbl_track_end.TabIndex = 14;
            lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1353, 30);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { changeMusicPathToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 24);
            toolStripMenuItem1.Text = "Settings";
            // 
            // changeMusicPathToolStripMenuItem
            // 
            changeMusicPathToolStripMenuItem.Name = "changeMusicPathToolStripMenuItem";
            changeMusicPathToolStripMenuItem.Size = new Size(216, 26);
            changeMusicPathToolStripMenuItem.Text = "Change Music Path";
            changeMusicPathToolStripMenuItem.Click += changeMusicPathToolStripMenuItem_Click;
            // 
            // btnPlayMode
            // 
            btnPlayMode.FlatStyle = FlatStyle.Flat;
            btnPlayMode.Location = new Point(303, 700);
            btnPlayMode.Name = "btnPlayMode";
            btnPlayMode.Size = new Size(103, 43);
            btnPlayMode.TabIndex = 16;
            btnPlayMode.Text = "Normal";
            btnPlayMode.UseVisualStyleBackColor = true;
            btnPlayMode.Click += btnPlayMode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 711);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 17;
            label1.Text = "Play Mode: ";
            label1.Click += label1_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(1160, 691);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(186, 61);
            btnQuit.TabIndex = 18;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.MenuBar;
            trackBar1.Location = new Point(42, 557);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(757, 56);
            trackBar1.SmallChange = 5;
            trackBar1.TabIndex = 19;
            trackBar1.TickStyle = TickStyle.None;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(221, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 97);
            panel1.TabIndex = 20;
            // 
            // youtube_search_result
            // 
            youtube_search_result.BackColor = Color.Gray;
            youtube_search_result.ForeColor = Color.Maroon;
            youtube_search_result.FormattingEnabled = true;
            youtube_search_result.Location = new Point(835, 287);
            youtube_search_result.Name = "youtube_search_result";
            youtube_search_result.Size = new Size(359, 264);
            youtube_search_result.TabIndex = 21;
            youtube_search_result.SelectedIndexChanged += youtube_search_result_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 189);
            label2.Name = "label2";
            label2.Size = new Size(177, 20);
            label2.TabIndex = 22;
            label2.Text = "Search online on Youtube";
            // 
            // youtube_searchbar
            // 
            youtube_searchbar.Location = new Point(280, 187);
            youtube_searchbar.Name = "youtube_searchbar";
            youtube_searchbar.Size = new Size(367, 27);
            youtube_searchbar.TabIndex = 23;
            youtube_searchbar.TextChanged += youtube_searchbar_TextChanged;
            // 
            // btnYoutubeSearch
            // 
            btnYoutubeSearch.Location = new Point(665, 187);
            btnYoutubeSearch.Name = "btnYoutubeSearch";
            btnYoutubeSearch.Size = new Size(94, 29);
            btnYoutubeSearch.TabIndex = 24;
            btnYoutubeSearch.Text = "Search";
            btnYoutubeSearch.UseVisualStyleBackColor = true;
            btnYoutubeSearch.Click += btnYoutubeSearch_Click;
            // 
            // btnAddYoutubeTrack
            // 
            btnAddYoutubeTrack.FlatStyle = FlatStyle.Flat;
            btnAddYoutubeTrack.Location = new Point(952, 571);
            btnAddYoutubeTrack.Name = "btnAddYoutubeTrack";
            btnAddYoutubeTrack.Size = new Size(143, 55);
            btnAddYoutubeTrack.TabIndex = 25;
            btnAddYoutubeTrack.Text = "Download and add to tracklist";
            btnAddYoutubeTrack.UseVisualStyleBackColor = true;
            btnAddYoutubeTrack.Click += btnAddYoutubeTrack_Click;
            // 
            // txtLyrics
            // 
            txtLyrics.Location = new Point(779, 131);
            txtLyrics.Multiline = true;
            txtLyrics.Name = "txtLyrics";
            txtLyrics.ScrollBars = ScrollBars.Vertical;
            txtLyrics.Size = new Size(399, 151);
            txtLyrics.TabIndex = 9;
            // 
            // btnPlayVideo
            // 
            btnPlayVideo.Location = new Point(952, 669);
            btnPlayVideo.Margin = new Padding(3, 4, 3, 4);
            btnPlayVideo.Name = "btnPlayVideo";
            btnPlayVideo.Size = new Size(143, 61);
            btnPlayVideo.TabIndex = 27;
            btnPlayVideo.Text = "Play Video";
            btnPlayVideo.UseVisualStyleBackColor = true;
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(654, 691);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(186, 61);
            btnRemoveItem.TabIndex = 28;
            btnRemoveItem.Text = "Delete item from track";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // MusicHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1353, 763);
            Controls.Add(btnRemoveItem);
            Controls.Add(btnPlayVideo);
            Controls.Add(btnAddYoutubeTrack);
            Controls.Add(btnYoutubeSearch);
            Controls.Add(youtube_searchbar);
            Controls.Add(label2);
            Controls.Add(youtube_search_result);
            Controls.Add(panel1);
            Controls.Add(btnQuit);
            Controls.Add(label1);
            Controls.Add(btnPlayMode);
            Controls.Add(lbl_track_end);
            Controls.Add(lbl_track_start);
            Controls.Add(lbl_volume);
            Controls.Add(volume_label);
            Controls.Add(trackVolume);
            Controls.Add(player);
            Controls.Add(pic_art);
            Controls.Add(track_list);
            Controls.Add(p_bar);
            Controls.Add(open_btn);
            Controls.Add(stop_btn);
            Controls.Add(pause_btn);
            Controls.Add(play_btn);
            Controls.Add(next_btn);
            Controls.Add(preview_btn);
            Controls.Add(menuStrip1);
            Controls.Add(trackBar1);
            Controls.Add(txtLyrics);
            MainMenuStrip = menuStrip1;
            Name = "MusicHomePage";
            Text = "Form1";
            Load += MusicHomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pic_art).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button preview_btn;
        private Button next_btn;
        private Button play_btn;
        private Button pause_btn;
        private Button stop_btn;
        private Button open_btn;
        private ProgressBar p_bar;
        private ListBox track_list;
        private PictureBox pic_art;
        private TrackBar trackVolume;
        private Label volume_label;
        private Label lbl_volume;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Label lbl_track_start;
        private Label lbl_track_end;
        private System.Windows.Forms.Timer timer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem changeMusicPathToolStripMenuItem;
        private Button btnPlayMode;
        private Label label1;
        private Button btnQuit;
        private TrackBar trackBar1;
        private Panel panel1;
        private ListBox youtube_search_result;
        private Label label2;
        private TextBox youtube_searchbar;
        private Button btnYoutubeSearch;
        private Button btnAddYoutubeTrack;
        private System.Windows.Forms.TextBox txtLyrics;
        private Button btnPlayVideo;
        private Button btnRemoveItem;
    }
}
