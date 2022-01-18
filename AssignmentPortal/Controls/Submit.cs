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

            var MCQs = new MCQs(ref answers, questions, this.txtID.Text);

            var result = MCQs.ShowDialog();

            if (result == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
            else
                this.DialogResult = DialogResult.No;

            this.Close();
        }
    }
}
