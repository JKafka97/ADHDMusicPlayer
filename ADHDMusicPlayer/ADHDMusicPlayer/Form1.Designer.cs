namespace ADHDMusicPlayer
{
    partial class ADHDMusicPlayer
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADHDMusicPlayer));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SongsBox = new System.Windows.Forms.ListBox();
            this.SongsSelect = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(652, 36);
            this.Header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SongsBox
            // 
            this.SongsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SongsBox.FormattingEnabled = true;
            this.SongsBox.ItemHeight = 16;
            this.SongsBox.Location = new System.Drawing.Point(452, 51);
            this.SongsBox.Name = "SongsBox";
            this.SongsBox.Size = new System.Drawing.Size(197, 244);
            this.SongsBox.TabIndex = 1;
            // 
            // SongsSelect
            // 
            this.SongsSelect.BackColor = System.Drawing.Color.IndianRed;
            this.SongsSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SongsSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SongsSelect.Location = new System.Drawing.Point(452, 301);
            this.SongsSelect.Name = "SongsSelect";
            this.SongsSelect.Size = new System.Drawing.Size(197, 47);
            this.SongsSelect.TabIndex = 2;
            this.SongsSelect.Text = "select";
            this.SongsSelect.UseVisualStyleBackColor = false;
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(11, 51);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(435, 297);
            this.WindowsMediaPlayer.TabIndex = 3;
            // 
            // ADHDMusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 371);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.SongsSelect);
            this.Controls.Add(this.SongsBox);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ADHDMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADHD Music Player";
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox SongsBox;
        private System.Windows.Forms.Button SongsSelect;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
    }
}

