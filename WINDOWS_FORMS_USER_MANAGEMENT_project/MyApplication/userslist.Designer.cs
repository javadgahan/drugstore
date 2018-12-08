namespace MyApplication
{
    partial class userslist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Exit_tomain = new System.Windows.Forms.Button();
            this.del_user = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userlistbox = new System.Windows.Forms.ListBox();
            this.fullname = new System.Windows.Forms.TextBox();
            this.SearchUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Exit_tomain
            // 
            this.Exit_tomain.Location = new System.Drawing.Point(307, 292);
            this.Exit_tomain.Name = "Exit_tomain";
            this.Exit_tomain.Size = new System.Drawing.Size(100, 26);
            this.Exit_tomain.TabIndex = 5;
            this.Exit_tomain.Text = "Exit";
            this.Exit_tomain.UseVisualStyleBackColor = true;
            this.Exit_tomain.Click += new System.EventHandler(this.Exit_tomain_Click_1);
            // 
            // del_user
            // 
            this.del_user.Location = new System.Drawing.Point(100, 292);
            this.del_user.Name = "del_user";
            this.del_user.Size = new System.Drawing.Size(104, 26);
            this.del_user.TabIndex = 4;
            this.del_user.Text = "Delete User";
            this.del_user.UseVisualStyleBackColor = true;
            this.del_user.Click += new System.EventHandler(this.del_user_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "FullName";
            // 
            // userlistbox
            // 
            this.userlistbox.FormattingEnabled = true;
            this.userlistbox.Location = new System.Drawing.Point(100, 86);
            this.userlistbox.Name = "userlistbox";
            this.userlistbox.Size = new System.Drawing.Size(307, 199);
            this.userlistbox.TabIndex = 2;
            this.userlistbox.SelectedIndexChanged += new System.EventHandler(this.UsersDetail_SelectedIndexChanged);
            this.userlistbox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UsersDetail_MouseDoubleClick);
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(100, 30);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(307, 21);
            this.fullname.TabIndex = 1;
            this.fullname.TextChanged += new System.EventHandler(this.fullname_TextChanged);
            // 
            // SearchUser
            // 
            this.SearchUser.Location = new System.Drawing.Point(100, 57);
            this.SearchUser.Name = "SearchUser";
            this.SearchUser.Size = new System.Drawing.Size(59, 23);
            this.SearchUser.TabIndex = 0;
            this.SearchUser.Text = "SearchUser";
            this.SearchUser.UseVisualStyleBackColor = true;
            this.SearchUser.Click += new System.EventHandler(this.userSearch_Click);
            // 
            // userslist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(506, 353);
            this.Controls.Add(this.Exit_tomain);
            this.Controls.Add(this.del_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userlistbox);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.SearchUser);
            this.Name = "userslist";
            this.Load += new System.EventHandler(this.userslist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button SearchUser;
        private System.Windows.Forms.TextBox fullname;
        private System.Windows.Forms.ListBox userlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button del_user;
        private System.Windows.Forms.Button Exit_tomain;
    }
}
