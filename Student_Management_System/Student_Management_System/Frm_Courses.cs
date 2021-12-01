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
    public partial class Frm_Courses : Form
    {
        public Frm_Courses()
        {
            InitializeComponent();
        }

        private void Frm_Courses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_Details._Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this.course_Details._Course_Details);

        }
    }
}
