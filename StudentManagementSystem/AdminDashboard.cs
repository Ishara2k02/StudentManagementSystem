using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class AdminDashboard : Form
    {
        private string _adminName;

        public AdminDashboard(string adminName = "Administrator")
        {
            _adminName = adminName;
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Set the admin name dynamically
            labelAdminName.Text = _adminName;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration regForm = new StudentRegistration();
            regForm.ShowDialog();
            this.Show();
        }

        private void buttonViewStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllStudents viewForm = new ViewAllStudents();
            viewForm.ShowDialog();
            this.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        // Draws a subtle shadow/border around card panels
        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1.5f))
            {
                e.Graphics.DrawRectangle(pen, 0, 0,
                    panel.Width - 1, panel.Height - 1);
            }
        }
    }
}