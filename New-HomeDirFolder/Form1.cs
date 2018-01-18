using System;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;

namespace New_HomeDirFolder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createHomedir_Click(object sender, EventArgs e)
        {
            //Collect data
            string homedirPath = string.Concat(homedirRootTxt.Text, "\\", userNameTxt.Text);
            bool allGood = true;

            //Validate input
            //Input is not blank
            if (string.IsNullOrEmpty(userNameTxt.Text) || string.IsNullOrEmpty(domainNameTxt.Text) || string.IsNullOrEmpty(homedirRootTxt.Text))
            {
                resultsTxt.AppendText("\r\nError: Please fill out all fields.");
                allGood = false;
            }

            //User exists in AD
            if (!UserExistsInAD(userNameTxt.Text, domainNameTxt.Text))
            {
                resultsTxt.AppendText("\r\nError: " + userNameTxt.Text  + " doesn't exist in domain " + domainNameTxt.Text + ".");
                allGood = false;
            }

            //Homedir root path is valid
            if (!Directory.Exists(homedirRootTxt.Text))
            {
                resultsTxt.AppendText("\r\nError: Homedir root path doesn't exist.");
                allGood = false;
            }

            //Homedir does not already exist
            if (Directory.Exists(homedirPath))
            {
                resultsTxt.AppendText("\r\nError: " + homedirPath + " already exists.");
                allGood = false;
            }

            //Do the work
            //Create homedir
            if (allGood)
            {
                resultsTxt.AppendText("\r\nValidation passed.\r\nCreating new homedir for " + userNameTxt.Text + "@" + domainNameTxt.Text + "...");

                try
                {
                    DirectoryInfo createHomedirResult = Directory.CreateDirectory(homedirPath);
                    resultsTxt.AppendText("\r\nSuccessfully created " + createHomedirResult.FullName + ".");
                }
                catch (UnauthorizedAccessException)
                {
                    resultsTxt.AppendText("\r\nError: Current user does not have access to create folder.");
                    allGood = false;
                }
                catch (DirectoryNotFoundException)
                {
                    resultsTxt.AppendText("\r\nError: The specified path is invalid.");
                    allGood = false;
                }
                catch
                {
                    resultsTxt.AppendText("\r\nError: Something happened.");
                    allGood = false;
                }
            }

            //Update permissions
            if (allGood)
            {
                var fs = Directory.GetAccessControl(homedirPath);
                var ntAccount = new NTAccount(domainNameTxt.Text, userNameTxt.Text);
                fs.SetOwner(ntAccount); //Set owner
                fs.AddAccessRule(new FileSystemAccessRule(ntAccount, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow)); //Set explicit perms

                //Apply changes
                try
                {
                    Directory.SetAccessControl(homedirPath, fs);
                    resultsTxt.AppendText("\r\nSuccessfully repaired perms for " + userNameTxt.Text + "@" + domainNameTxt.Text + ".");
                }
                catch (UnauthorizedAccessException)
                {
                    resultsTxt.AppendText("\r\nError: Unauthorized access.");
                }
                catch (ArgumentNullException)
                {
                    resultsTxt.AppendText("\r\nError: The directory security parameter is null.");
                }
                catch
                {
                    resultsTxt.AppendText("\r\nError: Something happened.");
                }
            }

            //Update resultsTxt
            resultsTxt.AppendText("\r\n\r\n****************\r\nReady");
        }

        #region ExtraFunctions

        #region UserExistsInAD
        ///<summary>
        ///Verify that a given username exists in Active Directory
        ///Thanks mhu on StackOverflow for this function
        ///https://stackoverflow.com/questions/1675813/faster-way-to-find-out-if-a-user-exists-on-a-system
        ///</summary>
        ///<param name="userName">The SAM account name of the user to check for.</param>
        ///<param name="domainName">The domain to check for the user.</param>
        ///<returns>State [bool]</returns>
        private bool UserExistsInAD(string userName, string domainName)
        {
            using (var oUser = new DirectoryEntry("WinNT://" + domainName + "/" + userName + ",user"))
            {
                return (oUser != null);
            }
        }
        #endregion

        #region UpdateADAccount
        private bool UpdateADAccount(string userName, string domainName, string homedirRoot, TextBox results)
        {
            var ntAccount = new NTAccount(domainName, userName);

            try
            {
                DirectoryEntry rootEntry = new DirectoryEntry("LDAP://" + domainName);
                DirectorySearcher searcher = new DirectorySearcher(rootEntry);
                return true;
            }
            catch
            {
                results.AppendText("\r\nError: Something happened.");
                return false;
            }
        }
        #endregion

        #endregion
    }
}
