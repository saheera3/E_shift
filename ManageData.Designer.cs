namespace E_shift
{
    partial class ManageData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageData));
            ManagedataGridView = new DataGridView();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ManagedataGridView).BeginInit();
            SuspendLayout();
            // 
            // ManagedataGridView
            // 
            ManagedataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ManagedataGridView.Location = new Point(12, 12);
            ManagedataGridView.Name = "ManagedataGridView";
            ManagedataGridView.RowHeadersWidth = 51;
            ManagedataGridView.Size = new Size(689, 335);
            ManagedataGridView.TabIndex = 0;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.LightCyan;
            deleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.DarkCyan;
            deleteBtn.Location = new Point(227, 365);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(135, 49);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.LightCyan;
            updateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.DarkCyan;
            updateBtn.Location = new Point(391, 365);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(135, 49);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.LightCyan;
            addBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.DarkCyan;
            addBtn.Location = new Point(552, 365);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(135, 49);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // ManageData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(addBtn);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(ManagedataGridView);
            Name = "ManageData";
            Text = "ManageData";
            Load += ManageData_Load;
            ((System.ComponentModel.ISupportInitialize)ManagedataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ManagedataGridView;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
    }
}