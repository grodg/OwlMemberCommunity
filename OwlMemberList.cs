///*Gavin Rodgers
// * 3309 Owl Member Community project IV
// * This is the OwlMemberList class that initializes the owl member list and can edit the list
// * Last Edited: 12/11/18
// */
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OwlCommunityFinal.Classes;

//namespace OwlCommunityFinal
//{
//    [Serializable()]
//    public class OwlMemberList
//    {
//        //creates the owlMemberList to store owl members
//        public List<OwlMemberClass> owlMemberList = new List<OwlMemberClass>();
//        public OwlMemberList()
//        {

//        }
//        //counts the size of owlMemberList
//        public int Count()
//        {
//            int c = owlMemberList.Count;
//            return c;
//        }
//        //adds owl member to owl member list
//        public void AddToList(OwlMemberClass NewOwlMember)
//        {
//            owlMemberList.Add(NewOwlMember);
//        }
//        //searches for an owl member and returns a string with info
//        public string ListSearch(string ID)
//        {
//            string owlmember = "";
//            if (ID != "")
//            {

//                int id = int.Parse(ID);
//                int i = 0;
//                while (i < owlMemberList.Count)
//                {
//                    if (id == owlMemberList[i].owlID)
//                    {
//                        owlmember = owlMemberList[i].owlID.ToString() + " " + owlMemberList[i].OwlName.ToString() + " "
//                           + owlMemberList[i].owlBirthDate.ToString();
//                    }
//                    i++;
//                }
//            }
//            return owlmember;

//        }
//        //deletes an owl member
//        public void DeleteOwlMember(string ID)
//        {
//            for (int i = 0; i < owlMemberList.Capacity; i++)
//            {
//                if (Convert.ToString(owlMemberList[i].owlID) == ID)
//                {
//                    owlMemberList.RemoveAt(i);
//                }
//            }
//        }
//        public OwlMemberClass getAnItem(int i)
//        {
//            OwlMemberClass p = owlMemberList[i];
//            return p;
//        }
//        public int searchOwlMemberList(int i, out bool valid)
//        {
//            valid = true;
//            int index = 0;
//            return index;
//        }

//    }

//}
