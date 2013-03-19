using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace Remote_Temperature_Monitoring
{
    class SMS
    {
        // ---------- Instance variables ---------- \\
        private AutoResetEvent receiveNow;
        SerialPort serialPort1 = new SerialPort(); // creates a serialport object

        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\

        public SMS()
        {
            ApplySMSSettings();
        }

        // ---------- Public methods     ---------- \\

        public void ApplySMSSettings() // Public method to apply new settings for SMS-account.
        {
            string CheckPinCode = ""; // Variable used to check if the pin code is written 
            string PinCode = Properties.Settings.Default.SMSPinCode;
            string COMPort = Properties.Settings.Default.SMSCOMPort;

            //PortSettigs(COMPort); // Applies new COM port setteings

            try
            {
                CheckPinCode = ExecuteATCommand(serialPort1, "AT+CPIN?", 60000, "Pinkode er ikke skrivd"); // AT command to check if pin code is written
                if (CheckPinCode != "AT+CPIN?\r\r\n+CPIN: READY\r\n\r\nOK\r\n") // Checks if the Pin Code is written
                {
                    ExecuteATCommand(serialPort1, "AT+CPIN=" + PinCode, 60000, "Pinkode mislyktes"); // Writes pin code to sim card
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }

        public bool SendSMS(string message) // Creates AT commands and runs ExecCommand method
        {
            int Counter; // A variable used to count the number of times the Do-While loop has run
            bool isSend = false; // A Variable to check if a message is sent or not

            string[] number = new string[4] { "45414022", "41845366", "47646738", "95788889" }; // An array that contains phonenumbers
            for (int i = 0; i < 4; i++) // A For-loop that runs through every phonenumber in the array "number" and sends each phonenumber a message
            {
                Counter = 0;
                do
                {
                    string recievedData = ExecuteATCommand(serialPort1, "AT", 1000, "GSM ikke tilkoblet"); //Tester om GSM er tilkoblet
                    recievedData = ExecuteATCommand(serialPort1, "AT+CMGF=1", 1000, "Fikk ikke satt meldingsformat"); //Setter meldingsformat
                    String command = "AT+CMGS=\"" + number[i] + "\""; //Lager AT komando for tlfnummer
                    recievedData = ExecuteATCommand(serialPort1, command, 1000, "Fikk ikke akseptert nummer"); //Sender AT komando med tlfnummer
                    command = message + char.ConvertFromUtf32(26) + "\r"; //Lager AT komando for melding
                    recievedData = ExecuteATCommand(serialPort1, command, 10000, "Fikk ikke sendt melding"); //Sender AT komando med melding
                    if (recievedData.EndsWith("\r\nOK\r\n")) // tests if AT commands succeed
                    {
                        isSend = true; // sets isSend to true
                    }
                    else if (recievedData.Contains("ERROR")) // test if AT commands didn't succeed
                    {
                        isSend = false; // sets isSend to false
                    }
                    Counter++; // increases counter variable by 1
                }
                while (isSend == false || Counter >= 3); // A Do-While loop that runs as long AT commands fail or 3 times
            }
            return isSend; // returns isSend with either true or false value
        }

        // ---------- Properties         ---------- \\
        

        // ---------- Private methods    ---------- \\

        private void PortSettigs(string COM) // Sets port settings
        {
            receiveNow = new AutoResetEvent(false);
            try
            {
                serialPort1.PortName = COM; // Connection to COM-port
                serialPort1.BaudRate = 19200; // Sets baundrate to 19200
                serialPort1.DataBits = 8; // Sets databits to 8
                serialPort1.StopBits = StopBits.One; // Sets stopbits to 1
                serialPort1.Parity = Parity.None; // Sets parity to "none"
                serialPort1.ReadTimeout = 30000; // 30 sec timeout for read operation
                serialPort1.WriteTimeout = 30000; // 30 sec timeout for write operation
                serialPort1.Encoding = Encoding.GetEncoding("iso-8859-1"); // Encoding for west european alphabet(norwegian)
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                serialPort1.Open(); // Opens the siral port
                serialPort1.DtrEnable = true; // indicates that the serial port is ready
                serialPort1.RtsEnable = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ExecuteATCommand(SerialPort port, string command, int responseTimeout, string errorMessage) // Writes AT commands to GSM
        {
            try
            {
                port.DiscardOutBuffer(); // Discards out buffer
                port.DiscardInBuffer(); // Discards in buffer
                receiveNow.Reset();
                port.Write(command + "\r"); // writes commands to GSM

                string input = ReadResponse(port, responseTimeout); // runs Readresponse method
                if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                    throw new ApplicationException("No success message was received.");
                return input;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ReadResponse(SerialPort port, int timeout) // tests if AT command succeed
        {
            string buffer = string.Empty;
            try
            {
                do
                {
                    if (receiveNow.WaitOne(timeout, false))
                    {
                        string t = port.ReadExisting();
                        buffer += t;
                    }
                    else
                    {
                        if (buffer.Length > 0)
                            throw new ApplicationException("Response received is incomplete.");
                        else
                            throw new ApplicationException("No data received from GSM.");
                    }
                }
                while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return buffer;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (e.EventType == SerialData.Chars)
                {
                    receiveNow.Set();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
