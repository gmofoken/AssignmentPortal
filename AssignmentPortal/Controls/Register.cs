using RestSharp;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var logic = new Logic();

            bool register = logic.RegisterUserAsync(this.txtEmail.Text, this.txtPassword.Text).Result;
            
            if (register)
            {
                MessageBox.Show("User Created");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public void RegisterNew() 
        {
            var logic = new Logic();

            logic.GetUsersAsync();
        }
    }
}
