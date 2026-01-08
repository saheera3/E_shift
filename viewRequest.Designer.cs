namespace E_shift
{
    partial class viewRequest
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
            requestJobDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            jobUpdateBtn = new Button();
            groupBox2 = new GroupBox();
            transportUnitUptadeBtn = new Button();
            availableTunitDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)requestJobDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availableTunitDataGrid).BeginInit();
            SuspendLayout();
            // 
            // requestJobDataGridView
            // 
            requestJobDataGridView.AllowUserToDeleteRows = false;
            requestJobDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestJobDataGridView.Location = new Point(3, 26);
            requestJobDataGridView.Name = "requestJobDataGridView";
            requestJobDataGridView.RowHeadersWidth = 51;
            requestJobDataGridView.Size = new Size(336, 319);
            requestJobDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(jobUpdateBtn);
            groupBox1.Controls.Add(requestJobDataGridView);
            groupBox1.Location = new Point(5, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(354, 450);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Job request";
            // 
            // jobUpdateBtn
            // 
            jobUpdateBtn.BackColor = Color.LightCyan;
            jobUpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jobUpdateBtn.ForeColor = Color.DarkCyan;
            jobUpdateBtn.Location = new Point(170, 377);
            jobUpdateBtn.Name = "jobUpdateBtn";
            jobUpdateBtn.Size = new Size(157, 38);
            jobUpdateBtn.TabIndex = 1;
            jobUpdateBtn.Text = "Update";
            jobUpdateBtn.UseVisualStyleBackColor = false;
            jobUpdateBtn.Click += jobUpdateBtn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(transportUnitUptadeBtn);
            groupBox2.Controls.Add(availableTunitDataGrid);
            groupBox2.Location = new Point(365, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 450);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Available transport unit";
            // 
            // transportUnitUptadeBtn
            // 
            transportUnitUptadeBtn.BackColor = Color.LightCyan;
            transportUnitUptadeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transportUnitUptadeBtn.ForeColor = Color.DarkCyan;
            transportUnitUptadeBtn.Location = new Point(179, 377);
            transportUnitUptadeBtn.Name = "transportUnitUptadeBtn";
            transportUnitUptadeBtn.Size = new Size(157, 38);
            transportUnitUptadeBtn.TabIndex = 1;
            transportUnitUptadeBtn.Text = "Update";
            transportUnitUptadeBtn.UseVisualStyleBackColor = false;
            transportUnitUptadeBtn.Click += transportUnitUptadeBtn_Click;
            // 
            // availableTunitDataGrid
            // 
            availableTunitDataGrid.AllowUserToDeleteRows = false;
            availableTunitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            availableTunitDataGrid.Location = new Point(6, 26);
            availableTunitDataGrid.Name = "availableTunitDataGrid";
            availableTunitDataGrid.RowHeadersWidth = 51;
            availableTunitDataGrid.Size = new Size(342, 319);
            availableTunitDataGrid.TabIndex = 0;
            // 
            // viewRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 489);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "viewRequest";
            Text = "viewRequest";
            Load += viewRequest_Load;
            ((System.ComponentModel.ISupportInitialize)requestJobDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)availableTunitDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView requestJobDataGridView;
        private GroupBox groupBox1;
        private Button jobUpdateBtn;
        private GroupBox groupBox2;
        private Button transportUnitUptadeBtn;
        private DataGridView availableTunitDataGrid;
    }
}