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
    public partial class students : Form
    {
        //Connection string
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GHQF0F1\SQLEXPRESS;Initial Catalog=database;Integrated Security=True");
        private object StudentDataset;

        public object Messagebox { get; private set; }

        public students()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }

        private void students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet5.Student_table' table. You can move, or remove it, as needed.
            this.student_tableTableAdapter2.Fill(this.databaseDataSet5.Student_table);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables declaration 

            String sname = textBox5.Text;
            String sid = textBox1.Text;
            String sgender = comboBox1.SelectedIndex.ToString();
            String sphone = textBox2.Text;
            String sadd = textBox3.Text;
            String sdep = comboBox2.SelectedIndex.ToString();
            String semail = textBox4.Text;

            try {

                //Query format
                con.Open();
                string instformat = "INSERT INTO Student_table VALUES(@sname,@sid,@sgender,@sphone,@sadd,@sdep,@semail);";

                //Converting from sql format to command 
                SqlCommand inscmd = new SqlCommand(instformat, con);

                //Values to params
                inscmd.Parameters.AddWithValue("@sname", sname);
                inscmd.Parameters.AddWithValue("@sid", sid);
                inscmd.Parameters.AddWithValue("@sgender", sgender);
                inscmd.Parameters.AddWithValue("@sphone", sphone);
                inscmd.Parameters.AddWithValue("@sadd", sadd);
                inscmd.Parameters.AddWithValue("@sdep", sdep);
                inscmd.Parameters.AddWithValue("@semail", semail);

                //Executing the command
                int intr = inscmd.ExecuteNonQuery();
                if (intr > 0) {
                    MessageBox.Show("Data was inserted successfully !");
                    con.Close();
                }
                else {
                    MessageBox.Show("Error occured while inserting data ");
                }
                this.student_tableTableAdapter1.Fill(this.databaseDataSet2.Student_table);                

            } 
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try {
                int sid = Int32.Parse(textBox1.Text);

                con.Open();
                string searchstmt = "SELECT * FROM Student_table where Student_ID=@sid;";
                SqlCommand searchcmd = new SqlCommand(searchstmt, con);

                searchcmd.Parameters.AddWithValue("@sid", sid);
                searchcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(searchcmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //int p = searchcmd.ExecuteNonQuery();

                textBox1.Text = dt.Rows[0][1].ToString();
                textBox2.Text = dt.Rows[0][3].ToString();
                textBox5.Text = dt.Rows[0][0].ToString();
                textBox3.Text = dt.Rows[0][4].ToString();
                textBox4.Text = dt.Rows[0][6].ToString();
                comboBox1.SelectedIndex = int.Parse(dt.Rows[0][2].ToString());
                comboBox2.SelectedIndex = int.Parse(dt.Rows[0][5].ToString());

                con.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
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

        private void label9_Click(object sender, EventArgs e)
        {
            new students().Show();
            this.Hide();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            //Variables Decalaration
            String sid = textBox1.Text;
            String sname = textBox5.Text;
            String sgender = comboBox1.SelectedIndex.ToString();
            String pnumber = textBox2.Text;
            String saddres = textBox3.Text;
            String Dep = comboBox2.SelectedIndex.ToString();
            String email = textBox4.Text;
            try
            {
                //preparing Query Format
                String format = "UPDATE Student_table SET Student_Name =@sname,Gender=@sgender,Phone_Number=@pnumber,Student_Adress=@saddres,Department=@dep,Email=@email WHERE Student_Id = @sid";

                //opening the Connection
                con.Open();
                //Converting SQL format to a SQL Command
                SqlCommand updtcmd = new SqlCommand(format, con);
                //setting values to parameters
                updtcmd.Parameters.AddWithValue("@sid", sid);
                updtcmd.Parameters.AddWithValue("@sname", sname);
                updtcmd.Parameters.AddWithValue("@sgender", sgender);
                updtcmd.Parameters.AddWithValue("@pnumber", pnumber);
                updtcmd.Parameters.AddWithValue("@saddres", saddres);
                updtcmd.Parameters.AddWithValue("@dep", Dep);
                updtcmd.Parameters.AddWithValue("@email", email);
                //Execute the command
                int r = updtcmd.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("Data was update succesfully !!");
                }
                else
                {
                    MessageBox.Show("No data was insert");                    
                }
                //connection closing
                con.Close();
                this.student_tableTableAdapter1.Fill(this.databaseDataSet2.Student_table);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Gathering user inputs
            String sid = textBox1.Text;
            try
            {
                //Preparing SQL Query Format
                string Format = "DELETE FROM Student_table WHERE Student_Id = @sid";
                //opening the connection
                con.Open();
                //converting SQL query format to a SQL Command
                SqlCommand Student_table = new SqlCommand(Format, con);
                Student_table.Parameters.AddWithValue("@sid", sid);
                //executive the Query
                int r = Student_table.ExecuteNonQuery();
                if (r > 0)
                {
                    MessageBox.Show("item was deleted");                    
                }
                else
                {
                    MessageBox.Show("no data was deleted");                           
                }
                this.student_tableTableAdapter1.Fill(this.databaseDataSet2.Student_table);
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            new menu().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void students_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

    }
   
