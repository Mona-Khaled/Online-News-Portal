using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_News_Portal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loginPanel.BackColor = Color.FromArgb(100,0,0,0);
           // panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm Re = new RegisterForm();
            Re.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (reader.Checked == true && supervisor.Checked == false && journalist.Checked == false)
            {
                this.Hide();
                ReaderForm R = new ReaderForm();
                R.Show();
            }
            if (reader.Checked == false && supervisor.Checked == true && journalist.Checked == false)
            {
                this.Hide();
                SupervisorForm S = new SupervisorForm();
                S.Show();
            }
            if (reader.Checked == false && supervisor.Checked == false && journalist.Checked == true)
            {
                this.Hide();
                JournalistForm J = new JournalistForm();
                J.Show();
            }
        }
    }
}
