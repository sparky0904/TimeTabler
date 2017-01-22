using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TimeTable.HelperClasses;

namespace TimeTable.AppLogic
{
    public static class clsTimeTableEntryDB
    {
        private static string DBConnectionString = clsGlobalParameters.DatabaseConnectionString;

        public static List<clsTimeTableEntry> GetList()
        {
            List<clsTimeTableEntry> myTimeTableEntry = new List<clsTimeTableEntry>();
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            //string con = clsGlobalParameters.DatabaseConnectionString;

            string con = DBConnectionString;

            clsTimeTableEntry theTimeTableEntry;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTimeTableEntrySelectListByLastName", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theTimeTableEntry = new clsTimeTableEntry();
                            theTimeTableEntry.ID = myReader.GetInt32(myReader.GetOrdinal("ID"));
                            //theTimeTableEntry.TutorFirstName = myReader["TutorFirstName"].ToString();

                            myTimeTableEntry.Add(theTimeTableEntry);
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TimeTableEntryDB.GetList", MessageBoxButtons.OK);
            }

            return myTimeTableEntry;
        }

        public static clsTimeTableEntry GetSingleRecord(int theId)
        {
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            // string con = clsGlobalParameters.DatabaseConnectionString;
            string con = DBConnectionString;

            clsTimeTableEntry theTimeTableEntry = new clsTimeTableEntry();

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTimeTableEntrySelectTimeTableEntryById", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("@Id", theId));

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theTimeTableEntry.ID = myReader.GetInt32(myReader.GetOrdinal("ID"));
                            //theTimeTableEntry.TutorFirstName = myReader["TutorFirstName"].ToString();
                            //theTimeTableEntry.Active = myReader.GetBoolean(myReader.GetOrdinal("Active"));
                            theTimeTableEntry.CreatedTimestamp = myReader.GetDateTime(myReader.GetOrdinal("CreatedTimestamp"));
                            theTimeTableEntry.ModifieldTimestamp = myReader.GetDateTime(myReader.GetOrdinal("ModifiedTimestamp"));
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TimeTableEntryDB.GetSingleRecord", MessageBoxButtons.OK);
            }

            return theTimeTableEntry;
        }

        private static void SetSQLParameters(clsTimeTableEntry theTimeTableEntry, SqlCommand myCommand)
        {
            myCommand.Parameters.Add(new SqlParameter("@Id", theTimeTableEntry.ID));
            // myCommand.Parameters.Add(new SqlParameter("@Active", theTutor.Active));
            // myCommand.Parameters.Add(new SqlParameter("@WorkingPatternID", theTutor.WorkingPatternID));
            //myCommand.Parameters.Add(new SqlParameter("@TutorLastName", theTutor.TutorLastName));
            //myCommand.Parameters.Add(new SqlParameter("@TutorFirstName", theTutor.TutorFirstName));
        }

        public static int Save(clsTimeTableEntry theTimeTableEntry)
        {
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            //string con = clsGlobalParameters.DatabaseConnectionString;
            string con = DBConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    string theStatementType;

                    if (theTimeTableEntry.ID < 0)
                    { theStatementType = "Insert"; }
                    else
                    { theStatementType = "Update"; }

                    SqlCommand myCommand = new SqlCommand("spTimeTableEntryInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SetSQLParameters(theTimeTableEntry, myCommand);
                    myCommand.Parameters.Add(new SqlParameter("@StatementType", theStatementType));
                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TimeTableEntryDB.Save", MessageBoxButtons.OK);
                return (-1);
            }
        }

        public static int Delete(int theId)
        {
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            // string con = clsGlobalParameters.DatabaseConnectionString;
            string con = DBConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    clsTimeTableEntry theTimeTableEntry = new clsTimeTableEntry();

                    SqlCommand myCommand = new SqlCommand("spTimeTableEntryInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    theTimeTableEntry.ID = theId;
                    SetSQLParameters(theTimeTableEntry, myCommand);
                    myCommand.Parameters.Add(new SqlParameter("@StatementType", "Delete"));

                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TimeTableEntryDB.Delete", MessageBoxButtons.OK);
                return (-1);
            }
        }
    }
}