using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADHDMusicPlayer
{
    public partial class ADHDMusicPlayer : Form
    {
        String[] paths, files;

        public ADHDMusicPlayer()
        {
            InitializeComponent();
        }

        private void SongsSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                files = dlg.SafeFileNames;
                paths = dlg.FileNames;

                for(int i = 0; i < files.Length; i++)
                {
                    SongsBox.Items.Add(files[i]);
                }
            }
        }

        private void SongsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = paths[SongsBox.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
