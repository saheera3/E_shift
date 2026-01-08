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
    public partial class customercompletedJobList : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        public customercompletedJobList()
        {
            InitializeComponent();
        }

        private void customercompletedJobList_Load(object sender, EventArgs e)
        {
            try
            {
                string query = @"SELECT jobID, pickupLocation, dropLocation, jobDate
                                 FROM job
                                 WHERE customerID = @customerID
                                 AND status ='completed' 
                                 AND jobID NOT IN (SELECT jobID FROM feedback)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerID", LoggedInCustomer.customerID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    completedjobGrid.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void selectFbSelectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (completedjobGrid.SelectedRows.Count > 0)
                {
                    int selectedJobID = Convert.ToInt32(completedjobGrid.SelectedRows[0].Cells["JobID"].Value);
                    Feedback feedback = new Feedback(selectedJobID);
                    feedback.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please select job to give feedback");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void canceFbSelectionBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }

        private void completedjobGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
