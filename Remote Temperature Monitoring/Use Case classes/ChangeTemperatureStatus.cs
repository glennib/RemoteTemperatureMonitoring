using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Remote_Temperature_Monitoring
{
    class ChangeTemperatureStatus
    {
        // ---------- Instance variables ---------- \\
        // °
        
        private const string TEMPERATURE_STATUS_SUBJECT = "RTM: Temperature status changed."; // A string that is included in every mail sent.
        private const ulong STATUS_CHANGE_DELAY = 120; // Seconds to wait before changing status.
        private const int DISCONNECTSTATUS_CHANGE_DELAY = 5; // Seconds to wait before Disconnected-status is initialized.

        private Status myTemperatureStatus; // Status that contains the current temperature status.
        private Thread myReadTemperatureThread; // Thread that runs the method ReadTemperature.
        private Thread myApplySettingsOnStart; // Double that gets limit-values on program start.
        private double myLowLowLimit; // Double that contains myLowLowLimit-value.
        private double myLowLimit; // Double that contains myLowLimit-value.
        private double myHighLimit; // Double that contains myHighLimit-value.
        private double myHighHighLimit; // Double that contains myLowLimit-value.
        

        private StopWatch myLowLowTimer = new StopWatch();
        private StopWatch myLowTimer = new StopWatch();
        private StopWatch myNormalTimer = new StopWatch();
        private StopWatch myHighTimer = new StopWatch();
        private StopWatch myHighHighTimer = new StopWatch();
        private StopWatch myDisconnectedTimer = new StopWatch();
      

        // ---------- Statics and events ---------- \\
        public enum Status // Datatype Status can contain one of the statuses below.
        {               
            D, // Disconnected
            LL, // Low Low
            L, // Low
            N, // Normal
            H, // High
            HH // High High
        };

        // ---------- Constructors       ---------- \\
        public ChangeTemperatureStatus()
        {
            ApplySettings(); // Applies the initial settings.
            myReadTemperatureThread = new Thread(ContinuousTemperatureReader); // Creates a new thread which runs method ContinuousTemperatureReader.
            myReadTemperatureThread.Start(); // Starts thread.
        }

               
        // ---------- Public methods     ---------- \\
        public void ApplySettings()
        {
            myLowLowLimit = Properties.Settings.Default.TempStatLowLowLimit; // Double that contains myLowLowLimit-value.
            myLowLimit = Properties.Settings.Default.TempStatLowLimit; // Double that contains myLowLimit-value.
            myHighLimit = Properties.Settings.Default.TempStatHighLimit; // Double that contains myHighLimit-value.
            myHighHighLimit = Properties.Settings.Default.TempStatHighHighLimit; // Double that contains myHighHighLimit-value.
        }


        // ---------- Properties         ---------- \\
        

        // ---------- Private methods    ---------- \\
        private void ContinuousTemperatureReader() //A method that reads temperature.
        {          
            while (true) //Loop that constantly reads temperature from MeasureTemperature.
            {
                Thread.Sleep(Program.Probe_Update_Delay); //Delay on how frequent the temperature is read.
                double Temperature = Program.myMeasureTemperature.Temperature; // Assigning the variable "Temperature" to the current temperature.
                TemperatureStatus(Temperature); // Sends current temperature to be tested in the method that changes temperaturesatus.
            }
        }
        

        private void TemperatureStatus(double Temperature) // A method that contains an IF-structure that changes temperature status.
        {
            if (!Program.myMeasureTemperature.IsConnected) //If-test to see if TemperatureCouple is connected.
            {
                myDisconnectedTimer.Start(); // Timer that sets new temperature status to LL, starts.
                myLowTimer.StopReset(); // All other timers are stopped AND reset.
                myHighTimer.StopReset();
                myHighHighTimer.StopReset();
                myLowLowTimer.StopReset();
                myNormalTimer.StopReset();

                if ((myDisconnectedTimer.SecondsElapsed > DISCONNECTSTATUS_CHANGE_DELAY) & (myTemperatureStatus!=Status.D))
                {
                    myTemperatureStatus = Status.D; // Sets status to Disconnected.

                    Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus);// Send status parameter to TemperatureStatusLogger.

                    Program.myEmail.SendMessage("Temperaturecouple disconnected. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT); //Sends e-mail when TemperatureCouple is disconnected.
                    Program.mySMS.SendSMS("RTM: Temperaturecouple disconnected. Time: " + DateTime.Now.ToString()); // Method to send SMS when Temperaturecouple is disconnected.
                }
            }
            else
            {
                if (Temperature < myLowLowLimit) //IF-structure that checks if current temperature is below myLowLowLimit-value.
                {
                    myLowLowTimer.Start(); // Timer that sets new temperature status to LL, starts.
                    myLowTimer.StopReset(); // All other timers are stopped AND reset.
                    myHighTimer.StopReset();
                    myHighHighTimer.StopReset();
                    myDisconnectedTimer.StopReset();
                    myNormalTimer.StopReset();

                    if ((myLowLowTimer.SecondsElapsed > STATUS_CHANGE_DELAY) && (myTemperatureStatus != Status.LL)) //Check whether temperature has been inside new temperaturelimit before switching status.
                    {
                        myTemperatureStatus = Status.LL; // Sets status to LowLow.

                        Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus, myLowLowLimit); // Send status parameter to TemperatureStatusLogger.

                        Program.myEmail.SendMessage("Temperature is currently below LowLow-Limit: " + Convert.ToString(myLowLowLimit) + "°C. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT);// Method to send e-mail when temperature is below LowLow-Limit.
                        Program.mySMS.SendSMS("RTM: Temperature is currently below LowLow-Limit: " + Convert.ToString(myLowLowLimit) + "°C. Time: " + DateTime.Now.ToString()); // Method to send SMS when temperature is below LowLow-Limit.
                    }
                }
                if (Temperature < myLowLimit) //IF-structure that checks if current temperature is below myLowLimit-value.
                {
                    myLowTimer.Start(); // Timer that sets new temperature status to L, starts.
                    myLowLowTimer.StopReset();// All other timers are stopped.
                    myHighTimer.StopReset();
                    myHighHighTimer.StopReset();
                    myDisconnectedTimer.StopReset();
                    myNormalTimer.StopReset();

                    if ((myLowTimer.SecondsElapsed > STATUS_CHANGE_DELAY) & (myTemperatureStatus != Status.L )) // IF-structure that tests if temperature is within Low-Limit AND status is not Low on beforehand, beforechanging status.
                    {
                        myTemperatureStatus = Status.L; // Sets status to Low.

                        Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus, myLowLimit );// Send status parameter to TemperatureStatusLogger.

                        Program.myEmail.SendMessage("Temperature is currently below Low-Limit: " + Convert.ToString(myLowLimit) + "°C. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT);// Method to send e-mail when temperature is below Low-Limit.
                        Program.mySMS.SendSMS("RTM: Temperature is currently below Low-Limit: " + Convert.ToString(myLowLimit) + "°C. Time: " + DateTime.Now.ToString()); // Method to send SMS when temperature is below Low-Limit.
                    }
                   }
                if (Temperature > myHighLimit) //IF-structure that checks if current temperature is above myHighLimit-value.
                {
                    myHighTimer.Start(); // Timer that sets new temperature status to H, starts.
                    myLowTimer.StopReset();// All other timers are stopped and reset.
                    myLowLowTimer.StopReset();
                    myHighHighTimer.StopReset();
                    myDisconnectedTimer.StopReset();
                    myNormalTimer.StopReset();

                    if ((myHighTimer.SecondsElapsed  > STATUS_CHANGE_DELAY)&(myTemperatureStatus!= Status.H)) // IF method to check if status-change-timer has been active long enough AND if the status already is H.
                    {
                        myTemperatureStatus = Status.H; // Sets status to High.
                        Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus, myHighLimit );// Send status parameter to TemperatureStatusLogger.
                        Program.myEmail.SendMessage("Temperature is currently above High-Limit: " + Convert.ToString(myHighLimit) + "°C. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT);// Method to send e-mail when temperature is above High-Limit.
                        Program.mySMS.SendSMS("RTM: Temperature is currently above High-Limit: " + Convert.ToString(myHighLimit) + "°C. Time: " + DateTime.Now.ToString()); // Method to send SMS when temperature is above High-Limit.
                    }
                }
                if (Temperature > myHighHighLimit) //IF-structure that checks if current temperature is above myHighHighLimit-value.
                {
                    myHighHighTimer.Start(); // Timer that sets new temperature status to L, starts.
                    myLowLowTimer.StopReset();// All other timers are stopped.
                    myHighTimer.StopReset();
                    myLowTimer.StopReset();
                    myDisconnectedTimer.StopReset();
                    myNormalTimer.StopReset();

                    if ((myHighHighTimer.SecondsElapsed > STATUS_CHANGE_DELAY)&(myTemperatureStatus != Status.HH))
                    {
                        myTemperatureStatus = Status.HH; // Sets status to HighHigh.

                        Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus, myHighHighLimit );// Send status parameter to TemperatureStatusLogger.

                        Program.myEmail.SendMessage("Temperature is currently above HighHigh-Limit: " + Convert.ToString(myHighHighLimit) + "°C. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT);// Method to send e-mail when temperature is above HighHigh-Limit.
                        Program.mySMS.SendSMS("RTM: Temperature is currently above HighHigh-Limit: " + Convert.ToString(myHighHighLimit) + "°C. Time: " + DateTime.Now.ToString()); // Method to send SMS when temperature is above HighHigh-Limit.
                    }
                }
                else //IF no other IF becomes true, then Status is Normal.
                {
                    myNormalTimer.Start(); // Timer that sets new temperature status to N, starts.
                    myLowLowTimer.StopReset();// All other timers are stopped and reset.
                    myHighTimer.StopReset();
                    myHighHighTimer.StopReset();
                    myLowTimer.StopReset();
                    myDisconnectedTimer.StopReset();

                    if ((myDisconnectedTimer.SecondsElapsed > STATUS_CHANGE_DELAY)&(myTemperatureStatus!=Status.N)) // IF method that checks if temperature is inside Normal-limits long enough.
                    {
                        myTemperatureStatus = Status.N; // Sets status to Normal.

                        Program.myTemperatureStatusLogger.LogTemperatureStatus(myTemperatureStatus);// Send status parameter to TemperatureStatusLogger.

                        Program.myEmail.SendMessage("Temperature is currently above High-Limit: " + Convert.ToString(myHighLimit) + "°C. Time: " + DateTime.Now.ToString(), TEMPERATURE_STATUS_SUBJECT);// Method to send e-mail when temperature is Normal.
                        Program.mySMS.SendSMS("RTM: Temperature is now Normal. Between: " + Convert.ToString(myLowLimit) + "°C and " + Convert.ToString(myHighLimit) + "°C. Time: " + DateTime.Now.ToString()); // Method to send SMS when temperature is Normal.
                    }
                }
            }
        }
    
    }
}
