using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace BrinkConfigGenerator
{
    public partial class Form1 : Form
    {

        private TextBox[] _videos;
        private String _topDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Brink Config Generator\Configs " + DateTime.Today.ToString("MM-dd-yy");
        private String[] _xmlPaths = new String[]

        {
            "XMLConfigs/Station1/Register.cfg",
            "XMLConfigs/Station2Plus/Register.cfg",
            "XMLConfigs/Kitchen/Kitchen.cfg"
        };
        public Form1()
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
            if(videoChkBox.Checked)
            {
                videoCmbo.Enabled = true;
            } else
            {
                videoCmbo.Enabled = false;
                videoCmbo.Text = "Total Videos";
            } 

            for(int i = 0; i < _videos.Length; i++)
            {
                _videos[i].Enabled = false;
                _videos[i].Text = "";
            }

        }

        private void VideoCmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int videoAmmount = int.Parse(videoCmbo.SelectedItem.ToString());
            int count = 0;
            for(int i = 0;  i < videoAmmount; i++)
            {
                _videos[i].Enabled = true;
                count++;
            }

            while(count < _videos.Length)
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
            if (!Directory.Exists(_topDir))
            {
                Directory.CreateDirectory(_topDir);
            }

            if (stationCmbo.Text != "Total Stations")
            {
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
            }
            if (videoCmbo.Text != "Total Videos")
            {
                int videoCount = int.Parse(videoCmbo.SelectedItem.ToString());
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

            RegisterXMLModifier(stationFullPath, "\\Register.cfg", 0);
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

        private void RegisterXMLModifier(String fullPath, String fileName, int index)
        {
            String location = locationIDTxt.Text;
            String stationOneIP = stationOneIpTxt.Text;
            String serverEndPoint = serverEndPointTxt.Text;
            String backupEndPoint = backupEndPointTxt.Text;
            String[] elements = new String[]
            {
                "//Register",
                "//Register//EndPoint",
                "//Register//ServerEndPoint",
                "//Register//BackupEndPoint"
            };

            XmlDocument xmlLoader = new XmlDocument();
            xmlLoader.Load(_xmlPaths[index]);
            
            for (int i = 1; i < elements.Length; i++)
            {
               XmlElement elementLoader = (XmlElement)xmlLoader.SelectSingleNode(elements[i - 1]);
                // STATION 1 CONFIG GENERATION
                if (i == 1)
                {
                    elementLoader.SetAttribute("LocationUid", location); // Set to new value.
                    elementLoader.SetAttribute("TerminalNumber", i.ToString()); // Set to new value.
                } else if (i == 2)
                {
                    elementLoader.SetAttribute("Address", serverEndPoint); // Set to new value.
                } else if (i == 3)
                {
                    elementLoader.SetAttribute("Address", serverEndPoint); // Set to new value.
                }
                // END STATION 1 CONFIG GENERATION
            }
            xmlLoader.Save(fullPath + fileName);
        }
        private void KitchenXMLModifier(String fullPath, String fileName)
        {
            String location = locationIDTxt.Text;

            XmlDocument statOneConfig = new XmlDocument();
            statOneConfig.Load("XMLConfigs/Station1/Register.xml");
            XmlElement locationUid = (XmlElement)statOneConfig.SelectSingleNode("//Kitchen");
            if (locationUid != null /* && locationIDTxt.Text != null */)
            {
                locationUid.SetAttribute("LocationUid", location); // Set to new value.
            }
            statOneConfig.Save(fullPath + fileName);
        }

    }
}
