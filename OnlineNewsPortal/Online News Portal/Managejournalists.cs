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
    public partial class Managejournalists : UserControl
    {
        DataSet ds;
        OracleDataAdapter ad;
        OracleCommandBuilder cmdBuilder;
        public Managejournalists()
        {
            InitializeComponent();
        }

        private void Managejournalists_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        //2. Select All rows from certain table 
        private void loadbtn_Click(object sender, EventArgs e)
        {
            string connectionstr = "Data Source = ORCL ; User Id = hr; Password = hr;";
            string cmdstr = "select * from JOURNALIST";
            ad = new OracleDataAdapter(cmdstr, connectionstr);
            ds = new DataSet();
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        //3. Insert, update, delete using oracle command builder 
        private void savebtn_Click(object sender, EventArgs e)
        {
            cmdBuilder = new OracleCommandBuilder(ad);
            ad.Update(ds.Tables[0]);
        }
    }
}
