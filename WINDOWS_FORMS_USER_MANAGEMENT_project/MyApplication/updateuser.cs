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
    public partial class updateuser : Infrastructure.BaseForm
    {
        public updateuser()
        {
            //Visible = true;
            
            InitializeComponent();
        }
        public Models.User SelectedUser { get; set; }

        
        
        private void Update_User_Information_Load(object sender, EventArgs e)
        {
            
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User foundeduser = databaseContext.Users
                    .Where(current => current.Id == SelectedUser.Id)
                    .FirstOrDefault();

                if (foundeduser == null)
                {
                    System.Windows.Forms.MessageBox.Show("there is no such a user anymore");
                    Close();

                }
                else
                isAdmin.Checked = foundeduser.IsAdmin;
                isActive.Checked = foundeduser.IsActive;

                FullNametextBox1.Text = foundeduser.FullName;
                //System.Windows.Forms.MessageBox.Show("test data full name" + FullNametextBox1);
                DescriptionTextBox2.Text = foundeduser.Description;


            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Close();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void DescriptionTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FullNametextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptionTextBox2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void Savebutton1_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
             
            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.User foundeduser = databaseContext.Users
                   .Where(current => current.Id == SelectedUser.Id)
                   .FirstOrDefault();
                if (foundeduser == null)
                {
                   MessageBox.Show("there is no such a user anymore");
                    Close();

                }
                foundeduser.IsAdmin = isAdmin.Checked;
                foundeduser.IsActive = isActive.Checked;
                foundeduser.FullName = FullNametextBox1.Text;
                foundeduser.Description = DescriptionTextBox2.Text;
                databaseContext.SaveChanges();
            }
            catch(System.Exception ex) {

                MessageBox.Show(ex.Message);
                Close();

            }
            this.Hide();
            

        }

        private void isAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
