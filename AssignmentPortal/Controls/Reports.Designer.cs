
namespace AssignmentPortal.Controls
{
    partial class Reports
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.REPORT = new System.Windows.Forms.Label();
            this.cbxReport = new System.Windows.Forms.ComboBox();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dgvReports);
            this.pnlDashboard.Controls.Add(this.btnSearch);
            this.pnlDashboard.Controls.Add(this.REPORT);
            this.pnlDashboard.Controls.Add(this.cbxReport);
            this.pnlDashboard.Location = new System.Drawing.Point(41, 60);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1192, 627);
            this.pnlDashboard.TabIndex = 7;
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(112, 85);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.Size = new System.Drawing.Size(964, 479);
            this.dgvReports.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(533, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // REPORT
            // 
            this.REPORT.AutoSize = true;
            this.REPORT.Location = new System.Drawing.Point(109, 46);
            this.REPORT.Name = "REPORT";
            this.REPORT.Size = new System.Drawing.Size(66, 17);
            this.REPORT.TabIndex = 3;
            this.REPORT.Text = "REPORT";
            // 
            // cbxReport
            // 
            this.cbxReport.FormattingEnabled = true;
            this.cbxReport.Items.AddRange(new object[] {
            "Users",
            "Submissions",
            "Trend",
            "Exceptions"});
            this.cbxReport.Location = new System.Drawing.Point(231, 39);
            this.cbxReport.Name = "cbxReport";
            this.cbxReport.Size = new System.Drawing.Size(255, 24);
            this.cbxReport.TabIndex = 0;
            this.cbxReport.SelectedIndexChanged += new System.EventHandler(this.cbxReport_SelectedIndexChanged);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 747);
            this.Controls.Add(this.pnlDashboard);
            this.Name = "Reports";
            this.Text = "Reports";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label REPORT;
        private System.Windows.Forms.ComboBox cbxReport;
    }
}