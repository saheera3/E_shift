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
    public partial class CustomerJobListTrack : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        public CustomerJobListTrack()
        {
            InitializeComponent();
        }

        private void CustomerJobListTrack_Load(object sender, EventArgs e)
        {
            string query = "SELECT jobID, pickupLocation, dropLocation, jobDate, status FROM job WHERE customerID = @customerID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerID", LoggedInCustomer.customerID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                jobListToTrackGrid.DataSource = dt;
                jobListToTrackGrid.Columns["status"]!.Visible = false;
            }

        }

        private void selectTrackBtn_Click(object sender, EventArgs e)
        {
            if (jobListToTrackGrid.SelectedRows.Count > 0)
            {
                string? status = jobListToTrackGrid.SelectedRows[0].Cells["status"].Value!.ToString();
                MessageBox.Show($"Selected Job is currently'{status}'", "Job Status");

            }
            else
            {
                MessageBox.Show("Please select job to track");
            }
        }

        private void cancelTrackBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Close();
        }
    }
}
