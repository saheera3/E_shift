namespace E_shift
{
    partial class CustomerJobListTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerJobListTrack));
            jobListToTrackGrid = new DataGridView();
            selectTrackBtn = new Button();
            label1 = new Label();
            cancelTrackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)jobListToTrackGrid).BeginInit();
            SuspendLayout();
            // 
            // jobListToTrackGrid
            // 
            jobListToTrackGrid.AllowUserToAddRows = false;
            jobListToTrackGrid.AllowUserToDeleteRows = false;
            jobListToTrackGrid.BackgroundColor = Color.White;
            jobListToTrackGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            jobListToTrackGrid.Location = new Point(12, 70);
            jobListToTrackGrid.MultiSelect = false;
            jobListToTrackGrid.Name = "jobListToTrackGrid";
            jobListToTrackGrid.ReadOnly = true;
            jobListToTrackGrid.RowHeadersWidth = 51;
            jobListToTrackGrid.Size = new Size(663, 295);
            jobListToTrackGrid.TabIndex = 0;
            // 
            // selectTrackBtn
            // 
            selectTrackBtn.BackColor = Color.MediumAquamarine;
            selectTrackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            selectTrackBtn.ForeColor = Color.Green;
            selectTrackBtn.Location = new Point(561, 408);
            selectTrackBtn.Name = "selectTrackBtn";
            selectTrackBtn.Size = new Size(114, 44);
            selectTrackBtn.TabIndex = 1;
            selectTrackBtn.Text = "Select";
            selectTrackBtn.UseVisualStyleBackColor = false;
            selectTrackBtn.Click += selectTrackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 3;
            label1.Text = "Select Job to Track";
            // 
            // cancelTrackBtn
            // 
            cancelTrackBtn.BackColor = Color.MediumAquamarine;
            cancelTrackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelTrackBtn.ForeColor = Color.Green;
            cancelTrackBtn.Location = new Point(430, 408);
            cancelTrackBtn.Name = "cancelTrackBtn";
            cancelTrackBtn.Size = new Size(114, 44);
            cancelTrackBtn.TabIndex = 1;
            cancelTrackBtn.Text = "Cancel";
            cancelTrackBtn.UseVisualStyleBackColor = false;
            cancelTrackBtn.Click += cancelTrackBtn_Click;
            // 
            // CustomerJobListTrack
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(label1);
            Controls.Add(cancelTrackBtn);
            Controls.Add(selectTrackBtn);
            Controls.Add(jobListToTrackGrid);
            Name = "CustomerJobListTrack";
            Text = "CustomerJobListTrack";
            Load += CustomerJobListTrack_Load;
            ((System.ComponentModel.ISupportInitialize)jobListToTrackGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView jobListToTrackGrid;
        private Button selectTrackBtn;
        private Label label1;
        private Button cancelTrackBtn;
    }
}