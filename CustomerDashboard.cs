using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_shift
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }
        private void RequestJobBtn_Click(object sender, EventArgs e)
        {
            RequestTransportJob requestTransportJob = new RequestTransportJob();
            loadFormInPanel(requestTransportJob);
        }
        

        private void CustomerDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            loggedCusNameTxt.Text = LoggedInCustomer.customerName;
            
        }


        public void loadFormInPanel(Form form)
        {
            
            customerPanel.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            customerPanel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        

        private void trackTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerJobListTrack customerJobListTrack = new CustomerJobListTrack();
            loadFormInPanel(customerJobListTrack);
        }

        private void customerDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerDashboard customerDashboard = new CustomerDashboard();
            customerDashboard.Show();
            this.Hide();
        }

        private void giveFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customercompletedJobList customercompletedJobList = new customercompletedJobList();
            loadFormInPanel(customercompletedJobList);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            customercompletedJobList customercompletedJobList = new customercompletedJobList();
            loadFormInPanel(customercompletedJobList);
        }

        private void viewPastTransportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pastTRasportsCustomer pastTRasportsCustomer = new pastTRasportsCustomer();
            loadFormInPanel(pastTRasportsCustomer);
        }

        private void requestTransportJobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestTransportJob requestTransportJob = new RequestTransportJob();
            loadFormInPanel(requestTransportJob);
        }

       
    }
}
