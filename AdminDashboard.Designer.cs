namespace E_shift
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            Adminpanel = new Panel();
            manageDataBtn = new Button();
            LoggedInAdtxt = new TextBox();
            viewRequestBtn = new Button();
            viewReportsBtn = new Button();
            manageDataComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            viewREportToolStripMenuItem = new ToolStripMenuItem();
            manageDataToolStripMenuItem = new ToolStripMenuItem();
            manageCustomersToolStripMenuItem = new ToolStripMenuItem();
            manageJobsToolStripMenuItem = new ToolStripMenuItem();
            manageTransportUnitToolStripMenuItem = new ToolStripMenuItem();
            viewTransportRequestToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            Adminpanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Adminpanel
            // 
            Adminpanel.BackgroundImage = (Image)resources.GetObject("Adminpanel.BackgroundImage");
            Adminpanel.BackgroundImageLayout = ImageLayout.Stretch;
            Adminpanel.Controls.Add(manageDataBtn);
            Adminpanel.Controls.Add(LoggedInAdtxt);
            Adminpanel.Controls.Add(viewRequestBtn);
            Adminpanel.Controls.Add(viewReportsBtn);
            Adminpanel.Controls.Add(manageDataComboBox);
            Adminpanel.Controls.Add(label4);
            Adminpanel.Controls.Add(label3);
            Adminpanel.Controls.Add(label2);
            Adminpanel.Controls.Add(label1);
            Adminpanel.Location = new Point(1, 39);
            Adminpanel.Name = "Adminpanel";
            Adminpanel.Size = new Size(714, 452);
            Adminpanel.TabIndex = 0;
            // 
            // manageDataBtn
            // 
            manageDataBtn.BackColor = Color.PaleTurquoise;
            manageDataBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageDataBtn.ForeColor = Color.DarkCyan;
            manageDataBtn.Location = new Point(481, 200);
            manageDataBtn.Name = "manageDataBtn";
            manageDataBtn.Size = new Size(150, 41);
            manageDataBtn.TabIndex = 4;
            manageDataBtn.Text = "Manage";
            manageDataBtn.UseVisualStyleBackColor = false;
            manageDataBtn.Click += manageDataBtn_Click;
            // 
            // LoggedInAdtxt
            // 
            LoggedInAdtxt.Enabled = false;
            LoggedInAdtxt.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoggedInAdtxt.Location = new Point(78, 20);
            LoggedInAdtxt.Name = "LoggedInAdtxt";
            LoggedInAdtxt.Size = new Size(261, 31);
            LoggedInAdtxt.TabIndex = 3;
            // 
            // viewRequestBtn
            // 
            viewRequestBtn.BackColor = Color.PaleTurquoise;
            viewRequestBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            viewRequestBtn.ForeColor = Color.DarkCyan;
            viewRequestBtn.Location = new Point(481, 339);
            viewRequestBtn.Name = "viewRequestBtn";
            viewRequestBtn.Size = new Size(150, 48);
            viewRequestBtn.TabIndex = 2;
            viewRequestBtn.Text = "View request";
            viewRequestBtn.UseVisualStyleBackColor = false;
            viewRequestBtn.Click += viewRequestBtn_Click;
            // 
            // viewReportsBtn
            // 
            viewReportsBtn.BackColor = Color.PaleTurquoise;
            viewReportsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            viewReportsBtn.ForeColor = Color.DarkCyan;
            viewReportsBtn.Location = new Point(481, 119);
            viewReportsBtn.Name = "viewReportsBtn";
            viewReportsBtn.Size = new Size(150, 43);
            viewReportsBtn.TabIndex = 2;
            viewReportsBtn.Text = "View reports";
            viewReportsBtn.UseVisualStyleBackColor = false;
            viewReportsBtn.Click += viewReportsBtn_Click;
            // 
            // manageDataComboBox
            // 
            manageDataComboBox.FormattingEnabled = true;
            manageDataComboBox.Items.AddRange(new object[] { "customer", "transportUnit", "job" });
            manageDataComboBox.Location = new Point(282, 202);
            manageDataComboBox.Name = "manageDataComboBox";
            manageDataComboBox.Size = new Size(151, 28);
            manageDataComboBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala Text", 13.8F);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(78, 277);
            label4.Name = "label4";
            label4.Size = new Size(468, 31);
            label4.TabIndex = 0;
            label4.Text = "See how many new job requests are waiting!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 13.8F);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(78, 210);
            label3.Name = "label3";
            label3.Size = new Size(150, 31);
            label3.TabIndex = 0;
            label3.Text = "Manage data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala Text", 13.8F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(78, 131);
            label2.Name = "label2";
            label2.Size = new Size(298, 31);
            label2.TabIndex = 0;
            label2.Text = "To generate various Reports";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Viner Hand ITC", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSeaGreen;
            label1.Location = new Point(345, 10);
            label1.Name = "label1";
            label1.Size = new Size(191, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome back!";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MintCream;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(713, 36);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "☰Menu";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, viewREportToolStripMenuItem, manageDataToolStripMenuItem, viewTransportRequestToolStripMenuItem, logOutToolStripMenuItem });
            toolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripMenuItem1.ForeColor = Color.CadetBlue;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(99, 32);
            toolStripMenuItem1.Text = "☰Menu";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.ForeColor = Color.CadetBlue;
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(323, 32);
            homeToolStripMenuItem.Text = "Admin Dashboard";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // viewREportToolStripMenuItem
            // 
            viewREportToolStripMenuItem.ForeColor = Color.CadetBlue;
            viewREportToolStripMenuItem.Name = "viewREportToolStripMenuItem";
            viewREportToolStripMenuItem.Size = new Size(323, 32);
            viewREportToolStripMenuItem.Text = "View Report";
            viewREportToolStripMenuItem.Click += viewREportToolStripMenuItem_Click;
            // 
            // manageDataToolStripMenuItem
            // 
            manageDataToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCustomersToolStripMenuItem, manageJobsToolStripMenuItem, manageTransportUnitToolStripMenuItem });
            manageDataToolStripMenuItem.ForeColor = Color.CadetBlue;
            manageDataToolStripMenuItem.Name = "manageDataToolStripMenuItem";
            manageDataToolStripMenuItem.Size = new Size(323, 32);
            manageDataToolStripMenuItem.Text = "Manage Data";
            // 
            // manageCustomersToolStripMenuItem
            // 
            manageCustomersToolStripMenuItem.ForeColor = Color.CadetBlue;
            manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            manageCustomersToolStripMenuItem.Size = new Size(312, 32);
            manageCustomersToolStripMenuItem.Text = "manage customers";
            manageCustomersToolStripMenuItem.Click += manageCustomersToolStripMenuItem_Click;
            // 
            // manageJobsToolStripMenuItem
            // 
            manageJobsToolStripMenuItem.ForeColor = Color.CadetBlue;
            manageJobsToolStripMenuItem.Name = "manageJobsToolStripMenuItem";
            manageJobsToolStripMenuItem.Size = new Size(312, 32);
            manageJobsToolStripMenuItem.Text = "manage jobs";
            manageJobsToolStripMenuItem.Click += manageJobsToolStripMenuItem_Click;
            // 
            // manageTransportUnitToolStripMenuItem
            // 
            manageTransportUnitToolStripMenuItem.ForeColor = Color.CadetBlue;
            manageTransportUnitToolStripMenuItem.Name = "manageTransportUnitToolStripMenuItem";
            manageTransportUnitToolStripMenuItem.Size = new Size(312, 32);
            manageTransportUnitToolStripMenuItem.Text = "manage transport unit";
            manageTransportUnitToolStripMenuItem.Click += manageTransportUnitToolStripMenuItem_Click;
            // 
            // viewTransportRequestToolStripMenuItem
            // 
            viewTransportRequestToolStripMenuItem.ForeColor = Color.CadetBlue;
            viewTransportRequestToolStripMenuItem.Name = "viewTransportRequestToolStripMenuItem";
            viewTransportRequestToolStripMenuItem.Size = new Size(323, 32);
            viewTransportRequestToolStripMenuItem.Text = "View Transport Request";
            viewTransportRequestToolStripMenuItem.Click += viewTransportRequestToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.ForeColor = Color.CadetBlue;
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(323, 32);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(menuStrip1);
            Controls.Add(Adminpanel);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            Adminpanel.ResumeLayout(false);
            Adminpanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Adminpanel;
        private Button viewReportsBtn;
        private ComboBox manageDataComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem viewREportToolStripMenuItem;
        private ToolStripMenuItem manageDataToolStripMenuItem;
        private ToolStripMenuItem manageCustomersToolStripMenuItem;
        private ToolStripMenuItem manageJobsToolStripMenuItem;
        private ToolStripMenuItem manageTransportUnitToolStripMenuItem;
        private ToolStripMenuItem viewTransportRequestToolStripMenuItem;
        private Button viewRequestBtn;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TextBox LoggedInAdtxt;
        private Button manageDataBtn;
    }
}