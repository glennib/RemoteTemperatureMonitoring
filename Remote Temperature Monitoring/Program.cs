using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Remote_Temperature_Monitoring
{
    static class Program
    {
        public static frmMainWindow myMainForm; // Object for main form. Scary shit.
        // Global objects for the application to use.

        public static RTMDataClassDataContext myDB; // Allocates database.


        public static Email myEmail; // Allocates object.
        public static SMS mySMS; // Allocates object.
        public static ChangeSystemStatus myChangeSystemStatus; // Allocates object.
        public static ChangeTemperatureStatus myChangeTemperatureStatus; // Allocates object.
        public static MeasureTemperature myMeasureTemperature; // Allocates object.
        public static UpdateGraph myUpdateGraph; // Allocates object.
        public static TemperatureLogger myTemperatureLogger; // Allocates object.
        public static TemperatureStatusLogger myTemperatureStatusLogger; // Allocates object.
        public static SystemStatusLogger mySystemStatusLogger; // Allocates object.

        public static int Probe_Update_Delay = 1000; //Global variable to set the delaytime between every time the probe is read, in milliseconds.

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            myMainForm = new frmMainWindow(); // Creates new object of the frmMainWindow.
            
            try // Declares all new objects, but shows a messagebox if something fails this early.
            {
                myDB = new RTMDataClassDataContext(); // Declares new database object.

                myEmail = new Email(); // Declares new Email object.
                mySMS = new SMS(); // Declares new SMS object.
                myChangeSystemStatus = new ChangeSystemStatus(); // Declares new ChangeSystemStatus object.
                myChangeTemperatureStatus = new ChangeTemperatureStatus(); // Declares new ChangetemperatureStatus object.
                myMeasureTemperature = new MeasureTemperature(); // Declares new MeasureTemperature object.
                myUpdateGraph = new UpdateGraph(); // Declares new UpdateGraph object.
                myTemperatureLogger = new TemperatureLogger(); // Declares new TemperatureLogger object.
                myTemperatureStatusLogger = new TemperatureStatusLogger(); // Declares new TemperatureStatusLogger object.
                mySystemStatusLogger = new SystemStatusLogger(); // Declares new SystemStatusLogger object.

            }
            catch (SystemException e)
            {
                MessageBox.Show("Exception:\n" + e.ToString() + "\n\nMessage:\n" +e.Message, "Object creation error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            Application.Run(myMainForm);
        }
    }
}
