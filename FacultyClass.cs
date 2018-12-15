/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Faculty class that stores info for faculty objects
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
    class FacultyClass : OwlMemberClass
    {
        //setting the class attributes
        public string department;
        public string rank;
        //non parameter constructor 
        public FacultyClass()
        {
        }
        //class constructor with parameter constructor
        public FacultyClass(string Department, string Rank, string ID, string name, string dob)
            : base(ID, name, dob)
        {
            rank = Rank;
            department = Department;
        }
        //department class value getter and setter
        public string FacultyDepartment
        {
            get
            {
                return department;
            }  // end get
            set   // (string value)
            {
                department = value;
            }  // end get
        }  // end Property
        //rank class value getter and setter
        public string FacultyRank
        {
            get
            {
                return rank;
            }  // end get
            set   // (string value)
            {
                rank = value;
            }  // end get
        }  // end Property
        //method used to save the base values and setting the class values to that of form entries
        internal override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            department = f.txtFacultyDepartment.Text;
            rank = f.txtFacultyRank.Text;

        } // end Save

        // Display data in object on form
        internal override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtFacultyDepartment.Text = department;
            f.txtFacultyRank.Text = rank;
        }  // end Display

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Faculty Info: " + department + rank;
            return s;
        }  // end ToString
    }
}