namespace Remote_Temperature_Monitoring
{
    partial class frmSettings
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
            this.grpEmailSubscribers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkLowLowLimitEmail = new System.Windows.Forms.CheckBox();
            this.chkLowLimitEmail = new System.Windows.Forms.CheckBox();
            this.chkHighHighLimitEmail = new System.Windows.Forms.CheckBox();
            this.chkHighLimitEmail = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAlarmLimits = new System.Windows.Forms.GroupBox();
            this.lblHighHighLimit = new System.Windows.Forms.Label();
            this.lblHighLimit = new System.Windows.Forms.Label();
            this.lblLowLimit = new System.Windows.Forms.Label();
            this.lblLowLowLimit = new System.Windows.Forms.Label();
            this.txtHighHighLimit = new System.Windows.Forms.TextBox();
            this.txtHighLimit = new System.Windows.Forms.TextBox();
            this.txtLowLimit = new System.Windows.Forms.TextBox();
            this.txtLowLowLimit = new System.Windows.Forms.TextBox();
            this.chkLowLowLimitSMS = new System.Windows.Forms.CheckBox();
            this.chkLowLimitSMS = new System.Windows.Forms.CheckBox();
            this.chkHighLimitSMS = new System.Windows.Forms.CheckBox();
            this.chkHighHighLimitSMS = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveEmail = new System.Windows.Forms.Button();
            this.btnAddEmail = new System.Windows.Forms.Button();
            this.lblEmailAdress = new System.Windows.Forms.Label();
            this.txtEmailAdress = new System.Windows.Forms.TextBox();
            this.lstEmail = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpPhoneSubscribers = new System.Windows.Forms.GroupBox();
            this.btnRemovePhoneNumber = new System.Windows.Forms.Button();
            this.btnAddPhoneNumber = new System.Windows.Forms.Button();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lstPhoneNumber = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grpGSMSettings = new System.Windows.Forms.GroupBox();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.grpEmailAccount = new System.Windows.Forms.GroupBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.cBSsl = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.lblEnableSsl = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblSenderEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpEmailSubscribers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpAlarmLimits.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grpPhoneSubscribers.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.grpGSMSettings.SuspendLayout();
            this.grpEmailAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmailSubscribers
            // 
            this.grpEmailSubscribers.Controls.Add(this.tabPage1);
            this.grpEmailSubscribers.Controls.Add(this.tabPage2);
            this.grpEmailSubscribers.Controls.Add(this.tabPage3);
            this.grpEmailSubscribers.Controls.Add(this.tabPage4);
            this.grpEmailSubscribers.Location = new System.Drawing.Point(12, 12);
            this.grpEmailSubscribers.Name = "grpEmailSubscribers";
            this.grpEmailSubscribers.SelectedIndex = 0;
            this.grpEmailSubscribers.Size = new System.Drawing.Size(342, 224);
            this.grpEmailSubscribers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chkLowLowLimitEmail);
            this.tabPage1.Controls.Add(this.chkLowLimitEmail);
            this.tabPage1.Controls.Add(this.chkHighHighLimitEmail);
            this.tabPage1.Controls.Add(this.chkHighLimitEmail);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.grpAlarmLimits);
            this.tabPage1.Controls.Add(this.chkLowLowLimitSMS);
            this.tabPage1.Controls.Add(this.chkLowLimitSMS);
            this.tabPage1.Controls.Add(this.chkHighLimitSMS);
            this.tabPage1.Controls.Add(this.chkHighHighLimitSMS);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 198);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alarm settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "HighHigh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "High";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Low";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "LowLow";
            // 
            // chkLowLowLimitEmail
            // 
            this.chkLowLowLimitEmail.AutoSize = true;
            this.chkLowLowLimitEmail.Location = new System.Drawing.Point(181, 177);
            this.chkLowLowLimitEmail.Name = "chkLowLowLimitEmail";
            this.chkLowLowLimitEmail.Size = new System.Drawing.Size(15, 14);
            this.chkLowLowLimitEmail.TabIndex = 13;
            this.chkLowLowLimitEmail.UseVisualStyleBackColor = true;
            // 
            // chkLowLimitEmail
            // 
            this.chkLowLimitEmail.AutoSize = true;
            this.chkLowLimitEmail.Location = new System.Drawing.Point(223, 177);
            this.chkLowLimitEmail.Name = "chkLowLimitEmail";
            this.chkLowLimitEmail.Size = new System.Drawing.Size(15, 14);
            this.chkLowLimitEmail.TabIndex = 12;
            this.chkLowLimitEmail.UseVisualStyleBackColor = true;
            // 
            // chkHighHighLimitEmail
            // 
            this.chkHighHighLimitEmail.AutoSize = true;
            this.chkHighHighLimitEmail.Location = new System.Drawing.Point(307, 178);
            this.chkHighHighLimitEmail.Name = "chkHighHighLimitEmail";
            this.chkHighHighLimitEmail.Size = new System.Drawing.Size(15, 14);
            this.chkHighHighLimitEmail.TabIndex = 11;
            this.chkHighHighLimitEmail.UseVisualStyleBackColor = true;
            // 
            // chkHighLimitEmail
            // 
            this.chkHighLimitEmail.AutoSize = true;
            this.chkHighLimitEmail.Location = new System.Drawing.Point(262, 177);
            this.chkHighLimitEmail.Name = "chkHighLimitEmail";
            this.chkHighLimitEmail.Size = new System.Drawing.Size(15, 14);
            this.chkHighLimitEmail.TabIndex = 10;
            this.chkHighLimitEmail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email recived for checked alarms:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "SMS recived for checked alarms:";
            // 
            // grpAlarmLimits
            // 
            this.grpAlarmLimits.Controls.Add(this.lblHighHighLimit);
            this.grpAlarmLimits.Controls.Add(this.lblHighLimit);
            this.grpAlarmLimits.Controls.Add(this.lblLowLimit);
            this.grpAlarmLimits.Controls.Add(this.lblLowLowLimit);
            this.grpAlarmLimits.Controls.Add(this.txtHighHighLimit);
            this.grpAlarmLimits.Controls.Add(this.txtHighLimit);
            this.grpAlarmLimits.Controls.Add(this.txtLowLimit);
            this.grpAlarmLimits.Controls.Add(this.txtLowLowLimit);
            this.grpAlarmLimits.Location = new System.Drawing.Point(7, 7);
            this.grpAlarmLimits.Name = "grpAlarmLimits";
            this.grpAlarmLimits.Size = new System.Drawing.Size(321, 126);
            this.grpAlarmLimits.TabIndex = 0;
            this.grpAlarmLimits.TabStop = false;
            this.grpAlarmLimits.Text = "Limits";
            // 
            // lblHighHighLimit
            // 
            this.lblHighHighLimit.AutoSize = true;
            this.lblHighHighLimit.Location = new System.Drawing.Point(16, 100);
            this.lblHighHighLimit.Name = "lblHighHighLimit";
            this.lblHighHighLimit.Size = new System.Drawing.Size(77, 13);
            this.lblHighHighLimit.TabIndex = 11;
            this.lblHighHighLimit.Text = "High High limit:";
            // 
            // lblHighLimit
            // 
            this.lblHighLimit.AutoSize = true;
            this.lblHighLimit.Location = new System.Drawing.Point(16, 74);
            this.lblHighLimit.Name = "lblHighLimit";
            this.lblHighLimit.Size = new System.Drawing.Size(52, 13);
            this.lblHighLimit.TabIndex = 10;
            this.lblHighLimit.Text = "High limit:";
            // 
            // lblLowLimit
            // 
            this.lblLowLimit.AutoSize = true;
            this.lblLowLimit.Location = new System.Drawing.Point(16, 48);
            this.lblLowLimit.Name = "lblLowLimit";
            this.lblLowLimit.Size = new System.Drawing.Size(50, 13);
            this.lblLowLimit.TabIndex = 9;
            this.lblLowLimit.Text = "Low limit:";
            // 
            // lblLowLowLimit
            // 
            this.lblLowLowLimit.AutoSize = true;
            this.lblLowLowLimit.Location = new System.Drawing.Point(16, 22);
            this.lblLowLowLimit.Name = "lblLowLowLimit";
            this.lblLowLowLimit.Size = new System.Drawing.Size(73, 13);
            this.lblLowLowLimit.TabIndex = 8;
            this.lblLowLowLimit.Text = "Low Low limit:";
            // 
            // txtHighHighLimit
            // 
            this.txtHighHighLimit.Location = new System.Drawing.Point(148, 97);
            this.txtHighHighLimit.Name = "txtHighHighLimit";
            this.txtHighHighLimit.Size = new System.Drawing.Size(167, 20);
            this.txtHighHighLimit.TabIndex = 3;
            // 
            // txtHighLimit
            // 
            this.txtHighLimit.Location = new System.Drawing.Point(148, 71);
            this.txtHighLimit.Name = "txtHighLimit";
            this.txtHighLimit.Size = new System.Drawing.Size(167, 20);
            this.txtHighLimit.TabIndex = 2;
            // 
            // txtLowLimit
            // 
            this.txtLowLimit.Location = new System.Drawing.Point(148, 45);
            this.txtLowLimit.Name = "txtLowLimit";
            this.txtLowLimit.Size = new System.Drawing.Size(167, 20);
            this.txtLowLimit.TabIndex = 1;
            // 
            // txtLowLowLimit
            // 
            this.txtLowLowLimit.Location = new System.Drawing.Point(148, 19);
            this.txtLowLowLimit.Name = "txtLowLowLimit";
            this.txtLowLowLimit.Size = new System.Drawing.Size(167, 20);
            this.txtLowLowLimit.TabIndex = 0;
            // 
            // chkLowLowLimitSMS
            // 
            this.chkLowLowLimitSMS.AutoSize = true;
            this.chkLowLowLimitSMS.Location = new System.Drawing.Point(181, 141);
            this.chkLowLowLimitSMS.Name = "chkLowLowLimitSMS";
            this.chkLowLowLimitSMS.Size = new System.Drawing.Size(15, 14);
            this.chkLowLowLimitSMS.TabIndex = 4;
            this.chkLowLowLimitSMS.UseVisualStyleBackColor = true;
            // 
            // chkLowLimitSMS
            // 
            this.chkLowLimitSMS.AutoSize = true;
            this.chkLowLimitSMS.Location = new System.Drawing.Point(223, 141);
            this.chkLowLimitSMS.Name = "chkLowLimitSMS";
            this.chkLowLimitSMS.Size = new System.Drawing.Size(15, 14);
            this.chkLowLimitSMS.TabIndex = 5;
            this.chkLowLimitSMS.UseVisualStyleBackColor = true;
            // 
            // chkHighLimitSMS
            // 
            this.chkHighLimitSMS.AutoSize = true;
            this.chkHighLimitSMS.Location = new System.Drawing.Point(262, 141);
            this.chkHighLimitSMS.Name = "chkHighLimitSMS";
            this.chkHighLimitSMS.Size = new System.Drawing.Size(15, 14);
            this.chkHighLimitSMS.TabIndex = 6;
            this.chkHighLimitSMS.UseVisualStyleBackColor = true;
            // 
            // chkHighHighLimitSMS
            // 
            this.chkHighHighLimitSMS.AutoSize = true;
            this.chkHighHighLimitSMS.Location = new System.Drawing.Point(307, 140);
            this.chkHighHighLimitSMS.Name = "chkHighHighLimitSMS";
            this.chkHighHighLimitSMS.Size = new System.Drawing.Size(15, 14);
            this.chkHighHighLimitSMS.TabIndex = 7;
            this.chkHighHighLimitSMS.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 198);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "E-mail subscribers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveEmail);
            this.groupBox2.Controls.Add(this.btnAddEmail);
            this.groupBox2.Controls.Add(this.lblEmailAdress);
            this.groupBox2.Controls.Add(this.txtEmailAdress);
            this.groupBox2.Controls.Add(this.lstEmail);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subscribers";
            // 
            // btnRemoveEmail
            // 
            this.btnRemoveEmail.Location = new System.Drawing.Point(205, 156);
            this.btnRemoveEmail.Name = "btnRemoveEmail";
            this.btnRemoveEmail.Size = new System.Drawing.Size(110, 23);
            this.btnRemoveEmail.TabIndex = 4;
            this.btnRemoveEmail.Text = "Remove";
            this.btnRemoveEmail.UseVisualStyleBackColor = true;
            this.btnRemoveEmail.Click += new System.EventHandler(this.btnRemoveEmail_Click);
            // 
            // btnAddEmail
            // 
            this.btnAddEmail.Location = new System.Drawing.Point(93, 156);
            this.btnAddEmail.Name = "btnAddEmail";
            this.btnAddEmail.Size = new System.Drawing.Size(110, 23);
            this.btnAddEmail.TabIndex = 3;
            this.btnAddEmail.Text = "Add";
            this.btnAddEmail.UseVisualStyleBackColor = true;
            this.btnAddEmail.Click += new System.EventHandler(this.btnAddEmail_Click);
            // 
            // lblEmailAdress
            // 
            this.lblEmailAdress.AutoSize = true;
            this.lblEmailAdress.Location = new System.Drawing.Point(6, 137);
            this.lblEmailAdress.Name = "lblEmailAdress";
            this.lblEmailAdress.Size = new System.Drawing.Size(72, 13);
            this.lblEmailAdress.TabIndex = 2;
            this.lblEmailAdress.Text = "E-mail adress:";
            // 
            // txtEmailAdress
            // 
            this.txtEmailAdress.Location = new System.Drawing.Point(93, 134);
            this.txtEmailAdress.Name = "txtEmailAdress";
            this.txtEmailAdress.Size = new System.Drawing.Size(222, 20);
            this.txtEmailAdress.TabIndex = 1;
            // 
            // lstEmail
            // 
            this.lstEmail.FormattingEnabled = true;
            this.lstEmail.Location = new System.Drawing.Point(7, 20);
            this.lstEmail.Name = "lstEmail";
            this.lstEmail.Size = new System.Drawing.Size(308, 108);
            this.lstEmail.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpPhoneSubscribers);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(334, 198);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Phone subscribers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpPhoneSubscribers
            // 
            this.grpPhoneSubscribers.Controls.Add(this.btnRemovePhoneNumber);
            this.grpPhoneSubscribers.Controls.Add(this.btnAddPhoneNumber);
            this.grpPhoneSubscribers.Controls.Add(this.lblPhoneNumber);
            this.grpPhoneSubscribers.Controls.Add(this.txtPhoneNumber);
            this.grpPhoneSubscribers.Controls.Add(this.lstPhoneNumber);
            this.grpPhoneSubscribers.Location = new System.Drawing.Point(7, 7);
            this.grpPhoneSubscribers.Name = "grpPhoneSubscribers";
            this.grpPhoneSubscribers.Size = new System.Drawing.Size(321, 185);
            this.grpPhoneSubscribers.TabIndex = 1;
            this.grpPhoneSubscribers.TabStop = false;
            this.grpPhoneSubscribers.Text = "Subscribers";
            // 
            // btnRemovePhoneNumber
            // 
            this.btnRemovePhoneNumber.Location = new System.Drawing.Point(205, 156);
            this.btnRemovePhoneNumber.Name = "btnRemovePhoneNumber";
            this.btnRemovePhoneNumber.Size = new System.Drawing.Size(110, 23);
            this.btnRemovePhoneNumber.TabIndex = 4;
            this.btnRemovePhoneNumber.Text = "Remove";
            this.btnRemovePhoneNumber.UseVisualStyleBackColor = true;
            this.btnRemovePhoneNumber.Click += new System.EventHandler(this.btnRemovePhoneNumber_Click);
            // 
            // btnAddPhoneNumber
            // 
            this.btnAddPhoneNumber.Location = new System.Drawing.Point(93, 156);
            this.btnAddPhoneNumber.Name = "btnAddPhoneNumber";
            this.btnAddPhoneNumber.Size = new System.Drawing.Size(110, 23);
            this.btnAddPhoneNumber.TabIndex = 3;
            this.btnAddPhoneNumber.Text = "Add";
            this.btnAddPhoneNumber.UseVisualStyleBackColor = true;
            this.btnAddPhoneNumber.Click += new System.EventHandler(this.btnAddPhoneNumber_Click);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(6, 137);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(93, 134);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 20);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // lstPhoneNumber
            // 
            this.lstPhoneNumber.FormattingEnabled = true;
            this.lstPhoneNumber.Location = new System.Drawing.Point(7, 20);
            this.lstPhoneNumber.Name = "lstPhoneNumber";
            this.lstPhoneNumber.Size = new System.Drawing.Size(308, 108);
            this.lstPhoneNumber.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.grpGSMSettings);
            this.tabPage4.Controls.Add(this.grpEmailAccount);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(334, 198);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Connection";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grpGSMSettings
            // 
            this.grpGSMSettings.Controls.Add(this.cboComPort);
            this.grpGSMSettings.Controls.Add(this.lblComPort);
            this.grpGSMSettings.Location = new System.Drawing.Point(4, 114);
            this.grpGSMSettings.Name = "grpGSMSettings";
            this.grpGSMSettings.Size = new System.Drawing.Size(327, 81);
            this.grpGSMSettings.TabIndex = 1;
            this.grpGSMSettings.TabStop = false;
            this.grpGSMSettings.Text = "GSM Settings";
            // 
            // cboComPort
            // 
            this.cboComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.cboComPort.Location = new System.Drawing.Point(74, 22);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 21);
            this.cboComPort.TabIndex = 8;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblComPort.Location = new System.Drawing.Point(13, 25);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(55, 13);
            this.lblComPort.TabIndex = 7;
            this.lblComPort.Text = "COM port:";
            // 
            // grpEmailAccount
            // 
            this.grpEmailAccount.Controls.Add(this.lblHost);
            this.grpEmailAccount.Controls.Add(this.txtHost);
            this.grpEmailAccount.Controls.Add(this.cBSsl);
            this.grpEmailAccount.Controls.Add(this.txtPort);
            this.grpEmailAccount.Controls.Add(this.txtUserName);
            this.grpEmailAccount.Controls.Add(this.txtPassword);
            this.grpEmailAccount.Controls.Add(this.txtSenderEmail);
            this.grpEmailAccount.Controls.Add(this.lblEnableSsl);
            this.grpEmailAccount.Controls.Add(this.lblPort);
            this.grpEmailAccount.Controls.Add(this.lblPassword);
            this.grpEmailAccount.Controls.Add(this.lblSenderEmail);
            this.grpEmailAccount.Controls.Add(this.lblUserName);
            this.grpEmailAccount.Location = new System.Drawing.Point(4, 4);
            this.grpEmailAccount.Name = "grpEmailAccount";
            this.grpEmailAccount.Size = new System.Drawing.Size(327, 104);
            this.grpEmailAccount.TabIndex = 0;
            this.grpEmailAccount.TabStop = false;
            this.grpEmailAccount.Text = "E-mail account";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblHost.Location = new System.Drawing.Point(187, 26);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(32, 13);
            this.lblHost.TabIndex = 2;
            this.lblHost.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(221, 23);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 5;
            // 
            // cBSsl
            // 
            this.cBSsl.AutoSize = true;
            this.cBSsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBSsl.Location = new System.Drawing.Point(258, 81);
            this.cBSsl.Name = "cBSsl";
            this.cBSsl.Size = new System.Drawing.Size(15, 14);
            this.cBSsl.TabIndex = 6;
            this.cBSsl.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(221, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(24, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(81, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(81, 75);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(81, 49);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(100, 20);
            this.txtSenderEmail.TabIndex = 3;
            // 
            // lblEnableSsl
            // 
            this.lblEnableSsl.AutoSize = true;
            this.lblEnableSsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblEnableSsl.Location = new System.Drawing.Point(187, 82);
            this.lblEnableSsl.Name = "lblEnableSsl";
            this.lblEnableSsl.Size = new System.Drawing.Size(66, 13);
            this.lblEnableSsl.TabIndex = 5;
            this.lblEnableSsl.Text = "Enable SSL:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPort.Location = new System.Drawing.Point(187, 52);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPassword.Location = new System.Drawing.Point(6, 78);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblSenderEmail
            // 
            this.lblSenderEmail.AutoSize = true;
            this.lblSenderEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSenderEmail.Location = new System.Drawing.Point(6, 52);
            this.lblSenderEmail.Name = "lblSenderEmail";
            this.lblSenderEmail.Size = new System.Drawing.Size(69, 13);
            this.lblSenderEmail.TabIndex = 1;
            this.lblSenderEmail.Text = "SenderEmail:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblUserName.Location = new System.Drawing.Point(6, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 242);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(197, 242);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(278, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 274);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpEmailSubscribers);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.grpEmailSubscribers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpAlarmLimits.ResumeLayout(false);
            this.grpAlarmLimits.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grpPhoneSubscribers.ResumeLayout(false);
            this.grpPhoneSubscribers.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.grpGSMSettings.ResumeLayout(false);
            this.grpGSMSettings.PerformLayout();
            this.grpEmailAccount.ResumeLayout(false);
            this.grpEmailAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl grpEmailSubscribers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox grpAlarmLimits;
        private System.Windows.Forms.Label lblHighHighLimit;
        private System.Windows.Forms.Label lblHighLimit;
        private System.Windows.Forms.Label lblLowLimit;
        private System.Windows.Forms.Label lblLowLowLimit;
        private System.Windows.Forms.CheckBox chkHighHighLimitSMS;
        private System.Windows.Forms.CheckBox chkHighLimitSMS;
        private System.Windows.Forms.CheckBox chkLowLimitSMS;
        private System.Windows.Forms.CheckBox chkLowLowLimitSMS;
        private System.Windows.Forms.TextBox txtHighHighLimit;
        private System.Windows.Forms.TextBox txtHighLimit;
        private System.Windows.Forms.TextBox txtLowLimit;
        private System.Windows.Forms.TextBox txtLowLowLimit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveEmail;
        private System.Windows.Forms.Button btnAddEmail;
        private System.Windows.Forms.Label lblEmailAdress;
        private System.Windows.Forms.TextBox txtEmailAdress;
        private System.Windows.Forms.ListBox lstEmail;
        private System.Windows.Forms.GroupBox grpPhoneSubscribers;
        private System.Windows.Forms.Button btnRemovePhoneNumber;
        private System.Windows.Forms.Button btnAddPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ListBox lstPhoneNumber;
        private System.Windows.Forms.GroupBox grpGSMSettings;
        private System.Windows.Forms.GroupBox grpEmailAccount;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.CheckBox cBSsl;
        private System.Windows.Forms.Label lblEnableSsl;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblSenderEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLowLowLimitEmail;
        private System.Windows.Forms.CheckBox chkLowLimitEmail;
        private System.Windows.Forms.CheckBox chkHighHighLimitEmail;
        private System.Windows.Forms.CheckBox chkHighLimitEmail;
    }
}