using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace UserRegistrationAndValidationProject
{
    public partial class Form1 : Form
    {
        public static bool LoginSignupBool = true;

        #region TopBar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Control_Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExitBox_MouseHover(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(240, 71, 71);
        }

        private void ExitBox_MouseLeave(object sender, EventArgs e)
        {
            ExitPictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        private void MinimisePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MinimisePictureBox_MouseHover(object sender, EventArgs e)
        {
            MinimisePictureBox.BackColor = Color.FromArgb(50, 53, 56);
        }

        private void MinimisePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimisePictureBox.BackColor = Color.FromArgb(45, 45, 48);
        }

        #endregion

        #region Encryption/Decryption
        public const int SALT_BYTE_SIZE = 24;
        public const int HASH_BYTE_SIZE = 24;
        public const int PBKDF2_ITERATIONS = 1000;

        public const int ITERATION_INDEX = 0;
        public const int SALT_INDEX = 1;
        public const int PBKDF2_INDEX = 2;

        public static string CreateHash(string password)
        {
            RNGCryptoServiceProvider csprng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_BYTE_SIZE];
            csprng.GetBytes(salt);
            byte[] hash = PBKDF2(password, salt, PBKDF2_ITERATIONS, HASH_BYTE_SIZE);
            return PBKDF2_ITERATIONS + ":" +
                Convert.ToBase64String(salt) + ":" +
                Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            char[] delimiter = { ':' };
            string[] split = correctHash.Split(delimiter);
            int iterations = Int32.Parse(split[ITERATION_INDEX]);
            byte[] salt = Convert.FromBase64String(split[SALT_INDEX]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2_INDEX]);

            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            return diff == 0;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignupPanel.Visible = false;
            LoginSignupBool = true;
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignupPanel.Visible = true;
            LoginSignupBool = false;
        }

        private void UsageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This project is for the UTC project #1 for the User creation and Validation \n It comes with the required 4 accounts \"User1\" to \"User4\" with the passwords being \"Password1\" to \"Password4\" \n It is possible to create new accounts and to log into those accounts");
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            InfoErrorLabel.Hide();
            if (LoginSignupBool)
            {
                List<UserObject> UserList = new List<UserObject>();
                try
                {
                    UserList = JsonConvert.DeserializeObject<List<UserObject>>(File.ReadAllText("Login.json"));

                    foreach (UserObject userObject in UserList)
                    {
                        if (ValidatePassword(PasswordLoginTextBox.Text, userObject.Password) == true && UsernameLoginTextBox.Text == userObject.Username)
                        {
                            InfoErrorLabel.Text = $"Logged in as: {UsernameLoginTextBox.Text}";
                            InfoErrorLabel.Show();
                            break;
                        }
                        else if (UsernameLoginTextBox.TextLength == 0)
                        {
                            InfoErrorLabel.Text = "Enter an Username";
                            InfoErrorLabel.Show();
                        }
                        else if (PasswordLoginTextBox.TextLength == 0)
                        {
                            InfoErrorLabel.Text = "Enter a Password";
                            InfoErrorLabel.Show();
                        }
                        else
                        {
                            InfoErrorLabel.Text = "The Password or Username was incorrect";
                            InfoErrorLabel.Show();
                        }
                    }


                }
                catch
                {
                    InfoErrorLabel.Text = "No Accounts Exist";
                    InfoErrorLabel.Show();
                }
            }
            else
            {
                if (PasswordSignUpTextBox.Text != RedoPasswordSignUpTextBox.Text)
                {
                    InfoErrorLabel.Text = "Password And Redo do not Match";
                    InfoErrorLabel.Show();
                }
                else if (UsernameSignUpTextBox.TextLength == 0)
                {
                    InfoErrorLabel.Text = "Enter an Username";
                    InfoErrorLabel.Show();
                }
                else if (PasswordSignUpTextBox.TextLength == 0)
                {
                    InfoErrorLabel.Text = "Enter a Password";
                    InfoErrorLabel.Show();
                }
                else if (PasswordSignUpTextBox.TextLength <= 12)
                {
                    InfoErrorLabel.Text = "Pasword has to be longer then 12 Characters";
                    InfoErrorLabel.Show();
                }
                else
                {
                    List<UserObject> UserList = new List<UserObject>();
                    try
                    {
                        UserList = JsonConvert.DeserializeObject<List<UserObject>>(File.ReadAllText("Login.json"));
                    }
                    catch
                    {

                    }

                    try
                    {
                        AddAndCheckObject(UserList, new UserObject(UsernameSignUpTextBox.Text, CreateHash(PasswordSignUpTextBox.Text)));
                        //UserList.Add(new UserObject(UsernameSignUpTextBox.Text, CreateHash(PasswordSignUpTextBox.Text)));
                        File.WriteAllText("Login.json", JsonConvert.SerializeObject(UserList));
                        SignupPanel.Hide();
                        InfoErrorLabel.Text = "Account Created";
                        InfoErrorLabel.Show();
                        LoginSignupBool = true;
                    }
                    catch
                    {
                        InfoErrorLabel.Text = "Username Already Exists";
                        InfoErrorLabel.Show();
                    }
                    
                }
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The file format Must be: \n Username \n Password \n Can be as many Usernames and Passwords as wanted");

            ImportFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ImportFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            ImportFileDialog.CheckFileExists = true;
            ImportFileDialog.CheckPathExists = true;

            ImportFileDialog.Multiselect = true;

            DialogResult dr = this.ImportFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (!ImportBackGroundWorker.IsBusy)
                {
                    ImportBackGroundWorker.RunWorkerAsync();
                }
            }
        }

        private void ImportBackGroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            int AlreadyExistingAccounts = 0;
            List<UserObject> UserList = new List<UserObject>();
            try
            {
                UserList = JsonConvert.DeserializeObject<List<UserObject>>(File.ReadAllText("Login.json"));
            }
            catch
            {

            }

            foreach (String file in ImportFileDialog.FileNames)
            {
                String PrevString = "";
                Boolean firstsecondline = true;
                foreach (String line in File.ReadAllLines(file))
                {
                    if (firstsecondline)
                    {
                        PrevString = line;
                        firstsecondline = false;
                    }
                    else
                    {
                        try
                        {
                            AddAndCheckObject(UserList, new UserObject(PrevString, CreateHash(line)));
                        }
                        catch (Exception ex)
                        {
                            AlreadyExistingAccounts++;
                        }
                        firstsecondline = true;
                    }
                }
            }
            if (AlreadyExistingAccounts > 0)
            {
                e.Result = $"{AlreadyExistingAccounts} Accounts could not be created, already exist";
            }
            else
            {
                e.Result = "Add and Created Accounts";
            }
            File.WriteAllText("Login.json", JsonConvert.SerializeObject(UserList));
        }

        private void ImportBackGroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                InfoErrorLabel.Text = "There was an error while importing";
            }
            else if (e.Cancelled)
            {
                InfoErrorLabel.Text = "Operation was cancelled";
            }
            else
            {
                InfoErrorLabel.Text = (String)e.Result;
            }
            InfoErrorLabel.Show();
        }

        /// <summary>
        /// Void to check if account already exists in the list and if not then to add the new account to the list
        /// </summary>
        /// <param name="ListForCheck">List for adding and checking</param>
        /// <param name="ObjectForCompare">The Object to be compared and added</param>
        /// <exception cref="UserAlreadyExistsException">Expection thrown when the account already exists for outside void handling</exception>
        public void AddAndCheckObject(List<UserObject> ListForCheck, UserObject ObjectForCompare)
        {
            foreach(UserObject UserObject in ListForCheck)
            {
                if (ObjectForCompare.Username == UserObject.Username)
                {
                    throw new UserAlreadyExistsException("Account Already Exists");
                }
            }
            ListForCheck.Add(ObjectForCompare);
        }

        
    }

    /// <summary>
    /// User object for Serialize and Deserialize To add to Json file
    /// </summary>
    public class UserObject
    {
        /// <summary>
        /// For creating an object simple
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="password">Hashed Password</param>
        public UserObject(String username, String password)
        {
            Username = username;
            Password = password;
        }
        public String Username { get; set; }
        public String Password { get; set; }
    }

    /// <summary>
    /// Exception Class just for making it all more official and nicer
    /// </summary>
    public class UserAlreadyExistsException : Exception
    {
        public UserAlreadyExistsException()
        {

        }
        public UserAlreadyExistsException(String ExceptionMessage) : base(ExceptionMessage)
        {

        }
    }
}