using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        string pathBackground;
        string pathImage;
        string pathMusic;
        string[] paths, files;
        bool play = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            listTrack.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for (int x = 0; x < files.Length; x++)
                {
                    string filename = Path.GetFileName(files[x].FormatFileName());
                    listTrack.Items.Add(x + 1 + ". " + filename + " ");
                }
            }
        }

        private void listTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listTrack.SelectedIndex >= 0)
            {
                int backgroundIndex = random.Next(1, 6);
                picThum.Image = Image.FromFile(pathBackground + backgroundIndex + ".gif");
                player.URL = paths[listTrack.SelectedIndex];
                player.Ctlcontrols.play();
                lbInfor.Text = listTrack.GetItemText(listTrack.SelectedItem);
                picPlay.Image = Image.FromFile(pathImage + "pause.png");
                play = true;
                timerText.Start();
                toolTip1.SetToolTip(lbInfor, lbInfor.Text);
            }
            else
            {
                MessageBox.Show("Please click OPEN button to add the songs!", "Empty queue");
            }
        }

        private void picPlay_Click(object sender, EventArgs e)
        {
            if(!play) 
            {
                player.Ctlcontrols.play();
                picPlay.Image = Image.FromFile(pathImage + "pause.png");
                play = true;
            }
            else
            {
                player.Ctlcontrols.pause();
                picPlay.Image = Image.FromFile(pathImage + "play-music.png");
                play = false;
            }
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if(listTrack.SelectedIndex < listTrack.Items.Count - 1)
            {
                listTrack.SelectedIndex = listTrack.SelectedIndex + 1;
            }
        }

        private void picForward_Click(object sender, EventArgs e)
        {
            if (listTrack.SelectedIndex > 0)
            {
                listTrack.SelectedIndex = listTrack.SelectedIndex - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                processTimer.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                processTimer.Value = (int)player.Ctlcontrols.currentPosition;
                try
                {
                    lbStart.Text = player.Ctlcontrols.currentPositionString;
                    lbEnd.Text = player.Ctlcontrols.currentItem.durationString;
                }
                catch { }
                if(processTimer.Value == processTimer.Maximum - 1)
                {
                    if (listTrack.SelectedIndex < listTrack.Items.Count - 1)
                    {
                        listTrack.SelectedIndex = listTrack.SelectedIndex + 1;
                    }
                }
            }
        }

        private void timerText_Tick(object sender, EventArgs e)
        {
            lbInfor.Text = lbInfor.Text.Substring(1) + lbInfor.Text.Substring(0, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pathBackground = Application.StartupPath + @"\Background\";
            pathImage = Application.StartupPath + @"\Images\";
            pathMusic = Application.StartupPath + @"\Music\";
            lbInfor.Text = "Emty ";
            if(listTrack.Items.Count == 0)
            {
                listTrack.Items.Add("Click OPEN to select the songs to play.");
            }
            timerText.Stop();
            trackVolume.Value = 10;
            trackVolume.Maximum = 100;
            trackVolume.Minimum = 0;
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
        }

        private void processTimer_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / processTimer.Width;
        }

        private void picMute_Click(object sender, EventArgs e)
        {
            if(!player.settings.mute)
            {
                player.settings.mute = true;
            }
            else
            {
                player.settings.mute = false;
            }
            
        }

        private void lbEnd_Click(object sender, EventArgs e)
        {

        }

        private void processTimer_Click(object sender, EventArgs e)
        {

        }
    }


    // Format file name
    static class Format
    {
        public static string FormatFileName(this string filename, string stopAt = ".")
        {
            if (!String.IsNullOrWhiteSpace(filename))
            {
                int charLocation = filename.IndexOf(stopAt, StringComparison.Ordinal);
                if (charLocation > 0)
                {
                    return filename.Substring(0, charLocation);
                }
            }
            return String.Empty;
        }
    }
}
