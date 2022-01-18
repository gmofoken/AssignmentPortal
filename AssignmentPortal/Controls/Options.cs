using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentPortal.Controls
{
    public class Options
    {
        int question = 0;

        public System.Windows.Forms.GroupBox AddGroupBox(int position)
        {
            var gbQ = new System.Windows.Forms.GroupBox();

            gbQ.Controls.Add(this.rbOption5);
            gbQ.Controls.Add(this.rbOption4);
            gbQ.Controls.Add(this.rbOption3);
            gbQ.Controls.Add(this.rbOption2);
            gbQ.Controls.Add(this.rbOption1);
            gbQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gbQ.Location = new System.Drawing.Point(288, 122 + position);
            gbQ.Name = "gbQ" + question;
            gbQ.Size = new System.Drawing.Size(864, 50);
            gbQ.TabIndex = 1;
            gbQ.TabStop = false;
            gbQ.Text = "Question " + question;

            return gbQ;
        }



        public Options(int q)
        {
            question = q;

            this.rbOption1 = new System.Windows.Forms.RadioButton();
            this.rbOption2 = new System.Windows.Forms.RadioButton();
            this.rbOption3 = new System.Windows.Forms.RadioButton();
            this.rbOption4 = new System.Windows.Forms.RadioButton();
            this.rbOption5 = new System.Windows.Forms.RadioButton();

            // 
            // rbOption1
            // 
            this.rbOption1.AutoSize = true;
            this.rbOption1.Location = new System.Drawing.Point(126, 21);
            this.rbOption1.Name = "rbOption1q" + question;
            this.rbOption1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOption1.Size = new System.Drawing.Size(38, 21);
            this.rbOption1.TabIndex = 0;
            this.rbOption1.TabStop = true;
            this.rbOption1.Text = "1";
            this.rbOption1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            this.rbOption2.AutoSize = true;
            this.rbOption2.Location = new System.Drawing.Point(289, 21);
            this.rbOption2.Name = "rbOption2q" + question;
            this.rbOption2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOption2.Size = new System.Drawing.Size(38, 21);
            this.rbOption2.TabIndex = 1;
            this.rbOption2.TabStop = true;
            this.rbOption2.Text = "2";
            this.rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            this.rbOption3.AutoSize = true;
            this.rbOption3.Location = new System.Drawing.Point(470, 21);
            this.rbOption3.Name = "rbOption3q" + question;
            this.rbOption3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOption3.Size = new System.Drawing.Size(38, 21);
            this.rbOption3.TabIndex = 2;
            this.rbOption3.TabStop = true;
            this.rbOption3.Text = "3";
            this.rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            this.rbOption4.AutoSize = true;
            this.rbOption4.Location = new System.Drawing.Point(636, 21);
            this.rbOption4.Name = "rbOption4q" + question;
            this.rbOption4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOption4.Size = new System.Drawing.Size(38, 21);
            this.rbOption4.TabIndex = 3;
            this.rbOption4.TabStop = true;
            this.rbOption4.Text = "4";
            this.rbOption4.UseVisualStyleBackColor = true;
            // 
            // rbOption5
            // 
            this.rbOption5.AutoSize = true;
            this.rbOption5.Location = new System.Drawing.Point(803, 21);
            this.rbOption5.Name = "rbOption5q" + question;
            this.rbOption5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbOption5.Size = new System.Drawing.Size(38, 21);
            this.rbOption5.TabIndex = 4;
            this.rbOption5.TabStop = true;
            this.rbOption5.Text = "5";
            this.rbOption5.UseVisualStyleBackColor = true;
        }

        private System.Windows.Forms.RadioButton rbOption5;
        private System.Windows.Forms.RadioButton rbOption4;
        private System.Windows.Forms.RadioButton rbOption3;
        private System.Windows.Forms.RadioButton rbOption2;
        private System.Windows.Forms.RadioButton rbOption1;
    }
}
