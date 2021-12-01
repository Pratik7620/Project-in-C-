using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class MDI_Coaching_Classes_Software : Form
    {
        

        public MDI_Coaching_Classes_Software()
        {
            InitializeComponent();
        }

        private void MDI_Coaching_Classes_Software_Load(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_New_Student obj = new Frm_New_Student();
             obj.MdiParent = this;
            obj.Show();
            
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Search_Student obj = new Frm_Search_Student();
            obj.MdiParent = this;
            obj.Show();
        }

        private void studentFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Student_Fees obj = new Frm_Student_Fees();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Course obj = new Frm_Add_Course();
            obj.MdiParent = this;
            obj.Show();
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Courses obj = new Frm_Courses();
            obj.MdiParent = this;
            obj.Show();
        }

        private void addTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Add_Teacher obj = new Frm_Add_Teacher();
            obj.MdiParent = this;
            obj.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Teacher obj = new Frm_Teacher();
            obj.MdiParent = this;
            obj.Show();
        }

        private void lbl_Logout_Click(object sender, EventArgs e)
        {
            Frm_Login_Form obj = new Frm_Login_Form();

            obj.Show();

            this.Hide();
        }

        
    
    }
}
