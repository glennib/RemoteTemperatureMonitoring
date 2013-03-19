using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RTMClassLibrary;
using System.Windows.Forms.DataVisualization.Charting;

namespace Remote_Temperature_Monitoring
{
    public partial class frmMainWindow : Form
    {
        // ---------- Instance variables ---------- \\
        frmSettings Settings = new frmSettings(); // Makes a object of the Settings-window.
        frmLog Log = new frmLog(); // Makes a object of the Log-window.
        

        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\
        public frmMainWindow()
        {
            InitializeComponent();            
            
        }        

        // ---------- Public methods     ---------- \\
        public void ApplyNewSettings() // Method should be run when settings are changed in frmSettings and at form load.
        {
            UpdateGraph();
        }

        public void UpdateSystemStatusLabels(bool Internet, bool USBGSM, bool USBInternet,
            bool USBTemp, bool Charger) // Method for ChangeSystemStatus class to use for changing the labels.
        {
            SetLabel(ref lblInternetConnection, Internet);
            SetLabel(ref lblUsbGsmModem, USBGSM);
            SetLabel(ref lblUsbInternetModem, USBInternet);
            SetLabel(ref lblUsbTemperatureTransmitter, USBTemp);
            SetLabel(ref lblChargerConnected, Charger);
        }

        // ---------- Properties         ---------- \\
        private void frmMainWindow_Load(object sender, EventArgs e) // When form is loaded in.
        {
            ApplyNewSettings(); // Applies needed settings.
            dtpTo.Value = DateTime.Now; // Sets To-value to the current time.
            dtpFrom.Value = dtpTo.Value - new TimeSpan(1, 0, 0, 0); // Sets from-value to one day earlier.
        }

        // ---------- Private methods    ---------- \\
        private void SetLabel(ref Label L, bool Status) // Takes a label, and sets its color accordingly.
        {
            if (Status)
            {
                L.ForeColor = Color.Green;
            }
            else
            {
                L.ForeColor = Color.Red;
            }
        }

        private void btnLog_Click(object sender, EventArgs e) // When Log-button is clicked.
        {
            Log.ShowDialog(); // Opens the log window
        } 

        private void btnSettings_Click(object sender, EventArgs e) // When Settings-button is clicked.
        {
            Settings.ShowDialog(); // Opens the settings form.
        }        

        // ---------- Graph code ------------------ \\
        private void UpdateGraph()                                                               // Method that is to be called every time the graph should be updated.
        {
            DateTime from, to;                                                                   // Declares new DateTime objects
            int days, hours, minutes;                                                            // Declares new itegers for real-time selection.
            if (rdoRealTime.Checked)                                                             // If RealTime is checked.
            {
                if (ErrorHandling.IsNumeric(txtDays.Text))                                       // If the text in txtDays is numeric.
                {
                    days = Convert.ToInt32(txtDays.Text);                                        // Integer days become the numeric value.
                    if (days < 0) days = 0;                                                      // If days is negative, set days to 0
                }
                else
                {
                    days = 0;                                                                    // If the text in txtdays is not numeric, set days to 0.
                }

                if (ErrorHandling.IsNumeric(txtHours.Text))                                      // ...
                {
                    hours = Convert.ToInt32(txtHours.Text);
                    if (hours < 0) hours = 0;
                }
                else
                {
                    hours = 0;
                }

                if (ErrorHandling.IsNumeric(txtMinutes.Text))
                {
                    minutes = Convert.ToInt32(txtMinutes.Text);
                    if (minutes < 0) minutes = 0;
                }
                else
                {
                    minutes = 0;
                }

                if ((days == 0) && (hours == 0) && (minutes == 0))                               // If all the time values are 0, set days to 1.
                {
                    days = 1;
                }

                to = DateTime.Now;                                                               // DateTime object to becomes the current time.
                from = to - new TimeSpan(days, hours, minutes, 0);                               // DateTime object from becomes the current time minus how many days/hours/minutes selected

                
            }
            else                                                                                 // if Interval is  selected.
            {
                to = dtpTo.Value;                                                                // To becomes the to-value.
                from = dtpFrom.Value;                                                            // From becomes the from-value.

            }

            graphSetProperties(from, to);                                                        // Sets the graph with the time settings.
        }

