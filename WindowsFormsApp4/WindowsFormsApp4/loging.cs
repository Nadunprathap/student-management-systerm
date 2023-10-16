using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class loging : Form
    {
        public loging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "password")  //this is The password and username 
            {
                MessageBox.Show("logging succesfull");// this can show logging succes massege
                this.Hide();
                menu mform = new menu();  // hide this form and open menu form
                mform.Show();


            }

            else
            {
                MessageBox.Show("The user name or password you enterd is incorrect,pleace try again");
                textBox1.Clear();
                textBox2.Clear(); // if password and user name are wrong then all clear
                textBox1.Clear();



                

            }
            }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // reset button work for clear all textboxes 
            textBox2.Clear();
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
         
          
        { 
            if (checkBox1.Checked == true)               //check box if click check bock and they show  password correctly
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();   // this picture click then form will hide

        }

        private void loging_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
