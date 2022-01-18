using AssignmentPortal.Models;
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
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            var answers = new List<Answers>();

            int questions = int.Parse(nudQuestions.Value.ToString());

            if (String.IsNullOrWhiteSpace(this.txtID.Text) || String.IsNullOrWhiteSpace(this.txtIdentifier.Text) || String.IsNullOrWhiteSpace(this.txtModuleCode.Text))
            {
                MessageBox.Show("Please capture all fields.");
                return;
            }

            var MCQs = new MCQs(ref answers, questions, this.txtID.Text, this.txtIdentifier.Text, this.txtModuleCode.Text);

            var result = MCQs.ShowDialog();

            if (result == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;

            this.Close();
        }

        private void txtModuleCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdentifier_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudQuestions_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
