/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Graduate Student class that stores info on graduate student object
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunityFinal.Classes;

namespace OwlCommunityFinal
{
    [Serializable()]
    class GraduateStudent : Student
    {
        //class attributes
        private string stipend;
        private string degreeProgram;
        //class constructor with no parameters
        public GraduateStudent()
        {
            stipend = "";
            degreeProgram = "";
        }
        //class constructor with parameters
        public GraduateStudent(string Stipend, string DegreeProgram, string name, string id, string dob,
             string major, string gpa) : base(name, id, dob, major, gpa)
        {
            stipend = Stipend;
            degreeProgram = DegreeProgram;
        }
        //getter and setter for stipend
        public string GraduateStudentStipend
        {
            get
            {
                return stipend;
            }  // end get
            set   // (string value)
            {
                stipend = value;
            }  // end get
        }  // end Property
        public string getGraduateStudentStipend()
        {
            return stipend;
        }
        //getter and setter for degree program
        public string UndergraduateStudentYear
        {
            get
            {
                return degreeProgram;
            }  // end get
            set   // (string value)
            {
                degreeProgram = value;
            }  // end get
        }  // end Property
        public string getGraduateStudentDegreeProgram()
        {
            return degreeProgram;
        }
        //saves base attributes and sets class attributes to form values
        internal override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            stipend = f.txtGraduateStudentStipend.Text;
            degreeProgram = f.txtGraduateStudentDegreeProgram.Text;
        } // end Save


        // Display data in object on form
        internal override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtGraduateStudentStipend.Text = stipend.ToString();
            f.txtGraduateStudentDegreeProgram.Text = degreeProgram;
        }  // end Display

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Graduate Student Info: " + stipend.ToString() + degreeProgram;
            return s;
        }  // end ToString
    }
}