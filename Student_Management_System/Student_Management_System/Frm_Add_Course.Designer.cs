namespace Student_Management_System
{
    partial class Frm_Add_Course
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
            this.cmb_Course_Name = new System.Windows.Forms.ComboBox();
            this.tb_Fees = new System.Windows.Forms.TextBox();
            this.tb_Course_ID = new System.Windows.Forms.TextBox();
            this.cmb_Time_Duration = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Time_Duration = new System.Windows.Forms.Label();
            this.lbl_Fees = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.lbl_Course_ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.cmb_Course_Name);
            this.groupBox1.Controls.Add(this.tb_Fees);
            this.groupBox1.Controls.Add(this.tb_Course_ID);
            this.groupBox1.Controls.Add(this.cmb_Time_Duration);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.lbl_Time_Duration);
            this.groupBox1.Controls.Add(this.lbl_Fees);
            this.groupBox1.Controls.Add(this.lbl_Course_Name);
            this.groupBox1.Controls.Add(this.lbl_Course_ID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(14, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(958, 491);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Course";
            // 
            // cmb_Course_Name
            // 
            this.cmb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course_Name.FormattingEnabled = true;
            this.cmb_Course_Name.Items.AddRange(new object[] {
            "C",
            "CPP",
            "HTML",
            "CSS",
            "JAVASCRIPT",
            "REACT",
            "NODE.JS",
            "MYSQL",
            "JAVA",
            "PYTHON",
            "DS",
            "C# .NET",
            "ASP.NET"});
            this.cmb_Course_Name.Location = new System.Drawing.Point(522, 134);
            this.cmb_Course_Name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Course_Name.Name = "cmb_Course_Name";
            this.cmb_Course_Name.Size = new System.Drawing.Size(224, 30);
            this.cmb_Course_Name.TabIndex = 2;
            // 
            // tb_Fees
            // 
            this.tb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fees.Location = new System.Drawing.Point(522, 217);
            this.tb_Fees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Fees.MaxLength = 10;
            this.tb_Fees.Name = "tb_Fees";
            this.tb_Fees.Size = new System.Drawing.Size(224, 28);
            this.tb_Fees.TabIndex = 3;
            // 
            // tb_Course_ID
            // 
            this.tb_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_ID.Location = new System.Drawing.Point(522, 48);
            this.tb_Course_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Course_ID.MaxLength = 5;
            this.tb_Course_ID.Name = "tb_Course_ID";
            this.tb_Course_ID.Size = new System.Drawing.Size(224, 28);
            this.tb_Course_ID.TabIndex = 1;
            // 
            // cmb_Time_Duration
            // 
            this.cmb_Time_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Time_Duration.FormattingEnabled = true;
            this.cmb_Time_Duration.Items.AddRange(new object[] {
            "1  MONTH",
            "2  MONTH",
            "3  MONTH",
            "5  MONTH",
            "7  MONTH",
            "9  MONTH",
            "10  MONTH",
            "1  YEAR"});
            this.cmb_Time_Duration.Location = new System.Drawing.Point(522, 301);
            this.cmb_Time_Duration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_Time_Duration.Name = "cmb_Time_Duration";
            this.cmb_Time_Duration.Size = new System.Drawing.Size(224, 30);
            this.cmb_Time_Duration.TabIndex = 4;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Red;
            this.btn_Save.Location = new System.Drawing.Point(382, 404);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 40);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Time_Duration
            // 
            this.lbl_Time_Duration.AutoSize = true;
            this.lbl_Time_Duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time_Duration.ForeColor = System.Drawing.Color.Red;
            this.lbl_Time_Duration.Location = new System.Drawing.Point(212, 307);
            this.lbl_Time_Duration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Time_Duration.Name = "lbl_Time_Duration";
            this.lbl_Time_Duration.Size = new System.Drawing.Size(141, 24);
            this.lbl_Time_Duration.TabIndex = 12;
            this.lbl_Time_Duration.Text = "Time Duration";
            // 
            // lbl_Fees
            // 
            this.lbl_Fees.AutoSize = true;
            this.lbl_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fees.ForeColor = System.Drawing.Color.Red;
            this.lbl_Fees.Location = new System.Drawing.Point(212, 221);
            this.lbl_Fees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fees.Name = "lbl_Fees";
            this.lbl_Fees.Size = new System.Drawing.Size(57, 24);
            this.lbl_Fees.TabIndex = 9;
            this.lbl_Fees.Text = "Fees";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course_Name.Location = new System.Drawing.Point(212, 141);
            this.lbl_Course_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(138, 24);
            this.lbl_Course_Name.TabIndex = 8;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // lbl_Course_ID
            // 
            this.lbl_Course_ID.AutoSize = true;
            this.lbl_Course_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_ID.ForeColor = System.Drawing.Color.Red;
            this.lbl_Course_ID.Location = new System.Drawing.Point(212, 52);
            this.lbl_Course_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Course_ID.Name = "lbl_Course_ID";
            this.lbl_Course_ID.Size = new System.Drawing.Size(102, 24);
            this.lbl_Course_ID.TabIndex = 6;
            this.lbl_Course_ID.Text = "Course ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(378, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD COURSE";
            // 
            // Frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(985, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Add_Course";
            this.Text = "Frm_Add_Course";
            this.Load += new System.EventHandler(this.Frm_Add_Course_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Course_Name;
        private System.Windows.Forms.TextBox tb_Fees;
        private System.Windows.Forms.TextBox tb_Course_ID;
        private System.Windows.Forms.ComboBox cmb_Time_Duration;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Time_Duration;
        private System.Windows.Forms.Label lbl_Fees;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Label lbl_Course_ID;
    }
}