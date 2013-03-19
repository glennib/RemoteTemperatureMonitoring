using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Remote_Temperature_Monitoring
{
    class StopWatch
    {
        // ---------- Instance variables ---------- \\
        private Timer myTimer; // Creates a timer.
        private ulong mySecondsElapsed; // Holds how many seconds that have elapsed.


        // ---------- Statics and events ---------- \\
        

        // ---------- Constructors       ---------- \\
        public StopWatch() // Constructor.
        {
            myTimer = new Timer(); // Declares object for myTimer.
            myTimer.Interval = 1000; // Sets the interval of myTimer to 1000 ms (1 second).
            mySecondsElapsed = 0; // Sets mySecondsElapsed to 0.

            myTimer.Tick += new EventHandler(myTimer_Tick); // Adds method to myTimer.Tick event.
        }        

        // ---------- Public methods     ---------- \\
        public void Start() // Starts stopwatch.
        {
            myTimer.Start();
        }

        public void Reset() // Resets stopwatch.
        {
            mySecondsElapsed = 0;
        }

        public void Stop() // Stops stopwatch.
        {
            myTimer.Stop();
        }

        public void StopReset() //Stops AND resets stopwatch.
        {
            myTimer.Stop();
            mySecondsElapsed = 0;
        }

        // ---------- Properties         ---------- \\
        public ulong SecondsElapsed // Returns seconds.
        {
            get
            {
                return mySecondsElapsed;
            }
        }

        // ---------- Private methods    ---------- \\
        private void myTimer_Tick(object sender, EventArgs e)
        {
            mySecondsElapsed++; // Increases seconds by 1.
        }


    }
}
