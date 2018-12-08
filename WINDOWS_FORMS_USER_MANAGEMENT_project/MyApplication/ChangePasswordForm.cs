using System.Linq;

namespace MyApplication
{
    public partial class ChangePasswordForm : Infrastructure.BaseForm
    {
        public ChangePasswordForm() : base()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, System.EventArgs e)
        {
        }

        private void changeButton_Click(object sender, System.EventArgs e)
        {
            string errorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(oldPasswordTextBox.Text))
            {
                errorMessages = "Enter old password please!";
            }

            if (string.IsNullOrWhiteSpace(newPasswordTextBox.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages +=
                    "Enter new password!";
            }
            else
            {
                if (newPasswordTextBox.Text.Length < 8 || newPasswordTextBox.Text.Length >40)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages += "Password should be 6-20 characters";
                }
            }

            if (string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Confirm password is required!";
            }
            else
            {
                if (string.Compare(confirmPasswordTextBox.Text, newPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages += "New password and confirmation are not equal!";
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

                Models.User currentUser =
                    databaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id)
                    .FirstOrDefault();

                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                if (string.Compare(currentUser.Password, oldPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Old password is not correct!");
                    oldPasswordTextBox.Focus();
                    return;
                }

                currentUser.Password = newPasswordTextBox.Text;
                databaseContext.SaveChanges();
                System.Windows.Forms.MessageBox.Show("Password changed successfully.");
                Close();
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

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void showPictureBox_Down(object sender, System.EventArgs e)
        {
            oldPasswordTextBox.PasswordChar = '\0';
            newPasswordTextBox.PasswordChar = '\0';
            confirmPasswordTextBox.PasswordChar = '\0';
        }
        private void showPictureBox_Up(object sender, System.EventArgs e)
        {
            oldPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
