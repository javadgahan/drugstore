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
    public partial class AddMedicine : Infrastructure.BaseForm
    {
        public AddMedicine()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string errorMessages = string.Empty;

            if (string.IsNullOrWhiteSpace(Medicinename_textBox1.Text))
            {
                errorMessages = "Enter Medicine Name please!";
            }
            else
            {
                if (Medicinename_textBox1.Text.Length < 6 || Medicinename_textBox1.Text.Length > 20)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages += "Medicine name should be 6-20 characters";
                }
            }

            if (string.IsNullOrWhiteSpace(Medicineamount_textBox2.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }
                
                errorMessages += "Enter Amount please!";
            }
            // checking if the amount is int or not 
            
            else
            {
                if (Medicineamount_textBox2.Text.Length < 1 || Medicineamount_textBox2.Text.Length > 40)
                {
                    if (errorMessages != string.Empty)
                    {
                        errorMessages += System.Environment.NewLine;
                    }

                    errorMessages +=
                        "Medicine Amount should be a number";
                }
            }

            if (string.IsNullOrWhiteSpace(Medicineprice_textBox3.Text))
            {
                if (errorMessages != string.Empty)
                {
                    errorMessages += System.Environment.NewLine;
                }

                errorMessages += "Please Enter the price";
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
                
                Models.Medicine medicine = databaseContext.Medicines
                    .Where(current => string.Compare(current.Name, Medicinename_textBox1.Text, true) == 0).
                    FirstOrDefault();

                if (medicine != null)
                {
                    System.Windows.Forms.MessageBox.Show("Medicine is already Defined!");
                    Medicinename_textBox1.Focus();
                    return;
                }
                int int_amount =Convert.ToInt32(Medicineamount_textBox2.Text);
                int int_price = Convert.ToInt32(Medicineprice_textBox3.Text);
                medicine = new Models.Medicine
                {

                    Name = Medicinename_textBox1.Text,

                    amount = int_amount,

                    price = int_price,

                    requiresdrpermit = checkBox1.Checked,


                   

                };

                databaseContext.Medicines.Add(medicine);
                databaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show($"Medicine is added");
                //resetButton_Click(null, null);
                //loginButton_Click(null, null);
                //LogForm.usernameText = user.Username;
                GlobalVariables.MedicineCounter++;
                System.Windows.Forms.MessageBox.Show("You have " + GlobalVariables.MedicineCounter + "Medicines");
                databaseContext.Medicines.ToArray();


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

        private void drpermits_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_EnabledChanged(object sender, EventArgs e)
        {
            if (sender.Equals(true)){

                System.Windows.Forms.MessageBox.Show("ture ?");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

            }
                
            
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
