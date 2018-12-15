/*Gavin Rodgers
 * 3309 Owl Member Community project IV
 * This is the Validation class that checks input validation
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OwlCommunityFinal.Classes;
using System.Text.RegularExpressions;

namespace OwlCommunityFinal
{
    static class Validation
    {
        //method used for validating ID owl member entry
        public static Boolean IDValidation(string ID)
        {
            try
            {
                if (ID.Length == 9)
                {
                    int Num;
                    bool isNum = int.TryParse(ID, out Num);
                    if (isNum)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //method used for owl member name validation
        public static Boolean NameValidation(string name)
        {
            try
            {
                if (name.Length < 20)
                {
                    if (Regex.Match(name, @"^([a-zA-Z]*)\s+([a-zA-Z ]*)$").Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        //method used for faculty department name entry
        public static Boolean DepartmentValidation(string name)
        {
            try
            {
                if (name.Length < 45)
                {
                    if (name != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        //method used for chairperson stipend entry validation
        public static Boolean ChairpersonStipendValidation(string stipend)
        {
            try
            {
                if (stipend.Length < 15)
                {
                    if (Regex.Match(stipend, @"^\$?[0-9][0-9\,]*(\.\d{1,2})?$|^\$?[\.]([\d][\d]?)$").Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //used for owl member student major validation
        public static Boolean StudentMajorValidation(string major)
        {
            try
            {
                if (major.Length < 20)
                {
                    if (major != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        //used for student gpa validation
        public static Boolean StudentGPAValidation(string gpa)
        {
            try
            {
                if (gpa.Length < 20)
                {
                    if (Regex.Match(gpa, @"^[0-4]\.\d{2}$").Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
        }
        //this method validates the undergraduate tuition amount
        public static Boolean UndergraduateStudentTuition(string tuition)
        {
            try
            {
                if (tuition.Length < 15)
                {
                    if (Regex.Match(tuition, @"^\$?[0-9][0-9\,]*(\.\d{1,2})?$|^\$?[\.]([\d][\d]?)$").Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //Freshman(0 to 29 credits)
        //Sophomore(30 to 59 credits)
        //Junior(60 to 89 credits)
        //Senior(90 or more credits)
        //validates undergraduate student credit amounts
        public static Boolean UndergraduateStudentCredits(string credits, frmOwlCommunity f)
        {
            try
            {
                string year = Convert.ToString(f.txtUndergraduateStudentYear.Text);
                int cred = Int32.Parse(credits);
                int Num;
                bool isValid = int.TryParse(credits, out Num);
                if (isValid)
                {
                    if (year == "Freshman" && (cred >= 0 && cred <= 29))
                    {
                        return true;
                    }
                    else if (year == "Sophomore" && (cred >= 30 && cred <= 59))
                    {
                        return true;
                    }
                    else if (year == "Junior" && (cred >= 60 && cred <= 89))
                    {
                        return true;
                    }
                    else if (year == "Senior" && (cred >= 90))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //method used to validate graduate student stipend amount
        public static Boolean GraduateStudentStipend(string stipend)
        {
            try
            {
                if (stipend.Length < 15)
                {
                    if (Regex.Match(stipend, @"^\$?[0-9][0-9\,]*(\.\d{1,2})?$|^\$?[\.]([\d][\d]?)$").Success)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        //validates faculty rank
        public static Boolean FacultyRankValidation(string rank)
        {
            if (rank != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validates undergraduate year 
        public static Boolean UndergraduateStudentYearValidation(string year)
        {
            if (year != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //validates graduate student degree program entry
        public static Boolean GraduateStudentDegreeProgramValidation(string DegreeProgram)
        {
            if (DegreeProgram != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

