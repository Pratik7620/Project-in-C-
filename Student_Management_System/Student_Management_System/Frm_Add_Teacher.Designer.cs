namespace Student_Management_System
{
    partial class Frm_Add_Teacher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Teacher_Name = new System.Windows.Forms.ComboBox();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.tb_Teacher_ID = new System.Windows.Forms.TextBox();
            this.cmb_Qualification = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.lbl_Subject = new System.Windows.Forms.Label();
            this.lbl_Teacher_Name = new System.Windows.Forms.Label();
            this.lbl_Teacher_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cmb_Teacher_Name);
            this.groupBox1.Controls.Add(this.tb_Subject);
            this.groupBox1.Controls.Add(this.tb_Teacher_ID);
            this.groupBox1.Controls.Add(this.cmb_Qualification);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_Qualification);
            this.groupBox1.Controls.Add(this.lbl_Subject);
            this.groupBox1.Controls.Add(this.lbl_Teacher_Name);
            this.groupBox1.Controls.Add(this.lbl_Teacher_ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(10, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(958, 483);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Teacher";
            // 
            // cmb_Teacher_Name
            // 
            this.cmb_Teacher_Name.FormattingEnabled = true;
            this.cmb_Teacher_Name.Items.AddRange(new object[] {
            "Pratik .P",
            "Jayram.P",
            "Sanket.P",
            "Akash.M",
            "Shubham.M",
            "Shraddha.B",
            "Prajakta.K",
            "Pratiksha.P"});
            this.cmb_Teacher_Name.Location = new System.Drawing.Point(533, 132);
            this.cmb_Teacher_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Teacher_Name.Name = "cmb_Teacher_Name";
            this.cmb_Teacher_Name.Size = new System.Drawing.Size(224, 28);
            this.cmb_Teacher_Name.TabIndex = 2;
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(533, 214);
            this.tb_Subject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Subject.MaxLength = 10;
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(224, 26);
            this.tb_Subject.TabIndex = 3;
            // 
            // tb_Teacher_ID
            // 
            this.tb_Teacher_ID.Location = new System.Drawing.Point(533, 46);
            this.tb_Teacher_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Teacher_ID.MaxLength = 5;
            this.tb_Teacher_ID.Name = "tb_Teacher_ID";
            this.tb_Teacher_ID.Size = new System.Drawing.Size(224, 26);
            this.tb_Teacher_ID.TabIndex = 1;
            // 
            // cmb_Qualification
            // 
            this.cmb_Qualification.FormattingEnabled = true;
            this.cmb_Qualification.Items.AddRange(new object[] {
            "10th ",
            "12th",
            "Bsc",
            "BSc-CS",
            "MCA",
            "BCA",
            "Diploma",
            "M-tech",
            "B-tech"});
            this.cmb_Qualification.Location = new System.Drawing.Point(533, 298);
            this.cmb_Qualification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Qualification.Name = "cmb_Qualification";
            this.cmb_Qualification.Size = new System.Drawing.Size(224, 28);
            this.cmb_Qualification.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Location = new System.Drawing.Point(394, 401);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 40);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Location = new System.Drawing.Point(224, 305);
            this.lbl_Qualification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(109, 20);
            this.lbl_Qualification.TabIndex = 12;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // lbl_Subject
            // 
            this.lbl_Subject.AutoSize = true;
            this.lbl_Subject.Location = new System.Drawing.Point(224, 219);
            this.lbl_Subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Subject.Name = "lbl_Subject";
            this.lbl_Subject.Size = new System.Drawing.Size(70, 20);
            this.lbl_Subject.TabIndex = 9;
            this.lbl_Subject.Text = "Subject";
            // 
            // lbl_Teacher_Name
            // 
            this.lbl_Teacher_Name.AutoSize = true;
            this.lbl_Teacher_Name.Location = new System.Drawing.Point(224, 138);
            this.lbl_Teacher_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Teacher_Name.Name = "lbl_Teacher_Name";
            this.lbl_Teacher_Name.Size = new System.Drawing.Size(125, 20);
            this.lbl_Teacher_Name.TabIndex = 8;
            this.lbl_Teacher_Name.Text = "Teacher Name";
            // 
            // lbl_Teacher_ID
            // 
            this.lbl_Teacher_ID.AutoSize = true;
            this.lbl_Teacher_ID.Location = new System.Drawing.Point(224, 50);
            this.lbl_Teacher_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Teacher_ID.Name = "lbl_Teacher_ID";
            this.lbl_Teacher_ID.Size = new System.Drawing.Size(98, 20);
            this.lbl_Teacher_ID.TabIndex = 6;
            this.lbl_Teacher_ID.Text = "Teacher ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(387, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD TEACHER";
            // 
            // Frm_Add_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(991, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Add_Teacher";
            this.Text = "Frm_Add_Teacher";
            this.Load += new System.EventHandler(this.Frm_Add_Teacher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.TextBox tb_Teacher_ID;
        private System.Windows.Forms.ComboBox cmb_Qualification;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Label lbl_Subject;
        private System.Windows.Forms.Label lbl_Teacher_Name;
        private System.Windows.Forms.Label lbl_Teacher_ID;
        private System.Windows.Forms.ComboBox cmb_Teacher_Name;
    }
}