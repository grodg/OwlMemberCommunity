/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Chairperson class that stores information on Faculty objects
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
    class ChairpersonClass : FacultyClass
    {
        //class attributes
        private string chairpersonStipend;
        //constructor used for chairpersonclass
        public ChairpersonClass()
        {
            chairpersonStipend = "";
        }
        //constructor used for chairperson class with parameters
        public ChairpersonClass(string ChairpersonStipend, string Department, string Rank, string ID, string name, string dob)
            : base(Department, Rank, ID, name, dob)
        {
            chairpersonStipend = ChairpersonStipend;
        }
        //getter and setter for chairperson stipend
        public string getFacultyChairperson()
        {     
                return chairpersonStipend;         
        }  // end Property
        //method used for saving base and setting chairperson stipend to the form entry value
        internal override void Save(frmOwlCommunity f)
        {
            base.Save(f);
            chairpersonStipend = f.txtChairpersonStipend.Text;

        } // end Save

        // Display data in object on form
        internal override void Display(frmOwlCommunity f)
        {
            base.Display(f);
            f.txtChairpersonStipend.Text = chairpersonStipend.ToString();
        }  // end Display

        // This toString function overrides the Object toString
        //     function.  The base refers to Object because this class
        //     inherits Object by default.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Chairperson Info: " + chairpersonStipend.ToString(); ;
            return s;
        }  // end ToString
    }
}
