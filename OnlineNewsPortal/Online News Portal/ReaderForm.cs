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

namespace Online_News_Portal
{
    public partial class ReaderForm : Form
    {
        DataSet ds;
        OracleDataAdapter ad;
        public ReaderForm()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReaderForm_Load(object sender, EventArgs e)
        {
            

        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            string connectionstr = "Data Source = ORCL ; User Id = hr; Password = hr;";
            string cmdstr = "select C_NAME from CATEGORIES";
            ad = new OracleDataAdapter(cmdstr, connectionstr);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        //1. Select certain rows for a given value entered by the user on the form 
        private void searchbtn_Click(object sender, EventArgs e)
        {
            string connectionstr = "Data Source = ORCL ; User Id = hr; Password = hr;";
            string cmdstr = "select C_NAME , DESCRIPTION from CATEGORIES c ,NEWS n where c.CATEGORY_ID = n.CATEGORY_NO and C_NAME = :categoryName";
            ad = new OracleDataAdapter(cmdstr, connectionstr);
            ad.SelectCommand.Parameters.Add("categoryName", searchtxt.Text);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
