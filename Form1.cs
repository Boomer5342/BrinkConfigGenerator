using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BrinkConfigGenerator.services;
using Microsoft.VisualBasic;

namespace BrinkConfigGenerator
{
    public partial class BrinkConfigGenerator : Form
    {

        private TextBox[] _videos;
        private String _topDir;
        public BrinkConfigGenerator()
        {
            InitializeComponent();
            FillCombos();

            _videos = new TextBox[]
            {
                videoOneTxt,
                videoTwoTxt,
                videoThreeTxt,
                videoFourTxt,
                videoFiveTxt,
                videoSixTxt,
                videoSevenTxt,
                videoEightTxt,
                videoNineTxt,
                videoTenTxt,
                videoElevenTxt,
                videoTwelveTxt,
                videoThirteenTxt,
                videoFourteenTxt,
            };
        }

        private void FillCombos()
        {
            stationCmbo.Items.AddRange(Enumerable.Range(1, 20).Select(i => (object)i).ToArray());
            videoCmbo.Items.AddRange(Enumerable.Range(1, 14).Select(i => (object)i).ToArray());
        }

        private String[,] RegAndVidTextBoxes()
        {
            String[,] regAndVidTxt = new String[,]
            {
                { locationIDTxt.Text, "Location ID" },
                { backupEndPointTxt.Text, "Backup End Point" },
                { stationOneIpTxt.Text, "Station 1 IP" },
                { serverEndPointTxt.Text, "Server End Point" },
            };
            return regAndVidTxt;
        }
        private String[,] RegTextBoxes()
        {
            String[,] regTxt = new String[,]
            {
                { registerLocationIDTxt.Text, "Location ID" },
                { registerBackupEndPointTxt.Text, "Backup End Point" },
                { registerStationOneIPTxt.Text, "Station 1 IP" },
                { registerServerEndPointTxt.Text, "Server End Point" },
                { registerNumberTxt.Text, "Station Number" }
            };
            return regTxt;
        }
        private String[,] VidTextBoxes()
        {
            String[,] vidTxt = new String[,]
            {
                { kitchenLocationIdTxt.Text, "Location ID" },
                { kitchenBackupEndPointTxt.Text, "Backup End Point" },
                { kitchenStationOneIPTxt.Text, "Station 1 IP" },
                { kitchenNumberTxt.Text, "Kitchen Number" }
            };
            return vidTxt;
        }
        private String[,] VideosTextBoxes()
        {
            String[,] videoTextBoxes = new String[_videos.Length,_videos.Length];
            for (int i = 0; i < _videos.Length; i++)
            {
                videoTextBoxes[i,0] = _videos[i].Text;
                videoTextBoxes[i, 1] = ("Video " + (i + 1));
            }
            return videoTextBoxes;
        }
        private void VideoChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (videoChkBox.Checked)
            {
                videoCmbo.Enabled = true;
            }
            else
            {
                videoCmbo.Enabled = false;
                videoCmbo.Text = "Total Videos";
            }

            for (int i = 0; i < _videos.Length; i++)
            {
                _videos[i].Enabled = false;
                _videos[i].Text = "";
            }

        }

        private bool FolderSelection()
        {
            String message = "Please Input Folder Name. The name provided will automatically contain the current date.";
            String title = "Folder Name";
            String defaultValue = "Brink Config Generator";
            String folder = Interaction.InputBox(message, title, defaultValue);

            if (folder == "")
            {
                return false;
            }

            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.RootFolder = Environment.SpecialFolder.Desktop;
            dir.Description = "Please Select Save Location";
            dir.ShowNewFolderButton = false;

            if (dir.ShowDialog() == DialogResult.OK)
            {
                _topDir = dir.SelectedPath + @"\" + folder + " " + DateTime.Today.ToString("MM-dd-yy");
            } 
            else
            {
                return false;
            }

            return true;

        }

        private void VideoCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int videoAmmount = int.Parse(videoCmbo.SelectedItem.ToString());
            int count = 0;
            for (int i = 0; i < videoAmmount; i++)
            {
                _videos[i].Enabled = true;
                count++;
            }

