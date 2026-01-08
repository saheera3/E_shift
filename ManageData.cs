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
    public partial class ManageData : Form

    {

        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        private string tableType;
        DataTable? dt;
        SqlDataAdapter? da;
        SqlCommandBuilder? builder;
        public ManageData(string selectedType)
        {
            InitializeComponent();
            tableType = selectedType;
        }

        private void LoadData(string tableName)
        {
            try
            {
                string query = $"SELECT * FROM {tableName}";
                da = new SqlDataAdapter(query, conn);
                builder = new SqlCommandBuilder(da);
                dt = new DataTable();
                da.Fill(dt);

                ManagedataGridView.DataSource = dt;

                if (tableType == "customer" && dt.Columns.Contains("password"))
                {
                    ManagedataGridView.Columns["password"]!.Visible = false;
                }

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ManageData_Load(object sender, EventArgs e)
        {
            if (tableType == "customer")
            {
                LoadData("customer");
            }
            else if (tableType == "job")
            {
                LoadData("job");
            }
            else if (tableType == "transportUnit")
            {
                LoadData("transportUnit");
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dt == null || da == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }

            if (MessageBox.Show("Do You Want to Update?", "Update confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                try 
                {
                    if (dt == null)
                    {
                        MessageBox.Show("No data loaded");

                    }
                    else
                    {
                        da.Update(dt); // automatically open and close the connection
                        MessageBox.Show("Data updated successfully.");
                        LoadData(tableType);
                    }

                    
                    
                }
            
                catch (Exception ex)
                {
                 MessageBox.Show("Update failed: " + ex.Message);
                }
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (dt == null || da == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }
            if (MessageBox.Show("Do You Want to Delete?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {

                    if (ManagedataGridView.SelectedRows.Count > 0)
                    {
                        foreach (DataGridViewRow row in ManagedataGridView.SelectedRows)
                        {
                            if (!row.IsNewRow)
                            {
                                ManagedataGridView.Rows.Remove(row);
                            }
                        }

                        da.Update(dt); // commit deletion
                        MessageBox.Show(" deleted successfully!");
                        LoadData(tableType);



                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                }



                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }


        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (dt == null || da == null)
            {
                MessageBox.Show("No data loaded");
                return;
            }

            try
            {
                DataRow newRow = dt.NewRow();      // create new empty row
                dt.Rows.Add(newRow);               // add to DataTable
                ManagedataGridView.CurrentCell = ManagedataGridView.Rows[ManagedataGridView.Rows.Count - 1].Cells[0];
                ManagedataGridView.BeginEdit(true); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add failed: " + ex.Message);
            }

        }

    }
}
