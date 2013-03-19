using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RTMClassLibrary;

namespace Remote_Temperature_Monitoring
{
    public partial class frmSettings : Form
    {
        // ---------- Instance variables ---------- \\
    

        // ---------- Statics and events ---------- \\


        // ---------- Constructors       ---------- \\
        public frmSettings()
        {

            InitializeComponent();
            UpdateSettings();

            
        }

        // ---------- Public methods     ---------- \\


        // ---------- Properties         ---------- \\


        // ---------- Private methods    ---------- \\
        private void ApplyNewSettings() // This method writes all the new settings to the database, and calls all objects' new settings methods.
        {

            Program.myEmail.ApplyNewSettings(); // Applies new E-mail settings
            Program.mySMS.ApplySMSSettings(); // Applies new SMS settings
            
        }



        /* Methods for email subscribers */
        private void LoadEmailSubscribers()
        {
            lstEmail.Items.Clear();
            foreach (EmailSubscriber S in Program.myDB.EmailSubscribers)
            {
                lstEmail.Items.Add(S.Email);
            }
        }

        private void SaveEmailSubscribers()
        {
            var deleteList =
                from S in Program.myDB.EmailSubscribers
                select S;
            Program.myDB.EmailSubscribers.DeleteAllOnSubmit(deleteList);
            foreach (string S in lstEmail.Items)
            {
                Program.myDB.EmailSubscribers.InsertOnSubmit(new EmailSubscriber() { Email = S });
            }
            Program.myDB.SubmitChanges();
        }        

        private bool AddEmailSubscriberToList(string email) // Adds new subscriber to list.
        {
            if (email != "") // If the string is not empty
            {
                if (ErrorHandling.IsNumeric(email))
                {
                    lstEmail.Items.Add(email);
                    return true;
                }
                else
                {
                    throw new FormatException("Wrong email format.");
                }
            }
            return false;
        }

        private void RemoveEmailSubscriberFromList() // Removes selected subscriber from list.
        {

            lstEmail.Items.RemoveAt(lstEmail.SelectedIndex);
        }

        private void btnAddEmail_Click(object sender, EventArgs e) // Event for AddEmail to list.
        {
            string email = txtEmailAdress.Text; // Gets text from textbox.
            if (AddEmailSubscriberToList(email)) // Adds the selected text to the list.
                txtEmailAdress.Clear(); // clears if it was successful.
        }

        private void btnRemoveEmail_Click(object sender, EventArgs e) // Event for RemoveEmail from list.
        {
            if (lstEmail.SelectedIndex != -1)
            {
                txtEmailAdress.Text = lstEmail.SelectedItem.ToString();
                txtEmailAdress.Focus();
                RemoveEmailSubscriberFromList();
            }
        }

        /* End methods for email subscribers */

        /* Methods for SMS subscribers */
        private void LoadSMSSubscribers() // Updates SMS subscriber list
        {
            lstPhoneNumber.Items.Clear(); // Clears the list.
            foreach (PhoneSubscriber S in Program.myDB.PhoneSubscribers) // Runs through each subscriber.
            {
                lstPhoneNumber.Items.Add(S.Number); // Adds the number to the list.
            }
        }

        private void SaveSMSSubscribers()
        {
            var deleteList =
                from S in Program.myDB.PhoneSubscribers
                select S;
            Program.myDB.PhoneSubscribers.DeleteAllOnSubmit(deleteList);
            foreach (string S in lstPhoneNumber.Items)
            {
                Program.myDB.PhoneSubscribers.InsertOnSubmit(new PhoneSubscriber() { Number = S });
            }
            Program.myDB.SubmitChanges();
        }

        private bool AddSMSSubscriberToList(string number) // Adds new subscriber to list.
        {
            if (number != "") // If the string is not empty
            {
                if (!number.Contains(",")) // If string does not contain a comma.
                {
                    lstPhoneNumber.Items.Add(number);
                    return true;                    
                } // End if not comma
                else
                {
                    throw new FormatException("Wrong number format.");
                }
            }
            return false;
        }

