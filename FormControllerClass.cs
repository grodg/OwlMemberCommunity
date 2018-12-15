/* Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Form Controller class that modifies the form
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using OwlCommunityFinal.Classes;

namespace OwlCommunityFinal
{
    static class FormController
    {
        // Resets form to initial state after form is loaded or
        //    an add Employee operation is performed

        public static void resetForm(frmOwlCommunity f)
        {
            //  Reset button components
            f.btnCreateFaculty.Enabled = true;
            f.btnCreateFaculty.Text = "Create Faculty";
            f.btnCreateChairperson.Enabled = true;
            f.btnCreateChairperson.Text = "Create Chairperson";
            f.btnCreateGraduateStudent.Enabled = true;
            f.btnCreateGraduateStudent.Text = "Create Graduate Student";
            f.btnCreateUndergraduateStudent.Enabled = true;
            f.btnCreateUndergraduateStudent.Text = "Create Undergraduate";

            // Reset group components
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.Gainsboro;
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Gainsboro;
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Gainsboro;
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Gainsboro;
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Gainsboro;
            f.grpChairperson.BackColor = Color.Gainsboro;
            f.grpChairperson.Enabled = false;

            // Reset Text boxes
            f.txtOwlMemberID.Enabled = false;
            f.txtOwlMemberName.Enabled = false;
            f.txtOwlMemberBirthDate.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.txtFacultyRank.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtUndergraduateStudentTuition.Enabled = false;
            f.txtUndergraduateStudentYear.Enabled = false;
            f.txtUndergraduateStudentCredits.Enabled = false;
            f.txtGraduateStudentDegreeProgram.Enabled = false;
            f.txtGraduateStudentStipend.Enabled = false;
            f.txtFacultyDepartment.Enabled = false;
            f.txtFacultyRank.Enabled = false;
        } // end resetForm


        // Activates and deactivates necessary form buttons
        //    when in add mode
        public static void formAddMode(frmOwlCommunity f)
        {
            f.btnClear.Enabled = true;
            f.btnDelete.Enabled = false;
            f.btnEdit.Enabled = false;
            f.btnFind.Enabled = false;
        }  // end formAddMode


        // Enable/disable buttons when not in edit mode
        public static void activateAddButtons(frmOwlCommunity f)
        {
            f.btnCreateGraduateStudent.Enabled = true;
            f.btnCreateChairperson.Enabled = true;
            f.btnCreateUndergraduateStudent.Enabled = true;
            f.btnCreateFaculty.Enabled = true;
        }  // end activateAddButtons


        // Enable/disable buttons when not in edit mode
        public static void deactivateAddButtons(frmOwlCommunity f)
        {
            f.btnCreateGraduateStudent.Enabled = false;
            f.btnCreateChairperson.Enabled = false;
            f.btnCreateUndergraduateStudent.Enabled = false;
            f.btnCreateFaculty.Enabled = false;
        }  // end deactivateAddButtons


        // Enables OwlMember textboxes and highlights the OwlMember groupbox
        public static void activateOwlMember(frmOwlCommunity f)
        {
            f.grpOwlMember.Enabled = true;
            f.grpOwlMember.BackColor = Color.LimeGreen;

        }  // end activateOwlMember


        //  Enables Student textboxes and highlights the Student groupbox
        public static void activateStudent(frmOwlCommunity f)
        {
            activateOwlMember(f);
            f.grpStudent.Enabled = true;
            f.grpStudent.BackColor = Color.LimeGreen;
        }  // end ActivateStudent


        // Enables Faculty textboxes and highlights the Faculty groupbox
        public static void activateFaculty(frmOwlCommunity f)
        {
            activateOwlMember(f);
            f.grpFaculty.Enabled = true;
            f.grpFaculty.BackColor = Color.LimeGreen;
            f.grpStudent.BackColor = Color.Red;
            f.btnEnterMember.Enabled = true;
        }  // end activateFaculty


        // Enables Undergrad Student textboxes and highlights the Undergrad Student groupbox
        public static void activateUndergraduateStudent(frmOwlCommunity f)
        {
            activateStudent(f);   // Student must be activated too
            f.grpUndergraduateStudent.Enabled = true;
            f.grpUndergraduateStudent.BackColor = Color.LimeGreen;
            f.btnEnterMember.Enabled = true;

        }  // end activateUndergraduateStudent


        // Enables Worker textboxes and highlights the Graduate Student groupbox
        public static void activateGraduateStudent(frmOwlCommunity f)
        {
            activateStudent(f);  // Student must be activated too
            f.grpGraduateStudent.Enabled = true;
            f.grpGraduateStudent.BackColor = Color.LimeGreen;
            f.btnEnterMember.Enabled = true;

        }  // end activateGraduateStudent


        // Enables Chairperson textboxes and highlights the Chairperson groupbox
        public static void activateChairperson(frmOwlCommunity f)
        {
            activateFaculty(f);  // Faculty must be activated too
            f.grpChairperson.Enabled = true;
            f.grpChairperson.BackColor = Color.LimeGreen;
            f.btnEnterMember.Enabled = true;
        }  // end activateChairperson


        // Disables OwlMember textboxes and highlights the OwlMember groupbox
        public static void deactivateOwlMember(frmOwlCommunity f)
        {
            deactivateStudent(f);
            deactivateFaculty(f);
            f.grpOwlMember.Enabled = false;
            f.grpOwlMember.BackColor = Color.Red;
        }  // end deactivateOwlMember


        // Disables Student textboxes and highlights the Student groupbox
        public static void deactivateStudent(frmOwlCommunity f)
        {
            deactivateUndergraduateStudent(f);   // Must deactivate UG Student too
            deactivateGraduateStudent(f);        // Must deactivate Grad Student too
            f.grpStudent.Enabled = false;
            f.grpStudent.BackColor = Color.Red;
        }  // end deactivateStudent


        // Disables Faculty textboxes and highlights the Faculty groupbox
        public static void deactivateFaculty(frmOwlCommunity f)
        {
            f.grpFaculty.Enabled = false;
            f.grpFaculty.BackColor = Color.Red;
        }  // end deactivateFaculty


        // Disables Undergraduate Student textboxes and highlights the Undergrad groupbox
        public static void deactivateUndergraduateStudent(frmOwlCommunity f)
        {
            f.grpUndergraduateStudent.Enabled = false;
            f.grpUndergraduateStudent.BackColor = Color.Red;
        }  // end deactivateUndergraduateStudent
        // Disables Graduate Student textboxes and highlights the Grad Student groupbox
        public static void deactivateGraduateStudent(frmOwlCommunity f)
        {
            f.grpGraduateStudent.Enabled = false;
            f.grpGraduateStudent.BackColor = Color.Red;
        }  // end deativateGraduateStudent
        // Disables Chairperson textboxes and highlights the Chairperson groupbox
        public static void deactivateChairperson(frmOwlCommunity f)
        {
            f.grpFaculty.Enabled = false;
            f.grpChairperson.BackColor = Color.Red;
        }   // end deativateChairperson
        // Clear all textboxes on the form
        public static void clear(frmOwlCommunity f)
        {
            f.txtOwlMemberName.Text = "";
            f.txtOwlMemberBirthDate.Text = "";
            f.txtOwlMemberID.Text = "";
            f.txtOwlMemberID.Focus();
            f.txtFacultyDepartment.Text = "";
            f.txtFacultyRank.Text = "";
            f.txtStudentMajor.Text = "";
            f.txtStudentGPA.Text = "";
            f.txtUndergraduateStudentTuition.Text = "";
            f.txtUndergraduateStudentYear.Text = "";
            f.txtUndergraduateStudentCredits.Text = "";
            f.txtGraduateStudentStipend.Text = "";
            f.txtGraduateStudentDegreeProgram.Text = "";
            f.txtChairpersonStipend.Text = "";
            f.txtMemberType.Text = "";
            f.txtMemberType.Enabled = false;
            resetForm(f);
            f.btnClickhereToEnterID.Enabled = true;
        } // end Clear
        public static void disableAll(frmOwlCommunity f)
        {
            f.txtOwlMemberName.Enabled = false;
            f.txtOwlMemberBirthDate.Enabled = false;
            f.txtOwlMemberID.Enabled = false;
            f.txtOwlMemberID.Focus();
            f.txtFacultyDepartment.Enabled = false;
            f.txtFacultyRank.Enabled = false;
            f.txtStudentMajor.Enabled = false;
            f.txtStudentGPA.Enabled = false;
            f.txtUndergraduateStudentTuition.Enabled = false;
            f.txtUndergraduateStudentYear.Enabled = false;
            f.txtUndergraduateStudentCredits.Enabled = false;
            f.txtGraduateStudentStipend.Enabled = false;
            f.txtGraduateStudentDegreeProgram.Enabled = false;
            f.txtChairpersonStipend.Enabled = false;
        }

    }  // end FormController class
}  // end namespace