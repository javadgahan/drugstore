using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using Models;

namespace MyApplication
{
    public partial class DeleteMedicine : Infrastructure.BaseForm
    {
        public DeleteMedicine()
        {
            InitializeComponent();
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

        private void DeleteMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
