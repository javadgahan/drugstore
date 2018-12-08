using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace MyApplication
{
    public partial class userslist : Infrastructure.BaseForm
    {
        public userslist()
        {
            InitializeComponent();
        }
        private void search()
        {
            Models.DatabaseContext
               databaseContext = null;
            System.Collections.Generic.List<Models.User> users = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                fullname.Text = fullname.Text.Trim();

                while (fullname.Text.Contains(" "))
                {
                    fullname.Text.Replace("  "," ");
                }
                if (fullname.Text == string.Empty)
                {
                    users =
                        databaseContext.Users
                        .OrderBy(current => current.FullName)
                        .ToList();



                }
                else
                {
                    users =
                       databaseContext.Users
                       .Where(current => current.FullName.Contains(fullname.Text))

                       .OrderBy(current => current.FullName).ToList();
                    


                }


            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
            
            userlistbox.ValueMember = "ID";
            userlistbox.DisplayMember = "FullName";
            userlistbox.DataSource = users;
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UsersDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            Models.User selectedUser = userlistbox.SelectedItem as Models.User;
            if (selectedUser != null)
            {

                
                
                //GlobalVariables.description  = selectedUser.Description.ToString();
                //GlobalVariables.fullname = selectedUser.FullName.ToString();


            }
            
        }

        private void userSearch_Click(object sender, EventArgs e)
        {

            search();
            this.Show();


        }

        private void UsersDetail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Models.User selectedUser =
                userlistbox.SelectedItem as Models.User;
             if (selectedUser !=null)
            {
                
                
                updateuser Updateuserform1 = new updateuser
                {
                    SelectedUser = selectedUser
                };

                Updateuserform1.ShowDialog();
                search();
            }

            
            
        }

        private void fullname_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void userslist_Load(object sender, EventArgs e)
        {
            
            
        }

        private void del_user_Click(object sender, EventArgs e)
        {
            Models.User selectedUser = userlistbox.SelectedItem as Models.User;
            if (selectedUser != null)
            {

                selectedUser.IsActive = false;
                



            }
        }

        private void Exit_tomain_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Exit_tomain_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
