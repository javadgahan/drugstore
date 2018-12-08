namespace MyApplication
{
    partial class AddMedicine
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
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exitapp_button3 = new System.Windows.Forms.Button();
            this.ResetMedicineinfo_button2 = new System.Windows.Forms.Button();
            this.Medicineprice_textBox3 = new System.Windows.Forms.TextBox();
            this.Medicineamount_textBox2 = new System.Windows.Forms.TextBox();
            this.Medicinename_textBox1 = new System.Windows.Forms.TextBox();
            this.Addmedicine_button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(127, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.EnabledChanged += new System.EventHandler(this.checkBox1_EnabledChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "medicine Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(10, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "medicine Amount";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Requires Dr permit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "medicine Name";
            // 
            // Exitapp_button3
            // 
            this.Exitapp_button3.Location = new System.Drawing.Point(289, 209);
            this.Exitapp_button3.Name = "Exitapp_button3";
            this.Exitapp_button3.Size = new System.Drawing.Size(47, 23);
            this.Exitapp_button3.TabIndex = 6;
            this.Exitapp_button3.Text = "Exit";
            this.Exitapp_button3.UseVisualStyleBackColor = true;
            // 
            // ResetMedicineinfo_button2
            // 
            this.ResetMedicineinfo_button2.Location = new System.Drawing.Point(223, 209);
            this.ResetMedicineinfo_button2.Name = "ResetMedicineinfo_button2";
            this.ResetMedicineinfo_button2.Size = new System.Drawing.Size(47, 23);
            this.ResetMedicineinfo_button2.TabIndex = 5;
            this.ResetMedicineinfo_button2.Text = "Reset";
            this.ResetMedicineinfo_button2.UseVisualStyleBackColor = true;
            // 
            // Medicineprice_textBox3
            // 
            this.Medicineprice_textBox3.Location = new System.Drawing.Point(127, 113);
            this.Medicineprice_textBox3.Name = "Medicineprice_textBox3";
            this.Medicineprice_textBox3.Size = new System.Drawing.Size(225, 21);
            this.Medicineprice_textBox3.TabIndex = 3;
            // 
            // Medicineamount_textBox2
            // 
            this.Medicineamount_textBox2.Location = new System.Drawing.Point(127, 68);
            this.Medicineamount_textBox2.Name = "Medicineamount_textBox2";
            this.Medicineamount_textBox2.Size = new System.Drawing.Size(225, 21);
            this.Medicineamount_textBox2.TabIndex = 2;
            // 
            // Medicinename_textBox1
            // 
            this.Medicinename_textBox1.Location = new System.Drawing.Point(127, 31);
            this.Medicinename_textBox1.Name = "Medicinename_textBox1";
            this.Medicinename_textBox1.Size = new System.Drawing.Size(225, 21);
            this.Medicinename_textBox1.TabIndex = 1;
            // 
            // Addmedicine_button1
            // 
            this.Addmedicine_button1.Location = new System.Drawing.Point(111, 209);
            this.Addmedicine_button1.Name = "Addmedicine_button1";
            this.Addmedicine_button1.Size = new System.Drawing.Size(97, 23);
            this.Addmedicine_button1.TabIndex = 0;
            this.Addmedicine_button1.Text = "Add Medicine";
            this.Addmedicine_button1.UseVisualStyleBackColor = true;
            this.Addmedicine_button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.BackgroundImage = global::MyApplication.Properties.Resources.Drugstore_1024x6831;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(377, 269);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitapp_button3);
            this.Controls.Add(this.ResetMedicineinfo_button2);
            this.Controls.Add(this.Medicineprice_textBox3);
            this.Controls.Add(this.Medicineamount_textBox2);
            this.Controls.Add(this.Medicinename_textBox1);
            this.Controls.Add(this.Addmedicine_button1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "AddMedicine";
            this.Text = "Adding Medicine";
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Addmedicine_button1;
        private System.Windows.Forms.TextBox Medicinename_textBox1;
        private System.Windows.Forms.TextBox Medicineamount_textBox2;
        private System.Windows.Forms.TextBox Medicineprice_textBox3;
        private System.Windows.Forms.Button ResetMedicineinfo_button2;
        private System.Windows.Forms.Button Exitapp_button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
