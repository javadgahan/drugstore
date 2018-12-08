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
    public partial class sell_medicine : Infrastructure.BaseForm
    {
        public sell_medicine()
        {
            InitializeComponent();
        }

        private void sell_medicine_Load(object sender, EventArgs e)
        {

        }
        public void search()
        {
            Models.DatabaseContext
               databaseContext = null;
            System.Collections.Generic.List<Models.Medicine> medicines = null;

            try
            {
                databaseContext =
                    new Models.DatabaseContext();

                MedicineName.Text = MedicineName.Text.Trim();

                while (MedicineName.Text.Contains(" "))
                {
                    MedicineName.Text.Replace("  ", " ");
                }
                if (MedicineName.Text == string.Empty)
                {
                    medicines =
                        databaseContext.Medicines
                        .OrderBy(current => current.Name)
                        .ToList();



                }
                else
                {
                    medicines =
                       databaseContext.Medicines
                       .Where(current => current.Name.Contains(MedicineName.Text))

                       .OrderBy(current => current.Name).ToList();



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
            Medicinelistbox.ValueMember = "ID";
            Medicinelistbox.DisplayMember = "display";
            Medicinelistbox.DataSource = medicines;
        }

        private void SearchMedicine_Click(object sender, EventArgs e)
        {
            search();
            this.Show();
        }
        private void Exit_tomain_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Delete_Medicine_Click(object sender, EventArgs e)
        {
            if (Medicinelistbox.SelectedItems.Count == 0)
            {
                MessageBox.Show("there is no medicine selected");

                return;
            }
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext =
                    new Models.DatabaseContext();
                foreach (var selectedItem in Medicinelistbox.SelectedItems)
                {
                    Models.Medicine SelectedMedicine = selectedItem as Models.Medicine;
                    if (SelectedMedicine != null)
                    {
                        Models.Medicine foundedmedicine = databaseContext.Medicines
                            .Where(current => current.Id == SelectedMedicine.Id)
                            .FirstOrDefault();

                        //databaseContext.Entry(SelectedMedicine).State = System.Data.Entity.EntityState.Deleted;
                        new Models.DatabaseContext();
                        if (foundedmedicine != null)
                        {

                            databaseContext.Medicines.Remove(foundedmedicine);
                            databaseContext.SaveChanges();
                        }
                    }


                }
                search();
            }
            catch (System.Exception ex) { }
            finally { }
            if (databaseContext != null)
            {
                databaseContext.Dispose();
                databaseContext = null;
            }


        }

        private void sell_medicine_Load_1(object sender, EventArgs e)
        {

        }

        private void Medicinelistbox_DoubleClick(object sender, EventArgs e)
        {//





        }   //
        public Models.User SelectedMedicine { get; set; }
        private void Update_Medicine_Information_Load(object sender, EventArgs e)
        {

        }

        private void SearchMedicine_Click_1(object sender, EventArgs e)
        {
            search();
            this.Show();

        }

        private void sell_medicinebutton_Click(object sender, EventArgs e)
        {
            
            Models.DatabaseContext databaseContext = null;

            try
            {
                databaseContext = new Models.DatabaseContext();

                Models.Medicine foundedMedicine = databaseContext.Medicines
                    .Where(current => current.Id == SelectedMedicine.Id)
                    .FirstOrDefault();

                if (foundedMedicine == null)
                {
                    System.Windows.Forms.MessageBox.Show("there is no such a medicine anymore");
                    Close();

                }
                else {
                   // int tempamount = Int32.Parse(newamounttextbox.Text.ToString());
                   // int temp = foundedMedicine.amount - tempamount;
                   // foundedMedicine.amount = temp;
                  //  SelectedMedicine.Id = foundedMedicine.Id;
                  //  MessageBox.Show("temp is " + temp);
                    // isActive.Checked = foundeduser.IsActive;

                    // FullNametextBox1.Text = foundeduser.FullName;
                    // System.Windows.Forms.MessageBox.Show("test data full name" + FullNametextBox1);
                    // DescriptionTextBox2.Text = foundeduser.Description;

                }
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
    }
}
