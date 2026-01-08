using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace E_shift
{
    public partial class Feedback : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        private int jobID;
        public Feedback(int jobFromSelection)
        {
            InitializeComponent();
            jobID = jobFromSelection;

        }

        private void Feedback_Load(object sender, EventArgs e)
        {

            jobIdFbTxt.Text = jobID.ToString();
            rating1.Tag = 1;
            rating2.Tag = 2;
            rating3.Tag = 3;
            rating4.Tag = 4;
            rating5.Tag = 5;
        }
        CustomerDashboard customerDashboard = new CustomerDashboard();
        private void submitBtnFb_Click(object sender, EventArgs e)
        {


            try
            {
                //get selected rating from radiobutton using tag
                int ratingValue = 0;
                foreach (Control control in rating.Controls)
                {
                    if (control is RadioButton radio && radio.Checked)
                    {
                        ratingValue = (int)radio.Tag!;
                        break;
                    }
                }
                if (ratingValue == 0)
                {
                    MessageBox.Show("Please select a rating before submitting");
                }
                int customerID = LoggedInCustomer.customerID;
                int jobID = int.Parse(jobIdFbTxt.Text);
                string comment = commentTxt.Text;
                DateTime feedbackDate = dateTimePickerFb.Value.Date;


                conn.Open();
                string query = "INSERT INTO feedback(customerID, jobID, rating, comment,feedbackDate)" +
                              "VALUES (@customerID, @jobID, @rating, @comment, @feedbackDate)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@jobID", jobID);
                    cmd.Parameters.AddWithValue("@rating", ratingValue);
                    cmd.Parameters.AddWithValue("@comment", comment);
                    cmd.Parameters.AddWithValue("@feedbackDate", feedbackDate);


                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Feedback submitted successfully");
                        customerDashboard.Show();
                        this.Hide();
                        
                        
                    }
                    else
                    {
                        MessageBox.Show("Could not submit the feedback");
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtnFb_Click(object sender, EventArgs e)
        {
            customerDashboard.Show();
            this.Close();

        }
    }
}
