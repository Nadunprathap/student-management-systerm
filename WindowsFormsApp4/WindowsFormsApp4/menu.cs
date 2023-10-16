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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new students().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Department().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Dashbord().Show();
            this.Hide();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {


            new students().Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
           new Department().Show();
           this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
           new Dashbord().Show();
            this.Hide();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            new loging().Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new students().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Department().Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new Dashbord().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new loging().Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
