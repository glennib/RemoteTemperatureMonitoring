using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace Remote_Temperature_Monitoring
{
    class MeasureTemperature // This class connects to the temperature measuring probe.
    {
        // ---------- Instance variables ---------- \\
        private double myTemperature; // Double that keeps the current temperature of the probe.
        private bool myIsConnected; // Bool value with info wether the TermoCouple is connected or not.
        private Timer myTimer = new Timer();

        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\
        

        // ---------- Public methods     ---------- \\


        // ---------- Properties         ---------- \\
        /// <summary>
        /// Gets the current temperature in degrees Celsius.
        /// </summary>
        public double Temperature // Property to reflect myTemperature.
        {
            get { return myTemperature; }
        }

        public bool IsConnected // Property to reflect wether TermoCouple is connected.
        {
            get { return myIsConnected; }
        }

        // ---------- Private methods    ---------- \\

        private void StartTempMeasuring()
        {
            myTimer.Tick += new EventHandler(Timer_Tick);
            myTimer.Interval = 1000;
            myTimer.Enabled = true; 
            myTimer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Task temperatureTask = new Task();

            AIChannel myAIChannel;

            myAIChannel = temperatureTask.AIChannels.CreateThermocoupleChannel
                (
                "Dev1/ai0",
                "Temperature",
                -40,
                120,
                AIThermocoupleType.J,
                AITemperatureUnits.DegreesC,
                25
                );

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(temperatureTask.Stream);

            double analogDataIn = reader.ReadSingleSample();

            analogDataIn = Math.Round(analogDataIn, 2);

            myTemperature = analogDataIn; // LOOK OUT!!!! A test to se if ThermoCouple is connected is needed! The Boolean value IsConnected need to be false if so.
        }

    }
}
