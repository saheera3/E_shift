using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace E_shift
{
    public partial class viewReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = SAHEERA3\SQLEXPRESS; Initial Catalog = E_shift; Integrated Security = True; Trust Server Certificate=True");
        public viewReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportTypecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selected = ReportTypecomboBox.SelectedItem!.ToString();
            JobStatusComboBox.Enabled = (selected == "Transport Job");
            feedbackRatingcomboBox.Enabled = (selected == "Feedback");
            bool enableDate = (selected == "Transport Job" || selected == "Feedback");
            FromdateReport.Enabled = enableDate;
            ToDateReport.Enabled = enableDate;

        }

        private void genarateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportTypecomboBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a report type.");
                    return;
                }

                string? reportType = ReportTypecomboBox.SelectedItem!.ToString();
                DataTable dt = new DataTable();
                SqlDataAdapter da;

                if (reportType == "Registered customer")
                {

                    da = new SqlDataAdapter("SELECT customerID, adminID,userName, fullName, mobile, email, address FROM customer", conn);
                }
                else if (reportType == "Transport Job")
                {
                    string query = "SELECT * FROM job WHERE 1=1";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (JobStatusComboBox.SelectedIndex != -1)
                    {
                        query += " AND status = @status";
                        cmd.Parameters.AddWithValue("@status", JobStatusComboBox.SelectedItem!.ToString());
                    }

                    if (FromdateReport.Enabled)
                    {
                        query += " AND jobDate BETWEEN @from AND @to";
                        cmd.Parameters.AddWithValue("@from", FromdateReport.Value.Date);
                        cmd.Parameters.AddWithValue("@to", ToDateReport.Value.Date);
                    }

                    cmd.CommandText = query;
                    da = new SqlDataAdapter(cmd);
                }
                else if (reportType == "Feedback")
                {
                    string query = "SELECT * FROM feedback WHERE 1=1";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    if (feedbackRatingcomboBox.SelectedIndex != -1)
                    {
                        object? selectedItem = feedbackRatingcomboBox.SelectedItem;
                        int rating = int.Parse(selectedItem!.ToString()!.Substring(0, 1));
                        query += " AND rating = @rating";
                        cmd.Parameters.AddWithValue("@rating", rating);
                    }

                    if (FromdateReport.Enabled)
                    {
                        query += " AND feedbackDate BETWEEN @from AND @to";
                        cmd.Parameters.AddWithValue("@from", FromdateReport.Value.Date);
                        cmd.Parameters.AddWithValue("@to", ToDateReport.Value.Date);
                    }

                    cmd.CommandText = query;
                    da = new SqlDataAdapter(cmd);
                }
                else
                {
                    MessageBox.Show("Unknown report type.");
                    return;
                }

                da.Fill(dt);
                ReportdataGridView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportdataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export.");
                    return;
                }

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF files (.pdf)|.pdf";
                    sfd.Title = "Save Report as PDF";
                    sfd.FileName = "Report.pdf"; 

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = sfd.FileName;
                        ExportGridViewToPDF(ReportdataGridView, filePath);
                        MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ExportGridViewToPDF(DataGridView dgv, string filePath)
        {
            try
            {
                PdfPTable pdfTable = new PdfPTable(dgv.ColumnCount);
                pdfTable.WidthPercentage = 100;
                pdfTable.DefaultCell.Padding = 5;
                pdfTable.DefaultCell.BorderWidth = 1;
                pdfTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

                // Add header
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText));
                    headerCell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    pdfTable.AddCell(headerCell);
                }

                // Add rows
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdfTable.AddCell(cell.Value?.ToString() ?? "");
                        }
                    }
                }

                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 10f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting PDF: " + ex.Message);
            }
        }
    }
}