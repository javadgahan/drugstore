namespace MyApplication
{
    partial class Medicine_List
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
            this.Exit_tomain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicinelistbox = new System.Windows.Forms.ListBox();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.SearchMedicine = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Exit_tomain
            // 
            this.Exit_tomain.Location = new System.Drawing.Point(170, 297);
            this.Exit_tomain.Name = "Exit_tomain";
            this.Exit_tomain.Size = new System.Drawing.Size(164, 26);
            this.Exit_tomain.TabIndex = 11;
            this.Exit_tomain.Text = "Exit";
            this.Exit_tomain.UseVisualStyleBackColor = true;
            this.Exit_tomain.Click += new System.EventHandler(this.Exit_tomain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Medicine Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Medicinelistbox
            // 
            this.Medicinelistbox.FormattingEnabled = true;
            this.Medicinelistbox.Location = new System.Drawing.Point(33, 131);
            this.Medicinelistbox.Name = "Medicinelistbox";
            this.Medicinelistbox.Size = new System.Drawing.Size(446, 160);
            this.Medicinelistbox.TabIndex = 8;
            this.Medicinelistbox.SelectedIndexChanged += new System.EventHandler(this.Medicinelistbox_SelectedIndexChanged);
            // 
            // MedicineName
            // 
            this.MedicineName.Location = new System.Drawing.Point(112, 27);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(307, 21);
            this.MedicineName.TabIndex = 7;
            this.MedicineName.TextChanged += new System.EventHandler(this.MedicineName_TextChanged);
            // 
            // SearchMedicine
            // 
            this.SearchMedicine.Location = new System.Drawing.Point(112, 54);
            this.SearchMedicine.Name = "SearchMedicine";
            this.SearchMedicine.Size = new System.Drawing.Size(114, 23);
            this.SearchMedicine.TabIndex = 6;
            this.SearchMedicine.Text = "Search";
            this.SearchMedicine.UseVisualStyleBackColor = true;
            this.SearchMedicine.Click += new System.EventHandler(this.SearchMedicine_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(30, 111);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Name";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(123, 111);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Amount";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(205, 111);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 17;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Price in Dollars";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(355, 111);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(124, 13);
            this.linkLabel4.TabIndex = 18;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "requires permission ";
            // 
            // Medicine_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(510, 384);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit_tomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medicinelistbox);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.SearchMedicine);
            this.Name = "Medicine_List";
            this.Load += new System.EventHandler(this.Medicine_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit_tomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Medicinelistbox;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.Button SearchMedicine;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
    }
}
