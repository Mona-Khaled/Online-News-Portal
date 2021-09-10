using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_project
{
    public partial class journalist : Form
    {
        public journalist()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN mm = new LOGIN();
            mm.Show();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            userControl11.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            userControl11.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void journalist_Load(object sender, EventArgs e)
        {
           
            userControl11.Hide();
        }

        private void journalist_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Conn
        }

        private void userControl21_Load_1(object sender, EventArgs e)
        {

        }
    }
}
