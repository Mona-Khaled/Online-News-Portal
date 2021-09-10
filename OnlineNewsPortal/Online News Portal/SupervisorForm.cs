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
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            manageCategories1.Hide();
            managejournalists1.Hide();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void roundbuttons3_Click(object sender, EventArgs e)
        {
            managejournalists1.Hide();
            manageCategories1.Show();
        }

        private void journalistbtn_Click(object sender, EventArgs e)
        {
            manageCategories1.Hide();
            managejournalists1.Show();

        }

        private void roundbuttons1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewsCrystalReport f = new NewsCrystalReport();
            f.Show();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void readerbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderReport f = new ReaderReport();
            f.Show();
        }

        private void commentsbtn_Click(object sender, EventArgs e)
        {

        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {

        }

        private void managejournalists1_Load(object sender, EventArgs e)
        {

        }
    }
}
