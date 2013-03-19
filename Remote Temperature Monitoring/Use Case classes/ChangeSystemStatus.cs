using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Temperature_Monitoring
{
    class ChangeSystemStatus
    {
        // ---------- Instance variables ---------- \\
        private const string SYSTEM_STATUS_MESSAGE_SUBJECT = "RTM: System status changed."; // Subject in each e-mail message that is sent.

        private bool myUSBGSMConnected; // Boolean to show if GSM module is connected.
        private bool myUSBCellPhoneConnected; // Boolean to show if cell phone is connected.
        private bool myUSBTransmitterConnected; // Boolean to show if temperature transmitter is connected.
        private bool myChargerConnected; // Boolean to show if charger is connected.
        private bool myHasSignal; // Boolean to show if we have GSM-signal.
        private bool myInternetConnected; // Boolean to show if internet is connected.

        /* All the error checkers go here. */
        private InternetChecker myInternetChecker;
        private ChargerChecker myChargerChecker;
        private USBChecker myUSBTransmitterChecker;
        private USBChecker myUSBGSMChecker;
        private USBChecker myUSBCellPhoneChecker;

        /* End */


        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\
        public ChangeSystemStatus() // Constructor with no parameters.
        {
            throw new NotImplementedException("ChangeSystemStatus class must be completed with VID & PID numbers.");

            /* For each error checker object that is created, remember to declare the methods associated with their events, and to initialize their IsOK values. */
            myInternetChecker = new InternetChecker(); // Declare new object internet checker.
            myInternetConnected = myInternetChecker.IsOK(); // Sets the global variable myInternetConnected to the current internet status.
            myInternetChecker.GoesOffline += new InternetChecker.ConnectionHandler(InternetCheckerGoesOffline); // Tells GoesOffline event which method to use.
            myInternetChecker.GoesOnline += new InternetChecker.ConnectionHandler(InternetCheckerGoesOnline); // Tells GoesOnline event which method to use.

            myChargerChecker = new ChargerChecker(); // Declare new object ChargerChecker.
            myChargerConnected = myChargerChecker.IsOK(); // Sets the global variable myChargerConnected to the current charger status.
            myChargerChecker.GoesOffline += new ChargerChecker.ConnectionHandler(ChargerCheckerGoesOffline); // Tells GoesOffline event which method to use.
            myChargerChecker.GoesOnline += new ChargerChecker.ConnectionHandler(ChargerCheckerGoesOnline); // Tells GoesOnline event which method to use.

            myUSBTransmitterChecker = new USBChecker(""/* VID for transmitter */, ""/* PID for transmitter */); // Declares new object from USBChecker. Constructor takes PID & VID
            myUSBTransmitterConnected = myUSBTransmitterChecker.IsOK(); // Sets the global variable myUSBTransmitterConnected to the current status.
            myUSBTransmitterChecker.GoesOffline += new USBChecker.ConnectionHandler(USBTransmitterCheckerGoesOffline); // Tells GoesOffline which method to use.
            myUSBTransmitterChecker.GoesOnline += new USBChecker.ConnectionHandler(USBTransmitterCheckerGoesOnline); // Tells GoesOnline which method to use.

            myUSBGSMChecker = new USBChecker(""/* VID for GSM module */, ""/* PID for gsm module */); // Declares new object from USBChecker. Constructor takes PID & VID
            myUSBGSMConnected = myUSBGSMChecker.IsOK(); // Sets the global variable myUSBGSMConnected to the current status.
            myUSBGSMChecker.GoesOffline += new USBChecker.ConnectionHandler(USBGSMCheckerGoesOffline); // Tells GoesOffline which method to use.
            myUSBGSMChecker.GoesOnline += new USBChecker.ConnectionHandler(USBGSMCheckerGoesOnline); // Tells GoesOnline which method to use.

            myUSBCellPhoneChecker = new USBChecker(""/* VID for Cell phone */, ""/* PID for cell phone */); // Declares new object from USBChecker. Constructor takes PID & VID
            myUSBCellPhoneConnected = myUSBCellPhoneChecker.IsOK(); // Sets the global variable myUSBCellPhoneConnected to the current status.
            myUSBCellPhoneChecker.GoesOffline += new USBChecker.ConnectionHandler(USBCellPhoneCheckerGoesOffline); // Tells GoesOffline which method to use.
            myUSBCellPhoneChecker.GoesOnline += new USBChecker.ConnectionHandler(USBCellPhoneCheckerGoesOnline); // Tells GoesOnline which method to use.


        }

        // ---------- Public methods     ---------- \\


        // ---------- Properties         ---------- \\
        public bool GSMConnected // Public property to reflect myUSBGSMConnected status. Read only.
        {
            get { return myUSBGSMConnected; }
        }
        public bool USBCellPhoneConnected // Public property to reflect myUSBCellPhoneConnected. Read only.
        {
            get { return myUSBCellPhoneConnected; }
        }
        public bool USBTransmitterConnected // Public property to reflect myUSBTransmitterConnected. Read only.
        {
            get { return myUSBTransmitterConnected; }
        }
        public bool ChargerConnected // Public property to reflect myChargerConnected. Read only.
        {
            get { return myChargerConnected; }
        }
        public bool HasSignal // Public property to reflect myHasSignal. Read only.
        {
            get
            {
                return myHasSignal;
            }
        }
        public bool InternetConnected // Public property to reflect myInternetConnected. Read only.
        {
            get { return myInternetConnected; }
        }


        // ---------- Private methods    ---------- \\
        private void UpdateStatusIndicators() // Updates the system status indicators.
        {
            Program.myMainForm.UpdateSystemStatusLabels(myInternetConnected, myUSBGSMConnected, myUSBCellPhoneConnected, myUSBTransmitterConnected, myChargerConnected); // updates the labels
        }

        private void InternetCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at InternetCheckerGoesOffline event.
        {
            myInternetConnected = false; // When internet is disconnected, myInternetConnected is set to false.
            UpdateStatusIndicators(); // Updates system status indicators.
        }

        private void InternetCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at InternetCheckerGoesOnline event.
        {
            
            myInternetConnected = true; // When internet is connected, myInternetConnected is set to true.
            UpdateStatusIndicators(); // Updates system status indicators.
        }

        private void ChargerCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at ChargerCheckerGoesOffline event.
        {
            myChargerConnected = false; // When charger is disconnected, myChargerConnected is set to false.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("Charger disconnected. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void ChargerCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at ChargerCheckerGoesOnline event.
        {
            myChargerConnected = true; // When charger is connected, myChargerConnected is set to true.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("Charger is reconnected. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void SignalCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at SignalCheckerGoesOffline event.
        {
            myHasSignal = false; // When signal goes offline, myHasSignal is set to false.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("GSM signal is lost. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void SignalCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at SignalCheckerGoesOnline event.
        {
            myHasSignal = true; // When signal goes online, myHasSignal is set to true.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("GSM signal is recovered. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void USBGSMCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at USBGSMCheckerGoesOffline event.
        {
            myUSBGSMConnected = false; // When GSM Checkers USB connection is lost, myUSBGSMConnected is set to false.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("GSM modem USB connection is lost. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void USBGSMCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at USBGSMCheckerGoesOnline event.
        {
            myUSBGSMConnected = true; // When GSM Checkers USB connection is reestablished, myUSBGSMConnected is set to true.
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("GSM modem USB connection is reestablished. Time: " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT); // Send message using global myEmail object.
        }

        private void USBCellPhoneCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at USBCellPhoneCheckerGoesOffline event.
        {
            myUSBCellPhoneConnected = false; // When cell phones USB connection is lost, myUSBGSMConnected is set to false.
            UpdateStatusIndicators(); // Updates system status indicators.
        }

        private void USBCellPhoneCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at USBCellPhoneCheckerGoesOnline event.
        {
            myUSBCellPhoneConnected = true; // When cell phones USB connection is reestablished, myUSBGSMConnected is set to true.
            UpdateStatusIndicators(); // Updates system status indicators.
        }

        private void USBTransmitterCheckerGoesOffline(object sender, BasicCheckerArgs e) // A method which is called at USBTransmitterCheckerGoesOffline event.
        {
            myUSBTransmitterConnected = false;
            UpdateStatusIndicators(); // Updates system status indicators.
            Program.myEmail.SendMessage("USB temperature transmitter is disconnected. Time " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT);
        }

        private void USBTransmitterCheckerGoesOnline(object sender, BasicCheckerArgs e) // A method which is called at USBTransmitterCheckerGoesOnline event.
        {
            myUSBTransmitterConnected = true;
            UpdateStatusIndicators();
            Program.myEmail.SendMessage("USB temperature transmitter connection is reestablished. Time " + DateTime.Now.ToString(), SYSTEM_STATUS_MESSAGE_SUBJECT);
        }
    }
}
