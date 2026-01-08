using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Data.SqlClient;



namespace E_shift
{
    public partial class CustomerLogin : Form
    {

        public CustomerLogin()
        {
            InitializeComponent();
        }

        //declared and initialized the connection
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cusLgnBtn_Click(object sender, EventArgs e)
        {
            string username = cusUsernameTxt.Text.Trim();
            string password = cusPasswordTxt.Text.Trim();
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both user name and password");
                return;
            }
            //encrypt entered password
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            try
            {
                conn.Open();
                string query = "SELECT customerID, fullName FROM customer WHERE userName =@username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwordBytes);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {

                       
                        if (reader.Read())
                        {
                            LoggedInCustomer.customerID = reader.GetInt32(0);
                            LoggedInCustomer.customerName = reader.GetString(1);

                            MessageBox.Show("Login successfull");
                            CustomerDashboard dashboard = new CustomerDashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("invalid user name or password");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void cusSignupPgBtn_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            customerSignUp.Show();
            this.Hide();

        }
    }
}
