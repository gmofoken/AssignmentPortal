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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var Logic = new Logic();

            bool result = Logic.Login(this.txtEmail.Text, this.txtPassword.Text).Result;

            if (result)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
