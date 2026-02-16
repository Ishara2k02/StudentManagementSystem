using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewAllStudents : Form
    {
        private string connString;

        public ViewAllStudents()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["StudentManagementSystem.Properties.Settings.stsmsConnectionString"].ConnectionString;
        }

        private void ViewAllStudents_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = @"SELECT 
                        s.regNo AS [Reg No],
                        s.firstName AS [First Name],
                        s.lastName AS [Last Name],
                        s.dateOfBirth AS [Date of Birth],
                        s.gender AS [Gender],
                        s.address AS [Address],
                        s.email AS [Email],
                        s.mobilePhone AS [Mobile Phone],
                        s.homePhone AS [Home Phone]
                        FROM students s
                        ORDER BY s.regNo";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridViewStudents.DataSource = dt;
                    }
                }

                // Format the grid after data is loaded
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dataGridViewStudents.Columns.Count == 0) return;

            // Auto-size columns to fit content
            dataGridViewStudents.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Set Date of Birth column format
            if (dataGridViewStudents.Columns["Date of Birth"] != null)
            {
                dataGridViewStudents.Columns["Date of Birth"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }
    }
}
