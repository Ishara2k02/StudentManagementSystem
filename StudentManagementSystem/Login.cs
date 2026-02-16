using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["StudentManagementSystem.Properties.Settings.stsmsConnectionString"].ConnectionString;

            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Logins WHERE username = @username AND password = @password";
                    
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            // Hide Login Form
                            this.Hide();

                            // Show Admin Dashboard
                            AdminDashboard dashboard = new AdminDashboard(username);
                            dashboard.ShowDialog();

                            // After Dashboard closes, close application or show login again. 
                            // For this requirement, closing application when dashboard closes is common,
                            // or showing login again if logout.
                            // But since we did this.Hide(), the app needs to exit when dashboard closes if it's the main form,
                            // OR we bring back login form.
                            // Reference: AdminDashboard logout logic creates new Form1(), implies Form1 is login. 
                            // But here class is 'Login'. AdminDashboard code refers to 'Form1'. I should check if Login is Form1 or renamed.
                            // Assuming this file is Login.cs and class is Login.
                            
                            this.Close(); // Close login form to exit app if it is main form, but Main() runs Login.
                            // If Main() runs Login, closing it exits app. 
                            // So we should probably NOT close it immediately if we want to return.
                            // But usually "Redirect" means switch.
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textBoxPassword.Clear();
                            textBoxPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}