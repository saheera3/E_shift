namespace E_shift
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            customerLgnPgBtn = new Button();
            adminLgnPgBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumAquamarine;
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(334, 35);
            label1.TabIndex = 0;
            label1.Text = "TRANSPORT SERVICE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(215, 68);
            label2.Name = "label2";
            label2.Size = new Size(237, 27);
            label2.TabIndex = 1;
            label2.Text = "E_Shift Logistics";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(174, 136);
            label3.Name = "label3";
            label3.Size = new Size(333, 29);
            label3.TabIndex = 2;
            label3.Text = "Welcome! to our Transport service system";
            // 
            // customerLgnPgBtn
            // 
            customerLgnPgBtn.BackColor = Color.MediumAquamarine;
            customerLgnPgBtn.BackgroundImageLayout = ImageLayout.Zoom;
            customerLgnPgBtn.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold);
            customerLgnPgBtn.ForeColor = Color.Green;
            customerLgnPgBtn.Image = (Image)resources.GetObject("customerLgnPgBtn.Image");
            customerLgnPgBtn.ImageAlign = ContentAlignment.MiddleLeft;
            customerLgnPgBtn.Location = new Point(152, 213);
            customerLgnPgBtn.Name = "customerLgnPgBtn";
            customerLgnPgBtn.Size = new Size(311, 62);
            customerLgnPgBtn.TabIndex = 3;
            customerLgnPgBtn.Text = "Customer LOGIN/ Sign UP";
            customerLgnPgBtn.UseVisualStyleBackColor = false;
            customerLgnPgBtn.Click += customerLgnPgBtn_Click;
            // 
            // adminLgnPgBtn
            // 
            adminLgnPgBtn.BackColor = Color.MediumAquamarine;
            adminLgnPgBtn.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Bold);
            adminLgnPgBtn.ForeColor = Color.Green;
            adminLgnPgBtn.Image = (Image)resources.GetObject("adminLgnPgBtn.Image");
            adminLgnPgBtn.ImageAlign = ContentAlignment.MiddleLeft;
            adminLgnPgBtn.Location = new Point(200, 295);
            adminLgnPgBtn.Name = "adminLgnPgBtn";
            adminLgnPgBtn.Size = new Size(215, 59);
            adminLgnPgBtn.TabIndex = 4;
            adminLgnPgBtn.Text = "Admin Login";
            adminLgnPgBtn.UseVisualStyleBackColor = false;
            adminLgnPgBtn.Click += adminLgnPgBtn_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(adminLgnPgBtn);
            Controls.Add(customerLgnPgBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "E_shift Logistics";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button customerLgnPgBtn;
        private Button adminLgnPgBtn;
    }
}