        private void RemoveSMSSubscriberFromList() // Removes selected subscriber from list.
        {
            lstPhoneNumber.Items.RemoveAt(lstPhoneNumber.SelectedIndex);
        }

        private void btnAddPhoneNumber_Click(object sender, EventArgs e) // Event for Add Phonenumber to list.
        {
            string number = txtPhoneNumber.Text; // Gets text from textbox.
            if (AddSMSSubscriberToList(number)) // Adds the selected text to the list.
                txtPhoneNumber.Clear(); // clears if it was successful.
        }

        private void btnRemovePhoneNumber_Click(object sender, EventArgs e)
        {
            if ((lstPhoneNumber.SelectedIndex != -1)) // If an item is selected.
            {
                txtPhoneNumber.Text = lstPhoneNumber.SelectedItem.ToString();
                txtPhoneNumber.Focus();
                RemoveSMSSubscriberFromList();
            }
        } // Event for remove Phonenumber from list.
        

        /* End methods for SMS subscribers */

        /* Methods for applying the settings */

        private void ApplySettings()
        {
            /* Alarm settings */

            //THESE NEED TO BE CHECKED IF NUMERIC

            if (txtLowLowLimit.Text != "")
            {
                Properties.Settings.Default.TempStatLowLowLimit = Convert.ToDouble(txtLowLowLimit.Text);
            }

            if (txtLowLimit.Text != "")
            {
                Properties.Settings.Default.TempStatLowLimit = Convert.ToDouble(txtLowLimit.Text);
            }

            if (txtHighLimit.Text != "")
            {
                Properties.Settings.Default.TempStatHighLimit = Convert.ToDouble(txtHighLimit.Text);
            }

            if (txtHighHighLimit.Text != "")
            {
                Properties.Settings.Default.TempStatHighHighLimit = Convert.ToDouble(txtHighHighLimit.Text);
            }

            if (chkLowLowLimitSMS.Checked == true)
            {
                Properties.Settings.Default.SMSLowLow = true;
            }
            else
            {
                Properties.Settings.Default.SMSLowLow = false;
            }

            if (chkLowLimitSMS.Checked== true)
            {
                Properties.Settings.Default.SMSLow = true;
            }
            else
            {
                Properties.Settings.Default.SMSLow = false;
            }

            if (chkHighLimitSMS.Checked == true)
            {
                Properties.Settings.Default.SMSHigh = true;
            }
            else
            {
                Properties.Settings.Default.SMSHigh = false;
            }

            if (chkHighHighLimitSMS.Checked == true)
            {
                Properties.Settings.Default.SMSHighHigh = true;
            }
            else
            {
                Properties.Settings.Default.SMSHighHigh = false;
            }

            if (chkLowLowLimitEmail.Checked == true)
            {
                Properties.Settings.Default.EmailLowLow = true;
            }
            else
            {
                Properties.Settings.Default.EmailLowLow = false;
            }

            if (chkLowLimitEmail.Checked == true)
            {
                Properties.Settings.Default.EmailLow = true;
            }
            else
            {
                Properties.Settings.Default.EmailLow = false;
            }

            if (chkHighLimitEmail.Checked == true)
            {
                Properties.Settings.Default.EmailHigh = true;
            }
            else
            {
                Properties.Settings.Default.EmailHigh = false;
            }

            if (chkHighHighLimitEmail.Checked == true)
            {
                Properties.Settings.Default.EmailHighHigh = true;
            }
            else
            {
                Properties.Settings.Default.EmailHighHigh = false;
            }


            /* Connection */

            if (txtUserName.Text != "")
            {
                Properties.Settings.Default.EmailUserName = txtUserName.Text;
            }

            if (txtSenderEmail.Text != "")
            {
                Properties.Settings.Default.EmailSenderEmail = txtSenderEmail.Text;
            }

            if (txtPassword.Text != "")
            {
                Properties.Settings.Default.EmailPassword = txtPassword.Text;
            }

            if (txtHost.Text != "")
            {
                Properties.Settings.Default.EmailHost = txtHost.Text;
            }

            if (txtPort.Text != "") // Needs a check if numeric function.
            {
                Properties.Settings.Default.EmailPort = Convert.ToInt16(txtPort.Text);
            }

            if (cBSsl.Checked == true) // Needs a check if numeric function.
            {
                Properties.Settings.Default.EmailSSL = true;
            }
            else
            {
                Properties.Settings.Default.EmailSSL = false;
            }

            if (cboComPort.Text != "")
            {
                Properties.Settings.Default.SMSCOMPort = cboComPort.SelectedText;
            }
            
            
        } // Applies the new settings.

