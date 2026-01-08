namespace E_shift
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            customerDashboardToolStripMenuItem = new ToolStripMenuItem();
            requestTransportJobToolStripMenuItem = new ToolStripMenuItem();
            trackTransportToolStripMenuItem = new ToolStripMenuItem();
            giveFeedbackToolStripMenuItem = new ToolStripMenuItem();
            viewPastTransportsToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            RequestJobBtn = new Button();
            feedbackBtn = new Button();
            customerPanel = new Panel();
            loggedCusNameTxt = new TextBox();
            menuStrip1.SuspendLayout();
            customerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightCyan;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(713, 36);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerDashboardToolStripMenuItem, requestTransportJobToolStripMenuItem, trackTransportToolStripMenuItem, giveFeedbackToolStripMenuItem, viewPastTransportsToolStripMenuItem, logOutToolStripMenuItem });
            menuToolStripMenuItem.ForeColor = Color.ForestGreen;
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(99, 32);
            menuToolStripMenuItem.Text = "☰Menu";
            // 
            // customerDashboardToolStripMenuItem
            // 
            customerDashboardToolStripMenuItem.ForeColor = Color.ForestGreen;
            customerDashboardToolStripMenuItem.Name = "customerDashboardToolStripMenuItem";
            customerDashboardToolStripMenuItem.Size = new Size(305, 32);
            customerDashboardToolStripMenuItem.Text = "Customer Dashboard";
            customerDashboardToolStripMenuItem.Click += customerDashboardToolStripMenuItem_Click;
            // 
            // requestTransportJobToolStripMenuItem
            // 
            requestTransportJobToolStripMenuItem.ForeColor = Color.Green;
            requestTransportJobToolStripMenuItem.Name = "requestTransportJobToolStripMenuItem";
            requestTransportJobToolStripMenuItem.Size = new Size(305, 32);
            requestTransportJobToolStripMenuItem.Text = "Request transport job";
            requestTransportJobToolStripMenuItem.Click += requestTransportJobToolStripMenuItem_Click;
            // 
            // trackTransportToolStripMenuItem
            // 
            trackTransportToolStripMenuItem.ForeColor = Color.Green;
            trackTransportToolStripMenuItem.Name = "trackTransportToolStripMenuItem";
            trackTransportToolStripMenuItem.Size = new Size(305, 32);
            trackTransportToolStripMenuItem.Text = "Track transport";
            trackTransportToolStripMenuItem.Click += trackTransportToolStripMenuItem_Click;
            // 
            // giveFeedbackToolStripMenuItem
            // 
            giveFeedbackToolStripMenuItem.ForeColor = Color.Green;
            giveFeedbackToolStripMenuItem.Name = "giveFeedbackToolStripMenuItem";
            giveFeedbackToolStripMenuItem.Size = new Size(305, 32);
            giveFeedbackToolStripMenuItem.Text = "Give feedback";
            giveFeedbackToolStripMenuItem.Click += giveFeedbackToolStripMenuItem_Click;
            // 
            // viewPastTransportsToolStripMenuItem
            // 
            viewPastTransportsToolStripMenuItem.ForeColor = Color.Green;
            viewPastTransportsToolStripMenuItem.Name = "viewPastTransportsToolStripMenuItem";
            viewPastTransportsToolStripMenuItem.Size = new Size(305, 32);
            viewPastTransportsToolStripMenuItem.Text = "View past transports";
            viewPastTransportsToolStripMenuItem.Click += viewPastTransportsToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.ForeColor = Color.ForestGreen;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(305, 32);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(262, 11);
            label1.Name = "label1";
            label1.Size = new Size(439, 45);
            label1.TabIndex = 1;
            label1.Text = "Welcome back to E-shift logistics";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(1, 225);
            label2.Name = "label2";
            label2.Size = new Size(414, 28);
            label2.TabIndex = 1;
            label2.Text = "What you think of your last transport job?";
            // 
            // RequestJobBtn
            // 
            RequestJobBtn.BackColor = Color.MediumAquamarine;
            RequestJobBtn.FlatStyle = FlatStyle.Popup;
            RequestJobBtn.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RequestJobBtn.ForeColor = Color.Green;
            RequestJobBtn.Location = new Point(193, 102);
            RequestJobBtn.Name = "RequestJobBtn";
            RequestJobBtn.Size = new Size(280, 53);
            RequestJobBtn.TabIndex = 2;
            RequestJobBtn.Text = "Request transport Job";
            RequestJobBtn.UseVisualStyleBackColor = false;
            RequestJobBtn.Click += RequestJobBtn_Click;
            // 
            // feedbackBtn
            // 
            feedbackBtn.BackColor = Color.MediumAquamarine;
            feedbackBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feedbackBtn.ForeColor = Color.Green;
            feedbackBtn.Location = new Point(461, 224);
            feedbackBtn.Name = "feedbackBtn";
            feedbackBtn.Size = new Size(155, 37);
            feedbackBtn.TabIndex = 2;
            feedbackBtn.Text = "Give feedback";
            feedbackBtn.UseVisualStyleBackColor = false;
            feedbackBtn.Click += feedbackBtn_Click;
            // 
            // customerPanel
            // 
            customerPanel.BackgroundImage = (Image)resources.GetObject("customerPanel.BackgroundImage");
            customerPanel.BackgroundImageLayout = ImageLayout.Stretch;
            customerPanel.Controls.Add(loggedCusNameTxt);
            customerPanel.Controls.Add(label1);
            customerPanel.Controls.Add(feedbackBtn);
            customerPanel.Controls.Add(label2);
            customerPanel.Controls.Add(RequestJobBtn);
            customerPanel.Location = new Point(0, 39);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(713, 451);
            customerPanel.TabIndex = 3;
            // 
            // loggedCusNameTxt
            // 
            loggedCusNameTxt.BackColor = SystemColors.Window;
            loggedCusNameTxt.Enabled = false;
            loggedCusNameTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loggedCusNameTxt.ForeColor = Color.CadetBlue;
            loggedCusNameTxt.Location = new Point(3, 12);
            loggedCusNameTxt.Name = "loggedCusNameTxt";
            loggedCusNameTxt.Size = new Size(244, 34);
            loggedCusNameTxt.TabIndex = 3;
            // 
            // CustomerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(customerPanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustomerDashboard";
            Text = "CustomerDashboard";
            FormClosing += CustomerDashboard_FormClosing;
            Load += CustomerDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            customerPanel.ResumeLayout(false);
            customerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private Button RequestJobBtn;
        private Button feedbackBtn;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem requestTransportJobToolStripMenuItem;
        private ToolStripMenuItem trackTransportToolStripMenuItem;
        private ToolStripMenuItem giveFeedbackToolStripMenuItem;
        private ToolStripMenuItem viewPastTransportsToolStripMenuItem;
        private ToolStripMenuItem customerDashboardToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TextBox loggedCusNameTxt;
        public Panel customerPanel;
    }
}