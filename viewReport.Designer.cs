namespace E_shift
{
    partial class viewReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewReport));
            label1 = new Label();
            label2 = new Label();
            ReportTypecomboBox = new ComboBox();
            JobStatusComboBox = new ComboBox();
            ToDateReport = new DateTimePicker();
            FromdateReport = new DateTimePicker();
            label5 = new Label();
            feedbackRatingcomboBox = new ComboBox();
            ReportdataGridView = new DataGridView();
            genarateBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            ExportBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ReportdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 12F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(379, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "Status";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala Text", 12F, FontStyle.Bold);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(26, 122);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 0;
            label2.Text = "Rating";
            // 
            // ReportTypecomboBox
            // 
            ReportTypecomboBox.FormattingEnabled = true;
            ReportTypecomboBox.Items.AddRange(new object[] { "Registered customer", "Transport Job", "Feedback" });
            ReportTypecomboBox.Location = new Point(156, 20);
            ReportTypecomboBox.Name = "ReportTypecomboBox";
            ReportTypecomboBox.Size = new Size(192, 28);
            ReportTypecomboBox.TabIndex = 1;
            ReportTypecomboBox.SelectedIndexChanged += ReportTypecomboBox_SelectedIndexChanged;
            // 
            // JobStatusComboBox
            // 
            JobStatusComboBox.FormattingEnabled = true;
            JobStatusComboBox.Items.AddRange(new object[] { "Pending", "Assigned", "In Transit", "Completed", "Cancelled" });
            JobStatusComboBox.Location = new Point(497, 20);
            JobStatusComboBox.Name = "JobStatusComboBox";
            JobStatusComboBox.Size = new Size(195, 28);
            JobStatusComboBox.TabIndex = 1;
            // 
            // ToDateReport
            // 
            ToDateReport.Location = new Point(497, 71);
            ToDateReport.Name = "ToDateReport";
            ToDateReport.Size = new Size(195, 27);
            ToDateReport.TabIndex = 2;
            // 
            // FromdateReport
            // 
            FromdateReport.Location = new Point(156, 79);
            FromdateReport.Name = "FromdateReport";
            FromdateReport.Size = new Size(192, 27);
            FromdateReport.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala Text", 12F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(26, 78);
            label5.Name = "label5";
            label5.Size = new Size(109, 28);
            label5.TabIndex = 0;
            label5.Text = "Date from";
            // 
            // feedbackRatingcomboBox
            // 
            feedbackRatingcomboBox.FormattingEnabled = true;
            feedbackRatingcomboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            feedbackRatingcomboBox.Location = new Point(156, 122);
            feedbackRatingcomboBox.Name = "feedbackRatingcomboBox";
            feedbackRatingcomboBox.Size = new Size(142, 28);
            feedbackRatingcomboBox.TabIndex = 1;
            // 
            // ReportdataGridView
            // 
            ReportdataGridView.AllowUserToAddRows = false;
            ReportdataGridView.AllowUserToDeleteRows = false;
            ReportdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportdataGridView.Location = new Point(26, 164);
            ReportdataGridView.Name = "ReportdataGridView";
            ReportdataGridView.ReadOnly = true;
            ReportdataGridView.RowHeadersWidth = 51;
            ReportdataGridView.Size = new Size(666, 241);
            ReportdataGridView.TabIndex = 3;
            // 
            // genarateBtn
            // 
            genarateBtn.BackColor = Color.Azure;
            genarateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genarateBtn.ForeColor = Color.DarkCyan;
            genarateBtn.Location = new Point(497, 122);
            genarateBtn.Name = "genarateBtn";
            genarateBtn.Size = new Size(195, 36);
            genarateBtn.TabIndex = 4;
            genarateBtn.Text = "Generate Report";
            genarateBtn.UseVisualStyleBackColor = false;
            genarateBtn.Click += genarateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 12F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(26, 16);
            label3.Name = "label3";
            label3.Size = new Size(124, 28);
            label3.TabIndex = 0;
            label3.Text = "Report type";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala Text", 12F, FontStyle.Bold);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(379, 77);
            label4.Name = "label4";
            label4.Size = new Size(40, 28);
            label4.TabIndex = 0;
            label4.Text = " To";
            label4.Click += label1_Click;
            // 
            // ExportBtn
            // 
            ExportBtn.BackColor = Color.Azure;
            ExportBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExportBtn.ForeColor = Color.DarkCyan;
            ExportBtn.Location = new Point(527, 411);
            ExportBtn.Name = "ExportBtn";
            ExportBtn.Size = new Size(165, 36);
            ExportBtn.TabIndex = 4;
            ExportBtn.Text = "Export PDF";
            ExportBtn.UseVisualStyleBackColor = false;
            ExportBtn.Click += ExportBtn_Click;
            // 
            // viewReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(ExportBtn);
            Controls.Add(genarateBtn);
            Controls.Add(ReportdataGridView);
            Controls.Add(FromdateReport);
            Controls.Add(ToDateReport);
            Controls.Add(JobStatusComboBox);
            Controls.Add(feedbackRatingcomboBox);
            Controls.Add(ReportTypecomboBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "viewReport";
            Text = "viewReport";
            ((System.ComponentModel.ISupportInitialize)ReportdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox ReportTypecomboBox;
        private ComboBox JobStatusComboBox;
        private DateTimePicker ToDateReport;
        private DateTimePicker FromdateReport;
        private Label label5;
        private ComboBox feedbackRatingcomboBox;
        private DataGridView ReportdataGridView;
        private Button genarateBtn;
        private Label label3;
        private Label label4;
        private Button ExportBtn;
    }
}