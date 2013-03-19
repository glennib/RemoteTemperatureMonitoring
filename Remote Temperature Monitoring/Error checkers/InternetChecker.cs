using System;
using System.Threading;
using System.Net.NetworkInformation;

namespace Remote_Temperature_Monitoring
{
    class InternetChecker
    {
        // ---------- Instance variables ---------- \\	
        private bool myIsOnline; // Boolean that contains information about whether the computer is connected to internet.
        private Thread myInternetController; // The thread that runs the method ContinuousInternetChecker.

        // ---------- Statics and events ---------- \\
        public delegate void ConnectionHandler(object sender, BasicCheckerArgs e); // Delegate which contains the methods that the events GoesOn/Offline will have.
        public event ConnectionHandler GoesOffline; // Event GoesOffline. Called when the internet status changes to Offline.
        public event ConnectionHandler GoesOnline; // Event GoesOnline. Called when the internet status changes to Online.

        // ---------- Constructors       ---------- \\	
        public InternetChecker() // Constructor with no parameters.
        {
            myInternetController = new Thread(ContinuousInternetChecker); // Creates a new thread object which runs the method ContinuousInternetChecker.
            myInternetController.Start(); // Starts the thread.
        }

        // ---------- Public methods     ---------- \\	
        public bool IsOK() // Method that reflects myIsOnline bool.
        {
            return myIsOnline;
        }

        // ---------- Properties         ---------- \\	


        // ---------- Private methods    ---------- \\	
        private void ContinuousInternetChecker() // Method that is run by the new thread.
        {
            while (true) // Eternal loop.
            {
                if ((!HasInternet()) && (myIsOnline)) // If internet is lost, and internet was active before.
                {
                    myIsOnline = false; // Set myIsOnline to False.
                    BasicCheckerArgs LostConnectionArgs = new BasicCheckerArgs("Lost connection."); // Creates a new object of InternetCheckerArgs that contains a message.
                    GoesOffline(this, LostConnectionArgs); // Activates the event GoesOffline.
                }
                else if ((HasInternet()) && (!myIsOnline)) // If internet is reestablished, and internet was reported as disconnected before.
                {
                    myIsOnline = true; // Set myIsOnline to True.
                    BasicCheckerArgs GotConnectionArgs = new BasicCheckerArgs("Reestablished connection."); // Creates a new object of InternetCheckerArgs that contains a message.
                    GoesOnline(this, GotConnectionArgs); // Activates the event GoesOnline.
                }
                Thread.Sleep(1000);
            }
        }

        private bool HasInternet() // Method which controlls if internet is avalible.
        {
            bool internet = false; // Boolsk verdi som inneholder informasjon om Internett er tilgjengelig.
            Ping myPing = new Ping(); // Skaper et nytt Ping-objekt.
            const string HOST = "google.com"; // Internettsiden man ønsker å kontrollere mot.
            const int TIMEOUT = 1000; // Hvor lang tid det skal ta uten internett før man "gir opp".
            byte[] buffer = new byte[32]; // Buffer for Ping-metoden.
            PingOptions pingOptions = new PingOptions(); // Objekt som inneholder informasjon om alternativene Ping-objektet skal sende med når det kontrollerer Internett (uviktig).
            try // Metoden som blir kjørt her inne vil kaste et unntak om Internett ikke er tilgjengelig når man tester.
            {
                PingReply reply = myPing.Send(HOST, TIMEOUT, buffer, pingOptions); // Tester om HOST er tilgjengelig.
                if (reply.Status == IPStatus.Success) // Om man har Internett.
                {
                    internet = true; // Sett den boolske verdien til true.
                }
            }
            catch // Om man ikke har internett.
            {
                // La den boolske verdien være uendret.
            }

            return internet;
        }

    }
}


//class InternetCheckerArgs // Class which contains the methods of the InternetChecker events.
//{
//    // ---------- Instance variables ---------- \\
//    private string myMessage; // String which contains the message associated with the event.

//    // ---------- Constructors       ---------- \\
//    public InternetCheckerArgs(string Message) // Constructor with parameter for the message.
//    {
//        myMessage = Message; // Set my message.
//    }

//    // ---------- Public methods     ---------- \\


//    // ---------- Properties         ---------- \\
//    public string Message // Property which reflects myMessage. Read only.
//    {
//        get
//        {
//            return myMessage;
//        }
//    }

//    // ---------- Private methods    ---------- \\


//}