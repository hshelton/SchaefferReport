namespace TimeCard
{
    partial class TimeDisplayForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DayReportObjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TodaysDateLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EnrollLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DayReportObjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DayReportObjectBindingSource
            // 
            this.DayReportObjectBindingSource.DataSource = typeof(TimeCard.DayReportObject);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.74667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.25333F));
            this.tableLayoutPanel1.Controls.Add(this.TodaysDateLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TitleLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EmployeeNameLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EnrollLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.09091F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1875, 88);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TodaysDateLabel
            // 
            this.TodaysDateLabel.AutoSize = true;
            this.TodaysDateLabel.Location = new System.Drawing.Point(3, 0);
            this.TodaysDateLabel.Name = "TodaysDateLabel";
            this.TodaysDateLabel.Size = new System.Drawing.Size(35, 13);
            this.TodaysDateLabel.TabIndex = 0;
            this.TodaysDateLabel.Text = "label1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(767, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(307, 24);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "PAY PERIOD TIMECARD REPORT";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.CausesValidation = false;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(767, 30);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.EmployeeNameLabel.TabIndex = 3;
            this.EmployeeNameLabel.Text = "Name";
            // 
            // EnrollLabel
            // 
            this.EnrollLabel.AutoSize = true;
            this.EnrollLabel.Location = new System.Drawing.Point(3, 30);
            this.EnrollLabel.Name = "EnrollLabel";
            this.EnrollLabel.Size = new System.Drawing.Size(73, 13);
            this.EnrollLabel.TabIndex = 4;
            this.EnrollLabel.Text = "Enroll Number";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.reportViewer1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 120);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1875, 407);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DayReportObjectBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TimeCard.EmployeeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(918, 306);
            this.reportViewer1.TabIndex = 0;
            // 
            // TimeDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2168, 603);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TimeDisplayForm";
            this.Text = "View Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DayReportObjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TodaysDateLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EnrollLabel;
        private System.Windows.Forms.BindingSource DayReportObjectBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

