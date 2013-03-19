using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Temperature_Monitoring
{
    class TemperatureStatusLogger
    {
        // ---------- Instance variables ---------- \\


        // ---------- Statics and events ---------- \\


        // ---------- Constructors ---------------- \\


        // ---------- Public methods     ---------- \\
        public void LogTemperatureStatus(ChangeTemperatureStatus.Status Status, double Limit) // A method that logs the current Temperature Status and limit to DB.
        {
            TemperatureStatusEvent newEvent = new TemperatureStatusEvent()                    // Defines a new event.
            {
                TimeStamp = DateTime.Now,                                                     // TimeStamp is set to current time.
                TemperatureStatus = Status.ToString(),                                        // Temperature status is set to the status enum converted to string.
                Limit = Limit,                                                                // Limit will become the paramter Limit.
                Description = Description(Status)                                             // Description will be applied from the function Description.
            };                                                                                // End new event.

            SubmitToDB(newEvent);                                                             // Sends the newEvent to the DB through SubmitToDB method.
        }

        public void LogTemperatureStatus(ChangeTemperatureStatus.Status Status)               // A method that logs the current Temperature Status to DB.
        {
            TemperatureStatusEvent newEvent = new TemperatureStatusEvent()                    // Defines a new event.
            {
                TimeStamp         = DateTime.Now,                                             // TimeStamp is set to current time.
                TemperatureStatus = Status.ToString(),                                        // Temperature status is set to the status enum converted to string.
                Description       = Description(Status)                                       // Description will be applied from the function Description.
            };

            SubmitToDB(newEvent);                                                             // Sends the newEvent to the DB through SubmitToDB method.
        }



        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\
        private string Description(ChangeTemperatureStatus.Status Status) // Generates a description string from the enum Status.
        {
            string description = "";                                      // Initializes a string.
            switch (Status)                                               // Switch of the status.
            {
                case ChangeTemperatureStatus.Status.D:
                    description = "Thermocouple Disconnected";
                    break;
                case ChangeTemperatureStatus.Status.N:
                    description = "Temperature between High and Low limit";
                    break;
                case ChangeTemperatureStatus.Status.LL:
                    description = "Temperature below LowLow limit";
                    break;
                case ChangeTemperatureStatus.Status.L:
                    description = "Temperature below Low limit";
                    break;
                case ChangeTemperatureStatus.Status.H:
                    description = "Temperature above High limit";
                    break;
                case ChangeTemperatureStatus.Status.HH:
                    description = "Temperature above HighHigh limit";
                    break;
            }

            return description;                                           // Returns the description.
        }

        private void SubmitToDB(TemperatureStatusEvent E)                 // Method to send a temperature event to the database.
        {
            Program.myDB.TemperatureStatusEvents.InsertOnSubmit(E);       // Insert event.
            Program.myDB.SubmitChanges();                                 // Submit.
        }

    }
}
