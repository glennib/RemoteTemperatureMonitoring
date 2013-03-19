using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Remote_Temperature_Monitoring
{
    class Email
    {
        // ---------- Instance variables ---------- \\        
        private MailMessage myMessage;                                     // Holds to message which is to be sent in any case SendMessage is called.
        private string mySubscribers;                                      // Holds the e-mail adresses of which to send messages.
        private string myUserName;                                         // Holds the e-mail account username.
        private string mySenderEmail;                                      // Holds the e-mail account adress of which to send messages from.
        private string myHost;                                             // Holds the e-mail HOST.
        private string myPassword;                                         // Holds the e-mail account password
        private string mySubject;                                          // Holds the subject of the e-mail.
        private int myPort;                                                // Holds the port number to use for the e-mail.
        private bool myEnableSSL;                                          // Holds information about whether to use SSL or not.
        private SmtpClient mySmtpClient = new SmtpClient();                // Creates a client to use to send messages.
        private NetworkCredential myCredentials = new NetworkCredential(); // Creates a set of settings.


        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\
        public Email()          // Constructor with no parameters.
        {
            ApplyNewSettings(); // Applies new settings at object construction.
            
        }


        // ---------- Public methods     ---------- \\
        public void SendMessage(string Message, string Subject) // The method that is used to send a message to the subscribers.
        {
            
            CreateMessage(Message, Subject);                    // Runs method that creates a message object.
            mySmtpClient.Send(myMessage);                       // Sends the created message.
        }

        public void ApplyNewSettings()
        {
            mySubscribers = "";                                                   // Resets subscribers.
            foreach (EmailSubscriber subscriber in Program.myDB.EmailSubscribers) // Puts together a string which contains all the email separated by a comma.
            {
                mySubscribers += subscriber.Email + ",";
            }
            mySubscribers = mySubscribers.TrimEnd(Convert.ToChar(","));           // Removes ending commas.

            myUserName = Properties.Settings.Default.EmailUserName;               // Gets username from settings.
            mySenderEmail = Properties.Settings.Default.EmailSenderEmail;         // Gets sender email from settings.
            myHost = Properties.Settings.Default.EmailHost;                       // Gets HOST from settings.
            myPassword = Properties.Settings.Default.EmailPassword;               // Gets password from settings.
            myPort = Properties.Settings.Default.EmailPort;                       // Gets port from settings.
            myEnableSSL = Properties.Settings.Default.EmailSSL;                   // Gets SSL fro settings.

            myMessage.To.Clear();                                                 // Clears all recipients.
            myMessage.To.Add(mySubscribers);                                      // Adds all the recipients. Må fikses. Klarer ikke når det ikke er noe i objektet.

            SetUpAccount();                                                       // Apply new settings.

        }

        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\
        private void CreateMessage(string Message, string Subject)                // Assigns message values to the global myMessage. Needs to be able to get to and from adresses from the DB
        {
            myMessage = new MailMessage(mySenderEmail, null, mySubject, Message); // Creates a message object.
        }

        

        private void SetUpAccount()
        {
            myCredentials.UserName = myUserName;        // Set new username.
            myCredentials.Password = myPassword;        // Set new password.
            mySmtpClient.Host = myHost;                 // Set new HOST.
            mySmtpClient.Port = myPort;                 // Set new port.
            mySmtpClient.UseDefaultCredentials = false; // Set useDefaultCredentials.
            mySmtpClient.Credentials = myCredentials;   // Apply new credentials.
            mySmtpClient.EnableSsl = myEnableSSL;       // Set new EnableSsl settings.
        }

    }
}
