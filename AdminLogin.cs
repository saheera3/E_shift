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
    public partial class AdminLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNameAdTxt.Text.Trim();
            string password = passwordAdTxt.Text.Trim();
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
                string query = "SELECT adminID, fullName FROM Admin WHERE userName =@username AND password = @password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", passwordBytes);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        if (reader.Read())
                        {
                            LoggedInAdmin.adminID = reader.GetInt32(0);
                            LoggedInAdmin.adminName = reader.GetString(1);

                            MessageBox.Show("Login successfull");
                            AdminDashboard admindashboard = new AdminDashboard();
                            admindashboard.Show();
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
