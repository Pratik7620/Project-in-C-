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

    public partial class Frm_Add_Teacher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VSSGCD3\SQLEXPRESS;Integrated Security=True");

        public Frm_Add_Teacher()
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

        int Auto_Incr()
        {
            int cnt;

            con_open();

            SqlCommand cmd = new SqlCommand("select Count(Teacher_ID) from Teacher_Details",con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cnt = 1 + cnt;

            con_close();

            return cnt;
        }

        void clear_controls()
        {
            tb_Teacher_ID.Text = Convert.ToString(Auto_Incr());
            cmb_Teacher_Name.Text = "";
            tb_Subject.Text = "";
            cmb_Qualification.Text = "";
            cmb_Teacher_Name.Focus();
        }

        private void Frm_Add_Teacher_Load(object sender, EventArgs e)
        {
            tb_Teacher_ID.Text = Convert.ToString(Auto_Incr());
            tb_Teacher_ID.Enabled = false;
            cmb_Teacher_Name.Focus();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con.Open();

            if (tb_Teacher_ID.Text != "" && cmb_Teacher_Name.Text != "" && tb_Subject.Text != "" && cmb_Qualification.Text != "")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Insert into Teacher_Details values (" + tb_Teacher_ID.Text + ",'" + cmb_Teacher_Name.Text + "','" + tb_Subject.Text + "','" + cmb_Qualification.Text + "')", con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                MessageBox.Show("Record Sucessfully Saved!!!");
                clear_controls();
            }
            else
            {
                MessageBox.Show("1st Fill All The Fields");
                clear_controls();

            }
            con.Close();
        }
    }
}
