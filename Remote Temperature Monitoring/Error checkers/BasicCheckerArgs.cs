using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Temperature_Monitoring
{
    class BasicCheckerArgs // Class which contains the methods of all the events created for the error checkers.
    {
        // ---------- Instance variables ---------- \\
    private string myMessage; // String which contains the message associated with the event.

    // ---------- Constructors       ---------- \\
    public BasicCheckerArgs(string Message) // Constructor with parameter for the message.
    {
        myMessage = Message; // Set my message.
    }

    // ---------- Public methods     ---------- \\


    // ---------- Properties         ---------- \\
    public string Message // Property which reflects myMessage. Read only.
    {
        get
        {
            return myMessage;
        }
    }

    // ---------- Private methods    ---------- \\

    }
}
