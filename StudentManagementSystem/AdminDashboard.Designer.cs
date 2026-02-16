namespace StudentManagementSystem
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));

            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelAdminName = new System.Windows.Forms.Label();
            this.labelSubtitle = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelAddStudent = new System.Windows.Forms.Panel();
            this.pictureBoxAddIcon = new System.Windows.Forms.PictureBox();
            this.labelAddTitle = new System.Windows.Forms.Label();
            this.labelAddDesc = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.panelViewStudent = new System.Windows.Forms.Panel();
            this.pictureBoxViewIcon = new System.Windows.Forms.PictureBox();
            this.labelViewTitle = new System.Windows.Forms.Label();
            this.labelViewDesc = new System.Windows.Forms.Label();
            this.buttonViewStudents = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelFooter = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();

            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelAddStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddIcon)).BeginInit();
            this.panelViewStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewIcon)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();

            // ─────────────────────────────────────────
            // panelHeader
            // ─────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.labelAppTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(860, 80);
            this.panelHeader.TabIndex = 0;

            // ─────────────────────────────────────────
            // pictureBoxLogo
            // ─────────────────────────────────────────
            this.pictureBoxLogo.Location = new System.Drawing.Point(20, 10);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            // this.pictureBoxLogo.Image = Image.FromFile("logo.png");

            // ─────────────────────────────────────────
            // labelAppTitle
            // ─────────────────────────────────────────
            this.labelAppTitle.AutoSize = false;
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI", 18F,
                System.Drawing.FontStyle.Bold);
            this.labelAppTitle.Location = new System.Drawing.Point(90, 20);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(350, 40);
            this.labelAppTitle.Text = "Skills International";
            this.labelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ─────────────────────────────────────────
            // panelWelcome
            // ─────────────────────────────────────────
            this.panelWelcome.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Controls.Add(this.labelAdminName);
            this.panelWelcome.Controls.Add(this.labelSubtitle);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.None;
            this.panelWelcome.Location = new System.Drawing.Point(0, 80);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(860, 120);
            this.panelWelcome.TabIndex = 1;

            // ─────────────────────────────────────────
            // labelWelcome
            // ─────────────────────────────────────────
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.labelWelcome.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            this.labelWelcome.Location = new System.Drawing.Point(40, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Text = "Welcome Back,";

            // ─────────────────────────────────────────
            // labelAdminName
            // ─────────────────────────────────────────
            this.labelAdminName.AutoSize = true;
            this.labelAdminName.Font = new System.Drawing.Font("Segoe UI", 20F,
                System.Drawing.FontStyle.Bold);
            this.labelAdminName.ForeColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.labelAdminName.Location = new System.Drawing.Point(36, 45);
            this.labelAdminName.Name = "labelAdminName";
            this.labelAdminName.Text = "Administrator";

            // ─────────────────────────────────────────
            // labelSubtitle
            // ─────────────────────────────────────────
            this.labelSubtitle.AutoSize = true;
            this.labelSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelSubtitle.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelSubtitle.Location = new System.Drawing.Point(40, 90);
            this.labelSubtitle.Name = "labelSubtitle";
            this.labelSubtitle.Text = "Manage your students from the dashboard below.";

            // ─────────────────────────────────────────
            // panelCards  –  container for both cards
            // ─────────────────────────────────────────
            this.panelCards.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelCards.Controls.Add(this.panelAddStudent);
            this.panelCards.Controls.Add(this.panelViewStudent);
            this.panelCards.Location = new System.Drawing.Point(0, 200);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(860, 320);
            this.panelCards.TabIndex = 2;

            // ─────────────────────────────────────────
            // panelAddStudent  –  Card 1
            // ─────────────────────────────────────────
            this.panelAddStudent.BackColor = System.Drawing.Color.White;
            this.panelAddStudent.Controls.Add(this.pictureBoxAddIcon);
            this.panelAddStudent.Controls.Add(this.labelAddTitle);
            this.panelAddStudent.Controls.Add(this.labelAddDesc);
            this.panelAddStudent.Controls.Add(this.buttonAddStudent);
            this.panelAddStudent.Location = new System.Drawing.Point(80, 40);
            this.panelAddStudent.Name = "panelAddStudent";
            this.panelAddStudent.Size = new System.Drawing.Size(300, 240);
            this.panelAddStudent.TabIndex = 0;
            // Rounded-card feel via border
            this.panelAddStudent.Paint += new System.Windows.Forms.PaintEventHandler(
                this.Panel_Paint);

            // ─────────────────────────────────────────
            // pictureBoxAddIcon
            // ─────────────────────────────────────────
            this.pictureBoxAddIcon.Location = new System.Drawing.Point(115, 20);
            this.pictureBoxAddIcon.Name = "pictureBoxAddIcon";
            this.pictureBoxAddIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxAddIcon.TabStop = false;
            this.pictureBoxAddIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // ─────────────────────────────────────────
            // labelAddTitle
            // ─────────────────────────────────────────
            this.labelAddTitle.AutoSize = false;
            this.labelAddTitle.Font = new System.Drawing.Font("Segoe UI", 13F,
                System.Drawing.FontStyle.Bold);
            this.labelAddTitle.ForeColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.labelAddTitle.Location = new System.Drawing.Point(10, 90);
            this.labelAddTitle.Name = "labelAddTitle";
            this.labelAddTitle.Size = new System.Drawing.Size(280, 30);
            this.labelAddTitle.Text = "Add New Student";
            this.labelAddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─────────────────────────────────────────
            // labelAddDesc
            // ─────────────────────────────────────────
            this.labelAddDesc.AutoSize = false;
            this.labelAddDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAddDesc.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelAddDesc.Location = new System.Drawing.Point(10, 125);
            this.labelAddDesc.Name = "labelAddDesc";
            this.labelAddDesc.Size = new System.Drawing.Size(280, 40);
            this.labelAddDesc.Text = "Register a new student into the system.";
            this.labelAddDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─────────────────────────────────────────
            // buttonAddStudent
            // ─────────────────────────────────────────
            this.buttonAddStudent.BackColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.buttonAddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonAddStudent.Location = new System.Drawing.Point(60, 185);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(175, 38);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "+ Add New Student";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddStudent.Click += new System.EventHandler(
                this.buttonAddStudent_Click);

            // ─────────────────────────────────────────
            // panelViewStudent  –  Card 2
            // ─────────────────────────────────────────
            this.panelViewStudent.BackColor = System.Drawing.Color.White;
            this.panelViewStudent.Controls.Add(this.pictureBoxViewIcon);
            this.panelViewStudent.Controls.Add(this.labelViewTitle);
            this.panelViewStudent.Controls.Add(this.labelViewDesc);
            this.panelViewStudent.Controls.Add(this.buttonViewStudents);
            this.panelViewStudent.Location = new System.Drawing.Point(460, 40);
            this.panelViewStudent.Name = "panelViewStudent";
            this.panelViewStudent.Size = new System.Drawing.Size(300, 240);
            this.panelViewStudent.TabIndex = 1;
            this.panelViewStudent.Paint += new System.Windows.Forms.PaintEventHandler(
                this.Panel_Paint);

            // ─────────────────────────────────────────
            // pictureBoxViewIcon
            // ─────────────────────────────────────────
            this.pictureBoxViewIcon.Location = new System.Drawing.Point(115, 20);
            this.pictureBoxViewIcon.Name = "pictureBoxViewIcon";
            this.pictureBoxViewIcon.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxViewIcon.TabStop = false;
            this.pictureBoxViewIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            // ─────────────────────────────────────────
            // labelViewTitle
            // ─────────────────────────────────────────
            this.labelViewTitle.AutoSize = false;
            this.labelViewTitle.Font = new System.Drawing.Font("Segoe UI", 13F,
                System.Drawing.FontStyle.Bold);
            this.labelViewTitle.ForeColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.labelViewTitle.Location = new System.Drawing.Point(10, 90);
            this.labelViewTitle.Name = "labelViewTitle";
            this.labelViewTitle.Size = new System.Drawing.Size(280, 30);
            this.labelViewTitle.Text = "View All Students";
            this.labelViewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─────────────────────────────────────────
            // labelViewDesc
            // ─────────────────────────────────────────
            this.labelViewDesc.AutoSize = false;
            this.labelViewDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelViewDesc.ForeColor = System.Drawing.Color.FromArgb(120, 120, 120);
            this.labelViewDesc.Location = new System.Drawing.Point(10, 125);
            this.labelViewDesc.Name = "labelViewDesc";
            this.labelViewDesc.Size = new System.Drawing.Size(280, 40);
            this.labelViewDesc.Text = "Browse and manage all registered students.";
            this.labelViewDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ─────────────────────────────────────────
            // buttonViewStudents
            // ─────────────────────────────────────────
            this.buttonViewStudents.BackColor = System.Drawing.Color.FromArgb(0, 153, 102);
            this.buttonViewStudents.FlatAppearance.BorderSize = 0;
            this.buttonViewStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewStudents.Font = new System.Drawing.Font("Segoe UI", 10F,
                System.Drawing.FontStyle.Bold);
            this.buttonViewStudents.ForeColor = System.Drawing.Color.White;
            this.buttonViewStudents.Location = new System.Drawing.Point(60, 185);
            this.buttonViewStudents.Name = "buttonViewStudents";
            this.buttonViewStudents.Size = new System.Drawing.Size(175, 38);
            this.buttonViewStudents.TabIndex = 2;
            this.buttonViewStudents.Text = "👁 View All Students";
            this.buttonViewStudents.UseVisualStyleBackColor = false;
            this.buttonViewStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewStudents.Click += new System.EventHandler(
                this.buttonViewStudents_Click);

            // ─────────────────────────────────────────
            // panelFooter
            // ─────────────────────────────────────────
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(31, 31, 58);
            this.panelFooter.Controls.Add(this.labelFooter);
            this.panelFooter.Controls.Add(this.buttonLogout);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 530);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(860, 50);
            this.panelFooter.TabIndex = 3;

            // ─────────────────────────────────────────
            // labelFooter
            // ─────────────────────────────────────────
            this.labelFooter.AutoSize = false;
            this.labelFooter.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.labelFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFooter.Location = new System.Drawing.Point(20, 15);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(400, 20);
            this.labelFooter.Text = "© 2024 Skills International – Student Management System";

            // ─────────────────────────────────────────
            // buttonLogout
            // ─────────────────────────────────────────
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F,
                System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(750, 10);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(90, 30);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);

            // ─────────────────────────────────────────
            // AdminDashboard Form
            // ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.ClientSize = new System.Drawing.Size(860, 580);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard – Skills International";

            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelAddStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddIcon)).EndInit();
            this.panelViewStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxViewIcon)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelAppTitle;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelAdminName;
        private System.Windows.Forms.Label labelSubtitle;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelAddStudent;
        private System.Windows.Forms.PictureBox pictureBoxAddIcon;
        private System.Windows.Forms.Label labelAddTitle;
        private System.Windows.Forms.Label labelAddDesc;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Panel panelViewStudent;
        private System.Windows.Forms.PictureBox pictureBoxViewIcon;
        private System.Windows.Forms.Label labelViewTitle;
        private System.Windows.Forms.Label labelViewDesc;
        private System.Windows.Forms.Button buttonViewStudents;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Button buttonLogout;
    }
}