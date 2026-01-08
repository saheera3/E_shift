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
    public partial class CustomerSignUp : Form
    {
        public CustomerSignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        private void createCustomerBtn_Click(object sender, EventArgs e)
        {
            //validate required fields
            if (CfullNameTxt.Text == "" || CmobileTxt.Text == "" || CemailTxt.Text == "" || CaddressTxt.Text == "" || CuserNameTxt.Text == "" || CpasswordTxt.Text == "")
            {
                MessageBox.Show("Please fill all required fields");
            }
            byte[] passwordBytes = Encoding.UTF8.GetBytes(CpasswordTxt.Text);
            try
            {
                conn.Open();
                string query = "INSERT INTO customer(fullName,mobile,email,address,userName,password)" +
                              "VALUES (@FullName, @Mobile, @Email, @Address, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", CfullNameTxt.Text);
                    cmd.Parameters.AddWithValue("@Mobile", CmobileTxt.Text);
                    cmd.Parameters.AddWithValue("@Email", CemailTxt.Text);
                    cmd.Parameters.AddWithValue("@Address", CaddressTxt.Text);
                    cmd.Parameters.AddWithValue("@Username", CuserNameTxt.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordBytes); // insert encrypted password

                    int rowCount = cmd.ExecuteNonQuery();
                    if (rowCount > 0)
                    {
                        MessageBox.Show("Account created successfully");
                        this.Hide();
                        new CustomerLogin().Show();
                    }
                    else
                    {
                        MessageBox.Show("Account creation failed");
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelcusSignBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
