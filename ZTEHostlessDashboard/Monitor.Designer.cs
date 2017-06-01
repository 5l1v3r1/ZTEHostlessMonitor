namespace ZTEHostlessDashboard
{
    partial class Monitor
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
            this.label_dashboardAddr = new System.Windows.Forms.Label();
            this.tb_dashboardAddress = new System.Windows.Forms.TextBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.tb_SWVer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FWVer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_HWVer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_IMSI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_IMEI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_State = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker_AJAXFetch = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Network = new System.Windows.Forms.GroupBox();
            this.tb_Roam = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tb_ActiveBand = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_CellID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_LAC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_MNC = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_MCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_NetDomainSpec = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_NetType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_NetSelect = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_OpName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Signal = new System.Windows.Forms.GroupBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tb_LTEPCI = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tb_LTEBand = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_LTESNR = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_LTERSRQ = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tb_LTERSRP = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.tb_LTERSSI = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_CSQ = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_ECIO = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_RSCP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_RSSI = new System.Windows.Forms.TextBox();
            this.signalBar = new System.Windows.Forms.ProgressBar();
            this.label15 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Model = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker_DevicePinger = new System.ComponentModel.BackgroundWorker();
            this.worker_GetStaticDeviceInfo = new System.ComponentModel.BackgroundWorker();
            this.button_Save = new System.Windows.Forms.Button();
            this.tabControl_Monitor = new System.Windows.Forms.TabControl();
            this.tabPage_Dashboard = new System.Windows.Forms.TabPage();
            this.panel_Connected = new System.Windows.Forms.Panel();
            this.label_SignalStrength = new System.Windows.Forms.Label();
            this.pictureBox_signalbar = new System.Windows.Forms.PictureBox();
            this.label_PPPStatus = new System.Windows.Forms.Label();
            this.pictureBox_SMSIcon = new System.Windows.Forms.PictureBox();
            this.label_UnreadSMS = new System.Windows.Forms.Label();
            this.label_NetType = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label44 = new System.Windows.Forms.Label();
            this.label_TxRate = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label_RxRate = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label_CurrentTx = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label_CurrentRx = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label_CurrentDuration = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label_CurrentTotal = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_USSD = new System.Windows.Forms.Button();
            this.button_SMS = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.label_OpName = new System.Windows.Forms.Label();
            this.button_CDC = new System.Windows.Forms.Button();
            this.panel_NotConnected = new System.Windows.Forms.Panel();
            this.label_NotConnected = new System.Windows.Forms.Label();
            this.tabPage_ModemInformation = new System.Windows.Forms.TabPage();
            this.groupBox_Connection = new System.Windows.Forms.GroupBox();
            this.tb_RxRate = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.tb_TxRate = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.tb_PPPState = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_APN = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tb_IPAddress = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tb_DNS2 = new System.Windows.Forms.TextBox();
            this.tb_DNS1 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPage_DeviceInformation = new System.Windows.Forms.TabPage();
            this.tabPage_AppSettings = new System.Windows.Forms.TabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDown_PoolingInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBox_AlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.backgroundWorker_ModemCDC = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Info.SuspendLayout();
            this.groupBox_Network.SuspendLayout();
            this.groupBox_Signal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl_Monitor.SuspendLayout();
            this.tabPage_Dashboard.SuspendLayout();
            this.panel_Connected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signalbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SMSIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel_NotConnected.SuspendLayout();
            this.tabPage_ModemInformation.SuspendLayout();
            this.groupBox_Connection.SuspendLayout();
            this.tabPage_DeviceInformation.SuspendLayout();
            this.tabPage_AppSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PoolingInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // label_dashboardAddr
            // 
            this.label_dashboardAddr.AutoSize = true;
            this.label_dashboardAddr.Location = new System.Drawing.Point(6, 9);
            this.label_dashboardAddr.Name = "label_dashboardAddr";
            this.label_dashboardAddr.Size = new System.Drawing.Size(108, 13);
            this.label_dashboardAddr.TabIndex = 0;
            this.label_dashboardAddr.Text = "Dashboard Address";
            // 
            // tb_dashboardAddress
            // 
            this.tb_dashboardAddress.Location = new System.Drawing.Point(112, 6);
            this.tb_dashboardAddress.Name = "tb_dashboardAddress";
            this.tb_dashboardAddress.Size = new System.Drawing.Size(155, 22);
            this.tb_dashboardAddress.TabIndex = 1;
            this.tb_dashboardAddress.TextChanged += new System.EventHandler(this.tb_dashboardAddress_TextChanged);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.tb_SWVer);
            this.groupBox_Info.Controls.Add(this.label6);
            this.groupBox_Info.Controls.Add(this.tb_FWVer);
            this.groupBox_Info.Controls.Add(this.label5);
            this.groupBox_Info.Controls.Add(this.tb_HWVer);
            this.groupBox_Info.Controls.Add(this.label4);
            this.groupBox_Info.Controls.Add(this.tb_IMSI);
            this.groupBox_Info.Controls.Add(this.label3);
            this.groupBox_Info.Controls.Add(this.tb_IMEI);
            this.groupBox_Info.Controls.Add(this.label1);
            this.groupBox_Info.Controls.Add(this.tb_State);
            this.groupBox_Info.Controls.Add(this.label2);
            this.groupBox_Info.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(332, 181);
            this.groupBox_Info.TabIndex = 3;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Device Information";
            // 
            // tb_SWVer
            // 
            this.tb_SWVer.CausesValidation = false;
            this.tb_SWVer.Location = new System.Drawing.Point(103, 144);
            this.tb_SWVer.Name = "tb_SWVer";
            this.tb_SWVer.ReadOnly = true;
            this.tb_SWVer.Size = new System.Drawing.Size(185, 22);
            this.tb_SWVer.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Web UI Version";
            // 
            // tb_FWVer
            // 
            this.tb_FWVer.CausesValidation = false;
            this.tb_FWVer.Location = new System.Drawing.Point(103, 118);
            this.tb_FWVer.Name = "tb_FWVer";
            this.tb_FWVer.ReadOnly = true;
            this.tb_FWVer.Size = new System.Drawing.Size(185, 22);
            this.tb_FWVer.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Firmware Version";
            // 
            // tb_HWVer
            // 
            this.tb_HWVer.CausesValidation = false;
            this.tb_HWVer.Location = new System.Drawing.Point(103, 92);
            this.tb_HWVer.Name = "tb_HWVer";
            this.tb_HWVer.ReadOnly = true;
            this.tb_HWVer.Size = new System.Drawing.Size(185, 22);
            this.tb_HWVer.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hardware Version";
            // 
            // tb_IMSI
            // 
            this.tb_IMSI.CausesValidation = false;
            this.tb_IMSI.Location = new System.Drawing.Point(103, 66);
            this.tb_IMSI.Name = "tb_IMSI";
            this.tb_IMSI.ReadOnly = true;
            this.tb_IMSI.Size = new System.Drawing.Size(185, 22);
            this.tb_IMSI.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "IMSI";
            // 
            // tb_IMEI
            // 
            this.tb_IMEI.CausesValidation = false;
            this.tb_IMEI.Location = new System.Drawing.Point(103, 40);
            this.tb_IMEI.Name = "tb_IMEI";
            this.tb_IMEI.ReadOnly = true;
            this.tb_IMEI.Size = new System.Drawing.Size(185, 22);
            this.tb_IMEI.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modem State";
            // 
            // tb_State
            // 
            this.tb_State.CausesValidation = false;
            this.tb_State.Location = new System.Drawing.Point(103, 14);
            this.tb_State.Name = "tb_State";
            this.tb_State.ReadOnly = true;
            this.tb_State.Size = new System.Drawing.Size(185, 22);
            this.tb_State.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "IMEI";
            // 
            // backgroundWorker_AJAXFetch
            // 
            this.backgroundWorker_AJAXFetch.WorkerReportsProgress = true;
            this.backgroundWorker_AJAXFetch.WorkerSupportsCancellation = true;
            this.backgroundWorker_AJAXFetch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_AJAXFetch_DoWork);
            this.backgroundWorker_AJAXFetch.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_AJAXFetch_ProgressChanged);
            this.backgroundWorker_AJAXFetch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_AJAXFetch_RunWorkerCompleted);
            // 
            // groupBox_Network
            // 
            this.groupBox_Network.Controls.Add(this.tb_Roam);
            this.groupBox_Network.Controls.Add(this.label42);
            this.groupBox_Network.Controls.Add(this.tb_ActiveBand);
            this.groupBox_Network.Controls.Add(this.label19);
            this.groupBox_Network.Controls.Add(this.tb_CellID);
            this.groupBox_Network.Controls.Add(this.label21);
            this.groupBox_Network.Controls.Add(this.tb_LAC);
            this.groupBox_Network.Controls.Add(this.label20);
            this.groupBox_Network.Controls.Add(this.tb_MNC);
            this.groupBox_Network.Controls.Add(this.label13);
            this.groupBox_Network.Controls.Add(this.tb_MCC);
            this.groupBox_Network.Controls.Add(this.label12);
            this.groupBox_Network.Controls.Add(this.tb_NetDomainSpec);
            this.groupBox_Network.Controls.Add(this.label10);
            this.groupBox_Network.Controls.Add(this.tb_NetType);
            this.groupBox_Network.Controls.Add(this.label9);
            this.groupBox_Network.Controls.Add(this.tb_NetSelect);
            this.groupBox_Network.Controls.Add(this.label8);
            this.groupBox_Network.Controls.Add(this.tb_OpName);
            this.groupBox_Network.Controls.Add(this.label7);
            this.groupBox_Network.Location = new System.Drawing.Point(6, 7);
            this.groupBox_Network.Name = "groupBox_Network";
            this.groupBox_Network.Size = new System.Drawing.Size(264, 205);
            this.groupBox_Network.TabIndex = 10;
            this.groupBox_Network.TabStop = false;
            this.groupBox_Network.Text = "Network";
            // 
            // tb_Roam
            // 
            this.tb_Roam.CausesValidation = false;
            this.tb_Roam.Location = new System.Drawing.Point(47, 71);
            this.tb_Roam.Name = "tb_Roam";
            this.tb_Roam.ReadOnly = true;
            this.tb_Roam.Size = new System.Drawing.Size(92, 22);
            this.tb_Roam.TabIndex = 15;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(6, 74);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(36, 13);
            this.label42.TabIndex = 40;
            this.label42.Text = "Roam";
            // 
            // tb_ActiveBand
            // 
            this.tb_ActiveBand.CausesValidation = false;
            this.tb_ActiveBand.Location = new System.Drawing.Point(106, 149);
            this.tb_ActiveBand.Name = "tb_ActiveBand";
            this.tb_ActiveBand.ReadOnly = true;
            this.tb_ActiveBand.Size = new System.Drawing.Size(137, 22);
            this.tb_ActiveBand.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Active Band";
            // 
            // tb_CellID
            // 
            this.tb_CellID.CausesValidation = false;
            this.tb_CellID.Location = new System.Drawing.Point(189, 71);
            this.tb_CellID.Name = "tb_CellID";
            this.tb_CellID.ReadOnly = true;
            this.tb_CellID.Size = new System.Drawing.Size(54, 22);
            this.tb_CellID.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(145, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 28;
            this.label21.Text = "Cell ID";
            // 
            // tb_LAC
            // 
            this.tb_LAC.CausesValidation = false;
            this.tb_LAC.Location = new System.Drawing.Point(189, 45);
            this.tb_LAC.Name = "tb_LAC";
            this.tb_LAC.ReadOnly = true;
            this.tb_LAC.Size = new System.Drawing.Size(54, 22);
            this.tb_LAC.TabIndex = 14;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(156, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "LAC";
            // 
            // tb_MNC
            // 
            this.tb_MNC.CausesValidation = false;
            this.tb_MNC.Location = new System.Drawing.Point(120, 45);
            this.tb_MNC.Name = "tb_MNC";
            this.tb_MNC.ReadOnly = true;
            this.tb_MNC.Size = new System.Drawing.Size(30, 22);
            this.tb_MNC.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "MNC";
            // 
            // tb_MCC
            // 
            this.tb_MCC.CausesValidation = false;
            this.tb_MCC.Location = new System.Drawing.Point(47, 45);
            this.tb_MCC.Name = "tb_MCC";
            this.tb_MCC.ReadOnly = true;
            this.tb_MCC.Size = new System.Drawing.Size(30, 22);
            this.tb_MCC.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "MCC";
            // 
            // tb_NetDomainSpec
            // 
            this.tb_NetDomainSpec.CausesValidation = false;
            this.tb_NetDomainSpec.Location = new System.Drawing.Point(106, 175);
            this.tb_NetDomainSpec.Name = "tb_NetDomainSpec";
            this.tb_NetDomainSpec.ReadOnly = true;
            this.tb_NetDomainSpec.Size = new System.Drawing.Size(137, 22);
            this.tb_NetDomainSpec.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Service Domain";
            // 
            // tb_NetType
            // 
            this.tb_NetType.CausesValidation = false;
            this.tb_NetType.Location = new System.Drawing.Point(106, 123);
            this.tb_NetType.Name = "tb_NetType";
            this.tb_NetType.ReadOnly = true;
            this.tb_NetType.Size = new System.Drawing.Size(137, 22);
            this.tb_NetType.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Network Type";
            // 
            // tb_NetSelect
            // 
            this.tb_NetSelect.CausesValidation = false;
            this.tb_NetSelect.Location = new System.Drawing.Point(106, 97);
            this.tb_NetSelect.Name = "tb_NetSelect";
            this.tb_NetSelect.ReadOnly = true;
            this.tb_NetSelect.Size = new System.Drawing.Size(137, 22);
            this.tb_NetSelect.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Network Selection";
            // 
            // tb_OpName
            // 
            this.tb_OpName.CausesValidation = false;
            this.tb_OpName.Location = new System.Drawing.Point(47, 19);
            this.tb_OpName.Name = "tb_OpName";
            this.tb_OpName.ReadOnly = true;
            this.tb_OpName.Size = new System.Drawing.Size(196, 22);
            this.tb_OpName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "PLMN";
            // 
            // groupBox_Signal
            // 
            this.groupBox_Signal.Controls.Add(this.label35);
            this.groupBox_Signal.Controls.Add(this.tb_LTEPCI);
            this.groupBox_Signal.Controls.Add(this.label34);
            this.groupBox_Signal.Controls.Add(this.label33);
            this.groupBox_Signal.Controls.Add(this.tb_LTEBand);
            this.groupBox_Signal.Controls.Add(this.label32);
            this.groupBox_Signal.Controls.Add(this.label25);
            this.groupBox_Signal.Controls.Add(this.label26);
            this.groupBox_Signal.Controls.Add(this.label27);
            this.groupBox_Signal.Controls.Add(this.tb_LTESNR);
            this.groupBox_Signal.Controls.Add(this.label28);
            this.groupBox_Signal.Controls.Add(this.tb_LTERSRQ);
            this.groupBox_Signal.Controls.Add(this.label29);
            this.groupBox_Signal.Controls.Add(this.tb_LTERSRP);
            this.groupBox_Signal.Controls.Add(this.label30);
            this.groupBox_Signal.Controls.Add(this.tb_LTERSSI);
            this.groupBox_Signal.Controls.Add(this.label31);
            this.groupBox_Signal.Controls.Add(this.label24);
            this.groupBox_Signal.Controls.Add(this.label23);
            this.groupBox_Signal.Controls.Add(this.label22);
            this.groupBox_Signal.Controls.Add(this.tb_CSQ);
            this.groupBox_Signal.Controls.Add(this.label18);
            this.groupBox_Signal.Controls.Add(this.tb_ECIO);
            this.groupBox_Signal.Controls.Add(this.label17);
            this.groupBox_Signal.Controls.Add(this.tb_RSCP);
            this.groupBox_Signal.Controls.Add(this.label16);
            this.groupBox_Signal.Controls.Add(this.tb_RSSI);
            this.groupBox_Signal.Controls.Add(this.signalBar);
            this.groupBox_Signal.Controls.Add(this.label15);
            this.groupBox_Signal.Location = new System.Drawing.Point(276, 7);
            this.groupBox_Signal.Name = "groupBox_Signal";
            this.groupBox_Signal.Size = new System.Drawing.Size(270, 205);
            this.groupBox_Signal.TabIndex = 21;
            this.groupBox_Signal.TabStop = false;
            this.groupBox_Signal.Text = "Signal";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 100);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(128, 13);
            this.label35.TabIndex = 73;
            this.label35.Text = "LTE Specific Information";
            // 
            // tb_LTEPCI
            // 
            this.tb_LTEPCI.CausesValidation = false;
            this.tb_LTEPCI.Location = new System.Drawing.Point(182, 123);
            this.tb_LTEPCI.Name = "tb_LTEPCI";
            this.tb_LTEPCI.ReadOnly = true;
            this.tb_LTEPCI.Size = new System.Drawing.Size(31, 22);
            this.tb_LTEPCI.TabIndex = 28;
            this.tb_LTEPCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(152, 126);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 13);
            this.label34.TabIndex = 71;
            this.label34.Text = "PCI";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(238, 178);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(21, 13);
            this.label33.TabIndex = 70;
            this.label33.Text = "dB";
            // 
            // tb_LTEBand
            // 
            this.tb_LTEBand.CausesValidation = false;
            this.tb_LTEBand.Location = new System.Drawing.Point(48, 123);
            this.tb_LTEBand.Name = "tb_LTEBand";
            this.tb_LTEBand.ReadOnly = true;
            this.tb_LTEBand.Size = new System.Drawing.Size(26, 22);
            this.tb_LTEBand.TabIndex = 27;
            this.tb_LTEBand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(10, 126);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 13);
            this.label32.TabIndex = 68;
            this.label32.Text = "Band";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(238, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 67;
            this.label25.Text = "dB";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(104, 178);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(30, 13);
            this.label26.TabIndex = 66;
            this.label26.Text = "dBm";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(104, 152);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 13);
            this.label27.TabIndex = 65;
            this.label27.Text = "dBm";
            // 
            // tb_LTESNR
            // 
            this.tb_LTESNR.CausesValidation = false;
            this.tb_LTESNR.Location = new System.Drawing.Point(182, 175);
            this.tb_LTESNR.Name = "tb_LTESNR";
            this.tb_LTESNR.ReadOnly = true;
            this.tb_LTESNR.Size = new System.Drawing.Size(50, 22);
            this.tb_LTESNR.TabIndex = 32;
            this.tb_LTESNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(146, 178);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 13);
            this.label28.TabIndex = 63;
            this.label28.Text = "SNR";
            // 
            // tb_LTERSRQ
            // 
            this.tb_LTERSRQ.CausesValidation = false;
            this.tb_LTERSRQ.Location = new System.Drawing.Point(182, 149);
            this.tb_LTERSRQ.Name = "tb_LTERSRQ";
            this.tb_LTERSRQ.ReadOnly = true;
            this.tb_LTERSRQ.Size = new System.Drawing.Size(50, 22);
            this.tb_LTERSRQ.TabIndex = 31;
            this.tb_LTERSRQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(138, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 61;
            this.label29.Text = "RSRQ";
            // 
            // tb_LTERSRP
            // 
            this.tb_LTERSRP.CausesValidation = false;
            this.tb_LTERSRP.Location = new System.Drawing.Point(48, 175);
            this.tb_LTERSRP.Name = "tb_LTERSRP";
            this.tb_LTERSRP.ReadOnly = true;
            this.tb_LTERSRP.Size = new System.Drawing.Size(50, 22);
            this.tb_LTERSRP.TabIndex = 30;
            this.tb_LTERSRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 178);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(33, 13);
            this.label30.TabIndex = 59;
            this.label30.Text = "RSRP";
            // 
            // tb_LTERSSI
            // 
            this.tb_LTERSSI.CausesValidation = false;
            this.tb_LTERSSI.Location = new System.Drawing.Point(48, 149);
            this.tb_LTERSSI.Name = "tb_LTERSSI";
            this.tb_LTERSSI.ReadOnly = true;
            this.tb_LTERSSI.Size = new System.Drawing.Size(50, 22);
            this.tb_LTERSSI.TabIndex = 29;
            this.tb_LTERSSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(10, 152);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 13);
            this.label31.TabIndex = 57;
            this.label31.Text = "RSSI";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "dBm";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(104, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "dBm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(104, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 13);
            this.label22.TabIndex = 38;
            this.label22.Text = "dBm";
            // 
            // tb_CSQ
            // 
            this.tb_CSQ.CausesValidation = false;
            this.tb_CSQ.Location = new System.Drawing.Point(178, 71);
            this.tb_CSQ.Name = "tb_CSQ";
            this.tb_CSQ.ReadOnly = true;
            this.tb_CSQ.Size = new System.Drawing.Size(50, 22);
            this.tb_CSQ.TabIndex = 26;
            this.tb_CSQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(143, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "CSQ";
            // 
            // tb_ECIO
            // 
            this.tb_ECIO.CausesValidation = false;
            this.tb_ECIO.Location = new System.Drawing.Point(178, 45);
            this.tb_ECIO.Name = "tb_ECIO";
            this.tb_ECIO.ReadOnly = true;
            this.tb_ECIO.Size = new System.Drawing.Size(50, 22);
            this.tb_ECIO.TabIndex = 25;
            this.tb_ECIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(138, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Ec/Io";
            // 
            // tb_RSCP
            // 
            this.tb_RSCP.CausesValidation = false;
            this.tb_RSCP.Location = new System.Drawing.Point(48, 71);
            this.tb_RSCP.Name = "tb_RSCP";
            this.tb_RSCP.ReadOnly = true;
            this.tb_RSCP.Size = new System.Drawing.Size(50, 22);
            this.tb_RSCP.TabIndex = 24;
            this.tb_RSCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "RSCP";
            // 
            // tb_RSSI
            // 
            this.tb_RSSI.CausesValidation = false;
            this.tb_RSSI.Location = new System.Drawing.Point(48, 45);
            this.tb_RSSI.Name = "tb_RSSI";
            this.tb_RSSI.ReadOnly = true;
            this.tb_RSSI.Size = new System.Drawing.Size(50, 22);
            this.tb_RSSI.TabIndex = 23;
            this.tb_RSSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // signalBar
            // 
            this.signalBar.Location = new System.Drawing.Point(6, 19);
            this.signalBar.Name = "signalBar";
            this.signalBar.Size = new System.Drawing.Size(258, 16);
            this.signalBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.signalBar.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "RSSI";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusSpring,
            this.toolStripStatusLabel_Model});
            this.statusStrip.Location = new System.Drawing.Point(0, 405);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(591, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 41;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripStatusSpring
            // 
            this.toolStripStatusSpring.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusSpring.Name = "toolStripStatusSpring";
            this.toolStripStatusSpring.Size = new System.Drawing.Size(476, 17);
            this.toolStripStatusSpring.Spring = true;
            // 
            // toolStripStatusLabel_Model
            // 
            this.toolStripStatusLabel_Model.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_Model.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_Model.Name = "toolStripStatusLabel_Model";
            this.toolStripStatusLabel_Model.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel_Model.Text = "No Device";
            // 
            // backgroundWorker_DevicePinger
            // 
            this.backgroundWorker_DevicePinger.WorkerSupportsCancellation = true;
            this.backgroundWorker_DevicePinger.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DevicePinger_DoWork);
            this.backgroundWorker_DevicePinger.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_DevicePinger_RunWorkerCompleted);
            // 
            // worker_GetStaticDeviceInfo
            // 
            this.worker_GetStaticDeviceInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_StaticDeviceInfo_DoWork);
            this.worker_GetStaticDeviceInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_StaticDeviceInfo_RunWorkerCompleted);
            // 
            // button_Save
            // 
            this.button_Save.Enabled = false;
            this.button_Save.Location = new System.Drawing.Point(112, 58);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // tabControl_Monitor
            // 
            this.tabControl_Monitor.Controls.Add(this.tabPage_Dashboard);
            this.tabControl_Monitor.Controls.Add(this.tabPage_ModemInformation);
            this.tabControl_Monitor.Controls.Add(this.tabPage_DeviceInformation);
            this.tabControl_Monitor.Controls.Add(this.tabPage_AppSettings);
            this.tabControl_Monitor.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Monitor.Name = "tabControl_Monitor";
            this.tabControl_Monitor.SelectedIndex = 0;
            this.tabControl_Monitor.Size = new System.Drawing.Size(562, 354);
            this.tabControl_Monitor.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl_Monitor.TabIndex = 42;
            // 
            // tabPage_Dashboard
            // 
            this.tabPage_Dashboard.Controls.Add(this.panel_Connected);
            this.tabPage_Dashboard.Controls.Add(this.panel_NotConnected);
            this.tabPage_Dashboard.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dashboard.Name = "tabPage_Dashboard";
            this.tabPage_Dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dashboard.Size = new System.Drawing.Size(554, 328);
            this.tabPage_Dashboard.TabIndex = 3;
            this.tabPage_Dashboard.Text = "Dashboard";
            this.tabPage_Dashboard.UseVisualStyleBackColor = true;
            // 
            // panel_Connected
            // 
            this.panel_Connected.Controls.Add(this.label_SignalStrength);
            this.panel_Connected.Controls.Add(this.pictureBox_signalbar);
            this.panel_Connected.Controls.Add(this.label_PPPStatus);
            this.panel_Connected.Controls.Add(this.pictureBox_SMSIcon);
            this.panel_Connected.Controls.Add(this.label_UnreadSMS);
            this.panel_Connected.Controls.Add(this.label_NetType);
            this.panel_Connected.Controls.Add(this.tableLayoutPanel1);
            this.panel_Connected.Controls.Add(this.flowLayoutPanel1);
            this.panel_Connected.Controls.Add(this.label_OpName);
            this.panel_Connected.Controls.Add(this.button_CDC);
            this.panel_Connected.Location = new System.Drawing.Point(6, 6);
            this.panel_Connected.Name = "panel_Connected";
            this.panel_Connected.Size = new System.Drawing.Size(542, 316);
            this.panel_Connected.TabIndex = 0;
            this.panel_Connected.Visible = false;
            // 
            // label_SignalStrength
            // 
            this.label_SignalStrength.Location = new System.Drawing.Point(481, 31);
            this.label_SignalStrength.Margin = new System.Windows.Forms.Padding(0);
            this.label_SignalStrength.Name = "label_SignalStrength";
            this.label_SignalStrength.Size = new System.Drawing.Size(61, 16);
            this.label_SignalStrength.TabIndex = 16;
            this.label_SignalStrength.Text = "signal";
            this.label_SignalStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_signalbar
            // 
            this.pictureBox_signalbar.Location = new System.Drawing.Point(499, 3);
            this.pictureBox_signalbar.Name = "pictureBox_signalbar";
            this.pictureBox_signalbar.Size = new System.Drawing.Size(40, 25);
            this.pictureBox_signalbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_signalbar.TabIndex = 15;
            this.pictureBox_signalbar.TabStop = false;
            // 
            // label_PPPStatus
            // 
            this.label_PPPStatus.Location = new System.Drawing.Point(377, 129);
            this.label_PPPStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_PPPStatus.Name = "label_PPPStatus";
            this.label_PPPStatus.Size = new System.Drawing.Size(165, 24);
            this.label_PPPStatus.TabIndex = 14;
            this.label_PPPStatus.Text = "PPPStatus";
            this.label_PPPStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_SMSIcon
            // 
            this.pictureBox_SMSIcon.Image = global::ZTEHostlessDashboard.Properties.Resources.sms_unread;
            this.pictureBox_SMSIcon.Location = new System.Drawing.Point(10, 3);
            this.pictureBox_SMSIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 10);
            this.pictureBox_SMSIcon.Name = "pictureBox_SMSIcon";
            this.pictureBox_SMSIcon.Size = new System.Drawing.Size(22, 30);
            this.pictureBox_SMSIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_SMSIcon.TabIndex = 13;
            this.pictureBox_SMSIcon.TabStop = false;
            // 
            // label_UnreadSMS
            // 
            this.label_UnreadSMS.AutoSize = true;
            this.label_UnreadSMS.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UnreadSMS.Location = new System.Drawing.Point(35, 10);
            this.label_UnreadSMS.Margin = new System.Windows.Forms.Padding(0);
            this.label_UnreadSMS.Name = "label_UnreadSMS";
            this.label_UnreadSMS.Size = new System.Drawing.Size(72, 15);
            this.label_UnreadSMS.TabIndex = 12;
            this.label_UnreadSMS.Text = "unread_sms";
            // 
            // label_NetType
            // 
            this.label_NetType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_NetType.Location = new System.Drawing.Point(301, 5);
            this.label_NetType.Margin = new System.Windows.Forms.Padding(10);
            this.label_NetType.Name = "label_NetType";
            this.label_NetType.Size = new System.Drawing.Size(185, 23);
            this.label_NetType.TabIndex = 11;
            this.label_NetType.Text = "Network Type";
            this.label_NetType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.61172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.54212F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tableLayoutPanel1.Controls.Add(this.label44, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_TxRate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label46, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_RxRate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label48, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentTx, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label50, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentRx, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label45, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentDuration, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label47, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_CurrentTotal, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 93);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 62);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(3, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 13);
            this.label44.TabIndex = 0;
            this.label44.Text = "Tx Rate";
            // 
            // label_TxRate
            // 
            this.label_TxRate.AutoSize = true;
            this.label_TxRate.Location = new System.Drawing.Point(62, 0);
            this.label_TxRate.Name = "label_TxRate";
            this.label_TxRate.Size = new System.Drawing.Size(41, 13);
            this.label_TxRate.TabIndex = 1;
            this.label_TxRate.Text = "tx_rate";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(138, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 13);
            this.label46.TabIndex = 2;
            this.label46.Text = "Rx Rate";
            // 
            // label_RxRate
            // 
            this.label_RxRate.AutoSize = true;
            this.label_RxRate.Location = new System.Drawing.Point(205, 0);
            this.label_RxRate.Name = "label_RxRate";
            this.label_RxRate.Size = new System.Drawing.Size(41, 13);
            this.label_RxRate.TabIndex = 3;
            this.label_RxRate.Text = "rx_rate";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(3, 20);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(45, 13);
            this.label48.TabIndex = 4;
            this.label48.Text = "Upload";
            // 
            // label_CurrentTx
            // 
            this.label_CurrentTx.AutoSize = true;
            this.label_CurrentTx.Location = new System.Drawing.Point(62, 20);
            this.label_CurrentTx.Name = "label_CurrentTx";
            this.label_CurrentTx.Size = new System.Drawing.Size(58, 13);
            this.label_CurrentTx.TabIndex = 5;
            this.label_CurrentTx.Text = "current_tx";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(138, 20);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(61, 13);
            this.label50.TabIndex = 6;
            this.label50.Text = "Download";
            // 
            // label_CurrentRx
            // 
            this.label_CurrentRx.AutoSize = true;
            this.label_CurrentRx.Location = new System.Drawing.Point(205, 20);
            this.label_CurrentRx.Name = "label_CurrentRx";
            this.label_CurrentRx.Size = new System.Drawing.Size(58, 13);
            this.label_CurrentRx.TabIndex = 7;
            this.label_CurrentRx.Text = "current_rx";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(3, 40);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 13);
            this.label45.TabIndex = 8;
            this.label45.Text = "Duration";
            // 
            // label_CurrentDuration
            // 
            this.label_CurrentDuration.AutoSize = true;
            this.label_CurrentDuration.Location = new System.Drawing.Point(62, 40);
            this.label_CurrentDuration.Name = "label_CurrentDuration";
            this.label_CurrentDuration.Size = new System.Drawing.Size(61, 13);
            this.label_CurrentDuration.TabIndex = 9;
            this.label_CurrentDuration.Text = "9999:99:99";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(138, 40);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(31, 13);
            this.label47.TabIndex = 10;
            this.label47.Text = "Total";
            // 
            // label_CurrentTotal
            // 
            this.label_CurrentTotal.AutoSize = true;
            this.label_CurrentTotal.Location = new System.Drawing.Point(205, 40);
            this.label_CurrentTotal.Name = "label_CurrentTotal";
            this.label_CurrentTotal.Size = new System.Drawing.Size(64, 22);
            this.label_CurrentTotal.TabIndex = 11;
            this.label_CurrentTotal.Text = "current_total";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.button_USSD);
            this.flowLayoutPanel1.Controls.Add(this.button_SMS);
            this.flowLayoutPanel1.Controls.Add(this.button_Settings);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 260);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(542, 56);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // button_USSD
            // 
            this.button_USSD.AutoSize = true;
            this.button_USSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_USSD.Location = new System.Drawing.Point(3, 3);
            this.button_USSD.Name = "button_USSD";
            this.button_USSD.Size = new System.Drawing.Size(75, 50);
            this.button_USSD.TabIndex = 2;
            this.button_USSD.Text = "USSD";
            this.button_USSD.UseVisualStyleBackColor = true;
            // 
            // button_SMS
            // 
            this.button_SMS.AutoSize = true;
            this.button_SMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SMS.Location = new System.Drawing.Point(84, 3);
            this.button_SMS.Name = "button_SMS";
            this.button_SMS.Size = new System.Drawing.Size(75, 50);
            this.button_SMS.TabIndex = 3;
            this.button_SMS.Text = "SMS";
            this.button_SMS.UseVisualStyleBackColor = true;
            // 
            // button_Settings
            // 
            this.button_Settings.AutoSize = true;
            this.button_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Settings.Location = new System.Drawing.Point(165, 3);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(75, 50);
            this.button_Settings.TabIndex = 4;
            this.button_Settings.Text = "Settings";
            this.button_Settings.UseVisualStyleBackColor = true;
            // 
            // label_OpName
            // 
            this.label_OpName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OpName.Location = new System.Drawing.Point(294, 86);
            this.label_OpName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label_OpName.Name = "label_OpName";
            this.label_OpName.Size = new System.Drawing.Size(248, 40);
            this.label_OpName.TabIndex = 7;
            this.label_OpName.Text = "Operator Name";
            this.label_OpName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_CDC
            // 
            this.button_CDC.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CDC.Location = new System.Drawing.Point(389, 181);
            this.button_CDC.Name = "button_CDC";
            this.button_CDC.Size = new System.Drawing.Size(150, 50);
            this.button_CDC.TabIndex = 8;
            this.button_CDC.Text = "Connect";
            this.button_CDC.UseVisualStyleBackColor = true;
            this.button_CDC.Click += new System.EventHandler(this.button_CDC_Click);
            // 
            // panel_NotConnected
            // 
            this.panel_NotConnected.BackColor = System.Drawing.Color.Transparent;
            this.panel_NotConnected.Controls.Add(this.label_NotConnected);
            this.panel_NotConnected.Location = new System.Drawing.Point(0, 139);
            this.panel_NotConnected.Name = "panel_NotConnected";
            this.panel_NotConnected.Size = new System.Drawing.Size(554, 42);
            this.panel_NotConnected.TabIndex = 13;
            // 
            // label_NotConnected
            // 
            this.label_NotConnected.AutoSize = true;
            this.label_NotConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NotConnected.Location = new System.Drawing.Point(171, 9);
            this.label_NotConnected.Name = "label_NotConnected";
            this.label_NotConnected.Size = new System.Drawing.Size(212, 24);
            this.label_NotConnected.TabIndex = 0;
            this.label_NotConnected.Text = "Waiting for the device";
            this.label_NotConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage_ModemInformation
            // 
            this.tabPage_ModemInformation.Controls.Add(this.groupBox_Connection);
            this.tabPage_ModemInformation.Controls.Add(this.groupBox_Network);
            this.tabPage_ModemInformation.Controls.Add(this.groupBox_Signal);
            this.tabPage_ModemInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_ModemInformation.Name = "tabPage_ModemInformation";
            this.tabPage_ModemInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_ModemInformation.Size = new System.Drawing.Size(554, 328);
            this.tabPage_ModemInformation.TabIndex = 0;
            this.tabPage_ModemInformation.Text = "Device Monitor";
            this.tabPage_ModemInformation.UseVisualStyleBackColor = true;
            // 
            // groupBox_Connection
            // 
            this.groupBox_Connection.Controls.Add(this.tb_RxRate);
            this.groupBox_Connection.Controls.Add(this.label41);
            this.groupBox_Connection.Controls.Add(this.tb_TxRate);
            this.groupBox_Connection.Controls.Add(this.label40);
            this.groupBox_Connection.Controls.Add(this.tb_PPPState);
            this.groupBox_Connection.Controls.Add(this.label11);
            this.groupBox_Connection.Controls.Add(this.tb_APN);
            this.groupBox_Connection.Controls.Add(this.label36);
            this.groupBox_Connection.Controls.Add(this.label37);
            this.groupBox_Connection.Controls.Add(this.tb_IPAddress);
            this.groupBox_Connection.Controls.Add(this.label38);
            this.groupBox_Connection.Controls.Add(this.tb_DNS2);
            this.groupBox_Connection.Controls.Add(this.tb_DNS1);
            this.groupBox_Connection.Controls.Add(this.label39);
            this.groupBox_Connection.Location = new System.Drawing.Point(6, 218);
            this.groupBox_Connection.Name = "groupBox_Connection";
            this.groupBox_Connection.Size = new System.Drawing.Size(542, 102);
            this.groupBox_Connection.TabIndex = 34;
            this.groupBox_Connection.TabStop = false;
            this.groupBox_Connection.Text = "Connection";
            // 
            // tb_RxRate
            // 
            this.tb_RxRate.CausesValidation = false;
            this.tb_RxRate.Location = new System.Drawing.Point(464, 45);
            this.tb_RxRate.Name = "tb_RxRate";
            this.tb_RxRate.ReadOnly = true;
            this.tb_RxRate.Size = new System.Drawing.Size(67, 22);
            this.tb_RxRate.TabIndex = 40;
            this.tb_RxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(387, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(76, 13);
            this.label41.TabIndex = 38;
            this.label41.Text = "Uplink Speed";
            // 
            // tb_TxRate
            // 
            this.tb_TxRate.CausesValidation = false;
            this.tb_TxRate.Location = new System.Drawing.Point(464, 19);
            this.tb_TxRate.Name = "tb_TxRate";
            this.tb_TxRate.ReadOnly = true;
            this.tb_TxRate.Size = new System.Drawing.Size(67, 22);
            this.tb_TxRate.TabIndex = 39;
            this.tb_TxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(373, 48);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(92, 13);
            this.label40.TabIndex = 36;
            this.label40.Text = "Downlink Speed";
            // 
            // tb_PPPState
            // 
            this.tb_PPPState.CausesValidation = false;
            this.tb_PPPState.Location = new System.Drawing.Point(68, 19);
            this.tb_PPPState.Name = "tb_PPPState";
            this.tb_PPPState.ReadOnly = true;
            this.tb_PPPState.Size = new System.Drawing.Size(100, 22);
            this.tb_PPPState.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "PPP State";
            // 
            // tb_APN
            // 
            this.tb_APN.CausesValidation = false;
            this.tb_APN.Location = new System.Drawing.Point(68, 45);
            this.tb_APN.Name = "tb_APN";
            this.tb_APN.ReadOnly = true;
            this.tb_APN.Size = new System.Drawing.Size(100, 22);
            this.tb_APN.TabIndex = 35;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(33, 48);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(28, 13);
            this.label36.TabIndex = 22;
            this.label36.Text = "APN";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(174, 22);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 13);
            this.label37.TabIndex = 24;
            this.label37.Text = "WAN IP Address";
            // 
            // tb_IPAddress
            // 
            this.tb_IPAddress.CausesValidation = false;
            this.tb_IPAddress.Location = new System.Drawing.Point(267, 19);
            this.tb_IPAddress.Name = "tb_IPAddress";
            this.tb_IPAddress.ReadOnly = true;
            this.tb_IPAddress.Size = new System.Drawing.Size(90, 22);
            this.tb_IPAddress.TabIndex = 36;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(194, 48);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 13);
            this.label38.TabIndex = 26;
            this.label38.Text = "DNS Primary";
            // 
            // tb_DNS2
            // 
            this.tb_DNS2.CausesValidation = false;
            this.tb_DNS2.Location = new System.Drawing.Point(267, 71);
            this.tb_DNS2.Name = "tb_DNS2";
            this.tb_DNS2.ReadOnly = true;
            this.tb_DNS2.Size = new System.Drawing.Size(90, 22);
            this.tb_DNS2.TabIndex = 38;
            // 
            // tb_DNS1
            // 
            this.tb_DNS1.CausesValidation = false;
            this.tb_DNS1.Location = new System.Drawing.Point(267, 45);
            this.tb_DNS1.Name = "tb_DNS1";
            this.tb_DNS1.ReadOnly = true;
            this.tb_DNS1.Size = new System.Drawing.Size(90, 22);
            this.tb_DNS1.TabIndex = 37;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(177, 74);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(85, 13);
            this.label39.TabIndex = 28;
            this.label39.Text = "DNS Secondary";
            // 
            // tabPage_DeviceInformation
            // 
            this.tabPage_DeviceInformation.Controls.Add(this.groupBox_Info);
            this.tabPage_DeviceInformation.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DeviceInformation.Name = "tabPage_DeviceInformation";
            this.tabPage_DeviceInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DeviceInformation.Size = new System.Drawing.Size(554, 328);
            this.tabPage_DeviceInformation.TabIndex = 1;
            this.tabPage_DeviceInformation.Text = "Device Information";
            this.tabPage_DeviceInformation.UseVisualStyleBackColor = true;
            // 
            // tabPage_AppSettings
            // 
            this.tabPage_AppSettings.Controls.Add(this.button_Save);
            this.tabPage_AppSettings.Controls.Add(this.label43);
            this.tabPage_AppSettings.Controls.Add(this.label_dashboardAddr);
            this.tabPage_AppSettings.Controls.Add(this.label14);
            this.tabPage_AppSettings.Controls.Add(this.tb_dashboardAddress);
            this.tabPage_AppSettings.Controls.Add(this.numericUpDown_PoolingInterval);
            this.tabPage_AppSettings.Controls.Add(this.checkBox_AlwaysOnTop);
            this.tabPage_AppSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AppSettings.Name = "tabPage_AppSettings";
            this.tabPage_AppSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AppSettings.Size = new System.Drawing.Size(554, 328);
            this.tabPage_AppSettings.TabIndex = 2;
            this.tabPage_AppSettings.Text = "App. Settings";
            this.tabPage_AppSettings.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(165, 34);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(21, 13);
            this.label43.TabIndex = 3;
            this.label43.Text = "ms";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Update Interval";
            // 
            // numericUpDown_PoolingInterval
            // 
            this.numericUpDown_PoolingInterval.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_PoolingInterval.Location = new System.Drawing.Point(112, 32);
            this.numericUpDown_PoolingInterval.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_PoolingInterval.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_PoolingInterval.Name = "numericUpDown_PoolingInterval";
            this.numericUpDown_PoolingInterval.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown_PoolingInterval.TabIndex = 3;
            this.numericUpDown_PoolingInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown_PoolingInterval.ValueChanged += new System.EventHandler(this.numericUpDown_PoolingInterval_ValueChanged);
            // 
            // checkBox_AlwaysOnTop
            // 
            this.checkBox_AlwaysOnTop.AutoSize = true;
            this.checkBox_AlwaysOnTop.Location = new System.Drawing.Point(456, 8);
            this.checkBox_AlwaysOnTop.Name = "checkBox_AlwaysOnTop";
            this.checkBox_AlwaysOnTop.Size = new System.Drawing.Size(99, 17);
            this.checkBox_AlwaysOnTop.TabIndex = 2;
            this.checkBox_AlwaysOnTop.Text = "Always on top";
            this.checkBox_AlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBox_AlwaysOnTop.CheckedChanged += new System.EventHandler(this.checkBox_AlwaysOnTop_CheckedChanged);
            // 
            // backgroundWorker_ModemCDC
            // 
            this.backgroundWorker_ModemCDC.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_ModemCDC_DoWork);
            this.backgroundWorker_ModemCDC.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_ModemCDC_RunWorkerCompleted);
            // 
            // Monitor
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(591, 427);
            this.Controls.Add(this.tabControl_Monitor);
            this.Controls.Add(this.statusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Monitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZTE Hostless Modem Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor_FormClosing);
            this.Shown += new System.EventHandler(this.Monitor_Shown);
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.groupBox_Network.ResumeLayout(false);
            this.groupBox_Network.PerformLayout();
            this.groupBox_Signal.ResumeLayout(false);
            this.groupBox_Signal.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl_Monitor.ResumeLayout(false);
            this.tabPage_Dashboard.ResumeLayout(false);
            this.panel_Connected.ResumeLayout(false);
            this.panel_Connected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_signalbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SMSIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel_NotConnected.ResumeLayout(false);
            this.panel_NotConnected.PerformLayout();
            this.tabPage_ModemInformation.ResumeLayout(false);
            this.groupBox_Connection.ResumeLayout(false);
            this.groupBox_Connection.PerformLayout();
            this.tabPage_DeviceInformation.ResumeLayout(false);
            this.tabPage_AppSettings.ResumeLayout(false);
            this.tabPage_AppSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_PoolingInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_dashboardAddr;
        private System.Windows.Forms.TextBox tb_dashboardAddress;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.ComponentModel.BackgroundWorker backgroundWorker_AJAXFetch;
        private System.Windows.Forms.GroupBox groupBox_Network;
        private System.Windows.Forms.TextBox tb_NetDomainSpec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_NetType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_NetSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_OpName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_Signal;
        private System.Windows.Forms.TextBox tb_CellID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_LAC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_MNC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_MCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_CSQ;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_ECIO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_RSCP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_RSSI;
        private System.Windows.Forms.ProgressBar signalBar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox tb_LTEPCI;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tb_LTEBand;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tb_LTESNR;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_LTERSRQ;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tb_LTERSRP;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tb_LTERSSI;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tb_ActiveBand;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Model;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSpring;
        private System.Windows.Forms.TextBox tb_Roam;
        private System.Windows.Forms.Label label42;
        private System.ComponentModel.BackgroundWorker backgroundWorker_DevicePinger;
        private System.ComponentModel.BackgroundWorker worker_GetStaticDeviceInfo;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox tb_SWVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FWVer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_HWVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_IMSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_IMEI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_State;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl_Monitor;
        private System.Windows.Forms.TabPage tabPage_ModemInformation;
        private System.Windows.Forms.GroupBox groupBox_Connection;
        private System.Windows.Forms.TextBox tb_RxRate;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tb_TxRate;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox tb_PPPState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_APN;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox tb_IPAddress;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tb_DNS2;
        private System.Windows.Forms.TextBox tb_DNS1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabPage_DeviceInformation;
        private System.Windows.Forms.TabPage tabPage_AppSettings;
        private System.Windows.Forms.CheckBox checkBox_AlwaysOnTop;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDown_PoolingInterval;
        private System.Windows.Forms.TabPage tabPage_Dashboard;
        private System.Windows.Forms.Panel panel_Connected;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label_TxRate;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label_RxRate;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label_CurrentTx;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label_CurrentRx;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_USSD;
        private System.Windows.Forms.Button button_SMS;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Label label_OpName;
        private System.Windows.Forms.Button button_CDC;
        private System.Windows.Forms.Label label_UnreadSMS;
        private System.Windows.Forms.Label label_NetType;
        private System.Windows.Forms.Panel panel_NotConnected;
        private System.Windows.Forms.Label label_NotConnected;
        private System.Windows.Forms.PictureBox pictureBox_SMSIcon;
        private System.Windows.Forms.Label label_PPPStatus;
        private System.Windows.Forms.PictureBox pictureBox_signalbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker_ModemCDC;
        private System.Windows.Forms.Label label_SignalStrength;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label_CurrentDuration;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label_CurrentTotal;
    }
}

