namespace E_shift
{
    partial class pastTRasportsCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pastTRasportsCustomer));
            pastJobGridView = new DataGridView();
            backBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pastJobGridView).BeginInit();
            SuspendLayout();
            // 
            // pastJobGridView
            // 
            pastJobGridView.AllowUserToAddRows = false;
            pastJobGridView.AllowUserToDeleteRows = false;
            pastJobGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pastJobGridView.Location = new Point(21, 12);
            pastJobGridView.Name = "pastJobGridView";
            pastJobGridView.ReadOnly = true;
            pastJobGridView.RowHeadersWidth = 51;
            pastJobGridView.Size = new Size(653, 333);
            pastJobGridView.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.LightCyan;
            backBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backBtn.ForeColor = Color.DarkCyan;
            backBtn.Location = new Point(483, 351);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(168, 51);
            backBtn.TabIndex = 1;
            backBtn.Text = "OK";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // pastTRasportsCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(backBtn);
            Controls.Add(pastJobGridView);
            Name = "pastTRasportsCustomer";
            Text = "pastTRasportsCustomer";
            Load += pastTRasportsCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)pastJobGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView pastJobGridView;
        private Button backBtn;
    }
}