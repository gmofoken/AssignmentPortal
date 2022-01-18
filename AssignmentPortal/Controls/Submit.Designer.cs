
namespace AssignmentPortal.Controls
{
    partial class Submit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudQuestions = new System.Windows.Forms.NumericUpDown();
            this.lblQuestions = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuestions
            // 
            this.nudQuestions.Location = new System.Drawing.Point(299, 151);
            this.nudQuestions.Name = "nudQuestions";
            this.nudQuestions.Size = new System.Drawing.Size(284, 22);
            this.nudQuestions.TabIndex = 0;
            // 
            // lblQuestions
            // 
            this.lblQuestions.AutoSize = true;
            this.lblQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestions.Location = new System.Drawing.Point(73, 156);
            this.lblQuestions.Name = "lblQuestions";
            this.lblQuestions.Size = new System.Drawing.Size(161, 17);
            this.lblQuestions.TabIndex = 1;
            this.lblQuestions.Text = "Number of Questions";
            // 
            // btnBegin
            // 
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(299, 222);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(299, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(284, 22);
            this.txtID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "UniqueID";
            // 
            // Submit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblQuestions);
            this.Controls.Add(this.nudQuestions);
            this.Name = "Submit";
            this.Text = "Submit";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQuestions;
        private System.Windows.Forms.Label lblQuestions;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}