using System.Linq;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace MyApplication
{
    public  class GlobalVariables
    {
           
        public static int MedicineCounter=0;
        public ArrayList list = new ArrayList();
        public static string description;
        public static int id;
        public static string fullname;
    }
	internal static class Program
	{
		static Program()
		{
		}
        
		[System.STAThread]
		internal static void Main()
		{
           
            //using system threading to pause the application when starts
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            SplashImageForm f1 = new SplashImageForm();
            f1.Show();
            Thread.Sleep(10000);  //sleeps in millie secconds 
            f1.Dispose();
            f1.Hide();
            // **************************************************

            // **************************************************
            Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//int adminCount =
				//	databaseContext.Users
				//	.Where(current => current.IsAdmin)
				//	.Count();
                
				//int userCount =
				//	databaseContext.Users
				//	.Count();
                // if you want to change the admin from MR. tasdighodo to balhblah 

                // save program ... delete db change code admin.username admin.pass
                // rerun the prog
				bool hasAnyUser =
					databaseContext.Users
					.Any();
                
				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User();

					adminUser.IsAdmin = true;
					adminUser.IsActive = true;

					adminUser.Username = "DariushT";
					adminUser.Password = "1234512345";
					adminUser.FullName = "Professor Dariush Tasdighi";

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
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
			// **************************************************
            
			// **************************************************
			//System.Windows.Forms.Application.Run(new StartupForm());

			#region Runing Startup Form and then Disposing!
			LoginForm startupForm = new LoginForm();
          
            

			System.Windows.Forms.Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}

				startupForm = null;
			}
			#endregion /Runing Startup Form and then Disposing!
			// **************************************************
		}
	}
}
