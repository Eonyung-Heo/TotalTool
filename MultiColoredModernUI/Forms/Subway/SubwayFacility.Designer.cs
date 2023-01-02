namespace MultiColoredModernUI.Forms.Subway
{
    partial class SubwayFacility
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listStationName = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLaneType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxRegion = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textStationName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textLostCenterUrl = new System.Windows.Forms.TextBox();
            this.textLostCenterTel = new System.Windows.Forms.TextBox();
            this.comboLocker = new System.Windows.Forms.ComboBox();
            this.comboVisitorCenter = new System.Windows.Forms.ComboBox();
            this.comboDisabledToilet = new System.Windows.Forms.ComboBox();
            this.combolactationRoom = new System.Windows.Forms.ComboBox();
            this.comboAutomaticDispenser = new System.Windows.Forms.ComboBox();
            this.comboElevator = new System.Windows.Forms.ComboBox();
            this.comboWheelChairLift = new System.Windows.Forms.ComboBox();
            this.comboTicket = new System.Windows.Forms.ComboBox();
            this.comboPublicOffice = new System.Windows.Forms.ComboBox();
            this.comboStationOffice = new System.Windows.Forms.ComboBox();
            this.comboTransferParking = new System.Windows.Forms.ComboBox();
            this.comboBicycleRack = new System.Windows.Forms.ComboBox();
            this.comboLostCenter = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.listStation = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listStationName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxLaneType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboboxRegion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 649);
            this.panel1.TabIndex = 1;
            // 
            // listStationName
            // 
            this.listStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStationName.HideSelection = false;
            this.listStationName.Location = new System.Drawing.Point(10, 125);
            this.listStationName.Margin = new System.Windows.Forms.Padding(10);
            this.listStationName.Name = "listStationName";
            this.listStationName.Size = new System.Drawing.Size(186, 512);
            this.listStationName.TabIndex = 6;
            this.listStationName.UseCompatibleStateImageBehavior = false;
            this.listStationName.SelectedIndexChanged += new System.EventHandler(this.listStationName_Click);
            this.listStationName.Click += new System.EventHandler(this.listStationName_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "노 선";
            // 
            // comboBoxLaneType
            // 
            this.comboBoxLaneType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLaneType.BackColor = System.Drawing.Color.White;
            this.comboBoxLaneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaneType.FormattingEnabled = true;
            this.comboBoxLaneType.Location = new System.Drawing.Point(97, 64);
            this.comboBoxLaneType.Name = "comboBoxLaneType";
            this.comboBoxLaneType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxLaneType.TabIndex = 3;
            this.comboBoxLaneType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaneType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "지 역";
            // 
            // comboboxRegion
            // 
            this.comboboxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxRegion.BackColor = System.Drawing.Color.White;
            this.comboboxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRegion.FormattingEnabled = true;
            this.comboboxRegion.Location = new System.Drawing.Point(97, 26);
            this.comboboxRegion.Name = "comboboxRegion";
            this.comboboxRegion.Size = new System.Drawing.Size(80, 20);
            this.comboboxRegion.TabIndex = 1;
            this.comboboxRegion.SelectedIndexChanged += new System.EventHandler(this.comboboxRegion_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textStationName);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.textLostCenterUrl);
            this.panel2.Controls.Add(this.textLostCenterTel);
            this.panel2.Controls.Add(this.comboLocker);
            this.panel2.Controls.Add(this.comboVisitorCenter);
            this.panel2.Controls.Add(this.comboDisabledToilet);
            this.panel2.Controls.Add(this.combolactationRoom);
            this.panel2.Controls.Add(this.comboAutomaticDispenser);
            this.panel2.Controls.Add(this.comboElevator);
            this.panel2.Controls.Add(this.comboWheelChairLift);
            this.panel2.Controls.Add(this.comboTicket);
            this.panel2.Controls.Add(this.comboPublicOffice);
            this.panel2.Controls.Add(this.comboStationOffice);
            this.panel2.Controls.Add(this.comboTransferParking);
            this.panel2.Controls.Add(this.comboBicycleRack);
            this.panel2.Controls.Add(this.comboLostCenter);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.btnAlter);
            this.panel2.Controls.Add(this.listStation);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 649);
            this.panel2.TabIndex = 2;
            // 
            // textStationName
            // 
            this.textStationName.BackColor = System.Drawing.Color.White;
            this.textStationName.Location = new System.Drawing.Point(182, 118);
            this.textStationName.Name = "textStationName";
            this.textStationName.ReadOnly = true;
            this.textStationName.Size = new System.Drawing.Size(121, 21);
            this.textStationName.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 121);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 12);
            this.label18.TabIndex = 52;
            this.label18.Text = "지하철 역 이름";
            // 
            // textLostCenterUrl
            // 
            this.textLostCenterUrl.BackColor = System.Drawing.Color.White;
            this.textLostCenterUrl.Location = new System.Drawing.Point(182, 561);
            this.textLostCenterUrl.Name = "textLostCenterUrl";
            this.textLostCenterUrl.Size = new System.Drawing.Size(624, 21);
            this.textLostCenterUrl.TabIndex = 51;
            // 
            // textLostCenterTel
            // 
            this.textLostCenterTel.BackColor = System.Drawing.Color.White;
            this.textLostCenterTel.Location = new System.Drawing.Point(182, 510);
            this.textLostCenterTel.Name = "textLostCenterTel";
            this.textLostCenterTel.Size = new System.Drawing.Size(121, 21);
            this.textLostCenterTel.TabIndex = 50;
            // 
            // comboLocker
            // 
            this.comboLocker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLocker.FormattingEnabled = true;
            this.comboLocker.Location = new System.Drawing.Point(685, 510);
            this.comboLocker.Name = "comboLocker";
            this.comboLocker.Size = new System.Drawing.Size(121, 20);
            this.comboLocker.TabIndex = 49;
            // 
            // comboVisitorCenter
            // 
            this.comboVisitorCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVisitorCenter.FormattingEnabled = true;
            this.comboVisitorCenter.Location = new System.Drawing.Point(685, 452);
            this.comboVisitorCenter.Name = "comboVisitorCenter";
            this.comboVisitorCenter.Size = new System.Drawing.Size(121, 20);
            this.comboVisitorCenter.TabIndex = 48;
            // 
            // comboDisabledToilet
            // 
            this.comboDisabledToilet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDisabledToilet.FormattingEnabled = true;
            this.comboDisabledToilet.Location = new System.Drawing.Point(685, 394);
            this.comboDisabledToilet.Name = "comboDisabledToilet";
            this.comboDisabledToilet.Size = new System.Drawing.Size(121, 20);
            this.comboDisabledToilet.TabIndex = 47;
            // 
            // combolactationRoom
            // 
            this.combolactationRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combolactationRoom.FormattingEnabled = true;
            this.combolactationRoom.Location = new System.Drawing.Point(685, 336);
            this.combolactationRoom.Name = "combolactationRoom";
            this.combolactationRoom.Size = new System.Drawing.Size(121, 20);
            this.combolactationRoom.TabIndex = 46;
            // 
            // comboAutomaticDispenser
            // 
            this.comboAutomaticDispenser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAutomaticDispenser.FormattingEnabled = true;
            this.comboAutomaticDispenser.Location = new System.Drawing.Point(685, 278);
            this.comboAutomaticDispenser.Name = "comboAutomaticDispenser";
            this.comboAutomaticDispenser.Size = new System.Drawing.Size(121, 20);
            this.comboAutomaticDispenser.TabIndex = 45;
            // 
            // comboElevator
            // 
            this.comboElevator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboElevator.FormattingEnabled = true;
            this.comboElevator.Location = new System.Drawing.Point(685, 162);
            this.comboElevator.Name = "comboElevator";
            this.comboElevator.Size = new System.Drawing.Size(121, 20);
            this.comboElevator.TabIndex = 44;
            // 
            // comboWheelChairLift
            // 
            this.comboWheelChairLift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWheelChairLift.FormattingEnabled = true;
            this.comboWheelChairLift.Location = new System.Drawing.Point(685, 220);
            this.comboWheelChairLift.Name = "comboWheelChairLift";
            this.comboWheelChairLift.Size = new System.Drawing.Size(121, 20);
            this.comboWheelChairLift.TabIndex = 43;
            // 
            // comboTicket
            // 
            this.comboTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTicket.FormattingEnabled = true;
            this.comboTicket.Location = new System.Drawing.Point(182, 452);
            this.comboTicket.Name = "comboTicket";
            this.comboTicket.Size = new System.Drawing.Size(121, 20);
            this.comboTicket.TabIndex = 42;
            // 
            // comboPublicOffice
            // 
            this.comboPublicOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPublicOffice.FormattingEnabled = true;
            this.comboPublicOffice.Location = new System.Drawing.Point(182, 394);
            this.comboPublicOffice.Name = "comboPublicOffice";
            this.comboPublicOffice.Size = new System.Drawing.Size(121, 20);
            this.comboPublicOffice.TabIndex = 41;
            // 
            // comboStationOffice
            // 
            this.comboStationOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStationOffice.FormattingEnabled = true;
            this.comboStationOffice.Location = new System.Drawing.Point(182, 336);
            this.comboStationOffice.Name = "comboStationOffice";
            this.comboStationOffice.Size = new System.Drawing.Size(121, 20);
            this.comboStationOffice.TabIndex = 40;
            // 
            // comboTransferParking
            // 
            this.comboTransferParking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTransferParking.FormattingEnabled = true;
            this.comboTransferParking.Location = new System.Drawing.Point(182, 278);
            this.comboTransferParking.Name = "comboTransferParking";
            this.comboTransferParking.Size = new System.Drawing.Size(121, 20);
            this.comboTransferParking.TabIndex = 39;
            // 
            // comboBicycleRack
            // 
            this.comboBicycleRack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBicycleRack.FormattingEnabled = true;
            this.comboBicycleRack.Location = new System.Drawing.Point(182, 220);
            this.comboBicycleRack.Name = "comboBicycleRack";
            this.comboBicycleRack.Size = new System.Drawing.Size(121, 20);
            this.comboBicycleRack.TabIndex = 38;
            // 
            // comboLostCenter
            // 
            this.comboLostCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLostCenter.FormattingEnabled = true;
            this.comboLostCenter.Location = new System.Drawing.Point(182, 161);
            this.comboLostCenter.Name = "comboLostCenter";
            this.comboLostCenter.Size = new System.Drawing.Size(121, 20);
            this.comboLostCenter.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(574, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 12);
            this.label17.TabIndex = 36;
            this.label17.Text = "물품 보관실";
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Location = new System.Drawing.Point(824, 96);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 43);
            this.btnAlter.TabIndex = 35;
            this.btnAlter.Text = "적용";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // listStation
            // 
            this.listStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listStation.HideSelection = false;
            this.listStation.Location = new System.Drawing.Point(5, 3);
            this.listStation.Name = "listStation";
            this.listStation.Size = new System.Drawing.Size(890, 84);
            this.listStation.TabIndex = 20;
            this.listStation.UseCompatibleStateImageBehavior = false;
            this.listStation.SelectedIndexChanged += new System.EventHandler(this.listStation_Click);
            this.listStation.Click += new System.EventHandler(this.listStation_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(574, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "무인 민원 발급기";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 12);
            this.label16.TabIndex = 27;
            this.label16.Text = "환승 주차장";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 12);
            this.label13.TabIndex = 24;
            this.label13.Text = "휠체어 리프트";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "자전거 보관소";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(54, 565);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "유실물 센터 URL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 514);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "유실물 센터 전화번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "장애인 화장실";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(574, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "수유방";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "유실물 센터";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(574, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "관광 안내소";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 456);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "열차,항공권 구입";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "현장 민원실";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "역무실";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "엘리베이터";
            // 
            // SubwayFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubwayFacility";
            this.Text = "SubwayFacility";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listStationName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLaneType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxRegion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.ListView listStation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLostCenterUrl;
        private System.Windows.Forms.TextBox textLostCenterTel;
        private System.Windows.Forms.ComboBox comboLocker;
        private System.Windows.Forms.ComboBox comboVisitorCenter;
        private System.Windows.Forms.ComboBox comboDisabledToilet;
        private System.Windows.Forms.ComboBox combolactationRoom;
        private System.Windows.Forms.ComboBox comboAutomaticDispenser;
        private System.Windows.Forms.ComboBox comboElevator;
        private System.Windows.Forms.ComboBox comboWheelChairLift;
        private System.Windows.Forms.ComboBox comboTicket;
        private System.Windows.Forms.ComboBox comboPublicOffice;
        private System.Windows.Forms.ComboBox comboStationOffice;
        private System.Windows.Forms.ComboBox comboTransferParking;
        private System.Windows.Forms.ComboBox comboBicycleRack;
        private System.Windows.Forms.ComboBox comboLostCenter;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textStationName;
        private System.Windows.Forms.Label label18;
    }
}