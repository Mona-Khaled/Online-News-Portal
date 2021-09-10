using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Online_News_Portal
{
    public partial class NewsCrystalReport : Form
    {
        News_Report CR;
        public NewsCrystalReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, category_cmb.Text);
            CR.SetParameterValue(1, Convert.ToDateTime(textBox1.Text));
            CR.SetParameterValue(2, Convert.ToDateTime(textBox2.Text));

            crystalReportViewer1.ReportSource = CR;

        }

        private void NewsCrystalReport_Load(object sender, EventArgs e)
        {
            CR = new News_Report();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
                category_cmb.Items.Add(v.Value);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupervisorForm f = new SupervisorForm();
            f.Show();
        }
    }
}