            while (count < _videos.Length)
            {
                _videos[count].Enabled = false;
                _videos[count].Text = "";
                count++;
            }

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            videoChkBox.Checked = false;
            stationCmbo.Text = "Total Stations";
            locationIDTxt.Text = "";
            stationOneIpTxt.Text = "";
            serverEndPointTxt.Text = "";
            backupEndPointTxt.Text = "";
        }

        private void GenConfigBtn_Click(object sender, EventArgs e)
        {
            String stationFullPath = "";
            String videoFullPath = "";
            int videoCount = 0;

            List<int> enabledVideos = new List<int>();
            for (int i = 0; i < _videos.Length; i++)
            {
                if (_videos[i].Enabled == true)
                {
                    enabledVideos.Add(i);
                }
            }
            int[] comboIndex = new int[]
            {
                stationCmbo.SelectedIndex,
                videoCmbo.SelectedIndex
            };
            bool enabled = videoCmbo.Enabled;
            if (!ErrorCheckingService.RegAndVidErrorChecker(comboIndex, enabled, RegAndVidTextBoxes(), VideosTextBoxes(), enabledVideos)) return;
            if (!FolderSelection()) return;

            if (!Directory.Exists(_topDir))
            {
                Directory.CreateDirectory(_topDir);
            }

            int stationCount = int.Parse(stationCmbo.SelectedItem.ToString());
            for (int i = 1; i <= stationCount; i++)
            {
                var stationSubdir = "Station " + i;
                stationFullPath = Path.Combine(_topDir, stationSubdir);
                if (!Directory.Exists(stationFullPath))
                {
                    Directory.CreateDirectory(stationFullPath);
                }
            }

            if (videoChkBox.Checked)
            {
                videoCount = int.Parse(videoCmbo.SelectedItem.ToString());
                for (int i = 1; i <= videoCount; i++)
                {
                    var videoSubdir = "Video " + _videos[i - 1].Text;
                    videoFullPath = Path.Combine(_topDir, videoSubdir);
                    if (!Directory.Exists(videoFullPath))
                    {
                        Directory.CreateDirectory(videoFullPath);
                    }
                }
            }

            for (int i = 1; i <= stationCount; i++)
            {
                if (i == 1)
                {
                    stationFullPath = _topDir + "\\Station 1";
                    XMLModificationService.RegisterOneXMLModifier(RegAndVidTextBoxes(), stationFullPath, "\\Register.cfg", 0);
                }
                if (i != 1)
                {
                    stationFullPath = _topDir + "\\Station " + i;
                    XMLModificationService.RegisterTwoPlusXMLModifier(RegAndVidTextBoxes(), stationFullPath, "\\Register.cfg", 1, i);
               }
            }

            List<String> videoNums = new List<String>();

            for (int i = 0; i < _videos.Length; i++)
            {
                if (_videos[i].Enabled == true)
                {
                    videoNums.Add(_videos[i].Text);
                }
            }

            for (int i = 0; i < videoNums.Count; i++)
            {
                videoFullPath = _topDir + "\\Video " + videoNums[i];
                XMLModificationService.KitchenXMLModifier(RegAndVidTextBoxes(), videoFullPath, "\\Kitchen.cfg", 2, videoNums[i]);
            }

            OpenFolder(_topDir);

        }
        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }

        private void registerGenConfigBtn_Click(object sender, EventArgs e)
        {
            bool isStatOne = stationChkBox.Checked;
            if (!ErrorCheckingService.SingleRegErrorChecker(RegTextBoxes(), isStatOne)) return;
            if (!FolderSelection()) return;

            // Creates Root Dir
            if (!Directory.Exists(_topDir))
            {
                Directory.CreateDirectory(_topDir);
            }
            var stationSubdir = "Station " + registerNumberTxt.Text;
            String stationFullPath = Path.Combine(_topDir, stationSubdir);

            // Creates Station Dir
            if (!Directory.Exists(stationFullPath))
            {
                Directory.CreateDirectory(stationFullPath);
            }

            if (registerNumberTxt.Text == "1")
            {
                stationFullPath = _topDir + "\\Station 1";
                XMLModificationService.RegisterOneXMLModifier(RegTextBoxes(), stationFullPath, "\\Register.cfg", 0);
            }
            else
            {
                stationFullPath = _topDir + "\\Station " + registerNumberTxt.Text;
                int statNum = int.Parse(registerNumberTxt.Text);
                XMLModificationService.RegisterTwoPlusXMLModifier(RegTextBoxes(), stationFullPath, "\\Register.cfg", 1, statNum);
            }

            OpenFolder(_topDir);

        }
        private void registerResetBtn_Click(object sender, EventArgs e)
        {
            registerNumberTxt.Text = "";
            registerLocationIDTxt.Text = "";
            registerStationOneIPTxt.Text = "";
            registerServerEndPointTxt.Text = "";
            registerBackupEndPointTxt.Text = "";
            stationChkBox.Checked = false;
        }

        private void stationChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stationChkBox.Checked)
            {
                registerStationOneIPTxt.Enabled = false;
                registerBackupEndPointTxt.Enabled = false;
                registerStationOneIPTxt.Text = "";
                registerBackupEndPointTxt.Text = "";
            }
            else
            {
                registerStationOneIPTxt.Enabled = true;
                registerBackupEndPointTxt.Enabled = true;
            }
        }

        private void videoGenConfigBtn_Click(object sender, EventArgs e)
        {
            if (!ErrorCheckingService.SingleVideoErrorChecker(VidTextBoxes())) return;
            if (!FolderSelection()) return;
            // Creates Root Dir
            if (!Directory.Exists(_topDir))
            {
                Directory.CreateDirectory(_topDir);
            }
            var kitchenSubdir = "Video " + kitchenNumberTxt.Text;
            String kitchenFullPath = Path.Combine(_topDir, kitchenSubdir);

            // Creates Station Dir
            if (!Directory.Exists(kitchenFullPath))
            {
                Directory.CreateDirectory(kitchenFullPath);
            }

            kitchenFullPath = _topDir + "\\Video " + kitchenNumberTxt.Text;
            String kitchenNum = kitchenNumberTxt.Text;
            XMLModificationService.KitchenXMLModifier(VidTextBoxes(), kitchenFullPath, "\\Kitchen.cfg", 2, kitchenNum);

            OpenFolder(_topDir);

        }

        private void videoResetBtn_Click(object sender, EventArgs e)
        {
            kitchenNumberTxt.Text = "";
            kitchenLocationIdTxt.Text = "";
            kitchenBackupEndPointTxt.Text = "";
            kitchenStationOneIPTxt.Text = "";
        }
    }
}
