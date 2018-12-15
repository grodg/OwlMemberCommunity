namespace OwlCommunityFinal
{
    partial class frmOwlCommunity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOwlCommunity));
            this.btnEnterMember = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveUpdates = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClickhereToEnterID = new System.Windows.Forms.Button();
            this.lblTheseOperations = new System.Windows.Forms.Label();
            this.lblFormControlsDataProcessing = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpOwlMember = new System.Windows.Forms.Panel();
            this.lblSelectMemberType = new System.Windows.Forms.Label();
            this.txtMemberType = new System.Windows.Forms.ComboBox();
            this.txtOwlMemberBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtOwlMemberName = new System.Windows.Forms.TextBox();
            this.grpStudent = new System.Windows.Forms.Panel();
            this.grpGraduateStudent = new System.Windows.Forms.Panel();
            this.txtGraduateStudentDegreeProgram = new System.Windows.Forms.ComboBox();
            this.txtGraduateStudentStipend = new System.Windows.Forms.TextBox();
            this.lblDegreeProgram = new System.Windows.Forms.Label();
            this.lblStipend = new System.Windows.Forms.Label();
            this.lblGraduateStudent = new System.Windows.Forms.Label();
            this.grpUndergraduateStudent = new System.Windows.Forms.Panel();
            this.txtUndergraduateStudentYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtUndergraduateStudentCredits = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.txtUndergraduateStudentTuition = new System.Windows.Forms.TextBox();
            this.lblTuition = new System.Windows.Forms.Label();
            this.lblUndergraduateStudent = new System.Windows.Forms.Label();
            this.lblGPA = new System.Windows.Forms.Label();
            this.txtStudentGPA = new System.Windows.Forms.TextBox();
            this.txtStudentMajor = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.grpFaculty = new System.Windows.Forms.Panel();
            this.txtFacultyRank = new System.Windows.Forms.ComboBox();
            this.grpChairperson = new System.Windows.Forms.Panel();
            this.txtChairpersonStipend = new System.Windows.Forms.TextBox();
            this.lblChairpersonStipend = new System.Windows.Forms.Label();
            this.lblChairperson = new System.Windows.Forms.Label();
            this.txtFacultyDepartment = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.txtOwlMemberID = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblOwlMember = new System.Windows.Forms.Label();
            this.lblToFind = new System.Windows.Forms.Label();
            this.pnlEntryControls = new System.Windows.Forms.Panel();
            this.btnCreateChairperson = new System.Windows.Forms.Button();
            this.btnCreateFaculty = new System.Windows.Forms.Button();
            this.btnCreateGraduateStudent = new System.Windows.Forms.Button();
            this.btnCreateUndergraduateStudent = new System.Windows.Forms.Button();
            this.lblNewEntry = new System.Windows.Forms.Label();
            this.lblToCreate = new System.Windows.Forms.Label();
            this.lblDataEntry = new System.Windows.Forms.Label();
            this.lblUserMessage = new System.Windows.Forms.Label();
            this.btnYES = new System.Windows.Forms.Button();
            this.btnNO = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            this.grpOwlMember.SuspendLayout();
            this.grpStudent.SuspendLayout();
            this.grpGraduateStudent.SuspendLayout();
            this.grpUndergraduateStudent.SuspendLayout();
            this.grpFaculty.SuspendLayout();
            this.grpChairperson.SuspendLayout();
            this.pnlEntryControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterMember
            // 
            this.btnEnterMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEnterMember.Enabled = false;
            this.btnEnterMember.Location = new System.Drawing.Point(626, 309);
            this.btnEnterMember.Name = "btnEnterMember";
            this.btnEnterMember.Size = new System.Drawing.Size(66, 38);
            this.btnEnterMember.TabIndex = 68;
            this.btnEnterMember.Text = "Enter\r\nMember";
            this.btnEnterMember.UseVisualStyleBackColor = false;
            this.btnEnterMember.Click += new System.EventHandler(this.btnEnterMember_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExitProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExitProgram.Location = new System.Drawing.Point(626, 241);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(47, 41);
            this.btnExitProgram.TabIndex = 67;
            this.btnExitProgram.Text = "Exit";
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click_1);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnDelete);
            this.panel8.Controls.Add(this.btnSaveUpdates);
            this.panel8.Controls.Add(this.btnEdit);
            this.panel8.Controls.Add(this.btnFind);
            this.panel8.Controls.Add(this.btnClickhereToEnterID);
            this.panel8.Controls.Add(this.lblTheseOperations);
            this.panel8.Controls.Add(this.lblFormControlsDataProcessing);
            this.panel8.Location = new System.Drawing.Point(12, 420);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(592, 88);
            this.panel8.TabIndex = 66;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(470, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveUpdates
            // 
            this.btnSaveUpdates.Enabled = false;
            this.btnSaveUpdates.Location = new System.Drawing.Point(359, 54);
            this.btnSaveUpdates.Name = "btnSaveUpdates";
            this.btnSaveUpdates.Size = new System.Drawing.Size(89, 23);
            this.btnSaveUpdates.TabIndex = 45;
            this.btnSaveUpdates.Text = "Save Updates";
            this.btnSaveUpdates.UseVisualStyleBackColor = true;
            this.btnSaveUpdates.Click += new System.EventHandler(this.btnSaveUpdates_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(263, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit/Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnFind
            // 
            this.btnFind.Enabled = false;
            this.btnFind.Location = new System.Drawing.Point(173, 54);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 43;
            this.btnFind.Text = "Find/Display";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click_1);
            // 
            // btnClickhereToEnterID
            // 
            this.btnClickhereToEnterID.BackColor = System.Drawing.Color.Lime;
            this.btnClickhereToEnterID.Location = new System.Drawing.Point(23, 54);
            this.btnClickhereToEnterID.Name = "btnClickhereToEnterID";
            this.btnClickhereToEnterID.Size = new System.Drawing.Size(137, 23);
            this.btnClickhereToEnterID.TabIndex = 42;
            this.btnClickhereToEnterID.Text = "Click Here to Enter ID";
            this.btnClickhereToEnterID.UseVisualStyleBackColor = false;
            this.btnClickhereToEnterID.Click += new System.EventHandler(this.btnClickhereToEnterID_Click_1);
            // 
            // lblTheseOperations
            // 
            this.lblTheseOperations.AutoSize = true;
            this.lblTheseOperations.ForeColor = System.Drawing.Color.Tomato;
            this.lblTheseOperations.Location = new System.Drawing.Point(-1, 13);
            this.lblTheseOperations.Name = "lblTheseOperations";
            this.lblTheseOperations.Size = new System.Drawing.Size(594, 26);
            this.lblTheseOperations.TabIndex = 41;
            this.lblTheseOperations.Text = resources.GetString("lblTheseOperations.Text");
            // 
            // lblFormControlsDataProcessing
            // 
            this.lblFormControlsDataProcessing.AutoSize = true;
            this.lblFormControlsDataProcessing.Location = new System.Drawing.Point(8, 0);
            this.lblFormControlsDataProcessing.Name = "lblFormControlsDataProcessing";
            this.lblFormControlsDataProcessing.Size = new System.Drawing.Size(170, 13);
            this.lblFormControlsDataProcessing.TabIndex = 40;
            this.lblFormControlsDataProcessing.Text = "Form Controls For Data Processing";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(626, 189);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(47, 42);
            this.btnClear.TabIndex = 65;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // grpOwlMember
            // 
            this.grpOwlMember.Controls.Add(this.lblSelectMemberType);
            this.grpOwlMember.Controls.Add(this.txtMemberType);
            this.grpOwlMember.Controls.Add(this.txtOwlMemberBirthDate);
            this.grpOwlMember.Controls.Add(this.txtOwlMemberName);
            this.grpOwlMember.Controls.Add(this.grpStudent);
            this.grpOwlMember.Controls.Add(this.grpFaculty);
            this.grpOwlMember.Controls.Add(this.txtOwlMemberID);
            this.grpOwlMember.Controls.Add(this.lblBirthDate);
            this.grpOwlMember.Controls.Add(this.lblName);
            this.grpOwlMember.Controls.Add(this.lblID);
            this.grpOwlMember.Controls.Add(this.lblOwlMember);
            this.grpOwlMember.Enabled = false;
            this.grpOwlMember.Location = new System.Drawing.Point(-3, 127);
            this.grpOwlMember.Name = "grpOwlMember";
            this.grpOwlMember.Size = new System.Drawing.Size(610, 273);
            this.grpOwlMember.TabIndex = 64;
            // 
            // lblSelectMemberType
            // 
            this.lblSelectMemberType.AutoSize = true;
            this.lblSelectMemberType.Location = new System.Drawing.Point(482, 62);
            this.lblSelectMemberType.Name = "lblSelectMemberType";
            this.lblSelectMemberType.Size = new System.Drawing.Size(105, 13);
            this.lblSelectMemberType.TabIndex = 42;
            this.lblSelectMemberType.Text = "Select Member Type";
            this.lblSelectMemberType.Visible = false;
            // 
            // txtMemberType
            // 
            this.txtMemberType.FormattingEnabled = true;
            this.txtMemberType.Items.AddRange(new object[] {
            "Undergraduate Student",
            "Graduate Student",
            "Faculty Member",
            "Faculty Chairperson"});
            this.txtMemberType.Location = new System.Drawing.Point(479, 83);
            this.txtMemberType.Name = "txtMemberType";
            this.txtMemberType.Size = new System.Drawing.Size(121, 21);
            this.txtMemberType.TabIndex = 41;
            this.txtMemberType.Visible = false;
            this.txtMemberType.SelectedIndexChanged += new System.EventHandler(this.txtMemberType_SelectedIndexChanged);
            // 
            // txtOwlMemberBirthDate
            // 
            this.txtOwlMemberBirthDate.Location = new System.Drawing.Point(379, 17);
            this.txtOwlMemberBirthDate.MaxDate = new System.DateTime(2018, 12, 25, 23, 59, 59, 0);
            this.txtOwlMemberBirthDate.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.txtOwlMemberBirthDate.Name = "txtOwlMemberBirthDate";
            this.txtOwlMemberBirthDate.Size = new System.Drawing.Size(154, 20);
            this.txtOwlMemberBirthDate.TabIndex = 40;
            this.txtOwlMemberBirthDate.Value = new System.DateTime(2008, 12, 31, 0, 0, 0, 0);
            // 
            // txtOwlMemberName
            // 
            this.txtOwlMemberName.Location = new System.Drawing.Point(204, 17);
            this.txtOwlMemberName.Name = "txtOwlMemberName";
            this.txtOwlMemberName.Size = new System.Drawing.Size(100, 20);
            this.txtOwlMemberName.TabIndex = 39;
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.grpGraduateStudent);
            this.grpStudent.Controls.Add(this.grpUndergraduateStudent);
            this.grpStudent.Controls.Add(this.lblGPA);
            this.grpStudent.Controls.Add(this.txtStudentGPA);
            this.grpStudent.Controls.Add(this.txtStudentMajor);
            this.grpStudent.Controls.Add(this.lblMajor);
            this.grpStudent.Controls.Add(this.lblStudent);
            this.grpStudent.Enabled = false;
            this.grpStudent.Location = new System.Drawing.Point(5, 139);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(555, 133);
            this.grpStudent.TabIndex = 38;
            // 
            // grpGraduateStudent
            // 
            this.grpGraduateStudent.Controls.Add(this.txtGraduateStudentDegreeProgram);
            this.grpGraduateStudent.Controls.Add(this.txtGraduateStudentStipend);
            this.grpGraduateStudent.Controls.Add(this.lblDegreeProgram);
            this.grpGraduateStudent.Controls.Add(this.lblStipend);
            this.grpGraduateStudent.Controls.Add(this.lblGraduateStudent);
            this.grpGraduateStudent.Enabled = false;
            this.grpGraduateStudent.Location = new System.Drawing.Point(321, 49);
            this.grpGraduateStudent.Name = "grpGraduateStudent";
            this.grpGraduateStudent.Size = new System.Drawing.Size(233, 84);
            this.grpGraduateStudent.TabIndex = 38;
            // 
            // txtGraduateStudentDegreeProgram
            // 
            this.txtGraduateStudentDegreeProgram.FormattingEnabled = true;
            this.txtGraduateStudentDegreeProgram.Items.AddRange(new object[] {
            "MD",
            "PhD",
            "PhDBA",
            "EMBA",
            "M.A. ",
            "M.Acct. ",
            "M.Aqua. ",
            "M.B.A.",
            "M.C.D. ",
            "M.C.S.",
            "M.Div.",
            "M.E. ",
            "M.Ed.",
            "M.Fstry.",
            "M.L.Arch.",
            "M.L.I.S. ",
            "M.M.",
            "M.P.S. ",
            "M.S. ",
            "M.S.C.J.",
            "M.S.C.S.",
            "M.S.Chem.",
            "M.S.F.S.",
            "M.S.M.Sci.",
            "M.S.Met.",
            "M.Sw.E ",
            "M.S.W.",
            "M.Th.",
            "Th.M."});
            this.txtGraduateStudentDegreeProgram.Location = new System.Drawing.Point(98, 51);
            this.txtGraduateStudentDegreeProgram.Name = "txtGraduateStudentDegreeProgram";
            this.txtGraduateStudentDegreeProgram.Size = new System.Drawing.Size(121, 21);
            this.txtGraduateStudentDegreeProgram.TabIndex = 36;
            // 
            // txtGraduateStudentStipend
            // 
            this.txtGraduateStudentStipend.Location = new System.Drawing.Point(81, 23);
            this.txtGraduateStudentStipend.Name = "txtGraduateStudentStipend";
            this.txtGraduateStudentStipend.Size = new System.Drawing.Size(100, 20);
            this.txtGraduateStudentStipend.TabIndex = 35;
            // 
            // lblDegreeProgram
            // 
            this.lblDegreeProgram.AutoSize = true;
            this.lblDegreeProgram.Location = new System.Drawing.Point(8, 54);
            this.lblDegreeProgram.Name = "lblDegreeProgram";
            this.lblDegreeProgram.Size = new System.Drawing.Size(84, 13);
            this.lblDegreeProgram.TabIndex = 34;
            this.lblDegreeProgram.Text = "Degree Program";
            // 
            // lblStipend
            // 
            this.lblStipend.AutoSize = true;
            this.lblStipend.Location = new System.Drawing.Point(8, 26);
            this.lblStipend.Name = "lblStipend";
            this.lblStipend.Size = new System.Drawing.Size(43, 13);
            this.lblStipend.TabIndex = 33;
            this.lblStipend.Text = "Stipend";
            // 
            // lblGraduateStudent
            // 
            this.lblGraduateStudent.AutoSize = true;
            this.lblGraduateStudent.Location = new System.Drawing.Point(2, 3);
            this.lblGraduateStudent.Name = "lblGraduateStudent";
            this.lblGraduateStudent.Size = new System.Drawing.Size(91, 13);
            this.lblGraduateStudent.TabIndex = 26;
            this.lblGraduateStudent.Text = "Graduate Student";
            // 
            // grpUndergraduateStudent
            // 
            this.grpUndergraduateStudent.Controls.Add(this.txtUndergraduateStudentYear);
            this.grpUndergraduateStudent.Controls.Add(this.lblYear);
            this.grpUndergraduateStudent.Controls.Add(this.txtUndergraduateStudentCredits);
            this.grpUndergraduateStudent.Controls.Add(this.lblCredits);
            this.grpUndergraduateStudent.Controls.Add(this.txtUndergraduateStudentTuition);
            this.grpUndergraduateStudent.Controls.Add(this.lblTuition);
            this.grpUndergraduateStudent.Controls.Add(this.lblUndergraduateStudent);
            this.grpUndergraduateStudent.Enabled = false;
            this.grpUndergraduateStudent.Location = new System.Drawing.Point(8, 43);
            this.grpUndergraduateStudent.Name = "grpUndergraduateStudent";
            this.grpUndergraduateStudent.Size = new System.Drawing.Size(291, 89);
            this.grpUndergraduateStudent.TabIndex = 37;
            // 
            // txtUndergraduateStudentYear
            // 
            this.txtUndergraduateStudentYear.FormattingEnabled = true;
            this.txtUndergraduateStudentYear.Items.AddRange(new object[] {
            "Freshman",
            "Sophomore",
            "Junior",
            "Senior"});
            this.txtUndergraduateStudentYear.Location = new System.Drawing.Point(58, 60);
            this.txtUndergraduateStudentYear.Name = "txtUndergraduateStudentYear";
            this.txtUndergraduateStudentYear.Size = new System.Drawing.Size(121, 21);
            this.txtUndergraduateStudentYear.TabIndex = 33;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(23, 63);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 31;
            this.lblYear.Text = "Year";
            // 
            // txtUndergraduateStudentCredits
            // 
            this.txtUndergraduateStudentCredits.Location = new System.Drawing.Point(198, 29);
            this.txtUndergraduateStudentCredits.Name = "txtUndergraduateStudentCredits";
            this.txtUndergraduateStudentCredits.Size = new System.Drawing.Size(75, 20);
            this.txtUndergraduateStudentCredits.TabIndex = 30;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(157, 32);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 29;
            this.lblCredits.Text = "Credits";
            // 
            // txtUndergraduateStudentTuition
            // 
            this.txtUndergraduateStudentTuition.Location = new System.Drawing.Point(69, 29);
            this.txtUndergraduateStudentTuition.Name = "txtUndergraduateStudentTuition";
            this.txtUndergraduateStudentTuition.Size = new System.Drawing.Size(75, 20);
            this.txtUndergraduateStudentTuition.TabIndex = 28;
            // 
            // lblTuition
            // 
            this.lblTuition.AutoSize = true;
            this.lblTuition.Location = new System.Drawing.Point(20, 32);
            this.lblTuition.Name = "lblTuition";
            this.lblTuition.Size = new System.Drawing.Size(39, 13);
            this.lblTuition.TabIndex = 27;
            this.lblTuition.Text = "Tuition";
            // 
            // lblUndergraduateStudent
            // 
            this.lblUndergraduateStudent.AutoSize = true;
            this.lblUndergraduateStudent.Location = new System.Drawing.Point(7, 9);
            this.lblUndergraduateStudent.Name = "lblUndergraduateStudent";
            this.lblUndergraduateStudent.Size = new System.Drawing.Size(118, 13);
            this.lblUndergraduateStudent.TabIndex = 25;
            this.lblUndergraduateStudent.Text = "Undergraduate Student";
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Location = new System.Drawing.Point(243, 20);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(29, 13);
            this.lblGPA.TabIndex = 24;
            this.lblGPA.Text = "GPA";
            // 
            // txtStudentGPA
            // 
            this.txtStudentGPA.Location = new System.Drawing.Point(286, 17);
            this.txtStudentGPA.Name = "txtStudentGPA";
            this.txtStudentGPA.Size = new System.Drawing.Size(100, 20);
            this.txtStudentGPA.TabIndex = 23;
            // 
            // txtStudentMajor
            // 
            this.txtStudentMajor.Location = new System.Drawing.Point(77, 17);
            this.txtStudentMajor.Name = "txtStudentMajor";
            this.txtStudentMajor.Size = new System.Drawing.Size(100, 20);
            this.txtStudentMajor.TabIndex = 22;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(28, 20);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(33, 13);
            this.lblMajor.TabIndex = 21;
            this.lblMajor.Text = "Major";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(0, 3);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(44, 13);
            this.lblStudent.TabIndex = 20;
            this.lblStudent.Text = "Student";
            // 
            // grpFaculty
            // 
            this.grpFaculty.Controls.Add(this.txtFacultyRank);
            this.grpFaculty.Controls.Add(this.grpChairperson);
            this.grpFaculty.Controls.Add(this.txtFacultyDepartment);
            this.grpFaculty.Controls.Add(this.lblRank);
            this.grpFaculty.Controls.Add(this.lblDepartment);
            this.grpFaculty.Controls.Add(this.lblFaculty);
            this.grpFaculty.Enabled = false;
            this.grpFaculty.Location = new System.Drawing.Point(8, 48);
            this.grpFaculty.Name = "grpFaculty";
            this.grpFaculty.Size = new System.Drawing.Size(455, 85);
            this.grpFaculty.TabIndex = 37;
            // 
            // txtFacultyRank
            // 
            this.txtFacultyRank.FormattingEnabled = true;
            this.txtFacultyRank.Items.AddRange(new object[] {
            "Assistant Professor (AstP)",
            "Associate Professor (AscP)",
            "Full Professor (Prof)",
            "Leturer (Lect)",
            "Instructor (Inst)",
            "Emeritus (Emer)"});
            this.txtFacultyRank.Location = new System.Drawing.Point(314, 14);
            this.txtFacultyRank.Name = "txtFacultyRank";
            this.txtFacultyRank.Size = new System.Drawing.Size(121, 21);
            this.txtFacultyRank.TabIndex = 21;
            // 
            // grpChairperson
            // 
            this.grpChairperson.Controls.Add(this.txtChairpersonStipend);
            this.grpChairperson.Controls.Add(this.lblChairpersonStipend);
            this.grpChairperson.Controls.Add(this.lblChairperson);
            this.grpChairperson.Enabled = false;
            this.grpChairperson.Location = new System.Drawing.Point(7, 39);
            this.grpChairperson.Name = "grpChairperson";
            this.grpChairperson.Size = new System.Drawing.Size(519, 45);
            this.grpChairperson.TabIndex = 20;
            // 
            // txtChairpersonStipend
            // 
            this.txtChairpersonStipend.Location = new System.Drawing.Point(129, 14);
            this.txtChairpersonStipend.Name = "txtChairpersonStipend";
            this.txtChairpersonStipend.Size = new System.Drawing.Size(100, 20);
            this.txtChairpersonStipend.TabIndex = 19;
            // 
            // lblChairpersonStipend
            // 
            this.lblChairpersonStipend.AutoSize = true;
            this.lblChairpersonStipend.Location = new System.Drawing.Point(21, 17);
            this.lblChairpersonStipend.Name = "lblChairpersonStipend";
            this.lblChairpersonStipend.Size = new System.Drawing.Size(102, 13);
            this.lblChairpersonStipend.TabIndex = 18;
            this.lblChairpersonStipend.Text = "Chairperson Stipend";
            // 
            // lblChairperson
            // 
            this.lblChairperson.AutoSize = true;
            this.lblChairperson.Location = new System.Drawing.Point(7, 4);
            this.lblChairperson.Name = "lblChairperson";
            this.lblChairperson.Size = new System.Drawing.Size(63, 13);
            this.lblChairperson.TabIndex = 17;
            this.lblChairperson.Text = "Chairperson";
            // 
            // txtFacultyDepartment
            // 
            this.txtFacultyDepartment.Location = new System.Drawing.Point(102, 14);
            this.txtFacultyDepartment.Name = "txtFacultyDepartment";
            this.txtFacultyDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtFacultyDepartment.TabIndex = 15;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(264, 17);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 14;
            this.lblRank.Text = "Rank";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(28, 17);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 13;
            this.lblDepartment.Text = "Department";
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(0, 1);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(41, 13);
            this.lblFaculty.TabIndex = 12;
            this.lblFaculty.Text = "Faculty";
            // 
            // txtOwlMemberID
            // 
            this.txtOwlMemberID.Location = new System.Drawing.Point(60, 17);
            this.txtOwlMemberID.Name = "txtOwlMemberID";
            this.txtOwlMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtOwlMemberID.TabIndex = 9;
            this.txtOwlMemberID.TextChanged += new System.EventHandler(this.txtOwlMemberID_TextChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(319, 20);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 8;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(170, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // lblOwlMember
            // 
            this.lblOwlMember.AutoSize = true;
            this.lblOwlMember.Location = new System.Drawing.Point(5, 1);
            this.lblOwlMember.Name = "lblOwlMember";
            this.lblOwlMember.Size = new System.Drawing.Size(66, 13);
            this.lblOwlMember.TabIndex = 5;
            this.lblOwlMember.Text = "Owl Member";
            // 
            // lblToFind
            // 
            this.lblToFind.AutoSize = true;
            this.lblToFind.Location = new System.Drawing.Point(24, 111);
            this.lblToFind.Name = "lblToFind";
            this.lblToFind.Size = new System.Drawing.Size(534, 13);
            this.lblToFind.TabIndex = 63;
            this.lblToFind.Text = "To Find/ SEARCH, edit/UPDATE or DELETE enter person\'s ID and Select appropriate c" +
    "ontrol at bottom of form";
            // 
            // pnlEntryControls
            // 
            this.pnlEntryControls.Controls.Add(this.btnCreateChairperson);
            this.pnlEntryControls.Controls.Add(this.btnCreateFaculty);
            this.pnlEntryControls.Controls.Add(this.btnCreateGraduateStudent);
            this.pnlEntryControls.Controls.Add(this.btnCreateUndergraduateStudent);
            this.pnlEntryControls.Location = new System.Drawing.Point(21, 70);
            this.pnlEntryControls.Name = "pnlEntryControls";
            this.pnlEntryControls.Size = new System.Drawing.Size(586, 34);
            this.pnlEntryControls.TabIndex = 62;
            // 
            // btnCreateChairperson
            // 
            this.btnCreateChairperson.Location = new System.Drawing.Point(455, 5);
            this.btnCreateChairperson.Name = "btnCreateChairperson";
            this.btnCreateChairperson.Size = new System.Drawing.Size(128, 23);
            this.btnCreateChairperson.TabIndex = 3;
            this.btnCreateChairperson.Text = "Create Chairperson";
            this.btnCreateChairperson.UseVisualStyleBackColor = true;
            this.btnCreateChairperson.Click += new System.EventHandler(this.btnCreateChairperson_Click);
            // 
            // btnCreateFaculty
            // 
            this.btnCreateFaculty.Location = new System.Drawing.Point(323, 5);
            this.btnCreateFaculty.Name = "btnCreateFaculty";
            this.btnCreateFaculty.Size = new System.Drawing.Size(126, 23);
            this.btnCreateFaculty.TabIndex = 2;
            this.btnCreateFaculty.Text = "Create Faculty";
            this.btnCreateFaculty.UseVisualStyleBackColor = true;
            this.btnCreateFaculty.Click += new System.EventHandler(this.btnCreateFaculty_Click);
            // 
            // btnCreateGraduateStudent
            // 
            this.btnCreateGraduateStudent.Location = new System.Drawing.Point(174, 5);
            this.btnCreateGraduateStudent.Name = "btnCreateGraduateStudent";
            this.btnCreateGraduateStudent.Size = new System.Drawing.Size(143, 23);
            this.btnCreateGraduateStudent.TabIndex = 1;
            this.btnCreateGraduateStudent.Text = "Create Graduate Student";
            this.btnCreateGraduateStudent.UseVisualStyleBackColor = true;
            this.btnCreateGraduateStudent.Click += new System.EventHandler(this.btnCreateGraduateStudent_Click);
            // 
            // btnCreateUndergraduateStudent
            // 
            this.btnCreateUndergraduateStudent.Location = new System.Drawing.Point(3, 5);
            this.btnCreateUndergraduateStudent.Name = "btnCreateUndergraduateStudent";
            this.btnCreateUndergraduateStudent.Size = new System.Drawing.Size(165, 23);
            this.btnCreateUndergraduateStudent.TabIndex = 0;
            this.btnCreateUndergraduateStudent.Text = "Create Undergraduate Student";
            this.btnCreateUndergraduateStudent.UseVisualStyleBackColor = true;
            this.btnCreateUndergraduateStudent.Click += new System.EventHandler(this.btnCreateUndergraduateStudent_Click_1);
            // 
            // lblNewEntry
            // 
            this.lblNewEntry.AutoSize = true;
            this.lblNewEntry.Location = new System.Drawing.Point(44, 54);
            this.lblNewEntry.Name = "lblNewEntry";
            this.lblNewEntry.Size = new System.Drawing.Size(163, 13);
            this.lblNewEntry.TabIndex = 61;
            this.lblNewEntry.Text = "Controls for Creating a New Entry";
            // 
            // lblToCreate
            // 
            this.lblToCreate.AutoSize = true;
            this.lblToCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToCreate.ForeColor = System.Drawing.Color.Red;
            this.lblToCreate.Location = new System.Drawing.Point(18, 29);
            this.lblToCreate.Name = "lblToCreate";
            this.lblToCreate.Size = new System.Drawing.Size(589, 13);
            this.lblToCreate.TabIndex = 60;
            this.lblToCreate.Text = "To CREATE a new Undergraduate or graduate student, faculty, or chairperson. alway" +
    "s press the button below before typing";
            // 
            // lblDataEntry
            // 
            this.lblDataEntry.AutoSize = true;
            this.lblDataEntry.Location = new System.Drawing.Point(173, 2);
            this.lblDataEntry.Name = "lblDataEntry";
            this.lblDataEntry.Size = new System.Drawing.Size(243, 13);
            this.lblDataEntry.TabIndex = 59;
            this.lblDataEntry.Text = "Data Entry and Display for Temple Owl Community";
            // 
            // lblUserMessage
            // 
            this.lblUserMessage.AutoSize = true;
            this.lblUserMessage.Location = new System.Drawing.Point(303, 54);
            this.lblUserMessage.Name = "lblUserMessage";
            this.lblUserMessage.Size = new System.Drawing.Size(0, 13);
            this.lblUserMessage.TabIndex = 69;
            // 
            // btnYES
            // 
            this.btnYES.Enabled = false;
            this.btnYES.Location = new System.Drawing.Point(626, 433);
            this.btnYES.Name = "btnYES";
            this.btnYES.Size = new System.Drawing.Size(36, 26);
            this.btnYES.TabIndex = 70;
            this.btnYES.Text = "YES";
            this.btnYES.UseVisualStyleBackColor = true;
            this.btnYES.Click += new System.EventHandler(this.btnYES_Click);
            // 
            // btnNO
            // 
            this.btnNO.Enabled = false;
            this.btnNO.Location = new System.Drawing.Point(668, 433);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(36, 26);
            this.btnNO.TabIndex = 72;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(648, 417);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(44, 13);
            this.lblDelete.TabIndex = 73;
            this.lblDelete.Text = "Delete?";
            // 
            // frmOwlCommunity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 513);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnNO);
            this.Controls.Add(this.btnYES);
            this.Controls.Add(this.lblUserMessage);
            this.Controls.Add(this.btnEnterMember);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpOwlMember);
            this.Controls.Add(this.lblToFind);
            this.Controls.Add(this.pnlEntryControls);
            this.Controls.Add(this.lblNewEntry);
            this.Controls.Add(this.lblToCreate);
            this.Controls.Add(this.lblDataEntry);
            this.Name = "frmOwlCommunity";
            this.Text = "Form1";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.grpOwlMember.ResumeLayout(false);
            this.grpOwlMember.PerformLayout();
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.grpGraduateStudent.ResumeLayout(false);
            this.grpGraduateStudent.PerformLayout();
            this.grpUndergraduateStudent.ResumeLayout(false);
            this.grpUndergraduateStudent.PerformLayout();
            this.grpFaculty.ResumeLayout(false);
            this.grpFaculty.PerformLayout();
            this.grpChairperson.ResumeLayout(false);
            this.grpChairperson.PerformLayout();
            this.pnlEntryControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnEnterMember;
        internal System.Windows.Forms.Button btnExitProgram;
        internal System.Windows.Forms.Panel panel8;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnSaveUpdates;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Button btnClickhereToEnterID;
        internal System.Windows.Forms.Label lblTheseOperations;
        internal System.Windows.Forms.Label lblFormControlsDataProcessing;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Panel grpOwlMember;
        internal System.Windows.Forms.DateTimePicker txtOwlMemberBirthDate;
        internal System.Windows.Forms.TextBox txtOwlMemberName;
        internal System.Windows.Forms.Panel grpStudent;
        internal System.Windows.Forms.Panel grpGraduateStudent;
        internal System.Windows.Forms.ComboBox txtGraduateStudentDegreeProgram;
        internal System.Windows.Forms.TextBox txtGraduateStudentStipend;
        internal System.Windows.Forms.Label lblDegreeProgram;
        internal System.Windows.Forms.Label lblStipend;
        internal System.Windows.Forms.Label lblGraduateStudent;
        internal System.Windows.Forms.Panel grpUndergraduateStudent;
        internal System.Windows.Forms.ComboBox txtUndergraduateStudentYear;
        internal System.Windows.Forms.Label lblYear;
        internal System.Windows.Forms.TextBox txtUndergraduateStudentCredits;
        internal System.Windows.Forms.Label lblCredits;
        internal System.Windows.Forms.TextBox txtUndergraduateStudentTuition;
        internal System.Windows.Forms.Label lblTuition;
        internal System.Windows.Forms.Label lblUndergraduateStudent;
        internal System.Windows.Forms.Label lblGPA;
        internal System.Windows.Forms.TextBox txtStudentGPA;
        internal System.Windows.Forms.TextBox txtStudentMajor;
        internal System.Windows.Forms.Label lblMajor;
        internal System.Windows.Forms.Label lblStudent;
        internal System.Windows.Forms.Panel grpFaculty;
        internal System.Windows.Forms.ComboBox txtFacultyRank;
        internal System.Windows.Forms.Panel grpChairperson;
        internal System.Windows.Forms.TextBox txtChairpersonStipend;
        internal System.Windows.Forms.Label lblChairpersonStipend;
        internal System.Windows.Forms.Label lblChairperson;
        internal System.Windows.Forms.TextBox txtFacultyDepartment;
        internal System.Windows.Forms.Label lblRank;
        internal System.Windows.Forms.Label lblDepartment;
        internal System.Windows.Forms.Label lblFaculty;
        internal System.Windows.Forms.TextBox txtOwlMemberID;
        internal System.Windows.Forms.Label lblBirthDate;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblID;
        internal System.Windows.Forms.Label lblOwlMember;
        internal System.Windows.Forms.Label lblToFind;
        internal System.Windows.Forms.Panel pnlEntryControls;
        internal System.Windows.Forms.Button btnCreateChairperson;
        internal System.Windows.Forms.Button btnCreateFaculty;
        internal System.Windows.Forms.Button btnCreateGraduateStudent;
        internal System.Windows.Forms.Button btnCreateUndergraduateStudent;
        internal System.Windows.Forms.Label lblNewEntry;
        internal System.Windows.Forms.Label lblToCreate;
        internal System.Windows.Forms.Label lblDataEntry;
        private System.Windows.Forms.Label lblUserMessage;
        private System.Windows.Forms.Label lblSelectMemberType;
        internal System.Windows.Forms.ComboBox txtMemberType;
        private System.Windows.Forms.Button btnYES;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Label lblDelete;
    }
}

