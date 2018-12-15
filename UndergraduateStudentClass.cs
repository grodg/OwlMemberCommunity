/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the UndergraduateStudent class that stores info for undergraduate objects
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
    class UndergraduateStudent : Student
    {
        //class attributes
        public string tuition;
        public string credits;
        public string year;
        //class constructor without parameters
        public UndergraduateStudent()
        {
            tuition = "";
            credits = "";
            year = "";
        }
        //class constructor with parameters
        public UndergraduateStudent(string Tuition, string Credits, string Year, string name, string id, string dob,
            string major, string gpa) : base(name, id, dob, major, gpa)
        {
            tuition = Tuition;
            credits = Credits;
            year = Year;
        }
        //getter and setter for undergraduate tuition
        public string getUndergraduateStudentTuition()
        {
            return tuition;
        }
        //getter and setter for undergraduate student credits

        public string getUndergraduateStudentCredits()
        {
            return credits;
        }
        //getter and setter for undergraduate student year
      
        public string getUndergraduateStudentYear()
        {
            return year;
        }
        //saves base and sets class attributes to form values
        internal override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            tuition = f.txtUndergraduateStudentTuition.Text;
            credits = f.txtUndergraduateStudentCredits.Text;
            year = f.txtUndergraduateStudentYear.Text;
        } // end Save

        // Display data in object on form
        internal override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtUndergraduateStudentTuition.Text = tuition.ToString();
            f.txtUndergraduateStudentCredits.Text = credits.ToString();
            f.txtUndergraduateStudentYear.Text = year.ToString();
        }  // end Display

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Undergraduate Student Info: " + tuition.ToString() + credits.ToString() + year.ToString(); ;
            return s;
        }  // end ToString
    }
}
