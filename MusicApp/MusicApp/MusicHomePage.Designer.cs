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
            ((System.ComponentModel.ISupportInitialize)pic_art).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            SuspendLayout();
            // 
            // preview_btn
            // 
            preview_btn.FlatStyle = FlatStyle.Flat;
            preview_btn.Location = new Point(22, 398);
            preview_btn.Name = "preview_btn";
            preview_btn.Size = new Size(103, 27);
            preview_btn.TabIndex = 0;
            preview_btn.Text = "Preview";
            preview_btn.UseVisualStyleBackColor = true;
            preview_btn.Click += preview_btn_Click;
            // 
            // next_btn
            // 
            next_btn.FlatStyle = FlatStyle.Flat;
            next_btn.Location = new Point(131, 398);
            next_btn.Name = "next_btn";
            next_btn.Size = new Size(103, 27);
            next_btn.TabIndex = 1;
            next_btn.Text = "Next";
            next_btn.UseVisualStyleBackColor = true;
            next_btn.Click += next_btn_Click;
            // 
            // play_btn
            // 
            play_btn.FlatStyle = FlatStyle.Flat;
            play_btn.Location = new Point(240, 398);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(103, 27);
            play_btn.TabIndex = 2;
            play_btn.Text = "Play";
            play_btn.UseVisualStyleBackColor = true;
            play_btn.Click += play_btn_Click;
            // 
            // pause_btn
            // 
            pause_btn.FlatStyle = FlatStyle.Flat;
            pause_btn.Location = new Point(349, 398);
            pause_btn.Name = "pause_btn";
            pause_btn.Size = new Size(103, 27);
            pause_btn.TabIndex = 3;
            pause_btn.Text = "Pause";
            pause_btn.UseVisualStyleBackColor = true;
            pause_btn.Click += pause_btn_Click;
            // 
            // stop_btn
            // 
            stop_btn.FlatStyle = FlatStyle.Flat;
            stop_btn.Location = new Point(458, 398);
            stop_btn.Name = "stop_btn";
            stop_btn.Size = new Size(103, 27);
            stop_btn.TabIndex = 4;
            stop_btn.Text = "Stop";
            stop_btn.UseVisualStyleBackColor = true;
            stop_btn.Click += stop_btn_Click;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(591, 380);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(186, 58);
            open_btn.TabIndex = 5;
            open_btn.Text = "Open";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // p_bar
            // 
            p_bar.Location = new Point(22, 357);
            p_bar.Name = "p_bar";
            p_bar.Size = new Size(755, 17);
            p_bar.TabIndex = 6;
            p_bar.Click += p_bar_Click;
            // 
            // track_list
            // 
            track_list.BackColor = Color.Gray;
            track_list.ForeColor = Color.Maroon;
            track_list.FormattingEnabled = true;
            track_list.Location = new Point(349, 100);
            track_list.Name = "track_list";
            track_list.Size = new Size(359, 251);
            track_list.TabIndex = 7;
            track_list.SelectedIndexChanged += track_list_SelectedIndexChanged;
            // 
            // pic_art
            // 
            pic_art.Image = (Image)resources.GetObject("pic_art.Image");
            pic_art.Location = new Point(42, 100);
            pic_art.Name = "pic_art";
            pic_art.Size = new Size(301, 251);
            pic_art.TabIndex = 8;
            pic_art.TabStop = false;
            // 
            // trackVolume
            // 
            trackVolume.Location = new Point(732, 131);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Orientation = Orientation.Vertical;
            trackVolume.Size = new Size(45, 197);
            trackVolume.TabIndex = 10;
            trackVolume.TickStyle = TickStyle.TopLeft;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // volume_label
            // 
            volume_label.AutoSize = true;
            volume_label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            volume_label.Location = new Point(712, 321);
            volume_label.Name = "volume_label";
            volume_label.Size = new Size(88, 30);
            volume_label.TabIndex = 11;
            volume_label.Text = "Volume";
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.Location = new Point(732, 109);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(44, 19);
            lbl_volume.TabIndex = 12;
            lbl_volume.Text = "100%";
            // 
            // player
            // 
            player.AllowDrop = true;
            player.Dock = DockStyle.Top;
            player.Enabled = true;
            player.Location = new Point(0, 0);
            player.Name = "player";
            player.OcxState = (AxHost.State)resources.GetObject("player.OcxState");
            player.Size = new Size(800, 94);
            player.TabIndex = 9;
            player.Enter += player_Enter;
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.BackColor = SystemColors.ActiveCaptionText;
            lbl_track_start.Font = new Font("Digital-7 Mono", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_start.ForeColor = Color.Lime;
            lbl_track_start.Location = new Point(22, 20);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(177, 64);
            lbl_track_start.TabIndex = 13;
            lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.BackColor = SystemColors.ActiveCaptionText;
            lbl_track_end.Font = new Font("Digital-7 Mono", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_track_end.ForeColor = Color.Lime;
            lbl_track_end.Location = new Point(611, 20);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(177, 64);
            lbl_track_end.TabIndex = 14;
            lbl_track_end.Text = "00:00";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MusicHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "MusicHomePage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pic_art).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
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
    }
}
