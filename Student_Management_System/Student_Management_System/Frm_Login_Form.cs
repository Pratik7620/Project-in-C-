using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    public partial class Frm_Login_Form : Form
    {
        SqlConnection con =new SqlConnection(@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Integrated Security=True");

        public Frm_Login_Form()
        {
            InitializeComponent();
        }
        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        void con_close()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void Frm_Login_Form_Load(object sender, EventArgs e)
        {
            tb_Username.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();

            SqlCommand cmd = new SqlCommand("select count(*) from Login where Username = '" + tb_Username.Text + "' And Password = '" + tb_Password.Text + "'", con);

            if (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Login Successful !!!");

                MDI_Coaching_Classes_Software obj = new MDI_Coaching_Classes_Software();

                obj.Show();

                this.Hide();
            }
            else
            {
               MessageBox.Show("Invalid Username And Password");
            }
            tb_Username.Text = "";
            tb_Password.Text = "";
           // tb_Password.Enabled = false;
           // btn_Save.Enabled = false;
            tb_Username.Focus();
            con_close();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }
    }
}

       

     
 
