using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Temperature_Monitoring
{
    class SystemStatusLogger
    {
        // ---------- Instance variables ---------- \\


        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\


        // ---------- Public methods     ---------- \\
        private void LogSystemStatus(string status) // A method that logs the current System Status in the Database
        {
            // SystemStatusEvent event = new SystemStatusEvent() { ID, TimeStamp = DateTime.Now, Description = status }; // Creates new event from aquired information.
            // Program.myDB.SystemStatusEvents.InsertOnSubmit(event); // Inserts that information in to the DB.
            // Program.myDB.SubmitChanges(); // Submit.
            // Writes the current System Status in the Database 
        }

        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\

    }
}
