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

namespace BrinkConfigGenerator
{
    public partial class Form1 : Form
    {

        private TextBox[] _videos;
        private String _topDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Brink Config Generator\Configs " + DateTime.Today.ToString("MM-dd-yy");  

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
                    var stationFullPath = Path.Combine(_topDir, stationSubdir);
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
                    var videoFullPath = Path.Combine(_topDir, videoSubdir);
                    if (!Directory.Exists(videoFullPath))
                    {
                        Directory.CreateDirectory(videoFullPath);
                    }
                }

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

    }
}
