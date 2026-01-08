namespace E_shift
{
    partial class customercompletedJobList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customercompletedJobList));
            completedjobGrid = new DataGridView();
            selectFbSelectionBtn = new Button();
            canceFbSelectionBtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)completedjobGrid).BeginInit();
            SuspendLayout();
            // 
            // completedjobGrid
            // 
            completedjobGrid.AllowUserToAddRows = false;
            completedjobGrid.AllowUserToDeleteRows = false;
            completedjobGrid.BackgroundColor = Color.White;
            completedjobGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            completedjobGrid.Location = new Point(12, 82);
            completedjobGrid.MultiSelect = false;
            completedjobGrid.Name = "completedjobGrid";
            completedjobGrid.ReadOnly = true;
            completedjobGrid.RowHeadersWidth = 51;
            completedjobGrid.Size = new Size(689, 298);
            completedjobGrid.TabIndex = 0;
            completedjobGrid.CellContentClick += completedjobGrid_CellContentClick;
            // 
            // selectFbSelectionBtn
            // 
            selectFbSelectionBtn.BackColor = Color.MediumAquamarine;
            selectFbSelectionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            selectFbSelectionBtn.ForeColor = Color.Green;
            selectFbSelectionBtn.Location = new Point(541, 404);
            selectFbSelectionBtn.Name = "selectFbSelectionBtn";
            selectFbSelectionBtn.Size = new Size(128, 49);
            selectFbSelectionBtn.TabIndex = 1;
            selectFbSelectionBtn.Text = "Select";
            selectFbSelectionBtn.UseVisualStyleBackColor = false;
            selectFbSelectionBtn.Click += selectFbSelectionBtn_Click;
            // 
            // canceFbSelectionBtn
            // 
            canceFbSelectionBtn.BackColor = Color.MediumAquamarine;
            canceFbSelectionBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            canceFbSelectionBtn.ForeColor = Color.Green;
            canceFbSelectionBtn.Location = new Point(402, 404);
            canceFbSelectionBtn.Name = "canceFbSelectionBtn";
            canceFbSelectionBtn.Size = new Size(128, 49);
            canceFbSelectionBtn.TabIndex = 1;
            canceFbSelectionBtn.Text = "Cancel";
            canceFbSelectionBtn.UseVisualStyleBackColor = false;
            canceFbSelectionBtn.Click += canceFbSelectionBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(250, 28);
            label1.TabIndex = 2;
            label1.Text = "Select Job to give feedback";
            // 
            // customercompletedJobList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(label1);
            Controls.Add(canceFbSelectionBtn);
            Controls.Add(selectFbSelectionBtn);
            Controls.Add(completedjobGrid);
            Name = "customercompletedJobList";
            Text = "customercompletedJobList";
            Load += customercompletedJobList_Load;
            ((System.ComponentModel.ISupportInitialize)completedjobGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView completedjobGrid;
        private Button selectFbSelectionBtn;
        private Button canceFbSelectionBtn;
        private Label label1;
    }
}