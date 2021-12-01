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
    public partial class Frm_New_Student : Form
    {
        string Gender;

        public Frm_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection con;

        SqlCommand comm;

        SqlDataReader dreader;

        string connstring = (@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Integrated Security=True");


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

        int Auto_Incr()
        {
            int cnt;

            con_open();

            SqlCommand cmd = new SqlCommand("select Count(Student_ID) from Student_Details", con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cnt = 1 + cnt;

            con_close();

            return cnt;
        }

        private void Frm_New_Student_Load(object sender, EventArgs e)
        {
            tb_Student_ID.Text = Convert.ToString(Auto_Incr());
            tb_Student_ID.Enabled = false;
            tb_First_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rb_Male.Checked == true)
            {
                Gender = "Male";
            }
            else
                Gender = "Female";
            con = new SqlConnection(connstring);

            con.Open();

            comm = new SqlCommand("insert into Student_Details values(" + tb_Student_ID.Text + ",'" + tb_First_Name.Text + "','" + tb_Last_Name.Text + "'," + tb_Mobile_No.Text + ",'" + Gender + "'," + tb_Fees.Text + ")", con);

            try

            {

                comm.ExecuteNonQuery();

                MessageBox.Show("Saved...");

            }

            catch (Exception)

            {

                MessageBox.Show("Not Saved");

            }

            finally

            {

                con.Close();

            }




        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        
    }
}
