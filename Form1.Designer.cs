namespace BrinkConfigGenerator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.videoChkBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stationCmbo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.locationIDTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.videoCmbo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stationOneIpTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.serverEndPointTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backupEndPointTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.videoOneTxt = new System.Windows.Forms.TextBox();
            this.videoFourteenTxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.videoThirteenTxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.videoTwelveTxt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.videoElevenTxt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.videoTenTxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.videoNineTxt = new System.Windows.Forms.TextBox();
            this.videoEightTxt = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.videoSevenTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.videoSixTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.videoFiveTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.videoFourTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.videoThreeTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.videoTwoTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genConfigBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register and Kitchen Config Generator";
            // 
            // videoChkBox
            // 
            this.videoChkBox.AutoSize = true;
            this.videoChkBox.Location = new System.Drawing.Point(220, 32);
            this.videoChkBox.Margin = new System.Windows.Forms.Padding(4);
            this.videoChkBox.Name = "videoChkBox";
            this.videoChkBox.Size = new System.Drawing.Size(200, 21);
            this.videoChkBox.TabIndex = 1;
            this.videoChkBox.Text = "Generate Kitchen Configs?";
            this.videoChkBox.UseVisualStyleBackColor = true;
            this.videoChkBox.CheckedChanged += new System.EventHandler(this.VideoChkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stations";
            // 
            // stationCmbo
            // 
            this.stationCmbo.FormattingEnabled = true;
            this.stationCmbo.Location = new System.Drawing.Point(81, 27);
            this.stationCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.stationCmbo.MaxDropDownItems = 10;
            this.stationCmbo.Name = "stationCmbo";
            this.stationCmbo.Size = new System.Drawing.Size(116, 24);
            this.stationCmbo.TabIndex = 3;
            this.stationCmbo.Text = "Total Stations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location ID";
            // 
            // locationIDTxt
            // 
            this.locationIDTxt.Location = new System.Drawing.Point(779, 28);
            this.locationIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.locationIDTxt.Name = "locationIDTxt";
            this.locationIDTxt.Size = new System.Drawing.Size(293, 22);
            this.locationIDTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitchen Videos";
            // 
            // videoCmbo
            // 
            this.videoCmbo.Enabled = false;
            this.videoCmbo.FormattingEnabled = true;
            this.videoCmbo.Location = new System.Drawing.Point(556, 27);
            this.videoCmbo.Margin = new System.Windows.Forms.Padding(4);
            this.videoCmbo.MaxDropDownItems = 10;
            this.videoCmbo.Name = "videoCmbo";
            this.videoCmbo.Size = new System.Drawing.Size(108, 24);
            this.videoCmbo.TabIndex = 7;
            this.videoCmbo.Text = "Total Videos";
            this.videoCmbo.SelectedIndexChanged += new System.EventHandler(this.VideoCmbo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Station 1 IP";
            // 
            // stationOneIpTxt
            // 
            this.stationOneIpTxt.Location = new System.Drawing.Point(104, 71);
            this.stationOneIpTxt.Margin = new System.Windows.Forms.Padding(4);
            this.stationOneIpTxt.Name = "stationOneIpTxt";
            this.stationOneIpTxt.Size = new System.Drawing.Size(149, 22);
            this.stationOneIpTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server End Point";
            // 
            // serverEndPointTxt
            // 
            this.serverEndPointTxt.Location = new System.Drawing.Point(428, 71);
            this.serverEndPointTxt.Margin = new System.Windows.Forms.Padding(4);
            this.serverEndPointTxt.Name = "serverEndPointTxt";
            this.serverEndPointTxt.Size = new System.Drawing.Size(216, 22);
            this.serverEndPointTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Backup End Point";
            // 
            // backupEndPointTxt
            // 
            this.backupEndPointTxt.Location = new System.Drawing.Point(825, 71);
            this.backupEndPointTxt.Margin = new System.Windows.Forms.Padding(4);
            this.backupEndPointTxt.Name = "backupEndPointTxt";
            this.backupEndPointTxt.Size = new System.Drawing.Size(247, 22);
            this.backupEndPointTxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(287, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(465, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Set Kitchen Video Terminal Numbers";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stationOneIpTxt);
            this.groupBox1.Controls.Add(this.videoChkBox);
            this.groupBox1.Controls.Add(this.backupEndPointTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.stationCmbo);
            this.groupBox1.Controls.Add(this.serverEndPointTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.locationIDTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.videoCmbo);
            this.groupBox1.Location = new System.Drawing.Point(16, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1085, 114);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.videoOneTxt);
            this.groupBox2.Controls.Add(this.videoFourteenTxt);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.videoThirteenTxt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.videoTwelveTxt);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.videoElevenTxt);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.videoTenTxt);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.videoNineTxt);
            this.groupBox2.Controls.Add(this.videoEightTxt);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.videoSevenTxt);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.videoSixTxt);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.videoFiveTxt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.videoFourTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.videoThreeTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.videoTwoTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1081, 187);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitchen Video Settings";
            // 
            // videoOneTxt
            // 
            this.videoOneTxt.Enabled = false;
            this.videoOneTxt.Location = new System.Drawing.Point(83, 85);
            this.videoOneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoOneTxt.Name = "videoOneTxt";
            this.videoOneTxt.Size = new System.Drawing.Size(53, 22);
            this.videoOneTxt.TabIndex = 43;
            // 
            // videoFourteenTxt
            // 
            this.videoFourteenTxt.Enabled = false;
            this.videoFourteenTxt.Location = new System.Drawing.Point(993, 133);
            this.videoFourteenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoFourteenTxt.Name = "videoFourteenTxt";
            this.videoFourteenTxt.Size = new System.Drawing.Size(53, 22);
            this.videoFourteenTxt.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(920, 137);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 41;
            this.label16.Text = "Video 14";
            // 
            // videoThirteenTxt
            // 
            this.videoThirteenTxt.Enabled = false;
            this.videoThirteenTxt.Location = new System.Drawing.Point(840, 133);
            this.videoThirteenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoThirteenTxt.Name = "videoThirteenTxt";
            this.videoThirteenTxt.Size = new System.Drawing.Size(53, 22);
            this.videoThirteenTxt.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(767, 137);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "Video 13";
            // 
            // videoTwelveTxt
            // 
            this.videoTwelveTxt.Enabled = false;
            this.videoTwelveTxt.Location = new System.Drawing.Point(696, 133);
            this.videoTwelveTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoTwelveTxt.Name = "videoTwelveTxt";
            this.videoTwelveTxt.Size = new System.Drawing.Size(53, 22);
            this.videoTwelveTxt.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(623, 137);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 17);
            this.label18.TabIndex = 37;
            this.label18.Text = "Video 12";
            // 
            // videoElevenTxt
            // 
            this.videoElevenTxt.Enabled = false;
            this.videoElevenTxt.Location = new System.Drawing.Point(544, 133);
            this.videoElevenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoElevenTxt.Name = "videoElevenTxt";
            this.videoElevenTxt.Size = new System.Drawing.Size(53, 22);
            this.videoElevenTxt.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(471, 137);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 35;
            this.label19.Text = "Video 11";
            // 
            // videoTenTxt
            // 
            this.videoTenTxt.Enabled = false;
            this.videoTenTxt.Location = new System.Drawing.Point(389, 133);
            this.videoTenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoTenTxt.Name = "videoTenTxt";
            this.videoTenTxt.Size = new System.Drawing.Size(53, 22);
            this.videoTenTxt.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(316, 137);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "Video 10";
            // 
            // videoNineTxt
            // 
            this.videoNineTxt.Enabled = false;
            this.videoNineTxt.Location = new System.Drawing.Point(239, 133);
            this.videoNineTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoNineTxt.Name = "videoNineTxt";
            this.videoNineTxt.Size = new System.Drawing.Size(53, 22);
            this.videoNineTxt.TabIndex = 32;
            // 
            // videoEightTxt
            // 
            this.videoEightTxt.Enabled = false;
            this.videoEightTxt.Location = new System.Drawing.Point(83, 133);
            this.videoEightTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoEightTxt.Name = "videoEightTxt";
            this.videoEightTxt.Size = new System.Drawing.Size(53, 22);
            this.videoEightTxt.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(173, 137);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "Video 9";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(17, 137);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Video 8";
            // 
            // videoSevenTxt
            // 
            this.videoSevenTxt.Enabled = false;
            this.videoSevenTxt.Location = new System.Drawing.Point(993, 86);
            this.videoSevenTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoSevenTxt.Name = "videoSevenTxt";
            this.videoSevenTxt.Size = new System.Drawing.Size(53, 22);
            this.videoSevenTxt.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(928, 90);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Video 7";
            // 
            // videoSixTxt
            // 
            this.videoSixTxt.Enabled = false;
            this.videoSixTxt.Location = new System.Drawing.Point(840, 86);
            this.videoSixTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoSixTxt.Name = "videoSixTxt";
            this.videoSixTxt.Size = new System.Drawing.Size(53, 22);
            this.videoSixTxt.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(775, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Video 6";
            // 
            // videoFiveTxt
            // 
            this.videoFiveTxt.Enabled = false;
            this.videoFiveTxt.Location = new System.Drawing.Point(696, 86);
            this.videoFiveTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoFiveTxt.Name = "videoFiveTxt";
            this.videoFiveTxt.Size = new System.Drawing.Size(53, 22);
            this.videoFiveTxt.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(631, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Video 5";
            // 
            // videoFourTxt
            // 
            this.videoFourTxt.Enabled = false;
            this.videoFourTxt.Location = new System.Drawing.Point(544, 86);
            this.videoFourTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoFourTxt.Name = "videoFourTxt";
            this.videoFourTxt.Size = new System.Drawing.Size(53, 22);
            this.videoFourTxt.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(479, 90);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Video 4";
            // 
            // videoThreeTxt
            // 
            this.videoThreeTxt.Enabled = false;
            this.videoThreeTxt.Location = new System.Drawing.Point(389, 86);
            this.videoThreeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoThreeTxt.Name = "videoThreeTxt";
            this.videoThreeTxt.Size = new System.Drawing.Size(53, 22);
            this.videoThreeTxt.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Video 3";
            // 
            // videoTwoTxt
            // 
            this.videoTwoTxt.Enabled = false;
            this.videoTwoTxt.Location = new System.Drawing.Point(239, 86);
            this.videoTwoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.videoTwoTxt.Name = "videoTwoTxt";
            this.videoTwoTxt.Size = new System.Drawing.Size(53, 22);
            this.videoTwoTxt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Video 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Video 1";
            // 
            // genConfigBtn
            // 
            this.genConfigBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.genConfigBtn.ForeColor = System.Drawing.Color.Black;
            this.genConfigBtn.Location = new System.Drawing.Point(921, 369);
            this.genConfigBtn.Margin = new System.Windows.Forms.Padding(4);
            this.genConfigBtn.Name = "genConfigBtn";
            this.genConfigBtn.Size = new System.Drawing.Size(176, 63);
            this.genConfigBtn.TabIndex = 17;
            this.genConfigBtn.Text = "Generate Configs";
            this.genConfigBtn.UseVisualStyleBackColor = false;
            this.genConfigBtn.Click += new System.EventHandler(this.GenConfigBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(735, 369);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(176, 63);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 437);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.genConfigBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1133, 484);
            this.MinimumSize = new System.Drawing.Size(1133, 484);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brink Config Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox videoChkBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stationCmbo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationIDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox videoCmbo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stationOneIpTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox serverEndPointTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox backupEndPointTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox videoFourteenTxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox videoThirteenTxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox videoTwelveTxt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox videoElevenTxt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox videoTenTxt;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox videoNineTxt;
        private System.Windows.Forms.TextBox videoEightTxt;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox videoSevenTxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox videoSixTxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox videoFiveTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox videoFourTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox videoThreeTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox videoTwoTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button genConfigBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.TextBox videoOneTxt;
    }
}

