namespace E_shift
{
    partial class CustomerLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLogin));
            label1 = new Label();
            label2 = new Label();
            cusLgnBtn = new Button();
            cusSignupPgBtn = new Button();
            cusPasswordTxt = new TextBox();
            cusUsernameTxt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(350, 38);
            label1.TabIndex = 0;
            label1.Text = "Already have an account?";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(12, 259);
            label2.Name = "label2";
            label2.Size = new Size(267, 38);
            label2.TabIndex = 0;
            label2.Text = "Not registered yet?";
            // 
            // cusLgnBtn
            // 
            cusLgnBtn.BackColor = Color.MediumAquamarine;
            cusLgnBtn.FlatStyle = FlatStyle.Popup;
            cusLgnBtn.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            cusLgnBtn.ForeColor = Color.Green;
            cusLgnBtn.Location = new Point(508, 174);
            cusLgnBtn.Name = "cusLgnBtn";
            cusLgnBtn.Size = new Size(121, 40);
            cusLgnBtn.TabIndex = 1;
            cusLgnBtn.Text = "Login";
            cusLgnBtn.UseVisualStyleBackColor = false;
            cusLgnBtn.Click += cusLgnBtn_Click;
            // 
            // cusSignupPgBtn
            // 
            cusSignupPgBtn.BackColor = Color.MediumAquamarine;
            cusSignupPgBtn.FlatStyle = FlatStyle.Popup;
            cusSignupPgBtn.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            cusSignupPgBtn.ForeColor = Color.Green;
            cusSignupPgBtn.Location = new Point(508, 259);
            cusSignupPgBtn.Name = "cusSignupPgBtn";
            cusSignupPgBtn.Size = new Size(121, 40);
            cusSignupPgBtn.TabIndex = 1;
            cusSignupPgBtn.Text = "Sign up";
            cusSignupPgBtn.UseVisualStyleBackColor = false;
            cusSignupPgBtn.Click += cusSignupPgBtn_Click;
            // 
            // cusPasswordTxt
            // 
            cusPasswordTxt.BackColor = Color.Honeydew;
            cusPasswordTxt.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            cusPasswordTxt.Location = new Point(188, 164);
            cusPasswordTxt.Name = "cusPasswordTxt";
            cusPasswordTxt.PasswordChar = '*';
            cusPasswordTxt.Size = new Size(249, 50);
            cusPasswordTxt.TabIndex = 5;
            // 
            // cusUsernameTxt
            // 
            cusUsernameTxt.BackColor = Color.Honeydew;
            cusUsernameTxt.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            cusUsernameTxt.Location = new Point(188, 79);
            cusUsernameTxt.Name = "cusUsernameTxt";
            cusUsernameTxt.Size = new Size(249, 50);
            cusUsernameTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.LightSeaGreen;
            label3.Location = new Point(20, 171);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala Text", 13.8F, FontStyle.Bold);
            label4.ForeColor = Color.LightSeaGreen;
            label4.Location = new Point(20, 79);
            label4.Name = "label4";
            label4.Size = new Size(131, 31);
            label4.TabIndex = 4;
            label4.Text = "User Name";
            // 
            // CustomerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(cusPasswordTxt);
            Controls.Add(cusUsernameTxt);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(cusSignupPgBtn);
            Controls.Add(cusLgnBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerLogin";
            Text = "CustomerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button cusLgnBtn;
        private Button cusSignupPgBtn;
        private TextBox cusPasswordTxt;
        private TextBox cusUsernameTxt;
        private Label label3;
        private Label label4;
    }
}