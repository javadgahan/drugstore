using System.Linq;
using System.Collections;
namespace MyApplication
{
    public partial class RegisterForm : Infrastructure.BaseForm
    {
        public RegisterForm():base()
        {
            

            InitializeComponent();
        }

        private void exitBbutton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            fullnameTextBox.Clear();
            usernameTextBox.Focus();
        }

        private void registerButton_Click(object sender, System.EventArgs e)
        {

            
            string errorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                errorMessages = "Enter username please!";
            }
            else
            {
                if (usernameTextBox.Text.Length < 6 || usernameTextBox.Text.Length >20)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages += "Username should be 6-20 characters";
                }
            }

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Enter password please!";
            }
            else
            {
                if (passwordTextBox.Text.Length < 8 || passwordTextBox.Text.Length >40)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages +=
                        "Password should be 6-20 characters";
                }
            }

            if (string.IsNullOrWhiteSpace(confirmPassTextBox.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Confirm password is required!";
            }
            else
            {
                if (string.Compare(confirmPassTextBox.Text, passwordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages += "Password and confirmation are not equal!";
                }
            }

            if (errorMessages != string.Empty)
            {
                System.Windows.Forms.MessageBox.Show(errorMessages);
                return;
            }
            
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User user = databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).
                    FirstOrDefault();

                if (user != null)
                {
                    System.Windows.Forms.MessageBox.Show("Username already exist!");
                    usernameTextBox.Focus();
                    return;
                }

                user = new Models.User
                {

                    FullName = fullnameTextBox.Text,
                    Username = usernameTextBox.Text,
                    Password = passwordTextBox.Text,
                    //Usercount = 
                    
                   
                    IsActive = true
                   
                };

                databaseContext.Users.Add(user);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show($"You are succesfully registered");
                resetButton_Click(null, null);
                loginButton_Click(null, null);
                LogForm.usernameText = user.Username;
                GlobalVariables.MedicineCounter++;
                System.Windows.Forms.MessageBox.Show("You have " + GlobalVariables.MedicineCounter +"Medicines");
                
                databaseContext.Users.ToArray();
                
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        public LoginForm LogForm;
        private void loginButton_Click(object sender, System.EventArgs e)
        {
            Hide();
            LogForm.Show();
        }

        private void showPictureBox_Down(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
            confirmPassTextBox.PasswordChar = '\0';
        }
        private void showPictureBox_Up(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            confirmPassTextBox.PasswordChar = '*';
        }

        private void usernameTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
