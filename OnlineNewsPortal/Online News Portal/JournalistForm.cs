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
    public partial class JournalistForm : Form
    {
        string ordb = "Data Source = ORCL ; User Id = hr; Password = hr;";
        OracleConnection conn;
        public JournalistForm()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }
        ///////////////////// LOADING ID AND CATEGORIES FROM DB  /////////////////////
        ////////////////////SELECT MORE ROWS WITHOUT WHERE  (COVERED POINT 1 IN CONNECTED) /////////////////////

        private void JournalistForm_Load(object sender, EventArgs e)
        {
            jourPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            label1.BackColor = Color.FromArgb(100, 0, 0, 0);
            //-------------------------------
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            //-------------------------------
            cmd.CommandText = " select NEWS_ID from NEWS ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                newsid_cmb.Items.Add(dr[0]);
            }
            dr.Close();
            //-------------------------------
            cmd.CommandText = " select CATEGORY_ID from Categories ";
            cmd.CommandType = CommandType.Text;
            OracleDataReader d = cmd.ExecuteReader();
            while (d.Read())
            {
                categoryname_cmb.Items.Add(d[0]);
            }
            d.Close();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
        ///////////////////// INSERT NEWS WITHOUT PROC (COVERED POINT 3 IN CONNECTED)  /////////////////////

        private void publishbtn_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "insert into NEWS values (:idinsert,:newdesc,:cateno)";
            cm.Parameters.Add("idinsert", newsid_cmb.Text);
            cm.Parameters.Add("newdesc", newsdes_txt.Text);
            cm.Parameters.Add("cateno", categoryname_cmb.SelectedItem);
            int n = cm.ExecuteNonQuery();
            if (n != -1)
            {
                newsid_cmb.Items.Add(newsid_cmb.Text);
                MessageBox.Show("New Post is added");
            }
        }
        ///////////////////// UPDATE NEWS WITHOUT PROC (COVERED POINT 3 IN CONNECTED)  /////////////////////

        private void updatebtn_Click(object sender, EventArgs e)
        {
            OracleCommand cmn = new OracleCommand();
            cmn.Connection = conn;
            cmn.CommandText = "update NEWS set DESCRIPTION =:desupdated ,CATEGORY_NO =:idcat where NEWS_ID=:idupdate";
            cmn.Parameters.Add("desupdated", newsdes_txt.Text);
            cmn.Parameters.Add("idcat", categoryname_cmb.SelectedItem);
            cmn.Parameters.Add("idupdate", newsid_cmb.SelectedItem.ToString());
            int rows = cmn.ExecuteNonQuery();
            if (rows != -1)
            {
                MessageBox.Show("Post modified");
            }
        }
        ///////////////////// DELETE NEWS WITHOUT PROC (COVERED POINT 3 IN CONNECTED)  /////////////////////

        private void deletebtn_Click(object sender, EventArgs e)
        {

            OracleCommand cmn = new OracleCommand();
            cmn.Connection = conn;
            cmn.CommandText = "Delete from NEWS where NEWS_ID=:id";
            cmn.Parameters.Add("id", newsid_cmb.SelectedItem.ToString());
            int rows = cmn.ExecuteNonQuery();
            if (rows != -1)
            {
                MessageBox.Show("Post deleted");
                newsid_cmb.Items.RemoveAt(newsid_cmb.SelectedIndex);
                newsdes_txt.Text = "";
                categoryname_cmb.Text = "";
            }
        }
        ///////////////////// WHEN SELECTING ID ,SHOWING ITS INFO /////////////////////
        //////////////////// SELECT MORE ROWS USING BIND VARS (COVERED POINT 2 IN CONNECTED) /////////////////////
        private void newsid_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select DESCRIPTION,CATEGORY_NO from News where NEWS_ID =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", newsid_cmb.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                newsdes_txt.Text = dr[0].ToString();
                categoryname_cmb.Text = dr[1].ToString();
            }
            dr.Close();
        }
    }
}
