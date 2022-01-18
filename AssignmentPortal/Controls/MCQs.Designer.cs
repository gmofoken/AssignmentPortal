
namespace AssignmentPortal.Controls
{
    partial class MCQs
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
            this.btnSubmitQuestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmitQuestions
            // 
            this.btnSubmitQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitQuestions.Location = new System.Drawing.Point(659, 337);
            this.btnSubmitQuestions.Name = "btnSubmitQuestions";
            this.btnSubmitQuestions.Size = new System.Drawing.Size(192, 49);
            this.btnSubmitQuestions.TabIndex = 0;
            this.btnSubmitQuestions.Text = "SUBMIT";
            this.btnSubmitQuestions.UseVisualStyleBackColor = true;
            this.btnSubmitQuestions.Click += new System.EventHandler(this.btnSubmitQuestions_Click);
            // 
            // MCQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1801, 450);
            //this.Controls.Add(this.btnSubmitQuestions);
            this.Name = "MCQs";
            this.Text = "MCQs";
            this.Load += new System.EventHandler(this.MCQs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmitQuestions;
    }
}