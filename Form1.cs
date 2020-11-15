using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

namespace BrinkConfigGenerator
{
    public partial class BrinkConfigGenerator : Form
    {

        private TextBox[] _videos;
        private String[] regAndVidTxt;
        private String[] regTxt;
        private String[] vidTxt;
        private String _topDir;
        private String[] _xmlPaths = new String[]

        {
            Application.StartupPath + @"\XMLConfigs\Station1\Register.cfg",
            Application.StartupPath + @"\XMLConfigs\Station2Plus\Register.cfg",
            Application.StartupPath + @"\XMLConfigs\Kitchen\Kitchen.cfg"
        };
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

            if (!ErrorChecker())
            {
                return;
            }
            if (!FolderSelection())
            {
                return;
            }

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
            regAndVidTxt = new String[]
            {
                locationIDTxt.Text,
                backupEndPointTxt.Text,
                stationOneIpTxt.Text,
                serverEndPointTxt.Text
            };
            for (int i = 1; i <= stationCount; i++)
            {
                if (i == 1)
                {
                    stationFullPath = _topDir + "\\Station 1";
                    RegisterOneXMLModifier(regAndVidTxt, stationFullPath, "\\Register.cfg", 0);
                }
                if (i != 1)
                {
                    stationFullPath = _topDir + "\\Station " + i;
                    RegisterTwoPlusXMLModifier(regAndVidTxt, stationFullPath, "\\Register.cfg", 1, i);
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
                KitchenXMLModifier(regAndVidTxt, videoFullPath, "\\Kitchen.cfg", 2, videoNums[i]);
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

        private void RegisterOneXMLModifier(String[] configChanges, String fullPath, String fileName, int index)
        {
            String[] elements = new String[]
            {
                "//Register",
                "//Register//EndPoint",
                "//Register//ServerEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 1; i <= elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i - 1]);
                // STATION 1 CONFIG GENERATION
                if (i == 1)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", i.ToString()); // Set to the value of i.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[3]); // Set to Server Endpoint Value.
                }
                else if (i == 3)
                {
                    elementLoader.SetAttribute("Address", configChanges[3]); // Set to Server Endpoint Value.
                }
                // END STATION 1 CONFIG GENERATION

            }
            xmlLoader.Save(fullPath + fileName);
        }
        private void RegisterTwoPlusXMLModifier(String[] configChanges, String fullPath, String fileName, int index, int statNum)
        {


            String[] elements = new String[]
            {
                "//Register",
                "//Register//EndPoint",
                "//Register//ServerEndPoint",
                "//Register//BackupEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 0; i < elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i]);
                // STATION 2 PLUS CONFIG GENERATION
                if (i == 0)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", statNum.ToString()); // Set to the value of i.
                }
                else if (i == 1)
                {
                    elementLoader.SetAttribute("Address", configChanges[2]); // Set to Server Endpoint Value.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[3]); // Set to Server Endpoint Value.
                }
                else if (i == 3)
                {
                    elementLoader.SetAttribute("Address", configChanges[1]); // Set to Server Endpoint Value.
                }
                // END STATION 2 PLUS CONFIG GENERATION

            }
            xmlLoader.Save(fullPath + fileName);
        }
        private void KitchenXMLModifier(String[] configChanges, String fullPath, String fileName, int index, String videoNum)
        {
            String[] elements = new String[]
            {
                "//Kitchen",
                "//Kitchen//EndPoint",
                "//Kitchen//BackupEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            for (int i = 0; i < elements.Length; i++)
            {
                XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i]);
                Console.WriteLine(elements[i]);
                Console.WriteLine(configChanges[0]);
                // KITCHEN VIDEO CONFIG GENERATION
                if (i == 0)
                {
                    elementLoader.SetAttribute("LocationUid", configChanges[0]); // Set to Location Value.
                    elementLoader.SetAttribute("TerminalNumber", videoNum); // Set to the value of i.
                }
                else if (i == 1)
                {
                    elementLoader.SetAttribute("Address", configChanges[2]); // Set to Server Endpoint Value.
                }
                else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", configChanges[1]); // Set to Server Endpoint Value.
                }
                // KITCHEN VIDEO CONFIG GENERATION
                xmlLoader.Save(fullPath + fileName);

            }

        }

        private void registerGenConfigBtn_Click(object sender, EventArgs e)
        {

            if (!ErrorChecker())
            {
                return;
            }
            if (!FolderSelection())
            {
                return;
            }

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

            regTxt = new String[]
            {
                registerLocationIDTxt.Text,
                registerBackupEndPointTxt.Text,
                registerStationOneIPTxt.Text,
                registerServerEndPointTxt.Text
            };

            if (registerNumberTxt.Text == "1")
            {
                stationFullPath = _topDir + "\\Station 1";
                RegisterOneXMLModifier(regTxt, stationFullPath, "\\Register.cfg", 0);
            }
            else
            {
                stationFullPath = _topDir + "\\Station " + registerNumberTxt.Text;
                int statNum = int.Parse(registerNumberTxt.Text);
                RegisterTwoPlusXMLModifier(regTxt, stationFullPath, "\\Register.cfg", 1, statNum);
            }

            OpenFolder(_topDir);

        }

        private bool ErrorChecker()
        {
            if (registerVideoTab.SelectedTab == registerAndVideo)
            {
                if (stationCmbo.Text == "Total Stations")
                {
                    MessageBox.Show("Please select station amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (videoChkBox.Checked && videoCmbo.Text == "Total Videos")
                {
                    MessageBox.Show("Please select video amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (locationIDTxt.Text == "")
                {
                    MessageBox.Show("Please fill in location ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (stationOneIpTxt.Text == "")
                {
                    MessageBox.Show("Please fill in station one IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (serverEndPointTxt.Text == "")
                {
                    MessageBox.Show("Please fill in the server end point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (backupEndPointTxt.Text == "")
                {
                    MessageBox.Show("Please fill in the backup end point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                List<int> enabledVideos = new List<int>();
                for (int i = 0; i < _videos.Length; i++)
                {
                    if (_videos[i].Enabled == true)
                    {
                        enabledVideos.Add(i);
                    }
                }

                foreach (int index in enabledVideos)
                {
                    if (_videos[index].Text == "")
                    {
                        MessageBox.Show("Please verify all enabled video text boxes are filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else if (registerVideoTab.SelectedTab == register)
            {
                if (registerNumberTxt.Text == "")
                {
                    MessageBox.Show("Please provide a Station Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (registerLocationIDTxt.Text == "")
                {
                    MessageBox.Show("Please fill in the Register Location ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (registerServerEndPointTxt.Text == "")
                {
                    MessageBox.Show("Please provide a server end point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!stationChkBox.Checked && registerStationOneIPTxt.Text == "")
                {
                    MessageBox.Show("Please provide station 1's IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!stationChkBox.Checked && registerBackupEndPointTxt.Text == "")
                {
                    MessageBox.Show("Please provide a backup end point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (registerVideoTab.SelectedTab == video)
            {
                if (kitchenNumberTxt.Text == "")
                {
                    MessageBox.Show("Please provide kitchen terminal number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (kitchenLocationIdTxt.Text == "")
                {
                    MessageBox.Show("Please provide a location ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (kitchenBackupEndPointTxt.Text == "")
                {
                    MessageBox.Show("Please provide backup end point", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (kitchenStationOneIPTxt.Text == "")
                {
                    MessageBox.Show("Please provide station 1's IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
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
            if (!ErrorChecker())
            {
                return;
            }
            if (!FolderSelection())
            {
                return;
            }

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

            vidTxt = new String[]
            {
                kitchenLocationIdTxt.Text,
                kitchenBackupEndPointTxt.Text,
                kitchenStationOneIPTxt.Text
            };

            kitchenFullPath = _topDir + "\\Video " + kitchenNumberTxt.Text;
            String kitchenNum = kitchenNumberTxt.Text;
            KitchenXMLModifier(vidTxt, kitchenFullPath, "\\Kitchen.cfg", 2, kitchenNum);

            OpenFolder(_topDir);

        }
    }
}
