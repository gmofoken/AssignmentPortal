using AssignmentPortal.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPortal.Controls
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void cbxReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string report = this.cbxReport.Text;
            var logic = new Logic();
            //Users response = null;

            int t = 0;

            if (report.Contains("Users"))
            {
                var response = logic.UsersReport().Result;

                var json = JArray.Parse(response);

                var obj = json.ToObject<List<Users>>();

                this.dgvReports.DataSource = obj;
            }
            else if (report.Contains("Submissions"))
            {
                var response = logic.SubmissionsReport().Result;

                var json = JArray.Parse(response);

                var obj = json.ToObject<List<Submissions>>();

                this.dgvReports.DataSource = obj;
            }
        }
    }
}
