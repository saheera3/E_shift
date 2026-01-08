using System;
using System.Collections;
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
    public partial class RequestTransportJob : Form
    {
        
        public RequestTransportJob()
        {
            InitializeComponent();
        }

        private void requestSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate pickup and drop locations
                if (string.IsNullOrWhiteSpace(pickupTxt.Text) || string.IsNullOrWhiteSpace(dropTxt.Text))
                {
                    MessageBox.Show("Pickup and Drop locations are required.");
                    return;
                }

                int customerID = LoggedInCustomer.customerID;
                string pickup = pickupTxt.Text;
                string drop = dropTxt.Text;
                DateTime date = JobDateTime.Value;
                string status = "pending";

                // Prepare product list
                var products = GetProductList();
                if (products.Count == 0)
                {
                    MessageBox.Show("Enter at least one product (name and weight).");
                    return;
                }

                float totalWeight = 0;

                using (SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True"))
                {
                    conn.Open();

                    //  Insert into Job and get jobID
                    string insertJobQuery = @"INSERT INTO Job (pickupLocation, dropLocation, jobDate, customerID, status) VALUES (@pickup, @drop, @date, @customerID, @status); SELECT SCOPE_IDENTITY();";

                    int jobID;
                    using (SqlCommand cmd = new SqlCommand(insertJobQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@pickup", pickup);
                        cmd.Parameters.AddWithValue("@drop", drop);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        cmd.Parameters.AddWithValue("@status", status);

                        jobID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    //  Calculate total weight and insert products 
                    foreach (var (name, type, weight) in products)
                    {
                        totalWeight += weight;
                    }

                    // Insert into Load table with jobID and total weight
                    string insertLoadQuery = @"INSERT INTO load (jobID, [weight(kg)]) VALUES (@jobID, @weight); SELECT SCOPE_IDENTITY();";

                    int loadID;
                    using (SqlCommand cmd = new SqlCommand(insertLoadQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@jobID", jobID);
                        cmd.Parameters.AddWithValue("@weight", totalWeight);

                        loadID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    //Insert products with actual loadID
                    foreach (var (name, type, _) in products)
                    {
                        string insertProductQuery = @"INSERT INTO Product (name, Type, loadID) VALUES (@name, @type, @loadID)";

                        using (SqlCommand cmd = new SqlCommand(insertProductQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@type", type);
                            cmd.Parameters.AddWithValue("@loadID", loadID);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Job submitted successfully!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }

        }

        private List<(string name, string type, float weight)> GetProductList()
        {
            var products = new List<(string, string, float)>();

            if (!string.IsNullOrWhiteSpace(productName1Txt.Text) && !string.IsNullOrWhiteSpace(p1weightTxt.Text))
                products.Add((productName1Txt.Text, p1typeTxt.Text, float.Parse(p1weightTxt.Text)));

            if (!string.IsNullOrWhiteSpace(product2NameTxt.Text) && !string.IsNullOrWhiteSpace(p2weightTxt.Text))
                products.Add((product2NameTxt.Text, p2typeTxt.Text, float.Parse(p2weightTxt.Text)));

            if (!string.IsNullOrWhiteSpace(productName3Txt.Text) && !string.IsNullOrWhiteSpace(p3weightTxt.Text))
                products.Add((productName3Txt.Text, p3TypeTxt.Text, float.Parse(p3weightTxt.Text)));

            return products;
        }


    }
}
