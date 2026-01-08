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

    public partial class viewRequest : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        private DataTable? dtJob;
        private SqlDataAdapter? daJob;
        private SqlCommandBuilder? builderJob;

        private DataTable? dtTransport;
        private SqlDataAdapter? daTransport;
        private SqlCommandBuilder? builderTransport;

        public viewRequest()
        {
            InitializeComponent();
        }

        private void viewRequest_Load(object sender, EventArgs e)
        {
            LoadJobData();
            LoadTransportData();

        }

        private void LoadJobData()
        {
            string query = "SELECT * FROM Job WHERE status='pending'";
            daJob = new SqlDataAdapter(query, conn);
            builderJob = new SqlCommandBuilder(daJob);
            dtJob = new DataTable();
            daJob.Fill(dtJob);
            requestJobDataGridView.DataSource = dtJob;
        }

        private void LoadTransportData()
        {
            string query = "SELECT * FROM TransportUnit WHERE availability='available'";
            daTransport = new SqlDataAdapter(query, conn);
            builderTransport = new SqlCommandBuilder(daTransport);
            dtTransport = new DataTable();
            daTransport.Fill(dtTransport);
            availableTunitDataGrid.DataSource = dtTransport;
        }

        private void jobUpdateBtn_Click(object sender, EventArgs e)
        {
            if (dtJob == null || daJob == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }
            try
            {
                daJob.Update(dtJob);
                MessageBox.Show("Job data updated successfully.");
                LoadJobData(); // refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job update failed: " + ex.Message);
            }

        }

        private void transportUnitUptadeBtn_Click(object sender, EventArgs e)
        {
            if (dtTransport == null || daTransport == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }
            try
            {
                daTransport.Update(dtTransport);
                MessageBox.Show("Transport unit data updated successfully.");
                LoadTransportData(); // refresh
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transport update failed: " + ex.Message);
            }

        }
    }
}
