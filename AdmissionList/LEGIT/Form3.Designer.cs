namespace LEGIT
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Middleinitial = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Phonenumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Emailadd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Emergency = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Zipcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Completeadd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admission Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // Fname
            // 
            this.Fname.AccessibleDescription = "Name";
            this.Fname.Location = new System.Drawing.Point(73, 141);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(194, 35);
            this.Fname.TabIndex = 2;
            // 
            // Middleinitial
            // 
            this.Middleinitial.AccessibleDescription = "Name";
            this.Middleinitial.Location = new System.Drawing.Point(289, 141);
            this.Middleinitial.Multiline = true;
            this.Middleinitial.Name = "Middleinitial";
            this.Middleinitial.Size = new System.Drawing.Size(194, 35);
            this.Middleinitial.TabIndex = 3;
            // 
            // Lastname
            // 
            this.Lastname.AccessibleDescription = "Name";
            this.Lastname.Location = new System.Drawing.Point(505, 141);
            this.Lastname.Multiline = true;
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(194, 35);
            this.Lastname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Middle Initial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Birth Date";
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(72, 278);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(190, 20);
            this.Birthday.TabIndex = 9;
            this.Birthday.Value = new System.DateTime(2024, 7, 14, 18, 15, 32, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Gender";
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(321, 278);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 17);
            this.male.TabIndex = 11;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(390, 278);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Female";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone Number";
            // 
            // Phonenumber
            // 
            this.Phonenumber.AccessibleDescription = "Name";
            this.Phonenumber.Location = new System.Drawing.Point(504, 266);
            this.Phonenumber.Multiline = true;
            this.Phonenumber.Name = "Phonenumber";
            this.Phonenumber.Size = new System.Drawing.Size(194, 35);
            this.Phonenumber.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Email Address";
            // 
            // Emailadd
            // 
            this.Emailadd.AccessibleDescription = "Name";
            this.Emailadd.Location = new System.Drawing.Point(73, 365);
            this.Emailadd.Multiline = true;
            this.Emailadd.Name = "Emailadd";
            this.Emailadd.Size = new System.Drawing.Size(194, 35);
            this.Emailadd.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Complete Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Emergency Contact";
            // 
            // Emergency
            // 
            this.Emergency.AccessibleDescription = "Name";
            this.Emergency.Location = new System.Drawing.Point(72, 454);
            this.Emergency.Multiline = true;
            this.Emergency.Name = "Emergency";
            this.Emergency.Size = new System.Drawing.Size(194, 35);
            this.Emergency.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(500, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 25);
            this.label12.TabIndex = 22;
            this.label12.Text = "Zip Code";
            // 
            // Zipcode
            // 
            this.Zipcode.AccessibleDescription = "Name";
            this.Zipcode.Location = new System.Drawing.Point(505, 365);
            this.Zipcode.Multiline = true;
            this.Zipcode.Name = "Zipcode";
            this.Zipcode.Size = new System.Drawing.Size(193, 35);
            this.Zipcode.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Completeadd
            // 
            this.Completeadd.AccessibleDescription = "Name";
            this.Completeadd.Location = new System.Drawing.Point(288, 365);
            this.Completeadd.Multiline = true;
            this.Completeadd.Name = "Completeadd";
            this.Completeadd.Size = new System.Drawing.Size(195, 35);
            this.Completeadd.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 536);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zipcode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Emergency);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Completeadd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Emailadd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Phonenumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Middleinitial);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "First Name";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Middleinitial;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Phonenumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Emailadd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Emergency;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Zipcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Completeadd;
    }
}