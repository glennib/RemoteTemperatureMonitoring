using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Remote_Temperature_Monitoring
{
    class ChargerChecker
    {
        // ---------- Instance variables ---------- \\
        private bool myIsOnline; // Boolean value that contains information if the computer is connected to a powersource.
        private Thread mypowerController; // Thread running the method ContinuouspowerChecker;

        // ---------- Events             ---------- \\
        public delegate void ConnectionHandler(object sender, BasicCheckerArgs e); // Delegate that contains what the events GoesOffline and GoesOnline contains of messages etc.
        public event ConnectionHandler GoesOffline; // Method for what happens when you are connected to a powersource. 
        public event ConnectionHandler GoesOnline; // Method for what happens when you loose connection to a powersource.

        // ---------- Constructors       ---------- \\
        public ChargerChecker() // Costructor for the ChargerChecker. 
        {
            mypowerController = new Thread(ContinuouspowerChecker); // Generates a new thread for the checker. 
            mypowerController.Start(); // Starts the thread.
        }

        // ---------- Public methods     ---------- \\
        public bool IsOK() // Method for returnal of the status if connected/disconnected to a powersource. 
        {
            return myIsOnline;
        }

        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\
        private void ContinuouspowerChecker() // Method that is beeing runned by the thread.
        {
            while (true) // Infinite loop.
            {
                if ((!Haspower()) && (myIsOnline)) // If you loose connection the powersource, and it was originally connected. 
                {
                    myIsOnline = false; // Changing the boolen value to false. 
                    BasicCheckerArgs LostConnectionArgs = new BasicCheckerArgs("Lost connection."); // Creates a new object that contains what the event GoesOffline should contain of information.
                    GoesOffline(this, LostConnectionArgs); // Activates the event GoesOffline.
                }
                else if ((Haspower()) && (!myIsOnline)) // If you get connected to a powersource, and it was originally disconnected. 
                {
                    myIsOnline = true; // Changing the boolean value to true.
                    BasicCheckerArgs GotConnectionArgs = new BasicCheckerArgs("Reestablished connection."); // // Creates a new object that contains what the event GoesOnline should contain of information.
                    GoesOnline(this, GotConnectionArgs); // Activates the event GoesOnline.
                }
            }
        }

        private bool Haspower() // Method that check if powersource is avaliable. 
        {
            bool power = false; // Boolean value that contains info if powersource is avaliable. 
            try // The method that will be ran here will throw a exeption if powersource is no avaliable when tested. 
            {
                if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online) // If you got power.
                {
                    power = true; // Change the boolean value to true. 
                }
            }
            catch // If you dont got powersource.
            {
                // Let the boolean value stay the same.
            }

            return power;
        }

    }

    //class ChargerCheckerArgs
    //{
    //    // ---------- Instance variables ---------- \\
    //    private string myMessage;

    //    // ---------- Constructors       ---------- \\
    //    public ChargerCheckerArgs(string Message)
    //    {
    //        myMessage = Message;
    //    }

    //    // ---------- Public methods     ---------- \\


    //    // ---------- Properties         ---------- \\
    //    public string Message
    //    {
    //        get
    //        {
    //            return myMessage;
    //        }
    //    }

    //    // ---------- Private methods    ---------- \\


    //}
}
