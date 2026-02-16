using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class StudentRegistration : Form
    {
        private string connString;

        public StudentRegistration()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["StudentManagementSystem.Properties.Settings.stsmsConnectionString"].ConnectionString;
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            LoadRegNumbers();
        }

        private void LoadRegNumbers()
        {
            comboBoxRegNo.Items.Clear();
            comboBoxRegNo.Items.Add(""); // empty first item

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string query = "SELECT regNo FROM students ORDER BY regNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxRegNo.Items.Add(reader["regNo"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading registration numbers: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegNo.SelectedIndex <= 0)
            {
                ClearFields();
                return;
            }

            string selectedId = comboBoxRegNo.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Load student details
                    string studentQuery = "SELECT * FROM students WHERE regNo = @id";
                    using (SqlCommand cmd = new SqlCommand(studentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxFirstName.Text = reader["firstName"].ToString();
                                textBoxLastName.Text = reader["lastName"].ToString();

                                if (reader["dateOfBirth"] != DBNull.Value)
                                    dateTimePickerDOB.Value = Convert.ToDateTime(reader["dateOfBirth"]);

                                string gender = reader["gender"].ToString();
                                radioButtonMale.Checked = gender.Equals("Male", StringComparison.OrdinalIgnoreCase);
                                radioButtonFemale.Checked = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);

                                textBoxAddress.Text = reader["address"].ToString();
                                textBoxEmail.Text = reader["email"].ToString();
                                textBoxMobilePhone.Text = reader["mobilePhone"].ToString();
                                textBoxHomePhone.Text = reader["homePhone"].ToString();
                            }
                        }
                    }

                    // Load parent details
                    string parentQuery = "SELECT * FROM ParentDetails WHERE regNo = @id";
                    using (SqlCommand cmd = new SqlCommand(parentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxParentName.Text = reader["parentName"].ToString();
                                textBoxNIC.Text = reader["nic"].ToString();
                                textBoxContactNumber.Text = reader["contactNo"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student details: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetNextRegNo(SqlConnection conn)
        {
            string query = "SELECT MAX(regNo) FROM students";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                object result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value)
                {
                    return "0000";
                }

                int currentMax = int.Parse(result.ToString());
                return (currentMax + 1).ToString("D4");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) || string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter at least First Name and Last Name.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string gender = radioButtonMale.Checked ? "Male" : (radioButtonFemale.Checked ? "Female" : "");

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Generate the next regNo
                    string newRegNo = GetNextRegNo(conn);

                    // Insert into students table
                    string insertStudent = @"INSERT INTO students 
                        (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone)
                        VALUES (@regNo, @firstName, @lastName, @dob, @gender, @address, @email, @mobile, @home)";

                    using (SqlCommand cmd = new SqlCommand(insertStudent, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", newRegNo);
                        cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobile", textBoxMobilePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@home", textBoxHomePhone.Text.Trim());

                        cmd.ExecuteNonQuery();
                    }

                    // Insert into ParentDetails table
                    if (!string.IsNullOrWhiteSpace(textBoxParentName.Text))
                    {
                        string insertParent = @"INSERT INTO ParentDetails 
                            (regNo, parentName, nic, contactNo)
                            VALUES (@regNo, @parentName, @nic, @contact)";

                        using (SqlCommand cmd = new SqlCommand(insertParent, conn))
                        {
                            cmd.Parameters.AddWithValue("@regNo", newRegNo);
                            cmd.Parameters.AddWithValue("@parentName", textBoxParentName.Text.Trim());
                            cmd.Parameters.AddWithValue("@nic", textBoxNIC.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", textBoxContactNumber.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Student registered successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadRegNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registering student: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxRegNo.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a student to update.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedId = comboBoxRegNo.SelectedItem.ToString();
            string gender = radioButtonMale.Checked ? "Male" : (radioButtonFemale.Checked ? "Female" : "");

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Update students table
                    string updateStudent = @"UPDATE students SET 
                        firstName = @firstName, lastName = @lastName, dateOfBirth = @dob,
                        gender = @gender, address = @address, email = @email,
                        mobilePhone = @mobile, homePhone = @home
                        WHERE regNo = @id";

                    using (SqlCommand cmd = new SqlCommand(updateStudent, conn))
                    {
                        cmd.Parameters.AddWithValue("@firstName", textBoxFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", textBoxLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@address", textBoxAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobile", textBoxMobilePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@home", textBoxHomePhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }

                    // Update or insert parent details
                    string checkParent = "SELECT COUNT(*) FROM ParentDetails WHERE regNo = @id";
                    int parentExists;
                    using (SqlCommand cmd = new SqlCommand(checkParent, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        parentExists = (int)cmd.ExecuteScalar();
                    }

                    if (parentExists > 0)
                    {
                        string updateParent = @"UPDATE ParentDetails SET 
                            parentName = @parentName, nic = @nic, contactNo = @contact
                            WHERE regNo = @id";

                        using (SqlCommand cmd = new SqlCommand(updateParent, conn))
                        {
                            cmd.Parameters.AddWithValue("@parentName", textBoxParentName.Text.Trim());
                            cmd.Parameters.AddWithValue("@nic", textBoxNIC.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", textBoxContactNumber.Text.Trim());
                            cmd.Parameters.AddWithValue("@id", selectedId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (!string.IsNullOrWhiteSpace(textBoxParentName.Text))
                    {
                        string insertParent = @"INSERT INTO ParentDetails 
                            (regNo, parentName, nic, contactNo)
                            VALUES (@regNo, @parentName, @nic, @contact)";

                        using (SqlCommand cmd = new SqlCommand(insertParent, conn))
                        {
                            cmd.Parameters.AddWithValue("@regNo", selectedId);
                            cmd.Parameters.AddWithValue("@parentName", textBoxParentName.Text.Trim());
                            cmd.Parameters.AddWithValue("@nic", textBoxNIC.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", textBoxContactNumber.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Student updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxRegNo.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a student to delete.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            string selectedId = comboBoxRegNo.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    // Delete parent details first (foreign key)
                    string deleteParent = "DELETE FROM ParentDetails WHERE regNo = @id";
                    using (SqlCommand cmd = new SqlCommand(deleteParent, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }

                    // Delete student
                    string deleteStudent = "DELETE FROM students WHERE regNo = @id";
                    using (SqlCommand cmd = new SqlCommand(deleteStudent, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Student deleted successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadRegNumbers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            comboBoxRegNo.SelectedIndex = 0;
        }

        private void ClearFields()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            dateTimePickerDOB.Value = DateTime.Now;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxAddress.Clear();
            textBoxEmail.Clear();
            textBoxMobilePhone.Clear();
            textBoxHomePhone.Clear();
            textBoxParentName.Clear();
            textBoxNIC.Clear();
            textBoxContactNumber.Clear();
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

        private void linkLabelExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
