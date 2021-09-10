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
    public partial class supervisor : Form
    {
        
        public supervisor()
        {
            InitializeComponent();
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            userControl21.Hide();
            LOGIN l = new LOGIN();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userControl21.Hide();
            Manage_categories l = new Manage_categories();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            userControl21.Hide();
            feedback l = new feedback();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userControl21.Hide();
            comments l = new comments();
            l.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            userControl21.Show(); 
        }

        private void supervisor_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