        private void UpdateSettings()
        {
            /* Alarm settings */
            txtLowLowLimit.Text = Convert.ToString(Properties.Settings.Default.TempStatLowLowLimit);
            txtLowLimit.Text = Convert.ToString(Properties.Settings.Default.TempStatLowLimit);
            txtHighLimit.Text = Convert.ToString(Properties.Settings.Default.TempStatHighLimit);
            txtHighHighLimit.Text = Convert.ToString(Properties.Settings.Default.TempStatHighHighLimit);

            if (Properties.Settings.Default.SMSLowLow == true)
            {
                chkLowLowLimitSMS.Checked = true;
            }
            else
            {
                chkLowLowLimitSMS.Checked = false;
            }

            if (Properties.Settings.Default.SMSLow == true)
            {
                chkLowLimitSMS.Checked = true;
            }
            else
            {
                chkLowLimitSMS.Checked = false;
            }

            if (Properties.Settings.Default.SMSHigh == true)
            {
                chkHighLimitSMS.Checked = true;
            }
            else
            {
                chkHighLimitSMS.Checked = false;
            }

            if (Properties.Settings.Default.SMSHighHigh == true)
            {
                chkHighHighLimitSMS.Checked = true;
            }
            else
            {
                chkHighHighLimitSMS.Checked = false;
            }

            if (Properties.Settings.Default.EmailLowLow == true)
            {
                chkLowLowLimitEmail.Checked = true;
            }
            else
            {
                chkLowLowLimitEmail.Checked = false;
            }

            if (Properties.Settings.Default.EmailLow == true)
            {
                chkLowLimitEmail.Checked = true;
            }
            else
            {
                chkLowLimitEmail.Checked = false;
            }

            if (Properties.Settings.Default.EmailHigh == true)
            {
                chkHighLimitEmail.Checked = true;
            }
            else
            {
                chkHighLimitEmail.Checked = false;
            }

            if (Properties.Settings.Default.EmailHighHigh == true)
            {
                chkHighHighLimitEmail.Checked = true;
            }
            else
            {
                chkHighHighLimitEmail.Checked = false;
            }





            
            /* Connection */
            

            /* Email */
            txtUserName.Text = Properties.Settings.Default.EmailUserName;
            txtSenderEmail.Text = Properties.Settings.Default.EmailSenderEmail;
            txtPassword.Text = Properties.Settings.Default.EmailPassword;
            txtHost.Text = Properties.Settings.Default.EmailHost;
            txtPort.Text = Convert.ToString(Properties.Settings.Default.EmailPort);
            if (Properties.Settings.Default.EmailSSL == true)
            {
                cBSsl.Checked = true;
            }
            else
            {
                cBSsl.Checked = false;
            }
            LoadEmailSubscribers(); // Loads the email subscribers into the list.

            /* SMS */
            LoadSMSSubscribers();


        } // Updates the saved settings to the settings window.

        private void btnApply_Click(object sender, EventArgs e)// Event for applying the settings.
        {
            ApplySettings();
            UpdateSettings();
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ApplySettings();
            this.Close();
        } // Event applying the settings and shutting down settings window.

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Event shutting down the settings windows without saving the settings.

        private void frmSettings_Load(object sender, EventArgs e)
        {
            UpdateSettings();
        }  


        
    }
}
