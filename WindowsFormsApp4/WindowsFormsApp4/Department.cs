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
using System.Data.Sql;

namespace WindowsFormsApp4
{

    public partial class Department : Form
    {
        //private object con;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHQF0F1\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");

        public object DepartmentTb { get; private set; }
        public object DepartmentDataSet { get; private set; }

        public Department()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            new Dashbord().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            new students().Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            new loging().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.DepartmentTb' table. You can move, or remove it, as needed.
            //        this.departmentTbTableAdapter1.Fill(this.databaseDataSet3.DepartmentTb);
            // TODO: This line of code loads data into the 'databaseDataSet1.DepartmentTb' table. You can move, or remove it, as needed.
          
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            String dtab = Departmenttab.Text;
            String depdetail = Detailstab.Text;

            try
            {               

                //preparing Query Format
                String format = "Update itemdesc set StudenId = DepartmentName=@dtab,DepartmentDetails=@depdetail";
   
                //opening the Connection
                con.Open();
                //Converting SQL format to a SQL Command
                SqlCommand updtcmd = new SqlCommand(format, con);
                //setting values to parameters
                updtcmd.Parameters.AddWithValue("@dtaab", dtab);
                updtcmd.Parameters.AddWithValue("@depdetail", depdetail);

                int r = updtcmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Data was update succesfully !!");
                    this.departmentTbTableAdapter.Fill(this.databaseDataSet1.DepartmentTb);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error wwith Updating");
                    this.departmentTbTableAdapter.Fill(this.databaseDataSet1.DepartmentTb);

                }
                //connection closing
                con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
; }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            //Gathering user inputs
            String dtab = Departmenttab.Text;
            try
            {
                //Preparing SQL Query Format
                string Format = "Delete from DepartmentTb =@dtab";
                //opening the connection
                con.Open();
                //converting SQL query format to a SQL Command
                SqlCommand DepartmentTb = new SqlCommand(Format, con);
                DepartmentTb.Parameters.AddWithValue("@dtab", dtab);
                //executive the Query
                int r = DepartmentTb.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("item was deleted");
                    this.departmentTbTableAdapter.Fill(this.databaseDataSet1.DepartmentTb);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("no data was deleted");
                    this.departmentTbTableAdapter.Fill(this.databaseDataSet1.DepartmentTb);
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Departmenttab_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void departmentlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Detailstab_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
             //Variables declaration 

            String dname = Departmenttab.Text;
            String ddetails = Detailstab.Text;
           
            try
            {
                //Query format
                con.Open();
                string instformat = "INSERT INTO DepartmentTb VALUES(@dname,@ddtails)";

                //Converting from sql format to command 
                SqlCommand inscmd = new SqlCommand(instformat, (SqlConnection)con);

                //Values to params
                inscmd.Parameters.AddWithValue("@dname", dname);
                inscmd.Parameters.AddWithValue("@ddtails", ddetails);
               
                //Executing the command
                int intr = inscmd.ExecuteNonQuery();
                if (intr > 0)
                {
                    MessageBox.Show("Data was inserted successfully !");
                    
                }
                else
                {
                    MessageBox.Show("Error occured while inserting data ");
                }

                Departmenttab.Clear();


                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

