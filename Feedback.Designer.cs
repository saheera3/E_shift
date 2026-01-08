namespace E_shift
{
    partial class Feedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feedback));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            commentTxt = new TextBox();
            dateTimePickerFb = new DateTimePicker();
            rating = new GroupBox();
            rating5 = new RadioButton();
            rating4 = new RadioButton();
            rating3 = new RadioButton();
            rating2 = new RadioButton();
            rating1 = new RadioButton();
            label4 = new Label();
            jobIdFbTxt = new TextBox();
            submitBtnFb = new Button();
            cancelBtnFb = new Button();
            rating.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 13.8F);
            label1.Location = new Point(35, 90);
            label1.Name = "label1";
            label1.Size = new Size(128, 31);
            label1.TabIndex = 0;
            label1.Text = "Rate below";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 13.8F);
            label2.Location = new Point(35, 310);
            label2.Name = "label2";
            label2.Size = new Size(219, 31);
            label2.TabIndex = 0;
            label2.Text = "Comment (optional)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 13.8F);
            label3.Location = new Point(35, 422);
            label3.Name = "label3";
            label3.Size = new Size(62, 31);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // commentTxt
            // 
            commentTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            commentTxt.Location = new Point(146, 359);
            commentTxt.Name = "commentTxt";
            commentTxt.Size = new Size(439, 34);
            commentTxt.TabIndex = 1;
            // 
            // dateTimePickerFb
            // 
            dateTimePickerFb.Location = new Point(146, 426);
            dateTimePickerFb.Name = "dateTimePickerFb";
            dateTimePickerFb.Size = new Size(207, 27);
            dateTimePickerFb.TabIndex = 2;
            // 
            // rating
            // 
            rating.Controls.Add(rating5);
            rating.Controls.Add(rating4);
            rating.Controls.Add(rating3);
            rating.Controls.Add(rating2);
            rating.Controls.Add(rating1);
            rating.Location = new Point(35, 136);
            rating.Name = "rating";
            rating.Size = new Size(650, 141);
            rating.TabIndex = 3;
            rating.TabStop = false;
            rating.Text = "Rating";
            // 
            // rating5
            // 
            rating5.AutoSize = true;
            rating5.Font = new Font("Segoe UI", 12F);
            rating5.Location = new Point(200, 93);
            rating5.Name = "rating5";
            rating5.Size = new Size(206, 32);
            rating5.TabIndex = 0;
            rating5.TabStop = true;
            rating5.Text = "⭐⭐⭐⭐⭐(Excellent)";
            rating5.UseVisualStyleBackColor = true;
            // 
            // rating4
            // 
            rating4.AutoSize = true;
            rating4.Font = new Font("Segoe UI", 12F);
            rating4.Location = new Point(14, 93);
            rating4.Name = "rating4";
            rating4.Size = new Size(163, 32);
            rating4.TabIndex = 0;
            rating4.TabStop = true;
            rating4.Text = "⭐⭐⭐⭐(Good)";
            rating4.UseVisualStyleBackColor = true;
            // 
            // rating3
            // 
            rating3.AutoSize = true;
            rating3.Font = new Font("Segoe UI", 12F);
            rating3.Location = new Point(347, 37);
            rating3.Name = "rating3";
            rating3.Size = new Size(178, 32);
            rating3.TabIndex = 0;
            rating3.TabStop = true;
            rating3.Text = "⭐⭐⭐(Avereage)";
            rating3.UseVisualStyleBackColor = true;
            // 
            // rating2
            // 
            rating2.AutoSize = true;
            rating2.Font = new Font("Segoe UI", 12F);
            rating2.Location = new Point(200, 37);
            rating2.Name = "rating2";
            rating2.Size = new Size(122, 32);
            rating2.TabIndex = 0;
            rating2.TabStop = true;
            rating2.Text = "⭐⭐(poor)";
            rating2.UseVisualStyleBackColor = true;
            // 
            // rating1
            // 
            rating1.AutoSize = true;
            rating1.Font = new Font("Segoe UI", 12F);
            rating1.Location = new Point(14, 37);
            rating1.Name = "rating1";
            rating1.Size = new Size(147, 32);
            rating1.TabIndex = 0;
            rating1.TabStop = true;
            rating1.Text = "⭐(very poor)";
            rating1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 13.8F);
            label4.Location = new Point(35, 26);
            label4.Name = "label4";
            label4.Size = new Size(77, 31);
            label4.TabIndex = 0;
            label4.Text = "Job ID";
            // 
            // jobIdFbTxt
            // 
            jobIdFbTxt.Enabled = false;
            jobIdFbTxt.Location = new Point(188, 30);
            jobIdFbTxt.Name = "jobIdFbTxt";
            jobIdFbTxt.Size = new Size(125, 27);
            jobIdFbTxt.TabIndex = 4;
            // 
            // submitBtnFb
            // 
            submitBtnFb.BackColor = Color.MediumAquamarine;
            submitBtnFb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            submitBtnFb.ForeColor = Color.Green;
            submitBtnFb.Location = new Point(554, 427);
            submitBtnFb.Name = "submitBtnFb";
            submitBtnFb.Size = new Size(120, 50);
            submitBtnFb.TabIndex = 5;
            submitBtnFb.Text = "Submit";
            submitBtnFb.UseVisualStyleBackColor = false;
            submitBtnFb.Click += submitBtnFb_Click;
            // 
            // cancelBtnFb
            // 
            cancelBtnFb.BackColor = Color.MediumAquamarine;
            cancelBtnFb.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cancelBtnFb.ForeColor = Color.Green;
            cancelBtnFb.Location = new Point(417, 427);
            cancelBtnFb.Name = "cancelBtnFb";
            cancelBtnFb.Size = new Size(120, 50);
            cancelBtnFb.TabIndex = 5;
            cancelBtnFb.Text = "Cancel";
            cancelBtnFb.UseVisualStyleBackColor = false;
            cancelBtnFb.Click += cancelBtnFb_Click;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(713, 489);
            Controls.Add(cancelBtnFb);
            Controls.Add(submitBtnFb);
            Controls.Add(jobIdFbTxt);
            Controls.Add(rating);
            Controls.Add(dateTimePickerFb);
            Controls.Add(commentTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Feedback";
            Text = "Feedback";
            Load += Feedback_Load;
            rating.ResumeLayout(false);
            rating.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox commentTxt;
        private DateTimePicker dateTimePickerFb;
        private GroupBox rating;
        private Label label4;
        private RadioButton rating5;
        private RadioButton rating4;
        private RadioButton rating3;
        private RadioButton rating2;
        private RadioButton rating1;
        private TextBox jobIdFbTxt;
        private Button submitBtnFb;
        private Button cancelBtnFb;
    }
}