        private void graphSetProperties(DateTime from, DateTime to)                              // Sets properties of the graph. Must be updated when a new item is added.
        {
            const double MIN_TEMP                                     = -5.0;                    // Constant for min temp to show on Y-axis.
            const double MAX_TEMP                                     = 40.0;                    // Constant for max temp to show on Y-axis.
            double oaFrom                                             = from.ToOADate();         // Declares a variable with a numeric format of the From-date.
            double oaTo                                               = to.ToOADate();           // Does the same with the To-date.
            chtTemperatureChart.Series.Clear();                                                  // Clears existing series.
            chtTemperatureChart.DataBindTable(TrendCollection(from, to), "TimeStamp");           // Adds series.
            chtTemperatureChart.Series[0].ChartType                   = SeriesChartType.Line;    // Sets the chart to a line-diagram.
            chtTemperatureChart.Series[0].XValueType                  = ChartValueType.DateTime; // Specifies the X-value to be a DateTime-value.
            chtTemperatureChart.Series[0].BorderWidth                 = 2;                       // Sets the width of the line.
            chtTemperatureChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd.MM.yy HH:mm";        // Formats the x-axis label.
            chtTemperatureChart.ChartAreas[0].AxisX.LabelStyle.Angle  = 90;                      // Sets the x-axis-label-angle.
            chtTemperatureChart.ChartAreas[0].AxisY.LabelStyle.Format = "0.0 °C";                // Formats the y-axis label.
            chtTemperatureChart.ChartAreas[0].AxisY.Minimum           = MIN_TEMP;                // Sets the min value of the Y-axis.
            chtTemperatureChart.ChartAreas[0].AxisY.Maximum           = MAX_TEMP;                // Sets the max value of the Y-axis.
            chtTemperatureChart.ChartAreas[0].AxisX.Minimum           = oaFrom;                  // Sets the min value of the X-axis.
            chtTemperatureChart.ChartAreas[0].AxisX.Maximum           = oaTo;                    // Sets the max value of the X-axis.
            chtTemperatureChart.ChartAreas[0].AxisX.Interval          = (oaTo - oaFrom) / 10;    // Sets the length of an interval between grid marks.
        }

        private dynamic TrendCollection(DateTime From, DateTime To)                              // Returns a collection of the trend points to view.
        {
            var trendCollection =
                from E in Program.myDB.TemperatureMeasurements
                where E.TimeStamp >= From && E.TimeStamp <= To
                select new { E.TimeStamp, E.Temperature };
            return trendCollection;
        }

        private void rdoRealTime_CheckedChanged(object sender, EventArgs e)                      // When the rdoRealTime checkbox is changed.
        {
            UpdateGraph();
        }

        private void rdoInterval_CheckedChanged(object sender, EventArgs e)                      // When the rdoInterval checkbox is changed.
        {
            UpdateGraph();
        }

        private void txtDays_TextChanged(object sender, EventArgs e)                             // When any of the textboxes change.
        {
            UpdateGraph();
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void txtMinutes_TextChanged(object sender, EventArgs e)
        {
            UpdateGraph();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)                            // When the date is changed.
        {
            UpdateGraph(); // Updates the graph.

            if (dtpFrom.Value > dtpTo.Value) // If from-value is later than to-value
            {
                dtpTo.Value = dtpFrom.Value + new TimeSpan(1, 0, 0); // Set to-value to one hour later than from-value.
            }
        }
        
        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            UpdateGraph();

            if (dtpTo.Value < dtpFrom.Value) // If to-value is earlier than from-value
            {
                dtpFrom.Value = dtpTo.Value - new TimeSpan(1, 0, 0); // Set from-value to one hour earlier than to-value.
            }
        }

    }
}
