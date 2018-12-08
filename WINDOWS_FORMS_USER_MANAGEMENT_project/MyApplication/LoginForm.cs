using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm() : base()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            
        }

        public void clearPassword()
        {
            passwordTextBox.Clear();
            passwordTextBox.Focus();
        }
        private void exitBbutton_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                Models.User foundedUser = databaseContext.Users
                    .Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).
                    FirstOrDefault();
                
                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("Username or Password is incorrect");
                    usernameTextBox.Focus();
                    return;
                }

                if (string.Compare(foundedUser.Password,passwordTextBox.Text,ignoreCase:false) !=0)
                {
                    System.Windows.Forms.MessageBox.Show("Username or Password is incorrect");
                    usernameTextBox.Focus();
                    return;
                }

                if (foundedUser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox.Show("You can not login!");
                    usernameLabel.Focus();
                    return;
                }

                Infrastructure.Utility.AuthenticatedUser = foundedUser;
                MainForm myMainForm = new MainForm();
                Hide();
                myMainForm.LogForm = this;
                myMainForm.InitializeMainForm();
                myMainForm.Show();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

                return;
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

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            usernameTextBox.Focus();
        }

        private RegisterForm RegForm;
        private void registerButton_Click(object sender, System.EventArgs e)
        {
            if (RegForm == null)
            {
                RegForm = new RegisterForm();
            }
            RegForm.LogForm = this;
            Hide();
            RegForm.Show();
        }
        private void showPictureBox_Down(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '\0';
        }
        private void showPictureBox_Up(object sender, System.EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
        }

        public string usernameText
        {
            set
            {
                usernameTextBox.Text = value;
            }
        }
    }
}
