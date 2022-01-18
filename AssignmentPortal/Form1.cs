using AssignmentPortal.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPortal
{
    public partial class mainControl : Form
    {
        public bool isLoggedIn = false;

        public mainControl()
        {
            InitializeComponent();
        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            if (isLoggedIn == false)
            {
                var login = new Login();

                var result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    isLoggedIn = true;
                    HandleLoginState();
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            var account = new Account(isLoggedIn);

            var result = account.ShowDialog();

            if (result == DialogResult.No)
            {
                isLoggedIn = false;
                HandleLoginState();
            }
            else if (result == DialogResult.OK)
            {
                isLoggedIn = true;
                HandleLoginState();
            }
        }

        private void HandleLoginState()
        {
            if (isLoggedIn)
            {
                btnReports.Enabled = true;
                btnSubmit.Enabled = true;
            }
            else
            {
                btnReports.Enabled = false;
                btnSubmit.Enabled = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var submit = new Submit();

            var result = submit.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var reports = new Reports();

            var result = reports.ShowDialog();
        }
    }
}
