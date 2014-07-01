using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.HelperClasses;
using System.Windows.Forms;

namespace TimeTable.AppLogic
{
    public static class clsTutorDB
    {
        public static List<clsTutor> GetList()
        {
            List<clsTutor> myTutorList = new List<clsTutor>();
            string con = Properties.Settings.Default.DatabaseConnectionString;
            clsTutor theTutor;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTutorSelectListByLastName", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theTutor = new clsTutor();

                            theTutor.Id = myReader.GetInt32(myReader.GetOrdinal("Id"));
                            theTutor.TutorFirstName = myReader["TutorFirstName"].ToString();
                            theTutor.TutorLastName = myReader["TutorLastName"].ToString();

                            myTutorList.Add(theTutor);
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TutorDB.GetList", MessageBoxButtons.OK);
            }

            return myTutorList;
        }

        public static clsTutor GetSingleRecord(int theId)
        {
            string con = Properties.Settings.Default.DatabaseConnectionString;
            clsTutor theTutor = new clsTutor();

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTutorSelectTutorById", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("@Id", theId));

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theTutor.Id = myReader.GetInt32(myReader.GetOrdinal("Id"));
                            theTutor.TutorFirstName = myReader["TutorFirstName"].ToString();
                            theTutor.TutorLastName = myReader["TutorLastName"].ToString();
                            theTutor.Active = myReader.GetBoolean(myReader.GetOrdinal("Active"));
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TutorDB.GetSingleRecord", MessageBoxButtons.OK);
            }

            return theTutor;
        }

        private static void SetSQLParameters(clsTutor theTutor, SqlCommand myCommand)
        {
            myCommand.Parameters.Add(new SqlParameter("@Id", theTutor.Id));
            myCommand.Parameters.Add(new SqlParameter("@Active", theTutor.Active));
            myCommand.Parameters.Add(new SqlParameter("@WorkingPatternID", theTutor.WorkingPatternID));
            myCommand.Parameters.Add(new SqlParameter("@TutorLastName", theTutor.TutorLastName));
            myCommand.Parameters.Add(new SqlParameter("@TutorFirstName", theTutor.TutorFirstName));
        }

        public static int Save(clsTutor theTutor)
        {
            string con = Properties.Settings.Default.DatabaseConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    string theStatementType;

                    if (theTutor.Id < 0)
                    { theStatementType = "Insert"; }
                    else
                    { theStatementType = "Update"; }

                    SqlCommand myCommand = new SqlCommand("spTutorInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SetSQLParameters(theTutor, myCommand);
                    myCommand.Parameters.Add(new SqlParameter("@StatementType", theStatementType));
                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TutorDB.Save", MessageBoxButtons.OK);
                return (-1);
            }
        }

        

        public static int Delete(int theId)
        {
            string con = Properties.Settings.Default.DatabaseConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    clsTutor thetutor = new clsTutor();

                    SqlCommand myCommand = new SqlCommand("spTutorInsertUpdateDelete", myConnection);

                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    thetutor.Id = theId;
                    SetSQLParameters(thetutor, myCommand);

                    myCommand.Parameters.Add(new SqlParameter("@StatementType", "Delete"));

                    myConnection.Open();

                    rowsUpdated = myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in TutorDB.Delete", MessageBoxButtons.OK);
                return (-1);
            }
        }
    }
}
