using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Management;

namespace Remote_Temperature_Monitoring
{
    class USBChecker
    {
        // ---------- Instance variables ---------- \\
        private bool myIsOnline; // Boolean value that contains informasion if the computer is connected to the usb-device.
        private Thread myusbController; // Thread that runs the method ContinuoususbChecker;
        private string myVID; // String that contains the USB-unit unique VID.
        private string myPID; // String that contains the USB-units unique PID.


        // ---------- Events             ---------- \\
        public delegate void ConnectionHandler(object sender, BasicCheckerArgs e); // Delegat that contains what the eventes GoesOffline og GoesOnline contains of messages etc.
        public event ConnectionHandler GoesOffline; // Method for what happens when you are connected to the usb. 
        public event ConnectionHandler GoesOnline; // Method for what happens when loose connection to the usb. 

        // ---------- Constructors       ---------- \\
        public USBChecker(string vid, string pid) // Constructor for the usbchecker.
        {
            myusbController = new Thread(ContinuoususbChecker); // Makes a new thread for the checker. 
            myusbController.Start(); // Starts the thread.
            myVID = vid; // Sets myVID to vid.
            myPID = pid; // Sets myPID to vid.
        }

        // ---------- Public methods     ---------- \\
        public bool IsOK() // Metode for returnal of the status of the connection.
        {
            return myIsOnline;
        }

        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\
        private void ContinuoususbChecker() // Method that is run by the thread.
        {
            while (true) // Infinite loop.
            {
                if ((!Hasusb()) && (myIsOnline)) // If you loose connection to the usb, but were originally connected.
                {
                    myIsOnline = false; // Sets the boolean value to false.
                    BasicCheckerArgs LostConnectionArgs = new BasicCheckerArgs(string.Format("Lost connection to VID:{0}, PID:{1}.", myVID, myPID)); // Creates a new object that contains what the events GoesOffline should contain of information.
                    GoesOffline(this, LostConnectionArgs); // Activates the event GoesOffline.
                }
                else if ((Hasusb()) && (!myIsOnline)) // If you regain connection to usb, and were originally disconnected.
                {
                    myIsOnline = true; // Sets the boolean value to true.
                    BasicCheckerArgs GotConnectionArgs = new BasicCheckerArgs(string.Format("Reestablished connection to VID:{0}, PID:{1}.", myVID, myPID)); // // Creates a new object that contains what the events GoesOnline should contain of information.
                    GoesOnline(this, GotConnectionArgs); // Activates the event GoesOnline.
                }
            }
        }

        private bool Hasusb() // Method checks if USB is avaliable. 
        {
            bool usb = false; // Boolean value that contains information if USB is avaliable.
            try // Method that is run here will throw a exeption if USB is not avaliable when test is run.
            {
                using (var searcher =
                  new ManagementObjectSearcher(@"Select * From Win32_USBControllerDevice"))
                {
                    using (var collection = searcher.Get())
                    {
                        foreach (var device in collection)
                        {
                            var usbDevice = Convert.ToString(device);

                            if (usbDevice.Contains(myVID) && usbDevice.Contains(myPID)) // Verdiene her er VID og PID for den aktuelle enheten.
                                usb = true;
                        }
                    }
                }
            }

            catch // If you dont got USB.
            {
                // Let the boolean value stay the same.
            }

            return usb;
        }
    }
}
