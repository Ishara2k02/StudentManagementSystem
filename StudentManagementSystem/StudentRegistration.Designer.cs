namespace StudentManagementSystem
{
    partial class StudentRegistration
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
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxStudentRegistration = new System.Windows.Forms.GroupBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.groupBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.textBoxHomePhone = new System.Windows.Forms.TextBox();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.labelParentName = new System.Windows.Forms.Label();
            this.textBoxParentName = new System.Windows.Forms.TextBox();
            this.labelNIC = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.textBoxContactNumber = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.groupBoxStudentRegistration.SuspendLayout();
            this.groupBoxBasicDetails.SuspendLayout();
            this.groupBoxContactDetails.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.linkLabelLogout.Location = new System.Drawing.Point(12, 15);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(60, 20);
            this.linkLabelLogout.TabIndex = 0;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(100, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(350, 30);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Skills International";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxStudentRegistration
            // 
            this.groupBoxStudentRegistration.Controls.Add(this.labelRegNo);
            this.groupBoxStudentRegistration.Controls.Add(this.comboBoxRegNo);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxBasicDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxContactDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxParentDetails);
            this.groupBoxStudentRegistration.Location = new System.Drawing.Point(15, 45);
            this.groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
            this.groupBoxStudentRegistration.Size = new System.Drawing.Size(707, 570);
            this.groupBoxStudentRegistration.TabIndex = 2;
            this.groupBoxStudentRegistration.TabStop = false;
            this.groupBoxStudentRegistration.Text = "Student Registration";
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelRegNo.Location = new System.Drawing.Point(30, 30);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(65, 20);
            this.labelRegNo.TabIndex = 0;
            this.labelRegNo.Text = "Reg No";
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(130, 28);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(130, 24);
            this.comboBoxRegNo.TabIndex = 1;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            // 
            // groupBoxBasicDetails
            // 
            this.groupBoxBasicDetails.Controls.Add(this.labelFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.textBoxFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.labelLastName);
            this.groupBoxBasicDetails.Controls.Add(this.textBoxLastName);
            this.groupBoxBasicDetails.Controls.Add(this.labelDOB);
            this.groupBoxBasicDetails.Controls.Add(this.dateTimePickerDOB);
            this.groupBoxBasicDetails.Controls.Add(this.labelGender);
            this.groupBoxBasicDetails.Controls.Add(this.radioButtonMale);
            this.groupBoxBasicDetails.Controls.Add(this.radioButtonFemale);
            this.groupBoxBasicDetails.Location = new System.Drawing.Point(15, 60);
            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            this.groupBoxBasicDetails.Size = new System.Drawing.Size(673, 160);
            this.groupBoxBasicDetails.TabIndex = 2;
            this.groupBoxBasicDetails.TabStop = false;
            this.groupBoxBasicDetails.Text = "Basic Details";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelFirstName.Location = new System.Drawing.Point(20, 30);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(92, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(115, 28);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(355, 22);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelLastName.Location = new System.Drawing.Point(20, 62);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(91, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(115, 60);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(355, 22);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelDOB.Location = new System.Drawing.Point(20, 95);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(105, 20);
            this.labelDOB.TabIndex = 4;
            this.labelDOB.Text = "Date of Birth";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(131, 93);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDOB.TabIndex = 5;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelGender.Location = new System.Drawing.Point(20, 128);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(64, 20);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioButtonMale.Location = new System.Drawing.Point(115, 126);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(66, 24);
            this.radioButtonMale.TabIndex = 7;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.radioButtonFemale.Location = new System.Drawing.Point(210, 126);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(85, 24);
            this.radioButtonFemale.TabIndex = 8;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.labelAddress);
            this.groupBoxContactDetails.Controls.Add(this.textBoxAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.textBoxMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.labelHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.textBoxHomePhone);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(15, 228);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new System.Drawing.Size(673, 155);
            this.groupBoxContactDetails.TabIndex = 3;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelAddress.Location = new System.Drawing.Point(6, 28);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(71, 20);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(115, 28);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(539, 50);
            this.textBoxAddress.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelEmail.Location = new System.Drawing.Point(6, 88);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 20);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(115, 88);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(539, 22);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelMobilePhone.Location = new System.Drawing.Point(6, 122);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(110, 20);
            this.labelMobilePhone.TabIndex = 4;
            this.labelMobilePhone.Text = "Mobile Phone";
            // 
            // textBoxMobilePhone
            // 
            this.textBoxMobilePhone.Location = new System.Drawing.Point(136, 120);
            this.textBoxMobilePhone.Name = "textBoxMobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(165, 22);
            this.textBoxMobilePhone.TabIndex = 5;
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelHomePhone.Location = new System.Drawing.Point(307, 122);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(106, 20);
            this.labelHomePhone.TabIndex = 6;
            this.labelHomePhone.Text = "Home Phone";
            // 
            // textBoxHomePhone
            // 
            this.textBoxHomePhone.Location = new System.Drawing.Point(426, 120);
            this.textBoxHomePhone.Name = "textBoxHomePhone";
            this.textBoxHomePhone.Size = new System.Drawing.Size(228, 22);
            this.textBoxHomePhone.TabIndex = 7;
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
            this.groupBoxParentDetails.Controls.Add(this.textBoxParentName);
            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
            this.groupBoxParentDetails.Controls.Add(this.textBoxNIC);
            this.groupBoxParentDetails.Controls.Add(this.labelContactNumber);
            this.groupBoxParentDetails.Controls.Add(this.textBoxContactNumber);
            this.groupBoxParentDetails.Location = new System.Drawing.Point(15, 390);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new System.Drawing.Size(673, 130);
            this.groupBoxParentDetails.TabIndex = 4;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelParentName.Location = new System.Drawing.Point(20, 30);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(107, 20);
            this.labelParentName.TabIndex = 0;
            this.labelParentName.Text = "Parent Name";
            // 
            // textBoxParentName
            // 
            this.textBoxParentName.Location = new System.Drawing.Point(160, 28);
            this.textBoxParentName.Name = "textBoxParentName";
            this.textBoxParentName.Size = new System.Drawing.Size(340, 22);
            this.textBoxParentName.TabIndex = 1;
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelNIC.Location = new System.Drawing.Point(20, 65);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(37, 20);
            this.labelNIC.TabIndex = 2;
            this.labelNIC.Text = "NIC";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Location = new System.Drawing.Point(160, 63);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(340, 22);
            this.textBoxNIC.TabIndex = 3;
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.labelContactNumber.Location = new System.Drawing.Point(20, 100);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(131, 20);
            this.labelContactNumber.TabIndex = 4;
            this.labelContactNumber.Text = "Contact Number";
            // 
            // textBoxContactNumber
            // 
            this.textBoxContactNumber.Location = new System.Drawing.Point(160, 100);
            this.textBoxContactNumber.Name = "textBoxContactNumber";
            this.textBoxContactNumber.Size = new System.Drawing.Size(340, 22);
            this.textBoxContactNumber.TabIndex = 5;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(20, 625);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(80, 30);
            this.buttonRegister.TabIndex = 3;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(110, 625);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(80, 30);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(370, 625);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(455, 625);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.AutoSize = true;
            this.linkLabelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.linkLabelExit.Location = new System.Drawing.Point(505, 665);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(37, 20);
            this.linkLabelExit.TabIndex = 7;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "Exit";
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 690);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxStudentRegistration);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.linkLabelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            this.groupBoxStudentRegistration.ResumeLayout(false);
            this.groupBoxStudentRegistration.PerformLayout();
            this.groupBoxBasicDetails.ResumeLayout(false);
            this.groupBoxBasicDetails.PerformLayout();
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxStudentRegistration;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.GroupBox groupBoxBasicDetails;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.TextBox textBoxMobilePhone;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.TextBox textBoxHomePhone;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.TextBox textBoxParentName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.TextBox textBoxContactNumber;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.LinkLabel linkLabelExit;
    }
}
