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

namespace WindowsFormsApp4
{
    public partial class Dashbord : Form
    {
        //Connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHQF0F1\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");

        public Dashbord()
        {
            InitializeComponent();
        }

        private void StudentNum_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            new students().Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            new Department().Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

            new Dashbord().Show();
            this.Hide();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            new loging().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashbord_Load(object sender, EventArgs e)
        {
            con.Open();
            string selection = "SELECT COUNT(*) as Student FROM Student_table";
            SqlCommand selectcmd = new SqlCommand(selection, con);
            Int32 count = (Int32)selectcmd.ExecuteScalar();
           label6.Text = count.ToString();
            con.Close();
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void DepartmentNum_Click(object sender, EventArgs e)
        {
            con.Open();
            string selection = "SELECT COUNT(*) as Department FROM DepartmentTb";
            SqlCommand selectcmd = new SqlCommand(selection, con);
            Int32 count = (Int32)selectcmd.ExecuteScalar();
            DepartmentNum.Text = count.ToString();
            con.Close();
        }

        private void MaleNum_Click(object sender, EventArgs e)
        {
            con.Open();
            string selection = "SELECT COUNT(*) as Student FROM Student_table";
            SqlCommand selectcmd = new SqlCommand(selection, con);
            Int32 count = (Int32)selectcmd.ExecuteScalar();
            MaleNum.Text = count.ToString();
            con.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Hide();
        }
    }
    }

