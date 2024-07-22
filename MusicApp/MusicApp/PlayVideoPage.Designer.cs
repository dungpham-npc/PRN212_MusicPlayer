namespace MusicApp
{
    partial class PlayVideoPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayVideoPage));
            listVideo = new ListBox();
            mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            btnLoadFile = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).BeginInit();
            SuspendLayout();
            // 
            // listVideo
            // 
            listVideo.FormattingEnabled = true;
            listVideo.ItemHeight = 15;
            listVideo.Location = new Point(541, 375);
            listVideo.Name = "listVideo";
            listVideo.Size = new Size(259, 154);
            listVideo.TabIndex = 0;
            listVideo.SelectedIndexChanged += listVideo_SelectedIndexChanged;
            // 
            // mediaPlayer
            // 
            mediaPlayer.AllowDrop = true;
            mediaPlayer.Dock = DockStyle.Top;
            mediaPlayer.Enabled = true;
            mediaPlayer.Location = new Point(0, 0);
            mediaPlayer.Margin = new Padding(3, 2, 3, 2);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.OcxState = (AxHost.State)resources.GetObject("mediaPlayer.OcxState");
            mediaPlayer.Size = new Size(800, 370);
            mediaPlayer.TabIndex = 10;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(311, 420);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(106, 53);
            btnLoadFile.TabIndex = 11;
            btnLoadFile.Text = "Browse File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(38, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(106, 53);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PlayVideoPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(btnBack);
            Controls.Add(btnLoadFile);
            Controls.Add(mediaPlayer);
            Controls.Add(listVideo);
            Name = "PlayVideoPage";
            Text = "PlayVideoPage";
            ((System.ComponentModel.ISupportInitialize)mediaPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listVideo;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
        private Button btnLoadFile;
        private Button btnBack;
    }
}