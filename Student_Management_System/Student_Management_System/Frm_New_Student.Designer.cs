namespace Student_Management_System
{
    partial class Frm_New_Student
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
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Fees = new System.Windows.Forms.TextBox();
            this.lbl_Fees = new System.Windows.Forms.Label();
            this.lbl_First_Name = new System.Windows.Forms.Label();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.tb_First_Name = new System.Windows.Forms.TextBox();
            this.tb_Last_Name = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Student_ID = new System.Windows.Forms.Label();
            this.tb_Student_ID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD NEW STUDENT";
            // 
            // btn_Reset
            // 
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Reset.Location = new System.Drawing.Point(622, 417);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 31);
            this.btn_Reset.TabIndex = 15;
            this.btn_Reset.Text = "RESET";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Save.Location = new System.Drawing.Point(212, 417);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(110, 31);
            this.btn_Save.TabIndex = 14;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Fees
            // 
            this.tb_Fees.Location = new System.Drawing.Point(734, 286);
            this.tb_Fees.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Fees.Name = "tb_Fees";
            this.tb_Fees.Size = new System.Drawing.Size(193, 26);
            this.tb_Fees.TabIndex = 7;
            // 
            // lbl_Fees
            // 
            this.lbl_Fees.AutoSize = true;
            this.lbl_Fees.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Fees.Location = new System.Drawing.Point(531, 294);
            this.lbl_Fees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fees.Name = "lbl_Fees";
            this.lbl_Fees.Size = new System.Drawing.Size(49, 20);
            this.lbl_Fees.TabIndex = 3;
            this.lbl_Fees.Text = "Fees";
            // 
            // lbl_First_Name
            // 
            this.lbl_First_Name.AutoSize = true;
            this.lbl_First_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_First_Name.Location = new System.Drawing.Point(33, 127);
            this.lbl_First_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_First_Name.Name = "lbl_First_Name";
            this.lbl_First_Name.Size = new System.Drawing.Size(98, 20);
            this.lbl_First_Name.TabIndex = 1;
            this.lbl_First_Name.Text = "FIrst Name";
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Last_Name.Location = new System.Drawing.Point(33, 209);
            this.lbl_Last_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(95, 20);
            this.lbl_Last_Name.TabIndex = 2;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Address.Location = new System.Drawing.Point(33, 292);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(75, 20);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(531, 40);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(128, 20);
            this.lbl_Mobile_No.TabIndex = 4;
            this.lbl_Mobile_No.Text = "Mobile Number";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Gender.Location = new System.Drawing.Point(531, 127);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(69, 20);
            this.lbl_Gender.TabIndex = 5;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_DOB.Location = new System.Drawing.Point(531, 209);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(115, 20);
            this.lbl_DOB.TabIndex = 6;
            this.lbl_DOB.Text = "Date Of Birth";
            // 
            // tb_First_Name
            // 
            this.tb_First_Name.Location = new System.Drawing.Point(212, 123);
            this.tb_First_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_First_Name.Name = "tb_First_Name";
            this.tb_First_Name.Size = new System.Drawing.Size(174, 26);
            this.tb_First_Name.TabIndex = 7;
            // 
            // tb_Last_Name
            // 
            this.tb_Last_Name.Location = new System.Drawing.Point(212, 205);
            this.tb_Last_Name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Last_Name.Name = "tb_Last_Name";
            this.tb_Last_Name.Size = new System.Drawing.Size(174, 26);
            this.tb_Last_Name.TabIndex = 8;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(212, 288);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(174, 26);
            this.tb_Address.TabIndex = 9;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Location = new System.Drawing.Point(734, 40);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(179, 26);
            this.tb_Mobile_No.TabIndex = 10;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Location = new System.Drawing.Point(734, 205);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(179, 26);
            this.dtp_DOB.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_Male);
            this.groupBox2.Controls.Add(this.rb_Female);
            this.groupBox2.Location = new System.Drawing.Point(735, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(178, 37);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rb_Male.Location = new System.Drawing.Point(2, 10);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(65, 24);
            this.rb_Male.TabIndex = 11;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rb_Female.Location = new System.Drawing.Point(96, 10);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(86, 24);
            this.rb_Female.TabIndex = 12;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Student_ID
            // 
            this.lbl_Student_ID.AutoSize = true;
            this.lbl_Student_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Student_ID.Location = new System.Drawing.Point(33, 46);
            this.lbl_Student_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Student_ID.Name = "lbl_Student_ID";
            this.lbl_Student_ID.Size = new System.Drawing.Size(97, 20);
            this.lbl_Student_ID.TabIndex = 15;
            this.lbl_Student_ID.Text = "Student ID";
            // 
            // tb_Student_ID
            // 
            this.tb_Student_ID.Location = new System.Drawing.Point(212, 42);
            this.tb_Student_ID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Student_ID.Name = "tb_Student_ID";
            this.tb_Student_ID.Size = new System.Drawing.Size(174, 26);
            this.tb_Student_ID.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tb_Fees);
            this.groupBox1.Controls.Add(this.tb_Student_ID);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_Fees);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.lbl_Student_ID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtp_DOB);
            this.groupBox1.Controls.Add(this.tb_Mobile_No);
            this.groupBox1.Controls.Add(this.tb_Address);
            this.groupBox1.Controls.Add(this.tb_Last_Name);
            this.groupBox1.Controls.Add(this.tb_First_Name);
            this.groupBox1.Controls.Add(this.lbl_DOB);
            this.groupBox1.Controls.Add(this.lbl_Gender);
            this.groupBox1.Controls.Add(this.lbl_Mobile_No);
            this.groupBox1.Controls.Add(this.lbl_Address);
            this.groupBox1.Controls.Add(this.lbl_Last_Name);
            this.groupBox1.Controls.Add(this.lbl_First_Name);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(9, 79);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1079, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // Frm_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1097, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_New_Student";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_New_Student_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Fees;
        private System.Windows.Forms.Label lbl_Fees;
        private System.Windows.Forms.Label lbl_First_Name;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.TextBox tb_First_Name;
        private System.Windows.Forms.TextBox tb_Last_Name;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lbl_Student_ID;
        private System.Windows.Forms.TextBox tb_Student_ID;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}