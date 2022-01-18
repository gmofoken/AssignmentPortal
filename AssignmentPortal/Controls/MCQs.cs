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
    public partial class MCQs : Form
    {
        int questionsCount = 0;
        string ID = "";


        public MCQs(ref List<Answers> answers, int questions, string uniqueID)
        {
            InitializeComponent();

            questionsCount = questions;
            int count = 1;
            int position = 0;
            ID = uniqueID;

            while (count < (questions + 1))
            {
                var groupBox = new Options(count);

                this.Controls.Add(groupBox.AddGroupBox(position));
                position = position + 55;
                count++;
            }

            this.btnSubmitQuestions.Location = new System.Drawing.Point(659, position + 150);
            this.Controls.Add(this.btnSubmitQuestions);
        }

        private void MCQs_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmitQuestions_Click(object sender, EventArgs e)
        {
            var answers = new List<Answers>();

            foreach (Control control in this.Controls)
            {
                if (control.Name == "btnSubmitQuestions")
                    break;

                var row = new Answers();
                row.Question = int.Parse(control.Name.Substring(3));

                var answer = control.Name.Substring(3);
                bool check = false;
                foreach (RadioButton item in control.Controls)
                {
                    var nm = item.Name;

                    if (item.Checked)
                    {
                        row.Answer = int.Parse(item.Name.Substring(8, (item.Name.IndexOf('q') - item.Name.IndexOf('n')) - 1));
                        check = true;
                        break;
                    }
                        
                }

                if (!check)
                {
                    MessageBox.Show("Not all options selected.");
                    return;
                }

                answers.Add(row);
            }

            var submission = new Submission()
            {
                UniqueID = ID,
                Answers = answers
            };

            var logic = new Logic();
            bool result = logic.Submit(submission).Result;

            if (result)
            {
                MessageBox.Show("Submission Succesful");
                this.DialogResult = DialogResult.OK;
            }
            this.DialogResult = DialogResult.No;

            this.Close();
        }
    }
}
