/*Gavin Rodgers
 * 3309 OwlMember Community Project
 * This Database class handles all the sql statements that interact with the database
 * Last Edited: 12/11/18
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using OwlCommunityFinal.Classes;


namespace OwlCommunityFinal.Classes
{
    class OwlMemberDBClass
    {
        //connection link to the database
        string strConnection = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source= ..\\Debug\\Resources\\OwlMemberDB (1).accdb";
        //constructor for OwlMemberDBClass
        public OwlMemberDBClass()
        {

        }
        //inserts a graduate student into the database
        public void InsertGraduateStudent(string ID, string Name, string BirthDate, string Major, string GPA, string DegreeProgram, string Stipend)
        {
            int id = Int32.Parse(ID);
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    OleDbCommand command1 = new OleDbCommand();
                    OleDbCommand command2 = new OleDbCommand();
                    OleDbCommand command3 = new OleDbCommand();
                    command1.CommandText = "INSERT INTO GraduateStudent (fldID, fldDegreeProgram, fldStipend) " + "VALUES (@ID,@DegreeProgram,@Stipend)";
                    command2.CommandText = "INSERT INTO Student (fldID, fldMajor, fldGpa) " + "VALUES (@ID,@Major,@GPA)";
                    command3.CommandText = "INSERT INTO OwlMember (fldID, fldName, fldBirthdate) " + "VALUES (@ID,@Name,@BirthDate)";
                    command1.Parameters.AddWithValue(@ID,id);
                    command1.Parameters.AddWithValue(@DegreeProgram,DegreeProgram);
                    command1.Parameters.AddWithValue(@Stipend,Stipend);
                    command2.Parameters.AddWithValue(@ID,id);
                    command2.Parameters.AddWithValue(@Major,Major);
                    command2.Parameters.AddWithValue(@GPA,GPA);
                    command3.Parameters.AddWithValue(@ID,id);
                    command3.Parameters.AddWithValue(@Name,Name);
                    command3.Parameters.AddWithValue(@BirthDate, birthdate);
                    command1.Connection = connection;
                    command2.Connection = connection;
                    command3.Connection = connection;
                    connection.Open();
                    command3.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command1.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();

            }
        }
        //inserts an Undergraduate Student into the database
        public void InsertUndergraduateStudent(string ID, string Name, string BirthDate, string Major, string GPA, string Tuition, string Year, string Credits)
        {
            int id = Int32.Parse(ID);          
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            OleDbConnection connection = new OleDbConnection(strConnection);
                try{
                OleDbCommand command1 = new OleDbCommand();
                OleDbCommand command2 = new OleDbCommand();
                OleDbCommand command3 = new OleDbCommand();
                command1.CommandText = "INSERT INTO UndergraduateStudent (fldID, fldTuition, fldYear, fldCredits) " + "VALUES (@ID,@Tuition,@Year,@Credits)";
                command2.CommandText = "INSERT INTO Student (fldID, fldMajor, fldGPA) " + "VALUES (@ID,@Major,@GPA)";
                command3.CommandText = "INSERT INTO OwlMember (fldID, fldName, fldBirthdate) " + "VALUES (@ID,@Name,@BirthDate)";
                command1.Parameters.AddWithValue(@ID,id);
                command1.Parameters.AddWithValue(@Tuition, Tuition);
                command1.Parameters.AddWithValue(@Year,Year);
                command1.Parameters.AddWithValue(@Credits, Credits);
                command2.Parameters.AddWithValue(@ID, id);
                command2.Parameters.AddWithValue(@Major, Major);
                command2.Parameters.AddWithValue(@GPA,GPA);
                command3.Parameters.AddWithValue(@ID,id);
                command3.Parameters.AddWithValue(@Name,Name);
                command3.Parameters.AddWithValue(@BirthDate,birthdate);
                command1.Connection = connection;
                command2.Connection = connection;
                command3.Connection = connection;
                connection.Open();
                command3.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command1.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("Error: " + ex.Message);
                connection.Close();
            }
            connection.Close();
        }
        //inserts a chairperson into the database
        public void InsertChairperson(string ID, string Name, string BirthDate, string Stipend, string Department, string Rank)
        {
            int id = Int32.Parse(ID);
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    OleDbCommand command1 = new OleDbCommand();
                    OleDbCommand command2 = new OleDbCommand();
                    OleDbCommand command3 = new OleDbCommand();
                    command3.CommandText = "INSERT INTO OWlMember (fldID, fldName, fldBirthdate) " + "VALUES (@ID,@Name,@BirthDate)";
                    command2.CommandText = "INSERT INTO Faculty (fldID, fldDepartment, fldRank) " + "VALUES (@ID,@Department,@Rank)";
                    command1.CommandText = "INSERT INTO Chairperson (fldID, fldStipend) " + "VALUES (@ID,@Stipend)";
                    command3.Parameters.AddWithValue(@ID,id);
                    command3.Parameters.AddWithValue(@Name, Name);
                    command3.Parameters.AddWithValue(@BirthDate, birthdate);
                    command2.Parameters.AddWithValue(@ID, id);
                    command2.Parameters.AddWithValue(@Department, Department);
                    command2.Parameters.AddWithValue(@Rank, Rank);
                    command1.Parameters.AddWithValue(@ID,id);
                    command1.Parameters.AddWithValue(@Stipend, Stipend);
                    command1.Connection = connection;
                    command2.Connection = connection;
                    command3.Connection = connection;
                    connection.Open();
                    command3.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command1.ExecuteNonQuery();

                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();
            }
        }

        //inserts an faculty into the database
        public void InsertFaculty(string ID, string Name, string BirthDate, string Department, string Rank)
        {
            int id = Int32.Parse(ID);
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                  OleDbCommand command = new OleDbCommand();
                  OleDbCommand command1 = new OleDbCommand();
                  
                  command.CommandText = "INSERT INTO OWlMember (fldID, fldName, fldBirthdate) " + "VALUES (@ID,@Name,@BirthDate)";
                  command1.CommandText = "INSERT INTO Faculty (fldID, fldDepartment, fldRank) " + "VALUES (@ID,@Department,@Rank)";
                    command.Parameters.AddWithValue(@ID, id);
                    command.Parameters.AddWithValue(@Name, Name);
                    command.Parameters.AddWithValue(@BirthDate, birthdate);
                    command1.Parameters.AddWithValue(@ID,id);
                    command1.Parameters.AddWithValue(@Department, Department);
                    command1.Parameters.AddWithValue(@Rank, Rank);
                  command1.Connection = connection;
                  command.Connection = connection;  
                  connection.Open();
                  command.ExecuteNonQuery();
                  command1.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();
            }
        }
        //deletes an owl member from the database
        public void Delete(int OwlMemberID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM OwlMember WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM Faculty WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM Student WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM UndergraduateStudent WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM GraduateStudent WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    using (OleDbCommand command6 = new OleDbCommand("DELETE FROM Chairperson WHERE fldID = " + OwlMemberID, connection))
                    {
                        OleDbDataReader reader = command6.ExecuteReader();
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete

        //Selects an Undergraduate Student
        public OleDbDataReader SelectOwlMemberFromUndergraduateStudent(string OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "Select * FROM ([Undergraduatestudent] Inner Join [Student] on [Undergraduatestudent].[fldID] = [Student].[fldID]) " +
                " Inner Join [OwlMember] on [Student].[fldID] = [OwlMember].[fldID] " +
                "WHERE [Undergraduatestudent].[fldID] = " + OwlMemberID + ";";
            //"SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthDate,STUDENT.fldMajor, STUDENT.fldGPA, " +
            //"UNDERGRADUATESTUDENT.fldTuition, UNDERGRADUATESTUDENT.fldYear, UNDERGRADUATESTUDENT.fldCredits FROM OWLMEMBER "
            //+ "INNER JOIN STUDENT ON STUDENT.fldID = OWLMEMBER.fldID "
            //+ "INNER JOIN UNDERGRADUATESTUDENT ON UNDERGRADUATESTUDENT.fldID = STUDENT.fldID " +  ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select UnderGraduate Student error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        } // end SelectOwlMemberFromGraduateStudent
        //Selects chairperson data from tables 
        public OleDbDataReader SelectOwlMemberFromChairperson(string OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "Select * FROM ([Chairperson] Inner Join [Faculty] on [Chairperson].[fldID] = [Faculty].[fldID]) " +
                " Inner Join [OwlMember] on [Faculty].[fldID] = [OwlMember].[fldID] " +
                "WHERE [Chairperson].[fldID] = " + OwlMemberID + ";";

            //"SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, " + "STUDENT.fldMajor, STUDENT.fldGPA, "
            //           + "CHAIRPERSON.fldStipend, FACULTY.fldRank, FACULTY.fldDepartment FROM (OWLMEMBER "
            //           + "INNER JOIN FACULTY ON FACULTY.fldID = OWLMEMBER.fldID) "
            //           + "INNER JOIN CHAIRPERSON ON CHAIRPERSON.fldID = OWLMEMBER.fldID) "
            //           + "WHERE OWLMEMBER.fldID = " + OwlMemberID + "";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Chairperson error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }
        //Selects Faculty from data tables
        public OleDbDataReader SelectOwlMemberFromFaculty(string OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "Select * FROM FACULTY Inner Join OwlMember on Faculty.fldID = OWlMember.fldID " +
                "where FACULTY.fldID = " +OwlMemberID + ";";
                
                //"SELECT OWLMEMBER.fldID, OWLMEMBER.fldName, OWLMEMBER.fldBirthdate, "
                //    + "FACULTY.fldDepartment, FACULTY.fldRank FROM OWLMEMBER "
                //    + "INNER JOIN FACULTY ON FACULTY.fldID = OWLMEMBER.fldID "
                //    + "WHERE FACULTY.fldID = " + OwlMemberID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Faculty member error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectOwlMemberFromFaculty
        //Selects Graduate Student from data tables
        public OleDbDataReader SelectOwlMemberFromGraduateStudent(string OwlMemberID, out bool OKFlag)
        {
            string strSelectOwlMember = "Select * FROM ([Graduatestudent] Inner Join [Student] on [Graduatestudent].[fldID] = [Student].[fldID]) " +
                " Inner Join [OwlMember] on [Student].[fldID] = [OwlMember].[fldID] " +
                "WHERE [Graduatestudent].[fldID] = " + OwlMemberID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true;
            }
            catch (OleDbException ex)
            {
                Console.Write("There was a Select Graduate Student error: " + ex.Message);
                myConnection.Close();
                myDataReader = null;
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        } // end SelectOwlMemberFromGraduateStudent
          //public bool findMember(string OwlMemberID, out bool OKFlag)
          //{
          //    string strSelectOwlMember = "SELECT OWLMEMBER.fldID FROM (OWLMEMBER)" +
          //        "WHERE OWLMEMBER.fldID = " + OwlMemberID + ";";

        //    OleDbConnection myConnection = new OleDbConnection(strConnection);
        //    OleDbCommand myCommand = new OleDbCommand(strSelectOwlMember, myConnection);
        //    OleDbDataReader myDataReader;

        //    myDataReader = myCommand.ExecuteReader();
        //    try
        //    {
        //        if (myCommand. != "")
        //        { 
        //        myConnection.Open();
        //        myDataReader = myCommand.ExecuteReader();                  
        //        OKFlag = true;                                        
        //        }
        //        else
        //        {
        //            myConnection.Close();
        //            OKFlag = false;
        //        }
        //    }
        //    catch (OleDbException ex)
        //    {
        //        Console.Write("There was a error: " + ex.Message);
        //        myConnection.Close();
        //        myDataReader = null;
        //        OKFlag = false; // returns false if Select was unsuccessful
        //    }

        //    return OKFlag;
        //}
        //Updates the Undergraduate student in the appropriate tables
        public void UpdateUndergraduateStudent(string ID, string Name, string BirthDate, string Major, string GPA, string Tuition, string Credits, string Year)
        {
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            int id = Int32.Parse(ID);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand CommandupdateUndergraduateStudent = connection.CreateCommand())
                    {
                        CommandupdateUndergraduateStudent.CommandText = "UPDATE UNDERGRADUATESTUDENT SET fldTuition = @Tuition, fldYear = @Year, fldCredits = @Credits WHERE fldId = @ID";
                        CommandupdateUndergraduateStudent.Parameters.AddWithValue(@ID, id);
                        CommandupdateUndergraduateStudent.Parameters.AddWithValue(@Tuition, Tuition);
                        CommandupdateUndergraduateStudent.Parameters.AddWithValue(@Year, Year);
                        CommandupdateUndergraduateStudent.Parameters.AddWithValue(@Credits, Credits);
                        CommandupdateUndergraduateStudent.Connection = connection;
                        CommandupdateUndergraduateStudent.ExecuteNonQuery();
                    }
                    using(OleDbCommand CommandUpdateStudent = connection.CreateCommand())
                    {
                        CommandUpdateStudent.CommandText = "UPDATE STUDENT SET fldMajor =  @Major , fldGPA = @GPA WHERE fldId = @ID";
                        CommandUpdateStudent.Parameters.AddWithValue(@Major, Major);
                        CommandUpdateStudent.Parameters.AddWithValue(@GPA, GPA);
                        CommandUpdateStudent.Parameters.AddWithValue(@ID, id);
                        CommandUpdateStudent.Connection = connection;
                        CommandUpdateStudent.ExecuteNonQuery();
                    }

                    using (OleDbCommand CommandUpdateOwlMember = connection.CreateCommand())
                    {
                        CommandUpdateOwlMember.CommandText = "UPDATE OWLMEMBER SET fldName = @Name, fldBirthdate = @BirthDate WHERE fldId = @ID";
                        CommandUpdateOwlMember.Parameters.AddWithValue(@Name, Name);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@BirthDate, BirthDate);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@ID, id);
                        CommandUpdateOwlMember.Connection = connection;
                        CommandUpdateOwlMember.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    Console.Write("There was an Update Student error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();
            }
        }
        //Updates the Graduate student in the approproate tables 
        public void UpdateGraduateStudent(string ID, string Name, string BirthDate, string Major, string GPA, string Stipend, string DegreeProgram)
        {
            
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            int id = Int32.Parse(ID);

            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                connection.Open();
                try
                {
                    using (OleDbCommand CommandUpdateGraduateStudent = connection.CreateCommand())
                    {
                        CommandUpdateGraduateStudent.CommandText = "UPDATE GRADUATESTUDENT SET fldDegreeProgram = @DegreeProgram ,fldStipend = @Stipend WHERE fldId = @ID";
                        CommandUpdateGraduateStudent.Parameters.AddWithValue(@DegreeProgram, DegreeProgram);
                        CommandUpdateGraduateStudent.Parameters.AddWithValue(@Stipend, Stipend);
                        CommandUpdateGraduateStudent.Parameters.AddWithValue(@ID,id);
                        CommandUpdateGraduateStudent.Connection = connection;
                        CommandUpdateGraduateStudent.ExecuteNonQuery();
                    }
                    using (OleDbCommand CommandUpdateStudent = connection.CreateCommand())
                    {
                        CommandUpdateStudent.CommandText = "UPDATE STUDENT SET fldMajor = @Major , fldGPA = @GPA WHERE fldId = @ID";
                        CommandUpdateStudent.Parameters.AddWithValue(@Major, Major);
                        CommandUpdateStudent.Parameters.AddWithValue(@GPA, GPA);
                        CommandUpdateStudent.Parameters.AddWithValue(@ID, ID);
                        CommandUpdateStudent.Connection = connection;
                        CommandUpdateStudent.ExecuteNonQuery();

                    }
                    using (OleDbCommand CommandUpdateOwlMember = connection.CreateCommand())
                    {
                        CommandUpdateOwlMember.CommandText = "UPDATE OwlMember SET fldName = @Name , fldBirthdate = @BirthDate WHERE fldId = @ID";
                        CommandUpdateOwlMember.Parameters.AddWithValue(@Name,Name);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@BirthDate,birthdate);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@ID, ID);
                        CommandUpdateOwlMember.Connection = connection;
                        CommandUpdateOwlMember.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    Console.Write("There was an Update Student error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();
            }
        }
        //Updates a faculty member in the corresponding tables 
        public void UpdateFaculty(string ID, string Name, string BirthDate, string Department, string Rank)
        {
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            int id = Int32.Parse(ID);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    using (OleDbCommand CommandUpdateFaculty = connection.CreateCommand())
                    {
                        CommandUpdateFaculty.CommandText= "UPDATE Faculty SET fldDepartment = @Department , fldRank = @Rank WHERE fldId = @ID";
                        CommandUpdateFaculty.Parameters.AddWithValue(@Department,Department);
                        CommandUpdateFaculty.Parameters.AddWithValue(@Rank,Rank);
                        CommandUpdateFaculty.Parameters.AddWithValue(@ID,id);
                        CommandUpdateFaculty.Connection = connection;
                        CommandUpdateFaculty.ExecuteNonQuery();
                    }
                    using (OleDbCommand CommandUpdateOwlMember = connection.CreateCommand())
                    {
                        CommandUpdateOwlMember.CommandText = "UPDATE OwlMember SET fldName = @Name , fldBirthdate = @BirthDate WHERE fldId = @ID";
                        CommandUpdateOwlMember.Parameters.AddWithValue(@Name, Name);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@BirthDate, birthdate);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@ID, ID);
                        CommandUpdateOwlMember.Connection = connection;
                        CommandUpdateOwlMember.ExecuteNonQuery();
                    }
                }catch(OleDbException ex)
                {
                    Console.Write("There was an Update Student error: " + ex.Message);
                    connection.Close();
                }
            }
        
        }
        //Updates a chairperson in the corresponding tables
        public void UpdateChairperson(string ID, string Name, string BirthDate, string Department, string Rank, string Stipend)
        {
            DateTime birthdate = Convert.ToDateTime(BirthDate);
            int id = Int32.Parse(ID);
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                connection.Open();
                try
                {
                    using (OleDbCommand CommandUpdateStipend = connection.CreateCommand())
                    {
                        CommandUpdateStipend.CommandText = "UPDATE CHAIRPERSON SET fldStipend = @Stipend  WHERE fldId = @ID";
                        CommandUpdateStipend.Parameters.AddWithValue(@Stipend,Stipend);
                        CommandUpdateStipend.Parameters.AddWithValue(@ID,id);
                        CommandUpdateStipend.Connection = connection;
                        CommandUpdateStipend.ExecuteNonQuery();
                    }
                    using (OleDbCommand CommandUpdateFaculty = connection.CreateCommand())
                    {
                        CommandUpdateFaculty.CommandText = "UPDATE Faculty SET fldDepartment = @Department , fldRank = @Rank WHERE fldId = @ID";
                        CommandUpdateFaculty.Parameters.AddWithValue(@Department, Department);
                        CommandUpdateFaculty.Parameters.AddWithValue(@Rank, Rank);
                        CommandUpdateFaculty.Parameters.AddWithValue(@ID, id);
                        CommandUpdateFaculty.Connection = connection;
                        CommandUpdateFaculty.ExecuteNonQuery();
                    }
                    using (OleDbCommand CommandUpdateOwlMember = connection.CreateCommand())
                    {
                        CommandUpdateOwlMember.CommandText = "UPDATE OwlMember SET fldName = @Name , fldBirthdate = @BirthDate WHERE fldId = @ID";
                        CommandUpdateOwlMember.Parameters.AddWithValue(@Name, Name);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@BirthDate, birthdate);
                        CommandUpdateOwlMember.Parameters.AddWithValue(@ID, ID);
                        CommandUpdateOwlMember.Connection = connection;
                        CommandUpdateOwlMember.ExecuteNonQuery();
                    }
                }
                catch (OleDbException ex)
                {
                    Console.Write("There was an Update Student error: " + ex.Message);
                    connection.Close();
                }
                connection.Close();
            }           
        }
    }
}

