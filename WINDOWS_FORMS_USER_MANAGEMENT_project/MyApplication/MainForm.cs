using System.Linq;
namespace MyApplication
{
    
   
    public partial class MainForm : System.Windows.Forms.Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }

        public void InitializeMainForm()
        {
            //adminToolStripMenuItem.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;

            if (string.IsNullOrWhiteSpace(Infrastructure.Utility.AuthenticatedUser.FullName))
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.Username }";
            }
            else
            {
                toolStripStatusLabel1.Text =
                    $"Welcome { Infrastructure.Utility.AuthenticatedUser.FullName }";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure to exit?"
                , "Exit Warning"
                , System.Windows.Forms.MessageBoxButtons.YesNo
                , System.Windows.Forms.MessageBoxIcon.Warning
                , System.Windows.Forms.MessageBoxDefaultButton.Button2);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        public LoginForm LogForm;
        private void logOutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Infrastructure.Utility.AuthenticatedUser = null;
            Close();
            LogForm.clearPassword();
            LogForm.Show();
        }
        private UpdateProfileForm updateForm;
        private void updateProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (updateForm == null || updateForm.IsDisposed)
            {
                updateForm = new UpdateProfileForm();
                updateForm.MdiParent = this;
            }
            updateForm.Show();
        }

        private ChangePasswordForm changePassForm;
        private void changePasswordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (changePassForm == null || changePassForm.IsDisposed)
            {
                changePassForm = new ChangePasswordForm();
                changePassForm.MdiParent = this;
            }
            changePassForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }
        private void Users_list(object sender, System.EventArgs e)
        {
           
            Models.DatabaseContext databaseContext = null;
            databaseContext =
                    new Models.DatabaseContext();

            
            Models.User foundedUser = databaseContext.Users
                .Where(current => string.Compare(current.Username, null, false) == 0).
                FirstOrDefault();
            string h = databaseContext.Users.ToList().ToString();
            System.Windows.Forms.MessageBox.Show(h);
        /*    if (foundedUser == null)
            {
                System.Windows.Forms.MessageBox.Show("Username or Password is incorrect");
                usernameTextBox.Focus();
                return;
            }*/

        }

        private void userListToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            userslist ulist1 = new userslist();
            ulist1.Show();

        }

        private void addMedicineToolStripMenuItem_DoubleClick(object sender, System.EventArgs e)
        {

        }

        private void addMedicineToolStripMenuItem_MouseEnter(object sender, System.EventArgs e)
        {

        }

        private void Medicine_listbutton1_Click(object sender, System.EventArgs e)
        {
            Medicine_List ml1 = new Medicine_List();
            ml1.ShowDialog();
           
        }

        private void AddMedicine_button2_Click(object sender, System.EventArgs e)
        {

            if (ActiveForm == null) {
            }
            AddMedicine newmedicine = new AddMedicine();
            newmedicine.ShowDialog();
        }

        private void AddMedicine_button2_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (ActiveForm == null) { }
            AddMedicine newmedicine = new AddMedicine();
            newmedicine.Show();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (ActiveForm == null) { }
            AddMedicine newmedicine = new AddMedicine();
            newmedicine.Show();
        }

        private void DeleteMedicine_button3_Click(object sender, System.EventArgs e)
        {
            //implementation of listmedicine . delete medicine function 
            DeleteMedicine dm1 = new DeleteMedicine();
            dm1.ShowDialog();


        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            sell_medicine sellmedic1 = new sell_medicine();
            sellmedic1.ShowDialog();
        }
    }
}
