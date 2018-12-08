namespace MyApplication
{
    partial class DeleteMedicine
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
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Exit_tomain = new System.Windows.Forms.Button();
            this.Delete_Medicine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicinelistbox = new System.Windows.Forms.ListBox();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.SearchMedicine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(305, 86);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Price in Dollars";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(202, 86);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Amount";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 86);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Name";
            // 
            // Exit_tomain
            // 
            this.Exit_tomain.Location = new System.Drawing.Point(286, 273);
            this.Exit_tomain.Name = "Exit_tomain";
            this.Exit_tomain.Size = new System.Drawing.Size(104, 26);
            this.Exit_tomain.TabIndex = 23;
            this.Exit_tomain.Text = "Exit";
            this.Exit_tomain.UseVisualStyleBackColor = true;
            // 
            // Delete_Medicine
            // 
            this.Delete_Medicine.Location = new System.Drawing.Point(83, 273);
            this.Delete_Medicine.Name = "Delete_Medicine";
            this.Delete_Medicine.Size = new System.Drawing.Size(114, 26);
            this.Delete_Medicine.TabIndex = 22;
            this.Delete_Medicine.Text = "Delete Medicine";
            this.Delete_Medicine.UseVisualStyleBackColor = true;
            this.Delete_Medicine.Click += new System.EventHandler(this.Delete_Medicine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medicine Name";
            // 
            // Medicinelistbox
            // 
            this.Medicinelistbox.FormattingEnabled = true;
            this.Medicinelistbox.Location = new System.Drawing.Point(83, 106);
            this.Medicinelistbox.Name = "Medicinelistbox";
            this.Medicinelistbox.Size = new System.Drawing.Size(307, 160);
            this.Medicinelistbox.TabIndex = 20;
            // 
            // MedicineName
            // 
            this.MedicineName.Location = new System.Drawing.Point(83, 11);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(307, 21);
            this.MedicineName.TabIndex = 19;
            // 
            // SearchMedicine
            // 
            this.SearchMedicine.Location = new System.Drawing.Point(83, 38);
            this.SearchMedicine.Name = "SearchMedicine";
            this.SearchMedicine.Size = new System.Drawing.Size(114, 23);
            this.SearchMedicine.TabIndex = 18;
            this.SearchMedicine.Text = "Search";
            this.SearchMedicine.UseVisualStyleBackColor = true;
            this.SearchMedicine.Click += new System.EventHandler(this.SearchMedicine_Click);
            // 
            // DeleteMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit_tomain);
            this.Controls.Add(this.Delete_Medicine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medicinelistbox);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.SearchMedicine);
            this.Name = "DeleteMedicine";
            this.Load += new System.EventHandler(this.DeleteMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Exit_tomain;
        private System.Windows.Forms.Button Delete_Medicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Medicinelistbox;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.Button SearchMedicine;
    }
}
