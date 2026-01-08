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
    public partial class pastTRasportsCustomer : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        public pastTRasportsCustomer()
        {
            InitializeComponent();
        }

        private void pastTRasportsCustomer_Load(object sender, EventArgs e)
        {
            string query = "SELECT jobID, pickupLocation, dropLocation, jobDate, status FROM job WHERE customerID = @customerID";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerID", LoggedInCustomer.customerID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                pastJobGridView.DataSource = dt;

            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Close();
        }
    }
}
