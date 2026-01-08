namespace E_shift
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            UserNameAdTxt = new TextBox();
            passwordAdTxt = new TextBox();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(57, 76);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(57, 168);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 0;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkSlateGray;
            button1.Location = new Point(463, 264);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserNameAdTxt
            // 
            UserNameAdTxt.BackColor = Color.Honeydew;
            UserNameAdTxt.Font = new Font("Segoe UI", 12F);
            UserNameAdTxt.Location = new Point(280, 69);
            UserNameAdTxt.Name = "UserNameAdTxt";
            UserNameAdTxt.Size = new Size(293, 34);
            UserNameAdTxt.TabIndex = 2;
            // 
            // passwordAdTxt
            // 
            passwordAdTxt.BackColor = Color.Honeydew;
            passwordAdTxt.Font = new Font("Segoe UI", 12F);
            passwordAdTxt.Location = new Point(280, 161);
            passwordAdTxt.Name = "passwordAdTxt";
            passwordAdTxt.PasswordChar = '*';
            passwordAdTxt.Size = new Size(293, 34);
            passwordAdTxt.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.PaleTurquoise;
            cancelBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelBtn.ForeColor = Color.DarkSlateGray;
            cancelBtn.Location = new Point(280, 264);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(110, 41);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(passwordAdTxt);
            Controls.Add(UserNameAdTxt);
            Controls.Add(cancelBtn);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "AdminLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox UserNameAdTxt;
        private TextBox passwordAdTxt;
        private Button cancelBtn;
    }
}