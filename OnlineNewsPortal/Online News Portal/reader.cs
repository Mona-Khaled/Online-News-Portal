using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace DB_project
{
    public partial class reader : Form
    {
        DataSet ds;
        OracleDataAdapter ad;
        
        public reader()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           LOGIN mm = new LOGIN();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e) //1. Select certain rows for a given value entered by the user on the form 
        {
            string connectionstr = "Data Source = ORCL ; User Id = hr; Password = hr;";
            string cmdstr = "select C_NAME , DESCRIPTION from CATEGORIES c ,NEWS n where c.CATEGORY_ID = n.CATEGORY_NO and C_NAME = :categoryName";
            ad = new OracleDataAdapter(cmdstr, connectionstr);
            ad.SelectCommand.Parameters.Add("categoryName", textBox2.Text);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstr = "Data Source = ORCL ; User Id = hr; Password = hr;";
            string cmdstr = "select C_NAME from CATEGORIES";
            ad = new OracleDataAdapter(cmdstr, connectionstr);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
