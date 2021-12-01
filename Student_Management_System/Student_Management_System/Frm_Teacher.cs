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
    public partial class Frm_Teacher : Form
    {
        public Frm_Teacher()
        {
            InitializeComponent();
        }

        private void Frm_Teacher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teacher_Details._Teacher_Details' table. You can move, or remove it, as needed.
            this.teacher_DetailsTableAdapter.Fill(this.teacher_Details._Teacher_Details);

        }
    }
}
