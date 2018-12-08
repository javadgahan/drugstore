namespace MyApplication
{
    partial class updateuser
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
            this.save = new System.Windows.Forms.Button();
            this.isAdmin = new System.Windows.Forms.CheckBox();
            this.isActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTextBox2 = new System.Windows.Forms.RichTextBox();
            this.FullNametextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(230, 273);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(134, 23);
            this.save.TabIndex = 6;
            this.save.Text = "Save and  Close";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(12, 215);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(62, 17);
            this.isAdmin.TabIndex = 5;
            this.isAdmin.Text = "Admin";
            this.isAdmin.UseVisualStyleBackColor = true;
            this.isAdmin.CheckedChanged += new System.EventHandler(this.isAdmin_CheckedChanged);
            // 
            // isActive
            // 
            this.isActive.AutoSize = true;
            this.isActive.Location = new System.Drawing.Point(12, 195);
            this.isActive.Name = "isActive";
            this.isActive.Size = new System.Drawing.Size(61, 17);
            this.isActive.TabIndex = 4;
            this.isActive.Text = "Active";
            this.isActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FullName";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DescriptionTextBox2
            // 
            this.DescriptionTextBox2.Location = new System.Drawing.Point(100, 61);
            this.DescriptionTextBox2.Name = "DescriptionTextBox2";
            this.DescriptionTextBox2.Size = new System.Drawing.Size(264, 195);
            this.DescriptionTextBox2.TabIndex = 1;
            this.DescriptionTextBox2.Text = "";
            this.DescriptionTextBox2.TextChanged += new System.EventHandler(this.DescriptionTextBox2_TextChanged);
            this.DescriptionTextBox2.DoubleClick += new System.EventHandler(this.DescriptionTextBox2_DoubleClick);
            // 
            // FullNametextBox1
            // 
            this.FullNametextBox1.Location = new System.Drawing.Point(100, 22);
            this.FullNametextBox1.Name = "FullNametextBox1";
            this.FullNametextBox1.Size = new System.Drawing.Size(264, 21);
            this.FullNametextBox1.TabIndex = 0;
            this.FullNametextBox1.TextChanged += new System.EventHandler(this.FullNametextBox1_TextChanged);
            // 
            // updateuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(397, 322);
            this.Controls.Add(this.save);
            this.Controls.Add(this.isAdmin);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionTextBox2);
            this.Controls.Add(this.FullNametextBox1);
            this.Name = "updateuser";
            this.Text = "Update User Description";
            this.Load += new System.EventHandler(this.Update_User_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNametextBox1;
        private System.Windows.Forms.RichTextBox DescriptionTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox isActive;
        private System.Windows.Forms.CheckBox isAdmin;
        private System.Windows.Forms.Button save;
    }
}
