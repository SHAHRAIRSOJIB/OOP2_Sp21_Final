using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace week_5_lab__final_
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllCourse();
        }

        private void ShowAllCourse()
        {
            SqlConnection con = new SqlConnection(@"Server=SHAHRAIRSOJIBPC\SQLEXPRESS;Database=db_finel;Integrated Security=true;");

            if (con == null)
            {
                MessageBox.Show("Connection Failed", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();

            string query = "SELECT * FROM coures";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader data = cmd.ExecuteReader();

            List<Course> courses = new List<Course>();

            while(data.Read())
            {
                Course course = new Course();

                course.Id = data.GetInt32(data.GetOrdinal("id"));
                course.CourseName  = data.GetString(data.GetOrdinal("name"));
                course.CourseCode = data.GetString(data.GetOrdinal("code"));

                courses.Add(course);
            }

            con.Close();

            viewDetails.DataSource = courses;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string courseName = textb1.Text.Trim();
            string courseCode = textb2.Text.Trim();

            SqlConnection con = new SqlConnection(@"Server=SHAHRAIRSOJIBPC\SQLEXPRESS;Database=db_finel;Integrated Security=true;");

            if (con == null)
            {
                MessageBox.Show("Connection Failed", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();

            string query = String.Format("INSERT INTO coures VALUES('{0}', '{1}')", courseName, courseCode);

            SqlCommand cmd = new SqlCommand(query, con);
            int row = cmd.ExecuteNonQuery();

            if(row == 0)
            {
                MessageBox.Show("Insertion Failed", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }

            con.Close();

            ShowAllCourse();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ShowAllCourse();
        }
    }
}
