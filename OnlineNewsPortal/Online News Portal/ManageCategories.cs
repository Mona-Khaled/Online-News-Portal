using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Online_News_Portal
{
    public partial class ManageCategories : UserControl
    {
        string ordb = "Data Source = ORCL ; User Id = hr; Password = hr;";
        OracleConnection conn;
        public ManageCategories()
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            InitializeComponent();
        }
        ///////////////////// GET CATEGORIES ID AND NAME FROM DB  /////////////////////
        ////////////////////SELECT MULTIPLE ROWS USING PROC  (COVERED POINT 5 IN CONNECTED) /////////////////////
        private void ManageCategories_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
            //------------------
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "GET_CATEGORYID";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("CID", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                catId_cmb.Items.Add(dr[0]);
            }
            dr.Close();
            //------------------------- 
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GET_CATEGORYNAME";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("Cname", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader d = c.ExecuteReader();
            while (d.Read())
            {
                catName_cmb.Items.Add(d[0]);
            }
            d.Close();
        }
        ///////////////////// INSERT CATRGORIES USING PROC (COVERED POINT 6 IN CONNECTED)  /////////////////////
        private void addbtn_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "INSERT_CATEGORY";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("Cid", catId_cmb.Text);
            cm.Parameters.Add("Cname", catName_cmb.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show("New Category is added");

        }
        ///////////////////// UPDATE CATRGORIES USING PROC (COVERED POINT 6 IN CONNECTED)  /////////////////////
        private void updatebtn_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "UPDATE_CATEGORY";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("CID", catId_cmb.SelectedItem);
            cm.Parameters.Add("Cname", catName_cmb.Text);
            cm.ExecuteNonQuery();
            MessageBox.Show(" Category is Updated");
        }
        ///////////////////// DELETE CATRGORIES USING PROC (COVERED POINT 6 IN CONNECTED)  /////////////////////
        private void deletebtn_Click(object sender, EventArgs e)
        {
            OracleCommand cm = new OracleCommand();
            cm.Connection = conn;
            cm.CommandText = "DELETE_CATEGORY";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("CID", catId_cmb.SelectedItem);
            cm.ExecuteNonQuery();
            MessageBox.Show(" Category is Deleted");
        }
        ///////////////////// WHEN SELECTING ID ,SHOWING ITS CATEGORIES'NAME  /////////////////////
        ////////////////////SELECT ONE ROW USING PROC  (COVERED POINT 4 IN CONNECTED) /////////////////////
        private void catName_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmdd = new OracleCommand();

            cmdd.Connection = conn;
            cmdd.CommandText = "LOAD_CATEGORYID";
            cmdd.CommandType = CommandType.StoredProcedure;

            cmdd.Parameters.Add("Cname",  catName_cmb.SelectedItem);
            cmdd.Parameters.Add("CID", catId_cmb.Text);

            cmdd.ExecuteNonQuery();
        }
    }
}
