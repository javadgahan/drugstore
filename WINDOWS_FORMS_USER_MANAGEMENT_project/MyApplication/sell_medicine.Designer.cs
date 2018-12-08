namespace MyApplication
{
    public partial class sell_medicine
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
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Exit_tomain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicinelistbox = new System.Windows.Forms.ListBox();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.SearchMedicine = new System.Windows.Forms.Button();
            this.newamounttextbox = new System.Windows.Forms.TextBox();
            this.newpricetextBox = new System.Windows.Forms.TextBox();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.drpermission = new System.Windows.Forms.CheckBox();
            this.sell_medicinebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(391, 96);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(124, 13);
            this.linkLabel4.TabIndex = 27;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "requires permission ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(241, 96);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(93, 13);
            this.linkLabel3.TabIndex = 26;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Price in Dollars";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(159, 96);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(51, 13);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Amount";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(66, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Name";
            // 
            // Exit_tomain
            // 
            this.Exit_tomain.Location = new System.Drawing.Point(206, 306);
            this.Exit_tomain.Name = "Exit_tomain";
            this.Exit_tomain.Size = new System.Drawing.Size(164, 26);
            this.Exit_tomain.TabIndex = 23;
            this.Exit_tomain.Text = "Exit";
            this.Exit_tomain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Medicine Name";
            // 
            // Medicinelistbox
            // 
            this.Medicinelistbox.FormattingEnabled = true;
            this.Medicinelistbox.Location = new System.Drawing.Point(69, 116);
            this.Medicinelistbox.Name = "Medicinelistbox";
            this.Medicinelistbox.Size = new System.Drawing.Size(446, 121);
            this.Medicinelistbox.TabIndex = 21;
            this.Medicinelistbox.DoubleClick += new System.EventHandler(this.Medicinelistbox_DoubleClick);
            // 
            // MedicineName
            // 
            this.MedicineName.Location = new System.Drawing.Point(148, 36);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(307, 21);
            this.MedicineName.TabIndex = 20;
            // 
            // SearchMedicine
            // 
            this.SearchMedicine.Location = new System.Drawing.Point(148, 63);
            this.SearchMedicine.Name = "SearchMedicine";
            this.SearchMedicine.Size = new System.Drawing.Size(114, 23);
            this.SearchMedicine.TabIndex = 19;
            this.SearchMedicine.Text = "Search";
            this.SearchMedicine.UseVisualStyleBackColor = true;
            this.SearchMedicine.Click += new System.EventHandler(this.SearchMedicine_Click_1);
            // 
            // newamounttextbox
            // 
            this.newamounttextbox.Location = new System.Drawing.Point(148, 253);
            this.newamounttextbox.Name = "newamounttextbox";
            this.newamounttextbox.Size = new System.Drawing.Size(100, 21);
            this.newamounttextbox.TabIndex = 28;
            // 
            // newpricetextBox
            // 
            this.newpricetextBox.Location = new System.Drawing.Point(293, 253);
            this.newpricetextBox.Name = "newpricetextBox";
            this.newpricetextBox.Size = new System.Drawing.Size(100, 21);
            this.newpricetextBox.TabIndex = 29;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(173, 237);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(51, 13);
            this.linkLabel5.TabIndex = 30;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Amount";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(300, 237);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(93, 13);
            this.linkLabel6.TabIndex = 31;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Price in Dollars";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(399, 237);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(124, 13);
            this.linkLabel7.TabIndex = 33;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "requires permission ";
            // 
            // drpermission
            // 
            this.drpermission.AutoSize = true;
            this.drpermission.Location = new System.Drawing.Point(403, 257);
            this.drpermission.Name = "drpermission";
            this.drpermission.Size = new System.Drawing.Size(147, 17);
            this.drpermission.TabIndex = 34;
            this.drpermission.Text = "requiresdrpermission";
            this.drpermission.UseVisualStyleBackColor = true;
            // 
            // sell_medicinebutton
            // 
            this.sell_medicinebutton.Location = new System.Drawing.Point(390, 280);
            this.sell_medicinebutton.Name = "sell_medicinebutton";
            this.sell_medicinebutton.Size = new System.Drawing.Size(125, 23);
            this.sell_medicinebutton.TabIndex = 35;
            this.sell_medicinebutton.Text = "sell";
            this.sell_medicinebutton.UseVisualStyleBackColor = true;
            this.sell_medicinebutton.Click += new System.EventHandler(this.sell_medicinebutton_Click);
            // 
            // sell_medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 369);
            this.Controls.Add(this.sell_medicinebutton);
            this.Controls.Add(this.drpermission);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.newpricetextBox);
            this.Controls.Add(this.newamounttextbox);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit_tomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Medicinelistbox);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.SearchMedicine);
            this.Name = "sell_medicine";
            this.Text = "sellMedicine";
            this.Load += new System.EventHandler(this.sell_medicine_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Exit_tomain;
        private System.Windows.Forms.ListBox Medicinelistbox;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.Button SearchMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newamounttextbox;
        private System.Windows.Forms.TextBox newpricetextBox;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.CheckBox drpermission;
        private System.Windows.Forms.Button sell_medicinebutton;

        public string Text { get; private set; }
    }
}
