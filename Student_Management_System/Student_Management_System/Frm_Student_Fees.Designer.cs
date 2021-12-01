namespace Student_Management_System
{
    partial class Frm_Student_Fees
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Student_Id = new System.Windows.Forms.TextBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.lbl_Student_Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Add_Fee = new System.Windows.Forms.TextBox();
            this.cmb_Course_Name = new System.Windows.Forms.ComboBox();
            this.tb_Paid_Fee = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Addres = new System.Windows.Forms.TextBox();
            this.tb_Last_Name = new System.Windows.Forms.TextBox();
            this.tb_First_Name = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Add_Fee = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_paid_fee = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Last_Name = new System.Windows.Forms.Label();
            this.lbl_First_Name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(359, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "STUDENT FEES";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tb_Student_Id);
            this.groupBox1.Controls.Add(this.btn_View);
            this.groupBox1.Controls.Add(this.lbl_Student_Id);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(14, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(946, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay Fees";
            // 
            // tb_Student_Id
            // 
            this.tb_Student_Id.Location = new System.Drawing.Point(323, 49);
            this.tb_Student_Id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Student_Id.Name = "tb_Student_Id";
            this.tb_Student_Id.Size = new System.Drawing.Size(114, 24);
            this.tb_Student_Id.TabIndex = 1;
            this.tb_Student_Id.TextChanged += new System.EventHandler(this.tb_Student_Id_TextChanged);
            // 
            // btn_View
            // 
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Location = new System.Drawing.Point(545, 41);
            this.btn_View.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(90, 40);
            this.btn_View.TabIndex = 2;
            this.btn_View.Text = "VIEW";
            this.btn_View.UseVisualStyleBackColor = true;
            // 
            // lbl_Student_Id
            // 
            this.lbl_Student_Id.AutoSize = true;
            this.lbl_Student_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Student_Id.Location = new System.Drawing.Point(120, 50);
            this.lbl_Student_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Student_Id.Name = "lbl_Student_Id";
            this.lbl_Student_Id.Size = new System.Drawing.Size(97, 20);
            this.lbl_Student_Id.TabIndex = 0;
            this.lbl_Student_Id.Text = "Student ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.tb_Add_Fee);
            this.groupBox2.Controls.Add(this.cmb_Course_Name);
            this.groupBox2.Controls.Add(this.tb_Paid_Fee);
            this.groupBox2.Controls.Add(this.tb_Mobile_No);
            this.groupBox2.Controls.Add(this.tb_Addres);
            this.groupBox2.Controls.Add(this.tb_Last_Name);
            this.groupBox2.Controls.Add(this.tb_First_Name);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.lbl_Add_Fee);
            this.groupBox2.Controls.Add(this.lbl_Course_Name);
            this.groupBox2.Controls.Add(this.lbl_paid_fee);
            this.groupBox2.Controls.Add(this.lbl_Mobile_No);
            this.groupBox2.Controls.Add(this.lbl_Address);
            this.groupBox2.Controls.Add(this.lbl_Last_Name);
            this.groupBox2.Controls.Add(this.lbl_First_Name);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(14, 197);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(946, 410);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Fees Details";
            // 
            // tb_Add_Fee
            // 
            this.tb_Add_Fee.Location = new System.Drawing.Point(705, 181);
            this.tb_Add_Fee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Add_Fee.Name = "tb_Add_Fee";
            this.tb_Add_Fee.Size = new System.Drawing.Size(174, 26);
            this.tb_Add_Fee.TabIndex = 11;
            // 
            // cmb_Course_Name
            // 
            this.cmb_Course_Name.FormattingEnabled = true;
            this.cmb_Course_Name.Location = new System.Drawing.Point(705, 108);
            this.cmb_Course_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Course_Name.Name = "cmb_Course_Name";
            this.cmb_Course_Name.Size = new System.Drawing.Size(174, 28);
            this.cmb_Course_Name.TabIndex = 8;
            // 
            // tb_Paid_Fee
            // 
            this.tb_Paid_Fee.Location = new System.Drawing.Point(705, 45);
            this.tb_Paid_Fee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Paid_Fee.Name = "tb_Paid_Fee";
            this.tb_Paid_Fee.Size = new System.Drawing.Size(174, 26);
            this.tb_Paid_Fee.TabIndex = 7;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Location = new System.Drawing.Point(221, 258);
            this.tb_Mobile_No.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(168, 26);
            this.tb_Mobile_No.TabIndex = 6;
            // 
            // tb_Addres
            // 
            this.tb_Addres.Location = new System.Drawing.Point(221, 177);
            this.tb_Addres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Addres.Name = "tb_Addres";
            this.tb_Addres.Size = new System.Drawing.Size(168, 26);
            this.tb_Addres.TabIndex = 5;
            // 
            // tb_Last_Name
            // 
            this.tb_Last_Name.Location = new System.Drawing.Point(221, 111);
            this.tb_Last_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Last_Name.Name = "tb_Last_Name";
            this.tb_Last_Name.Size = new System.Drawing.Size(168, 26);
            this.tb_Last_Name.TabIndex = 4;
            // 
            // tb_First_Name
            // 
            this.tb_First_Name.Location = new System.Drawing.Point(221, 45);
            this.tb_First_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_First_Name.Name = "tb_First_Name";
            this.tb_First_Name.Size = new System.Drawing.Size(168, 26);
            this.tb_First_Name.TabIndex = 3;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Red;
            this.btn_Add.Location = new System.Drawing.Point(448, 322);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 40);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "ADD";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // lbl_Add_Fee
            // 
            this.lbl_Add_Fee.AutoSize = true;
            this.lbl_Add_Fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Fee.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Add_Fee.Location = new System.Drawing.Point(524, 183);
            this.lbl_Add_Fee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Add_Fee.Name = "lbl_Add_Fee";
            this.lbl_Add_Fee.Size = new System.Drawing.Size(77, 20);
            this.lbl_Add_Fee.TabIndex = 0;
            this.lbl_Add_Fee.Text = "Add Fee";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Course_Name.Location = new System.Drawing.Point(524, 115);
            this.lbl_Course_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(117, 20);
            this.lbl_Course_Name.TabIndex = 0;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_paid_fee
            // 
            this.lbl_paid_fee.AutoSize = true;
            this.lbl_paid_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paid_fee.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_paid_fee.Location = new System.Drawing.Point(524, 49);
            this.lbl_paid_fee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_paid_fee.Name = "lbl_paid_fee";
            this.lbl_paid_fee.Size = new System.Drawing.Size(80, 20);
            this.lbl_paid_fee.TabIndex = 0;
            this.lbl_paid_fee.Text = "Paid Fee";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(40, 262);
            this.lbl_Mobile_No.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(128, 20);
            this.lbl_Mobile_No.TabIndex = 0;
            this.lbl_Mobile_No.Text = "Mobile Number";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Address.Location = new System.Drawing.Point(40, 181);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(66, 20);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Addres";
            // 
            // lbl_Last_Name
            // 
            this.lbl_Last_Name.AutoSize = true;
            this.lbl_Last_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Last_Name.Location = new System.Drawing.Point(41, 115);
            this.lbl_Last_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Last_Name.Name = "lbl_Last_Name";
            this.lbl_Last_Name.Size = new System.Drawing.Size(95, 20);
            this.lbl_Last_Name.TabIndex = 0;
            this.lbl_Last_Name.Text = "Last Name";
            // 
            // lbl_First_Name
            // 
            this.lbl_First_Name.AutoSize = true;
            this.lbl_First_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_First_Name.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_First_Name.Location = new System.Drawing.Point(40, 49);
            this.lbl_First_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_First_Name.Name = "lbl_First_Name";
            this.lbl_First_Name.Size = new System.Drawing.Size(96, 20);
            this.lbl_First_Name.TabIndex = 0;
            this.lbl_First_Name.Text = "First Name";
            // 
            // Frm_Student_Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(971, 618);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Student_Fees";
            this.Text = "Frm_Student_Fees";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Student_Id;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Label lbl_Student_Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Add_Fee;
        private System.Windows.Forms.ComboBox cmb_Course_Name;
        private System.Windows.Forms.TextBox tb_Paid_Fee;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_Addres;
        private System.Windows.Forms.TextBox tb_Last_Name;
        private System.Windows.Forms.TextBox tb_First_Name;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Add_Fee;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_paid_fee;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Last_Name;
        private System.Windows.Forms.Label lbl_First_Name;
    }
}