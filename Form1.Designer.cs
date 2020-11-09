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
            this.videoOneTxt = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(227, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register and Kitchen Config Generator";
            // 
            // videoChkBox
            // 
            this.videoChkBox.AutoSize = true;
            this.videoChkBox.Location = new System.Drawing.Point(165, 26);
            this.videoChkBox.Name = "videoChkBox";
            this.videoChkBox.Size = new System.Drawing.Size(153, 17);
            this.videoChkBox.TabIndex = 1;
            this.videoChkBox.Text = "Generate Kitchen Configs?";
            this.videoChkBox.UseVisualStyleBackColor = true;
            this.videoChkBox.CheckedChanged += new System.EventHandler(this.VideoChkBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stations";
            // 
            // stationCmbo
            // 
            this.stationCmbo.FormattingEnabled = true;
            this.stationCmbo.Location = new System.Drawing.Point(61, 22);
            this.stationCmbo.MaxDropDownItems = 10;
            this.stationCmbo.Name = "stationCmbo";
            this.stationCmbo.Size = new System.Drawing.Size(88, 21);
            this.stationCmbo.TabIndex = 3;
            this.stationCmbo.Text = "Total Stations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location ID";
            // 
            // locationIDTxt
            // 
            this.locationIDTxt.Location = new System.Drawing.Point(584, 23);
            this.locationIDTxt.Name = "locationIDTxt";
            this.locationIDTxt.Size = new System.Drawing.Size(221, 20);
            this.locationIDTxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kitchen Videos";
            // 
            // videoCmbo
            // 
            this.videoCmbo.Enabled = false;
            this.videoCmbo.FormattingEnabled = true;
            this.videoCmbo.Location = new System.Drawing.Point(417, 22);
            this.videoCmbo.MaxDropDownItems = 10;
            this.videoCmbo.Name = "videoCmbo";
            this.videoCmbo.Size = new System.Drawing.Size(82, 21);
            this.videoCmbo.TabIndex = 7;
            this.videoCmbo.Text = "Total Videos";
            this.videoCmbo.SelectedIndexChanged += new System.EventHandler(this.VideoCmbo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Station 1 IP";
            // 
            // stationOneIpTxt
            // 
            this.stationOneIpTxt.Location = new System.Drawing.Point(78, 58);
            this.stationOneIpTxt.Name = "stationOneIpTxt";
            this.stationOneIpTxt.Size = new System.Drawing.Size(113, 20);
            this.stationOneIpTxt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Server End Point";
            // 
            // serverEndPointTxt
            // 
            this.serverEndPointTxt.Location = new System.Drawing.Point(321, 58);
            this.serverEndPointTxt.Name = "serverEndPointTxt";
            this.serverEndPointTxt.Size = new System.Drawing.Size(163, 20);
            this.serverEndPointTxt.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Backup End Point";
            // 
            // backupEndPointTxt
            // 
            this.backupEndPointTxt.Location = new System.Drawing.Point(619, 58);
            this.backupEndPointTxt.Name = "backupEndPointTxt";
            this.backupEndPointTxt.Size = new System.Drawing.Size(186, 20);
            this.backupEndPointTxt.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(368, 25);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 93);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Settings";
            // 
            // groupBox2
            // 
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
            this.groupBox2.Controls.Add(this.videoOneTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 152);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitchen Video Settings";
            // 
            // videoFourteenTxt
            // 
            this.videoFourteenTxt.Enabled = false;
            this.videoFourteenTxt.Location = new System.Drawing.Point(745, 108);
            this.videoFourteenTxt.Name = "videoFourteenTxt";
            this.videoFourteenTxt.Size = new System.Drawing.Size(41, 20);
            this.videoFourteenTxt.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(690, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "Video 14";
            // 
            // videoThirteenTxt
            // 
            this.videoThirteenTxt.Enabled = false;
            this.videoThirteenTxt.Location = new System.Drawing.Point(630, 108);
            this.videoThirteenTxt.Name = "videoThirteenTxt";
            this.videoThirteenTxt.Size = new System.Drawing.Size(41, 20);
            this.videoThirteenTxt.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(575, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Video 13";
            // 
            // videoTwelveTxt
            // 
            this.videoTwelveTxt.Enabled = false;
            this.videoTwelveTxt.Location = new System.Drawing.Point(522, 108);
            this.videoTwelveTxt.Name = "videoTwelveTxt";
            this.videoTwelveTxt.Size = new System.Drawing.Size(41, 20);
            this.videoTwelveTxt.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(467, 111);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Video 12";
            // 
            // videoElevenTxt
            // 
            this.videoElevenTxt.Enabled = false;
            this.videoElevenTxt.Location = new System.Drawing.Point(408, 108);
            this.videoElevenTxt.Name = "videoElevenTxt";
            this.videoElevenTxt.Size = new System.Drawing.Size(41, 20);
            this.videoElevenTxt.TabIndex = 36;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(353, 111);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Video 11";
            // 
            // videoTenTxt
            // 
            this.videoTenTxt.Enabled = false;
            this.videoTenTxt.Location = new System.Drawing.Point(292, 108);
            this.videoTenTxt.Name = "videoTenTxt";
            this.videoTenTxt.Size = new System.Drawing.Size(41, 20);
            this.videoTenTxt.TabIndex = 34;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(237, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Video 10";
            // 
            // videoNineTxt
            // 
            this.videoNineTxt.Enabled = false;
            this.videoNineTxt.Location = new System.Drawing.Point(179, 108);
            this.videoNineTxt.Name = "videoNineTxt";
            this.videoNineTxt.Size = new System.Drawing.Size(41, 20);
            this.videoNineTxt.TabIndex = 32;
            // 
            // videoEightTxt
            // 
            this.videoEightTxt.Enabled = false;
            this.videoEightTxt.Location = new System.Drawing.Point(62, 108);
            this.videoEightTxt.Name = "videoEightTxt";
            this.videoEightTxt.Size = new System.Drawing.Size(41, 20);
            this.videoEightTxt.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(130, 111);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Video 9";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "Video 8";
            // 
            // videoSevenTxt
            // 
            this.videoSevenTxt.Enabled = false;
            this.videoSevenTxt.Location = new System.Drawing.Point(745, 70);
            this.videoSevenTxt.Name = "videoSevenTxt";
            this.videoSevenTxt.Size = new System.Drawing.Size(41, 20);
            this.videoSevenTxt.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(696, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Video 7";
            // 
            // videoSixTxt
            // 
            this.videoSixTxt.Enabled = false;
            this.videoSixTxt.Location = new System.Drawing.Point(630, 70);
            this.videoSixTxt.Name = "videoSixTxt";
            this.videoSixTxt.Size = new System.Drawing.Size(41, 20);
            this.videoSixTxt.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(581, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Video 6";
            // 
            // videoFiveTxt
            // 
            this.videoFiveTxt.Enabled = false;
            this.videoFiveTxt.Location = new System.Drawing.Point(522, 70);
            this.videoFiveTxt.Name = "videoFiveTxt";
            this.videoFiveTxt.Size = new System.Drawing.Size(41, 20);
            this.videoFiveTxt.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(473, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Video 5";
            // 
            // videoFourTxt
            // 
            this.videoFourTxt.Enabled = false;
            this.videoFourTxt.Location = new System.Drawing.Point(408, 70);
            this.videoFourTxt.Name = "videoFourTxt";
            this.videoFourTxt.Size = new System.Drawing.Size(41, 20);
            this.videoFourTxt.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(359, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Video 4";
            // 
            // videoThreeTxt
            // 
            this.videoThreeTxt.Enabled = false;
            this.videoThreeTxt.Location = new System.Drawing.Point(292, 70);
            this.videoThreeTxt.Name = "videoThreeTxt";
            this.videoThreeTxt.Size = new System.Drawing.Size(41, 20);
            this.videoThreeTxt.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(243, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Video 3";
            // 
            // videoTwoTxt
            // 
            this.videoTwoTxt.Enabled = false;
            this.videoTwoTxt.Location = new System.Drawing.Point(179, 70);
            this.videoTwoTxt.Name = "videoTwoTxt";
            this.videoTwoTxt.Size = new System.Drawing.Size(41, 20);
            this.videoTwoTxt.TabIndex = 18;
            // 
            // videoOneTxt
            // 
            this.videoOneTxt.Enabled = false;
            this.videoOneTxt.Location = new System.Drawing.Point(62, 70);
            this.videoOneTxt.Name = "videoOneTxt";
            this.videoOneTxt.Size = new System.Drawing.Size(41, 20);
            this.videoOneTxt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Video 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Video 1";
            // 
            // genConfigBtn
            // 
            this.genConfigBtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.genConfigBtn.ForeColor = System.Drawing.Color.Black;
            this.genConfigBtn.Location = new System.Drawing.Point(691, 300);
            this.genConfigBtn.Name = "genConfigBtn";
            this.genConfigBtn.Size = new System.Drawing.Size(132, 51);
            this.genConfigBtn.TabIndex = 17;
            this.genConfigBtn.Text = "Generate Configs";
            this.genConfigBtn.UseVisualStyleBackColor = false;
            this.genConfigBtn.Click += new System.EventHandler(this.GenConfigBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.LightCoral;
            this.resetBtn.ForeColor = System.Drawing.Color.Black;
            this.resetBtn.Location = new System.Drawing.Point(551, 300);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(132, 51);
            this.resetBtn.TabIndex = 18;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 363);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.genConfigBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(854, 402);
            this.MinimumSize = new System.Drawing.Size(854, 402);
            this.Name = "Form1";
            this.Text = "Brink Config Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.CenterToScreen();

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
        private System.Windows.Forms.TextBox videoOneTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button genConfigBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

