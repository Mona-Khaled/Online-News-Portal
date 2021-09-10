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
    public partial class ReaderReport : Form
    {
        ReaderCrystalReport CR;
        public ReaderReport()
        {
            InitializeComponent();
        }

        private void displaybtn_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;

        }

        private void ReaderReport_Load(object sender, EventArgs e)
        {
            CR = new ReaderCrystalReport();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            SupervisorForm f = new SupervisorForm();
            f.Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
