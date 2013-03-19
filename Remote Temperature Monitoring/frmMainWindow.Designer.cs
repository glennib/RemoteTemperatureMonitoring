namespace Remote_Temperature_Monitoring
{
    partial class frmMainWindow
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chtTemperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCurrentTemp = new System.Windows.Forms.TextBox();
            this.txtAlarmLimH = new System.Windows.Forms.TextBox();
            this.txtAlarmLimL = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblMakers = new System.Windows.Forms.Label();
            this.lblCurrentTemp = new System.Windows.Forms.Label();
            this.lblAlarmLimitH = new System.Windows.Forms.Label();
            this.lblAlarmLimitL = new System.Windows.Forms.Label();
            this.tmrTempTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoInterval = new System.Windows.Forms.RadioButton();
            this.rdoRealTime = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnLog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUsbTemperatureTransmitter = new System.Windows.Forms.Label();
            this.lblChargerConnected = new System.Windows.Forms.Label();
            this.lblUsbInternetModem = new System.Windows.Forms.Label();
            this.lblUsbGsmModem = new System.Windows.Forms.Label();
            this.lblInternetConnection = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtTemperatureChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chtTemperatureChart);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 437);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature graph";
            // 
            // chtTemperatureChart
            // 
            chartArea1.AxisX.Title = "Hour";
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Temperature";
            chartArea1.Name = "ChartArea1";
            this.chtTemperatureChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTemperatureChart.Legends.Add(legend1);
            this.chtTemperatureChart.Location = new System.Drawing.Point(6, 19);
            this.chtTemperatureChart.Name = "chtTemperatureChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chtTemperatureChart.Series.Add(series1);
            this.chtTemperatureChart.Size = new System.Drawing.Size(539, 412);
            this.chtTemperatureChart.TabIndex = 0;
            this.chtTemperatureChart.Text = "Temperature Chart";
            // 
            // txtCurrentTemp
            // 
            this.txtCurrentTemp.Location = new System.Drawing.Point(737, 12);
            this.txtCurrentTemp.Name = "txtCurrentTemp";
            this.txtCurrentTemp.Size = new System.Drawing.Size(29, 20);
            this.txtCurrentTemp.TabIndex = 2;
            // 
            // txtAlarmLimH
            // 
            this.txtAlarmLimH.Location = new System.Drawing.Point(737, 38);
            this.txtAlarmLimH.Name = "txtAlarmLimH";
            this.txtAlarmLimH.Size = new System.Drawing.Size(29, 20);
            this.txtAlarmLimH.TabIndex = 3;
            // 
            // txtAlarmLimL
            // 
            this.txtAlarmLimL.Location = new System.Drawing.Point(737, 64);
            this.txtAlarmLimL.Name = "txtAlarmLimL";
            this.txtAlarmLimL.Size = new System.Drawing.Size(29, 20);
            this.txtAlarmLimL.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(678, 427);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(88, 23);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Remote_Temperature_Monitoring.Properties.Resources.logoconsolecolor;
            this.pbLogo.Location = new System.Drawing.Point(570, 394);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 50);
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lblMakers
            // 
            this.lblMakers.AutoSize = true;
            this.lblMakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.4F);
            this.lblMakers.Location = new System.Drawing.Point(568, 441);
            this.lblMakers.Name = "lblMakers";
            this.lblMakers.Size = new System.Drawing.Size(104, 12);
            this.lblMakers.TabIndex = 11;
            this.lblMakers.Text = "2013 Porsgrunn\'s Finest";
            // 
            // lblCurrentTemp
            // 
            this.lblCurrentTemp.AutoSize = true;
            this.lblCurrentTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTemp.Location = new System.Drawing.Point(570, 16);
            this.lblCurrentTemp.Name = "lblCurrentTemp";
            this.lblCurrentTemp.Size = new System.Drawing.Size(79, 12);
            this.lblCurrentTemp.TabIndex = 12;
            this.lblCurrentTemp.Text = "CURRENT TEMP";
            // 
            // lblAlarmLimitH
            // 
            this.lblAlarmLimitH.AutoSize = true;
            this.lblAlarmLimitH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmLimitH.Location = new System.Drawing.Point(570, 42);
            this.lblAlarmLimitH.Name = "lblAlarmLimitH";
            this.lblAlarmLimitH.Size = new System.Drawing.Size(74, 12);
            this.lblAlarmLimitH.TabIndex = 13;
            this.lblAlarmLimitH.Text = "ALARMLIMIT H";
            // 
            // lblAlarmLimitL
            // 
            this.lblAlarmLimitL.AutoSize = true;
            this.lblAlarmLimitL.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmLimitL.Location = new System.Drawing.Point(570, 68);
            this.lblAlarmLimitL.Name = "lblAlarmLimitL";
            this.lblAlarmLimitL.Size = new System.Drawing.Size(72, 12);
            this.lblAlarmLimitL.TabIndex = 14;
            this.lblAlarmLimitL.Text = "ALARMLIMIT L";
            // 
            // tmrTempTimer
            // 
            this.tmrTempTimer.Interval = 1000;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdoInterval);
            this.groupBox2.Controls.Add(this.rdoRealTime);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtHours);
            this.groupBox2.Controls.Add(this.txtMinutes);
            this.groupBox2.Controls.Add(this.txtDays);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Location = new System.Drawing.Point(570, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 164);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Graph";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "From:";
            // 
            // rdoInterval
            // 
            this.rdoInterval.AutoSize = true;
            this.rdoInterval.Location = new System.Drawing.Point(6, 82);
            this.rdoInterval.Name = "rdoInterval";
            this.rdoInterval.Size = new System.Drawing.Size(60, 17);
            this.rdoInterval.TabIndex = 9;
            this.rdoInterval.Text = "Interval";
            this.rdoInterval.UseVisualStyleBackColor = true;
            this.rdoInterval.CheckedChanged += new System.EventHandler(this.rdoInterval_CheckedChanged);
            // 
            // rdoRealTime
            // 
            this.rdoRealTime.AutoSize = true;
            this.rdoRealTime.Checked = true;
            this.rdoRealTime.Location = new System.Drawing.Point(7, 20);
            this.rdoRealTime.Name = "rdoRealTime";
            this.rdoRealTime.Size = new System.Drawing.Size(69, 17);
            this.rdoRealTime.TabIndex = 8;
            this.rdoRealTime.TabStop = true;
            this.rdoRealTime.Text = "Real time";
            this.rdoRealTime.UseVisualStyleBackColor = true;
            this.rdoRealTime.CheckedChanged += new System.EventHandler(this.rdoRealTime_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Days";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(53, 56);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(41, 20);
            this.txtHours.TabIndex = 4;
            this.txtHours.Text = "0";
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(100, 56);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(41, 20);
            this.txtMinutes.TabIndex = 3;
            this.txtMinutes.Text = "0";
            this.txtMinutes.TextChanged += new System.EventHandler(this.txtMinutes_TextChanged);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(6, 56);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(41, 20);
            this.txtDays.TabIndex = 2;
            this.txtDays.Text = "1";
            this.txtDays.TextChanged += new System.EventHandler(this.txtDays_TextChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd.MM.yy HH:mm";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(53, 131);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 20);
            this.dtpTo.TabIndex = 1;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dtpTo_ValueChanged);
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd.MM.yy HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(53, 105);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2013, 3, 19, 18, 3, 7, 0);
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dtpFrom_ValueChanged);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(679, 394);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(88, 23);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUsbTemperatureTransmitter);
            this.groupBox3.Controls.Add(this.lblChargerConnected);
            this.groupBox3.Controls.Add(this.lblUsbInternetModem);
            this.groupBox3.Controls.Add(this.lblUsbGsmModem);
            this.groupBox3.Controls.Add(this.lblInternetConnection);
            this.groupBox3.Location = new System.Drawing.Point(572, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 135);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System status:";
            // 
            // lblUsbTemperatureTransmitter
            // 
            this.lblUsbTemperatureTransmitter.AutoSize = true;
            this.lblUsbTemperatureTransmitter.ForeColor = System.Drawing.Color.Black;
            this.lblUsbTemperatureTransmitter.Location = new System.Drawing.Point(8, 86);
            this.lblUsbTemperatureTransmitter.Name = "lblUsbTemperatureTransmitter";
            this.lblUsbTemperatureTransmitter.Size = new System.Drawing.Size(143, 13);
            this.lblUsbTemperatureTransmitter.TabIndex = 4;
            this.lblUsbTemperatureTransmitter.Text = "USB Temperature transmitter";
            // 
            // lblChargerConnected
            // 
            this.lblChargerConnected.AutoSize = true;
            this.lblChargerConnected.ForeColor = System.Drawing.Color.Black;
            this.lblChargerConnected.Location = new System.Drawing.Point(8, 109);
            this.lblChargerConnected.Name = "lblChargerConnected";
            this.lblChargerConnected.Size = new System.Drawing.Size(98, 13);
            this.lblChargerConnected.TabIndex = 3;
            this.lblChargerConnected.Text = "Charger connected";
            // 
            // lblUsbInternetModem
            // 
            this.lblUsbInternetModem.AutoSize = true;
            this.lblUsbInternetModem.ForeColor = System.Drawing.Color.Black;
            this.lblUsbInternetModem.Location = new System.Drawing.Point(8, 64);
            this.lblUsbInternetModem.Name = "lblUsbInternetModem";
            this.lblUsbInternetModem.Size = new System.Drawing.Size(106, 13);
            this.lblUsbInternetModem.TabIndex = 2;
            this.lblUsbInternetModem.Text = "USB Internet Modem";
            // 
            // lblUsbGsmModem
            // 
            this.lblUsbGsmModem.AutoSize = true;
            this.lblUsbGsmModem.ForeColor = System.Drawing.Color.Black;
            this.lblUsbGsmModem.Location = new System.Drawing.Point(8, 42);
            this.lblUsbGsmModem.Name = "lblUsbGsmModem";
            this.lblUsbGsmModem.Size = new System.Drawing.Size(94, 13);
            this.lblUsbGsmModem.TabIndex = 1;
            this.lblUsbGsmModem.Text = "USB GSM Modem";
            // 
            // lblInternetConnection
            // 
            this.lblInternetConnection.AutoSize = true;
            this.lblInternetConnection.ForeColor = System.Drawing.Color.Black;
            this.lblInternetConnection.Location = new System.Drawing.Point(7, 20);
            this.lblInternetConnection.Name = "lblInternetConnection";
            this.lblInternetConnection.Size = new System.Drawing.Size(99, 13);
            this.lblInternetConnection.TabIndex = 0;
            this.lblInternetConnection.Text = "Internet connection";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblAlarmLimitL);
            this.Controls.Add(this.lblAlarmLimitH);
            this.Controls.Add(this.lblCurrentTemp);
            this.Controls.Add(this.lblMakers);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.txtAlarmLimL);
            this.Controls.Add(this.txtAlarmLimH);
            this.Controls.Add(this.txtCurrentTemp);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMainWindow";
            this.Text = "Remote Temperature Monitoring";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtTemperatureChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTemperatureChart;
        private System.Windows.Forms.TextBox txtCurrentTemp;
        private System.Windows.Forms.TextBox txtAlarmLimH;
        private System.Windows.Forms.TextBox txtAlarmLimL;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblMakers;
        private System.Windows.Forms.Label lblCurrentTemp;
        private System.Windows.Forms.Label lblAlarmLimitH;
        private System.Windows.Forms.Label lblAlarmLimitL;
        private System.Windows.Forms.Timer tmrTempTimer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoInterval;
        private System.Windows.Forms.RadioButton rdoRealTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUsbTemperatureTransmitter;
        private System.Windows.Forms.Label lblChargerConnected;
        private System.Windows.Forms.Label lblUsbInternetModem;
        private System.Windows.Forms.Label lblUsbGsmModem;
        private System.Windows.Forms.Label lblInternetConnection;
    }
}

