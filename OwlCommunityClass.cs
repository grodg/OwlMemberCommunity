/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the owlMemberClass that stores info on owlmember objects
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using OwlCommunityFinal.Classes;

namespace OwlCommunityFinal.Classes
{
    [Serializable()]
    public abstract class OwlMemberClass
    {
        private int hiddenID;   // Owl ID
        private string hiddenName; // Owl name
        private DateTime hiddenBirthDate;   // Owl birth date

        // Parameterless Constructor
        public OwlMemberClass()
        {
            hiddenID = 0;
            hiddenName = "";
            hiddenBirthDate = DateTime.Now;

        }  // end Owl Parameterless Constructor

        // Parameterized Constructor
        public OwlMemberClass(string id, string name, string bd)
        {
            hiddenName = name;
            hiddenBirthDate = Convert.ToDateTime(bd);
            hiddenID = Int32.Parse(id);
        }  // end Owl Parameterized Constructor


        // Accessor/Mutator for id
        public int owlID
        {
            get
            {
                return hiddenID;
            } //  end get
            set   // (string value)
            {
                hiddenID = value;
            }  // end get
        }  // End Property


        // Accessor/mutator for name
        public string OwlName
        {
            get
            {
                return hiddenName;
            }  // end get
            set   // (string value)
            {
                hiddenName = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for birth date
        public DateTime owlBirthDate
        {
            get
            {
                return hiddenBirthDate;
            }  // end get
            set   // (DateTime value)
            {
                hiddenBirthDate = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        internal virtual void Save(frmOwlCommunity f)
        {
            hiddenName = f.txtOwlMemberName.Text;
            hiddenBirthDate = Convert.ToDateTime(f.txtOwlMemberBirthDate.Text);
            hiddenID = Convert.ToInt32(f.txtOwlMemberID.Text);
        }  // end Save

        // Display data in object on form
        internal virtual void Display(frmOwlCommunity f)
        {
            f.txtOwlMemberName.Text = hiddenName;
            f.txtOwlMemberBirthDate.Text = hiddenBirthDate.ToString();
            f.txtOwlMemberID.Text = hiddenID.ToString();
        }  // end Display

        // This toString function overrides the Object toString function
        // The base refers to Object because this class inherits Object by default
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "OwlName     : " + hiddenName + "\n";
            s += "OwlBirthDate: " + hiddenBirthDate.ToString() + "\n";
            s += "OwlID       :" + hiddenID;
            return s;
        }  // end ToString
    } // end OwlClass

} // end namespace

