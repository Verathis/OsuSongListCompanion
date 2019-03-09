using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OsuSongListCompanion
{
    public partial class MainForm : Form
    {
        Font unselectedFont = new Font("Calibri Light", 16, FontStyle.Regular);
        Font selectedFont = new Font("Calibri Light", 16, FontStyle.Italic);
        Color unselectedColor = ColorTranslator.FromHtml("#1B1F20");
        Color selectedColor = ColorTranslator.FromHtml("#222A2B");

        string[] folders;
        string defaultPath = Environment.ExpandEnvironmentVariables("%APPDATA%");
        string roamingFolder = "\\Roaming";
        //string fileName = String.Format(@"{0}\songlist.txt", Application.StartupPath);
        Random randomSong = new Random();
        string beatmapID;
        string beatmapLink;
        string baseLink = "https://osu.ppy.sh/beatmapsets/";

        string selectedPath = "";

        public MainForm()
        {
            InitializeComponent();
            importExportLabel.BackColor = selectedColor;
            importExportLabel.Font = selectedFont;
            tabControlBox.SelectTab(0);
        }
        
        private void MinimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void importExportLabel_Click(object sender, EventArgs e)
        {
            ResetUnselectedFonts();
            importExportLabel.BackColor = selectedColor;
            importExportLabel.Font = selectedFont;
            tabControlBox.SelectTab(0);
        }

        private void randomizerLabel_Click(object sender, EventArgs e)
        {
            if (songsListBox.Items.Count == 0)
            {
                MessageBox.Show("Import songs first.");
            }

            if (songsListBox.Items.Count > 0)
            {
                ResetUnselectedFonts();
                randomizerLabel.BackColor = selectedColor;
                randomizerLabel.Font = selectedFont;
                tabControlBox.SelectTab(1);
            }            
        }

        private void aboutLabel_Click(object sender, EventArgs e)
        {
            ResetUnselectedFonts();
            aboutLabel.BackColor = selectedColor;
            aboutLabel.Font = selectedFont;
            tabControlBox.SelectTab(2);
        }

        private void ResetUnselectedFonts()
        {
            importExportLabel.Font = unselectedFont;
            importExportLabel.BackColor = unselectedColor;

            randomizerLabel.BackColor = unselectedColor;
            randomizerLabel.Font = unselectedFont;

            aboutLabel.BackColor = unselectedColor;
            aboutLabel.Font = unselectedFont;
        }

        private void ImportSongs(object sender, EventArgs e)
        {
            string formattedDefault = defaultPath.Remove(defaultPath.Length - roamingFolder.Length);
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "Select the osu 'Songs' directory.";
            FBD.RootFolder = Environment.SpecialFolder.Desktop;
            FBD.SelectedPath = @formattedDefault;

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                songsListBox.Items.Clear();
                folders = Directory.GetDirectories(FBD.SelectedPath);
                selectedPath = FBD.SelectedPath;

                foreach (string folder in folders)
                {
                    songsListBox.Items.Add(folder.Remove(0, selectedPath.Length + 1));
                }
                
                exportButton.Visible = true;
            }
        }

        private void ExportToFile(object sender, EventArgs e)
        {
            using (var textFile = new StreamWriter("songlist.txt", false))
            {
                foreach (var item in songsListBox.Items)
                {
                    textFile.WriteLine(item);
                }
            }
        }

        private void ChooseRandomSong(object sender, EventArgs e)
        {
            int index = randomSong.Next(folders.Count());
            string formattedFolder = folders[index].Remove(0, selectedPath.Length + 1);
            randomSongBox.Text = folders[index].Remove(0, selectedPath.Length + 1);

            if (beatmapPageButton.Visible == false)
            {
                beatmapPageButton.Visible = true;
            }
        }

        private void GoToSongPage(object sender, EventArgs e)
        {
            beatmapID = randomSongBox.Text;
            beatmapLink = baseLink + beatmapID.Remove(beatmapID.IndexOf(" "));
            Process.Start(beatmapLink);
        }

        private void GoToTwitchPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.twitch.tv/verathis");
        }

        private void GoToTwitterPage(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.twitter.com/Verathis");
        }        


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
