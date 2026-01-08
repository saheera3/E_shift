using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_shift
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoggedInAdtxt.Text = LoggedInAdmin.adminName;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();

        }

        private void viewREportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewReport viewReport = new viewReport();
            loadFormInPanel(viewReport);

        }

        private void viewReportsBtn_Click(object sender, EventArgs e)
        {
            viewReport viewReport = new viewReport();
            loadFormInPanel(viewReport);

        }

        private void viewRequestBtn_Click(object sender, EventArgs e)
        {
            viewRequest viewRequest = new viewRequest();
            loadFormInPanel(viewRequest);

        }

        private void viewTransportRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewRequest viewRequest = new viewRequest();
            loadFormInPanel(viewRequest);

        }

        private void ManageData(string data)
        {
            ManageData manageData = new ManageData(data);
            loadFormInPanel(manageData);
        }



        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData("customer");
        }

        private void manageJobsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData("job");
        }

        private void manageTransportUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageData("transportUnit");
        }

        private void loadFormInPanel(Form form)
        {
            Adminpanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            Adminpanel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void manageDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (manageDataComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a data type to manage.");
                    return;
                }

                string selectedData = manageDataComboBox.SelectedItem.ToString()?.ToLower()??"";
                ManageData(selectedData);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            }
        
    }
}
