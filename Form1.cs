/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Form Class that handles the functionality of the form
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OwlCommunityFinal.Classes;
using System.Data.OleDb;

namespace OwlCommunityFinal
{
    internal partial class frmOwlCommunity : Form
    {
        //initializes the owl member list
        //public OwlMemberList memberList = new OwlMemberList();
        public OwlMemberDBClass dbFunctions = new OwlMemberDBClass();
        private int owlMemberSelected;
        Boolean inputValidity = true;
        private int recordsProcessedCount = 0;
        //initializes the form for Owl Community
        internal frmOwlCommunity()
        {
            InitializeComponent();
        }
        //enables correct text box entries for graduate students
        internal void btnCreateGraduateStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a valid 9 digit ID number, at least a first and last name, a birthdate," +
                "A major, a 4 scale GPA in the form of 4.00, A Stipend with or without a decimal point depending, " +
                "and select a degree program from the drop down window ","Please Enter Data");
            FormController.deactivateAddButtons(this);
            btnClickhereToEnterID.Enabled = false;
            FormController.activateGraduateStudent(this);
            owlMemberSelected = 2;
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            txtOwlMemberBirthDate.Enabled = true;
            txtStudentGPA.Enabled = true;
            txtStudentMajor.Enabled = true;
            txtGraduateStudentDegreeProgram.Enabled = true;
            txtGraduateStudentStipend.Enabled = true;
        }
        //enables correct text box entries for faculty member   
        //called for owl member entry validation
        internal void OwlMemberValidation()
        {
            if (Validation.IDValidation(txtOwlMemberID.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.NameValidation(txtOwlMemberName.Text) == false)
            {
                inputValidity = false;
            }
        }
        //called for owl member student entry validation
        internal void StudentValidation()
        {
            OwlMemberValidation();
            if (Validation.StudentMajorValidation(txtStudentMajor.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.StudentGPAValidation(txtStudentGPA.Text) == false)
            {
                inputValidity = false;
            }
        }
        //called for owl member faculty entry validation
        internal void FacultyValidation()
        {
            OwlMemberValidation();
            if (Validation.DepartmentValidation(txtFacultyDepartment.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.FacultyRankValidation(txtFacultyRank.Text) == false)
            {
                inputValidity = false;
            }
        }
        //called for owl member faculty entry validation
        internal void ChairpersonValidation()
        {
            OwlMemberValidation();
            if (Validation.ChairpersonStipendValidation(txtChairpersonStipend.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.DepartmentValidation(txtFacultyDepartment.Text) == false)
            {
                inputValidity = false;
            }
        }
        //called for owl member undergraduate student entry validation
        internal void UndergraduateStudentValidation()
        {
            OwlMemberValidation();
            StudentValidation();
            if (Validation.UndergraduateStudentTuition(txtUndergraduateStudentTuition.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.UndergraduateStudentCredits(txtUndergraduateStudentCredits.Text, this) == false)
            {
                inputValidity = false;
            }
            if (Validation.UndergraduateStudentYearValidation(txtUndergraduateStudentYear.Text) == false)
            {
                inputValidity = false;
            }
        }
        //used for owl member gradutuate student entry validation
        internal void GraduateStudentValidation()
        {
            OwlMemberValidation();
            StudentValidation();
            if (Validation.GraduateStudentStipend(txtGraduateStudentStipend.Text) == false)
            {
                inputValidity = false;
            }
            if (Validation.GraduateStudentDegreeProgramValidation(txtGraduateStudentDegreeProgram.Text) == false)
            {
                inputValidity = false;
            }
        }

        // Display DB Information to be deleted in a message box
        // This is a complete method (from start to finish but you haveto fill in some of the code
        void displayDbInformation()
        {
            bool successFlag;
            OleDbDataReader myDataReader;

            if (txtMemberType.Text == "Undergraduate Student")     // Process Faculty
            {
                myDataReader = dbFunctions.SelectOwlMemberFromUndergraduateStudent(txtOwlMemberID.Text, out successFlag);
                if (myDataReader == null)
                {
                    MessageBox.Show("On UndergraduateStudent Select, null returned. No match found.  Reenter ID",
                            "UndergraduateStudent SELECT Error", MessageBoxButtons.OK);
                    // this.Close();
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                }
                else
                {
                    myDataReader.Read();
                    if (!myDataReader.HasRows)
                    {
                        MessageBox.Show("Select UndergraduateStudent produced no rows. No match found. DB and Serializable File not synched. Reenter ID.", "Faculty SELECT Error", MessageBoxButtons.OK);
                        txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        try
                        {
                            txtOwlMemberID.Text = myDataReader[0].ToString();
                            txtUndergraduateStudentTuition.Text = myDataReader[1].ToString();
                            txtUndergraduateStudentYear.Text = (myDataReader[2]).ToString();
                            txtUndergraduateStudentCredits.Text = myDataReader[3].ToString();
                            txtStudentMajor.Text = myDataReader[5].ToString();
                            txtStudentGPA.Text = myDataReader[6].ToString();
                            txtOwlMemberName.Text = myDataReader[8].ToString();
                            txtOwlMemberBirthDate.Text = myDataReader[9].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("DataReader Faculty Data Conversion Error. Reenter ID. ", "Faculty SELECT Error", MessageBoxButtons.OK);
                            txtOwlMemberID.Text = "";
                            txtOwlMemberID.Focus();
                        }  // end try-catch
                    }  // end else on myDataReader HasRows
                }  // end else on myDataReader == null
            }  // end processing Faculty

            else if (txtMemberType.Text == "Graduate Student")     // Process Chairperson
            {

                myDataReader = dbFunctions.SelectOwlMemberFromGraduateStudent(txtOwlMemberID.Text, out successFlag);
                if (myDataReader == null)
                {
                    MessageBox.Show("On GraduateStudent Select, null returned. No match found.  Reenter ID",
                            "Faculty SELECT Error", MessageBoxButtons.OK);
                    // this.Close();
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                }
                else
                {
                    myDataReader.Read();
                    if (!myDataReader.HasRows)
                    {
                        MessageBox.Show("Select GraduateStudent produced no rows. No match found. DB and Serializable File not synched. Reenter ID.", "Faculty SELECT Error", MessageBoxButtons.OK);
                        txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        try
                        {
                            txtOwlMemberID.Text = myDataReader[0].ToString();
                            txtGraduateStudentDegreeProgram.Text = myDataReader[1].ToString();
                            txtGraduateStudentStipend.Text = (myDataReader[2]).ToString();
                            txtStudentMajor.Text = myDataReader[4].ToString();
                            txtStudentGPA.Text = myDataReader[5].ToString();
                            txtOwlMemberName.Text = myDataReader[7].ToString();
                            txtOwlMemberBirthDate.Text = myDataReader[8].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("DataReader Faculty Data Conversion Error. Reenter ID. ", "Faculty SELECT Error", MessageBoxButtons.OK);
                            txtOwlMemberID.Text = "";
                            txtOwlMemberID.Focus();
                        }  // end try-catch
                    }  // end else on myDataReader HasRows
                }  // end else on myDataReader == null

            }  // end processing Chairperson 

            else if (txtMemberType.Text == "Faculty Member")     // Process Undergrad
            {
                myDataReader = dbFunctions.SelectOwlMemberFromFaculty(txtOwlMemberID.Text, out successFlag);
                if (myDataReader == null)
                {
                    MessageBox.Show("On Faculty Select, null returned. No match found. DB and Serializable File not synched.  Reenter ID",
                            "Faculty SELECT Error", MessageBoxButtons.OK);
                    // this.Close();
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                }
                else
                {
                    myDataReader.Read();
                    if (!myDataReader.HasRows)
                    {
                        MessageBox.Show("Select Faculty produced no rows. No match found. DB and Serializable File not synched. Reenter ID.", "Faculty SELECT Error", MessageBoxButtons.OK);
                        txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        try
                        {
                            txtOwlMemberID.Text = myDataReader[0].ToString();
                            txtFacultyDepartment.Text = myDataReader[1].ToString();
                            txtFacultyRank.Text = myDataReader[2].ToString();
                            txtOwlMemberName.Text = myDataReader[4].ToString();
                            txtOwlMemberBirthDate.Text = myDataReader[5].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("DataReader Faculty Data Conversion Error. Reenter ID. ", "Faculty SELECT Error", MessageBoxButtons.OK);
                            txtOwlMemberID.Text = "";
                            txtOwlMemberID.Focus();
                        }  // end try-catch
                    }  // end else on myDataReader HasRows
                }  // end else on myDataReader == null

            }  // end Processing Undergrad

            else if (txtMemberType.Text == "Faculty Chairperson")   /// Process GradStudent
            {
                myDataReader = dbFunctions.SelectOwlMemberFromChairperson(txtOwlMemberID.Text, out successFlag);
                if (myDataReader == null)
                {
                    MessageBox.Show("On Chairperson Select, null returned. No match found.  Reenter ID",
                            "Chairperson SELECT Error", MessageBoxButtons.OK);
                    // this.Close();
                    txtOwlMemberID.Text = "";
                    txtOwlMemberID.Focus();
                }
                else
                {
                    myDataReader.Read();
                    if (!myDataReader.HasRows)
                    {
                        MessageBox.Show("Select Chairperson produced no rows. No match found. DB and Serializable File not synched. Reenter ID.", "Faculty SELECT Error", MessageBoxButtons.OK);
                        txtOwlMemberID.Text = "";
                        txtOwlMemberID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Faculty record found and read.  ", "Faculty Record Found", MessageBoxButtons.OK);
                        try
                        {
                            txtOwlMemberID.Text = myDataReader[0].ToString();
                            txtChairpersonStipend.Text = myDataReader[1].ToString();
                            txtFacultyDepartment.Text = myDataReader[3].ToString();
                            txtFacultyRank.Text = myDataReader[4].ToString();
                            txtOwlMemberName.Text = myDataReader[6].ToString();
                            txtOwlMemberBirthDate.Text = myDataReader[7].ToString();
                        }
                        catch
                        {
                            MessageBox.Show("DataReader Chairperson Data Conversion Error. Reenter ID. ", "Chairperson SELECT Error", MessageBoxButtons.OK);
                            txtOwlMemberID.Text = "";
                            txtOwlMemberID.Focus();
                        }  // end try-catch
                    }  // end else on myDataReader HasRows
                }  // end else on myDataReader == null


            }  // end processing GradStudent
            else
            {
                MessageBox.Show("Type of object to Edit/Update is not valid. Contact System Admin.", "Delete Object Type Error", MessageBoxButtons.OK);
                MessageBox.Show("Number of records processed = " + recordsProcessedCount.ToString(),
                            "Exit Message", MessageBoxButtons.OK);
                this.Close();
            }  // end multiple alternative if
        }  // end displayDbInformation

        // Checks if Owl List is empty and, if not, copies the data for the
        // ith OwlMember to the appropriate group textboxes using the display method+.
        // Also checks to determine if the next button should be enabled.
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            if (Validation.IDValidation(txtOwlMemberID.Text) == true)
            {

                if (txtMemberType.Text == "Undergraduate Student")
                {
                    FormController.activateUndergraduateStudent(this);
                    FormController.deactivateFaculty(this);
                    FormController.deactivateGraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    displayDbInformation();
                    txtOwlMemberID.Enabled = false;
                    txtMemberType.Enabled = false;
                    txtOwlMemberName.Enabled = true;
                    txtOwlMemberBirthDate.Enabled = true;
                    txtStudentGPA.Enabled = true;
                    txtStudentMajor.Enabled = true;
                    txtUndergraduateStudentCredits.Enabled = true;
                    txtUndergraduateStudentTuition.Enabled = true;
                    txtUndergraduateStudentYear.Enabled = true;
                    btnSaveUpdates.Enabled = true;
                }

                else if (txtMemberType.Text == "Graduate Student")
                {
                    FormController.activateGraduateStudent(this);
                    FormController.deactivateFaculty(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    displayDbInformation();
                    txtOwlMemberID.Enabled = false;
                    txtMemberType.Enabled = false;
                    txtOwlMemberName.Enabled = true;
                    txtOwlMemberBirthDate.Enabled = true;
                    txtStudentGPA.Enabled = true;
                    txtStudentMajor.Enabled = true;
                    txtGraduateStudentStipend.Enabled = true;
                    txtGraduateStudentDegreeProgram.Enabled = true;
                    btnSaveUpdates.Enabled = true;

                }
                else if (txtMemberType.Text == "Faculty Member")
                {
                    FormController.deactivateGraduateStudent(this);
                    FormController.activateFaculty(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.deactivateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    displayDbInformation();
                    txtOwlMemberID.Enabled = false;
                    txtMemberType.Enabled = false;
                    txtOwlMemberName.Enabled = true;
                    txtOwlMemberBirthDate.Enabled = true;
                    txtFacultyRank.Enabled = true;
                    txtFacultyDepartment.Enabled = true;
                    btnSaveUpdates.Enabled = true;

                }
                else if (txtMemberType.Text == "Faculty Chairperson")
                {
                    FormController.deactivateGraduateStudent(this);
                    FormController.activateFaculty(this);
                    FormController.deactivateUndergraduateStudent(this);
                    FormController.activateChairperson(this);
                    FormController.deactivateAddButtons(this);
                    displayDbInformation();
                    txtOwlMemberID.Enabled = false;
                    txtMemberType.Enabled = false;
                    txtOwlMemberName.Enabled = true;
                    txtOwlMemberBirthDate.Enabled = true;
                    txtFacultyRank.Enabled = true;
                    txtFacultyDepartment.Enabled = true;
                    txtChairpersonStipend.Enabled = true;
                    btnSaveUpdates.Enabled = true;

                }
            }  // end multiple alternative if
            else
            {
                MessageBox.Show("Fatal error. Data type not Faculty, Undergrad, GradStudent, or Chairperson.  Program     ",
                              "Mis-typed Object", MessageBoxButtons.OK);
                this.Close();
            }  // end multiple alternative if
        }  // end if on success
        //Enters a member into the database depending on member type selected
        private void btnEnterMember_Click(object sender, EventArgs e)
        {
           
                if (owlMemberSelected == 1)
                {
                    UndergraduateStudentValidation();
                    if (inputValidity == true)
                    {
                        UndergraduateStudent undergraduateStudent = new UndergraduateStudent(txtUndergraduateStudentTuition.Text, txtUndergraduateStudentCredits.Text,
                        txtUndergraduateStudentYear.Text, txtOwlMemberName.Text, txtOwlMemberID.Text, txtOwlMemberBirthDate.Text,
                        txtStudentMajor.Text, txtStudentGPA.Text);
                        dbFunctions.InsertUndergraduateStudent(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtStudentMajor.Text,
                        txtStudentGPA.Text, txtUndergraduateStudentTuition.Text,
                        txtUndergraduateStudentYear.Text, txtUndergraduateStudentCredits.Text);
                        FormController.resetForm(this);
                        MessageBox.Show("Member Entered", "Entry Complete");

                    }
                    else
                    {
                        MessageBox.Show("Please Correct Data Input style to provided examples", "Input Invalid");

                    }
                }
                if (owlMemberSelected == 2)
                {
                    GraduateStudentValidation();
                    if (inputValidity == true)
                    {
                        GraduateStudent graduateStudent = new GraduateStudent(txtGraduateStudentStipend.Text, txtGraduateStudentDegreeProgram.Text,
                            txtOwlMemberName.Text, txtOwlMemberID.Text, txtOwlMemberBirthDate.Text,
                            txtStudentMajor.Text, txtStudentGPA.Text);
                        dbFunctions.InsertGraduateStudent(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtStudentMajor.Text, txtStudentGPA.Text,
                            txtGraduateStudentDegreeProgram.Text, txtGraduateStudentStipend.Text);
                        FormController.resetForm(this);
                        MessageBox.Show("Member Entered", "Entry Complete");
                    }
                    else
                    {
                        MessageBox.Show("Please Correct Data Input style to provided examples", "Input Invalid");
                    }
                }
                if (owlMemberSelected == 3)
                {
                    FacultyValidation();
                    if (inputValidity == true)
                    {
                        FacultyClass faculty = new FacultyClass(txtFacultyDepartment.Text, txtFacultyRank.Text, txtOwlMemberID.Text,
                            txtOwlMemberName.Text, txtOwlMemberBirthDate.Text);
                        dbFunctions.InsertFaculty(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtFacultyDepartment.Text, txtFacultyRank.Text);
                        FormController.resetForm(this);
                        MessageBox.Show("Member Entered", "Entry Complete");
                    }
                    else
                    {
                        MessageBox.Show("Please Correct Data Input style to provided examples", "Input Invalid");
                    }
                }
                if (owlMemberSelected == 4)
                {
                    ChairpersonValidation();
                    if (inputValidity == true)
                    {
                        ChairpersonClass chairperson = new ChairpersonClass(txtChairpersonStipend.Text, txtFacultyDepartment.Text, txtFacultyRank.Text,
                            txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text);
                        dbFunctions.InsertChairperson(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtChairpersonStipend.Text,
                        txtFacultyDepartment.Text, txtFacultyRank.Text);
                        FormController.resetForm(this);
                        MessageBox.Show("Member Entered", "Entry Complete");
                    }
                    else
                    {
                        MessageBox.Show("Please Correct Data Input style to provided examples", "Input Invalid");
                    }
                }
          

        }
        //clear button on the form to clear the form data
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            FormController.clear(this);
            btnSaveUpdates.Enabled = false;
        }
        //closes the program from the exit button
        private void btnExitProgram_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //handles create undergrad button
        private void btnCreateUndergraduateStudent_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a 9 digit ID, at least a first and last name, birthdate, a valid all letter Major, " +
                "a 4 scale gpa in the form of 4.00, A tuition with or without decimal points, integer credit amount and your academic " +
                "year based off credit count(Freshman(0 to 29 credits),Sophomore(30 to 59 credits),Junior(60 to 89 credits),Senior(90 or more credits) ", "Please Enter Info");
            FormController.deactivateAddButtons(this);
            btnClickhereToEnterID.Enabled = false;

            FormController.activateUndergraduateStudent(this);
            owlMemberSelected = 1;
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            txtOwlMemberBirthDate.Enabled = true;
            txtStudentGPA.Enabled = true;
            txtStudentMajor.Enabled = true;
            txtUndergraduateStudentCredits.Enabled = true;
            txtUndergraduateStudentTuition.Enabled = true;
            txtUndergraduateStudentYear.Enabled = true;
        }
        //handles create chairperson button
        private void btnCreateChairperson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a 9 digit ID, at least a first and last name, birthdate, an all letter department," +
                "select a rank from the drop down box, and input a stipend either with or without a decimal point", "Please Enter Info");
            btnClickhereToEnterID.Enabled = false;

            FormController.deactivateAddButtons(this);
            FormController.activateChairperson(this);
            owlMemberSelected = 4;
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            txtOwlMemberBirthDate.Enabled = true;
            txtFacultyRank.Enabled = true;
            txtFacultyDepartment.Enabled = true;
            txtChairpersonStipend.Enabled = true;

        }
        //handles create faculty button
        private void btnCreateFaculty_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a 9 digit ID, at least a first and last name, birthdate, an all letter department and " +
                "select a rank from the drop down box", "Please Enter Info");
            FormController.deactivateAddButtons(this);
            btnClickhereToEnterID.Enabled = false;
            FormController.activateFaculty(this);
            owlMemberSelected = 3;
            txtOwlMemberID.Enabled = true;
            txtOwlMemberName.Enabled = true;
            txtOwlMemberBirthDate.Enabled = true;
            txtFacultyRank.Enabled = true;
            txtFacultyDepartment.Enabled = true;
        }
        //handles the enter ID button on form
        private void btnClickhereToEnterID_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter a 9 digit ID and select a member type");
            btnClickhereToEnterID.Enabled = false;
            FormController.clear(this);
            FormController.deactivateAddButtons(this);
            txtOwlMemberID.Enabled = true;
            txtMemberType.Visible = true;
            txtMemberType.Enabled = true;
            lblSelectMemberType.Visible = true;
            btnEnterMember.Enabled = false;
        }
        //finds a member from the find button
        private void btnFind_Click_1(object sender, EventArgs e)
        {
            if (txtMemberType.Text == "Undergraduate Student")
            {
                displayDbInformation();
            }
            if (txtMemberType.Text == "Graduate Student")
            {
                displayDbInformation();
            }
            if (txtMemberType.Text == "Faculty Member")
            {
                displayDbInformation();
            }
            if (txtMemberType.Text == "Faculty Chairperson")
            {
                displayDbInformation();
            }
        }
        //handles the save update button on the form
        private void btnSaveUpdates_Click_1(object sender, EventArgs e)
        {
            if (txtMemberType.Text == "Undergraduate Student")
            {
                dbFunctions.UpdateUndergraduateStudent(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtStudentMajor.Text,
                    txtStudentGPA.Text, txtUndergraduateStudentTuition.Text, txtUndergraduateStudentCredits.Text, txtUndergraduateStudentYear.Text);
                MessageBox.Show("Updates Saved","Saved");
                FormController.clear(this);
            }
           else if (txtMemberType.Text == "Graduate Student")
            {
                dbFunctions.UpdateGraduateStudent(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtStudentMajor.Text,
                    txtStudentGPA.Text, txtGraduateStudentStipend.Text, txtGraduateStudentDegreeProgram.Text);
                MessageBox.Show("Updates Saved", "Saved");
                FormController.clear(this);
            }
            else if (txtMemberType.Text == "Faculty Member")
            {
                dbFunctions.UpdateFaculty(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtFacultyDepartment.Text, txtFacultyRank.Text);
                MessageBox.Show("Updates Saved", "Saved");
                FormController.clear(this);
            }
            else if (txtMemberType.Text == "Faculty Chairperson")
            {
                dbFunctions.UpdateChairperson(txtOwlMemberID.Text, txtOwlMemberName.Text, txtOwlMemberBirthDate.Text, txtFacultyDepartment.Text,
                    txtFacultyRank.Text, txtFacultyRank.Text);
                MessageBox.Show("Updates Saved", "Saved");
                FormController.clear(this);
            }
            else if(txtMemberType.Text != "Undergraduate Student" || txtMemberType.Text != "Graduate Student" || txtMemberType.Text != "Faculty Member" ||txtMemberType.Text != "Faculty Chairperson")
            {
                MessageBox.Show("Please select a member type from the drop down box and then proceed", "Error");
            }

        }
        //handles the delete button on the form
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtOwlMemberID.Enabled = false;
            txtMemberType.Enabled = false;
            btnSaveUpdates.Enabled = false;
            btnFind.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            displayDbInformation();
            MessageBox.Show("Please Select YES or NO depending if this is the record you want to delete", "Select YES or NO");
            btnYES.Enabled = true;
            btnNO.Enabled = true;
        }
        //handles the yes delete button to the frm
        private void btnYES_Click(object sender, EventArgs e)
        {
            btnNO.Enabled = false;
            btnYES.Enabled = false;
            dbFunctions.Delete(Convert.ToInt32(txtOwlMemberID.Text));
            MessageBox.Show("Member removed from database", "Delete Completed");
        }
        //handles the no delete button to the form
        private void btnNO_Click(object sender, EventArgs e)
        {
            FormController.activateAddButtons(this);
            MessageBox.Show("Please begin new function", "Delete Cancelled");
        }
        //text box for ID validation used for botton control button enablition to prevent issues
        private void txtOwlMemberID_TextChanged(object sender, EventArgs e)
        {
            if (txtOwlMemberID.TextLength == 9)
            {
                if (txtMemberType.Text == "Undergraduate Student" || txtMemberType.Text == "Graduate Student"
                    || txtMemberType.Text == "Faculty Member" || txtMemberType.Text == "Faculty Chairperson")
                {
                    btnFind.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }
        //text box for MemberType validation used for botton control button enablition to prevent issues
        private void txtMemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtMemberType.Text == "Undergraduate Student" || txtMemberType.Text == "Graduate Student"
                    || txtMemberType.Text == "Faculty Member" || txtMemberType.Text == "Faculty Chairperson")
            {
                if (txtOwlMemberID.TextLength == 9)
                {
                    btnFind.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
        }
    }
}

