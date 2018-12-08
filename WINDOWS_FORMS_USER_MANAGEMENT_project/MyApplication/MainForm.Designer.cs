namespace MyApplication
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteMedicine_button3 = new System.Windows.Forms.Button();
            this.AddMedicine_button2 = new System.Windows.Forms.Button();
            this.Medicine_listbutton1 = new System.Windows.Forms.Button();
            this.sellmedicinebutton1 = new System.Windows.Forms.Button();
            this.buymedicinebutton2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.addMedicineToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.updateProfileToolStripMenuItem.Text = "Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfileToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userListToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // userListToolStripMenuItem
            // 
            this.userListToolStripMenuItem.DoubleClickEnabled = true;
            this.userListToolStripMenuItem.Name = "userListToolStripMenuItem";
            this.userListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F3)));
            this.userListToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.userListToolStripMenuItem.Text = "User List";
            this.userListToolStripMenuItem.Click += new System.EventHandler(this.userListToolStripMenuItem_Click);
            // 
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.addMedicineToolStripMenuItem.Text = "Add Medicine";
            this.addMedicineToolStripMenuItem.Click += new System.EventHandler(this.addMedicineToolStripMenuItem_Click);
            this.addMedicineToolStripMenuItem.DoubleClick += new System.EventHandler(this.addMedicineToolStripMenuItem_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(854, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DeleteMedicine_button3
            // 
            this.DeleteMedicine_button3.Location = new System.Drawing.Point(661, 310);
            this.DeleteMedicine_button3.Name = "DeleteMedicine_button3";
            this.DeleteMedicine_button3.Size = new System.Drawing.Size(113, 81);
            this.DeleteMedicine_button3.TabIndex = 5;
            this.DeleteMedicine_button3.Text = "Delete Medicine";
            this.DeleteMedicine_button3.UseVisualStyleBackColor = true;
            this.DeleteMedicine_button3.Click += new System.EventHandler(this.DeleteMedicine_button3_Click);
            // 
            // AddMedicine_button2
            // 
            this.AddMedicine_button2.Location = new System.Drawing.Point(380, 310);
            this.AddMedicine_button2.Name = "AddMedicine_button2";
            this.AddMedicine_button2.Size = new System.Drawing.Size(113, 81);
            this.AddMedicine_button2.TabIndex = 6;
            this.AddMedicine_button2.Text = "Add Medicine";
            this.AddMedicine_button2.UseVisualStyleBackColor = true;
            this.AddMedicine_button2.Click += new System.EventHandler(this.AddMedicine_button2_Click);
            this.AddMedicine_button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddMedicine_button2_MouseClick);
            // 
            // Medicine_listbutton1
            // 
            this.Medicine_listbutton1.BackgroundImage = global::MyApplication.Properties.Resources.prescription_bottle_pills_on_table_overdose_getty_large;
            this.Medicine_listbutton1.Location = new System.Drawing.Point(124, 310);
            this.Medicine_listbutton1.Name = "Medicine_listbutton1";
            this.Medicine_listbutton1.Size = new System.Drawing.Size(113, 81);
            this.Medicine_listbutton1.TabIndex = 7;
            this.Medicine_listbutton1.Text = "List Medicines";
            this.Medicine_listbutton1.UseVisualStyleBackColor = true;
            this.Medicine_listbutton1.Click += new System.EventHandler(this.Medicine_listbutton1_Click);
            // 
            // sellmedicinebutton1
            // 
            this.sellmedicinebutton1.Location = new System.Drawing.Point(223, 162);
            this.sellmedicinebutton1.Name = "sellmedicinebutton1";
            this.sellmedicinebutton1.Size = new System.Drawing.Size(113, 81);
            this.sellmedicinebutton1.TabIndex = 9;
            this.sellmedicinebutton1.Text = "Sell Medicine";
            this.sellmedicinebutton1.UseVisualStyleBackColor = true;
            this.sellmedicinebutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buymedicinebutton2
            // 
            this.buymedicinebutton2.Location = new System.Drawing.Point(475, 162);
            this.buymedicinebutton2.Name = "buymedicinebutton2";
            this.buymedicinebutton2.Size = new System.Drawing.Size(113, 81);
            this.buymedicinebutton2.TabIndex = 10;
            this.buymedicinebutton2.Text = "Buy Medicine";
            this.buymedicinebutton2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::MyApplication.Properties.Resources.mainimage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.buymedicinebutton2);
            this.Controls.Add(this.sellmedicinebutton1);
            this.Controls.Add(this.Medicine_listbutton1);
            this.Controls.Add(this.AddMedicine_button2);
            this.Controls.Add(this.DeleteMedicine_button3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Druge Store";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userListToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.Button DeleteMedicine_button3;
        private System.Windows.Forms.Button AddMedicine_button2;
        private System.Windows.Forms.Button Medicine_listbutton1;
        private System.Windows.Forms.Button sellmedicinebutton1;
        private System.Windows.Forms.Button buymedicinebutton2;
    }
}