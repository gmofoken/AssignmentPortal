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
    public partial class Account : Form
    {
        public Account(bool loggedIn)
        {
            InitializeComponent();

            if (loggedIn)
            {
                btnLogin.Enabled = false;
                btnRegister.Enabled = false;
            }
            else
                btnLogout.Enabled = false;
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = new Login();

            var result = login.ShowDialog();

            if (result == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register();

            var result = register.ShowDialog();

            if (result == DialogResult.OK)
            {

            }
        }
    }
}
