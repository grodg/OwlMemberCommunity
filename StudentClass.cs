/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Students class that stores the student object information
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using OwlCommunityFinal.Classes;

namespace OwlCommunityFinal
{
    // Client inherits the data and methods in Person
    [Serializable()]
    abstract class Student : OwlMemberClass
    {
        private string hiddenStudentMajor;
        private string hiddenStudentGPA;

        // Parameterless Constructor
        public Student()
        {
            hiddenStudentMajor = "";
            hiddenStudentGPA = "";

        } // end Employee Parameterless Constructor


        // Parameterized Constructor
        public Student(string name, string id, string dob,  // For Person Constructor
            string major, string gpa) : base(id, name, dob)
        {

            hiddenStudentMajor = major;
            hiddenStudentGPA = gpa;
        }  // end Employee Parameterized Constructor


        // Accessor/mutator for job title
        public string studentMajor
        {
            get
            {
                return hiddenStudentMajor;
            }  // end get
            set   // (string value)
            {
                hiddenStudentMajor = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for job title
        public string studentGPA
        {
            get
            {
                return hiddenStudentGPA;
            }  // end get
            set   // (string value)
            {
                hiddenStudentGPA = value;
            }  // end get
        }  // end Property

        // Save data from form to object
        internal override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            hiddenStudentMajor = f.txtStudentMajor.Text;
            hiddenStudentGPA = f.txtStudentGPA.Text;
        } // end Save


        // Display data in object on form
        internal override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtStudentMajor.Text = hiddenStudentMajor;
            f.txtStudentGPA.Text = hiddenStudentGPA.ToString();
        }  // end Display


        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Student Info: " + hiddenStudentGPA + hiddenStudentGPA.ToString(); ;
            return s;
        }  // end ToString

    }  // end Student class
}  // end namespace

