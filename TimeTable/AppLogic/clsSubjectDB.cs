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
    public static class clsSubjectDB
    {
        static string DBConnectionString = clsGlobalParameters.DatabaseConnectionString;

        public static List<clsSubject> GetList()
        {
            List<clsSubject> mySubjectList = new List<clsSubject>();
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            //string con = clsGlobalParameters.DatabaseConnectionString;

            string con = DBConnectionString;

            clsSubject theSubject;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spSubjectSelectList", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theSubject = new clsSubject();

                            theSubject.ID = myReader.GetInt32(myReader.GetOrdinal("ID"));
                            theSubject.Name = myReader["Name"].ToString();
                            theSubject.Description = myReader["Description"].ToString();                            

                            mySubjectList.Add(theSubject);
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in SubjectDB.GetList", MessageBoxButtons.OK);
            }

            return mySubjectList;
        }

        public static clsSubject GetSingleRecord(int theId)
        {
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            // string con = clsGlobalParameters.DatabaseConnectionString;
            string con = DBConnectionString;

            clsSubject theSubject = new clsSubject();

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTutorSelectSubjectById", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("@Id", theId));

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theSubject.ID = myReader.GetInt32(myReader.GetOrdinal("ID"));
                            theSubject.Name = myReader["Name"].ToString();
                            theSubject.Description = myReader["Description"].ToString();
                            theSubject.DepartmentID = myReader.GetInt32(myReader.GetOrdinal("DepartmentID"));
                            theSubject.UserCreatedID = myReader.GetInt32(myReader.GetOrdinal("UserCreatedID"));
                            theSubject.UserModifiedID = myReader.GetInt32(myReader.GetOrdinal("UserModifiedID"));
                            theSubject.CreatedTimestamp = myReader.GetDateTime(myReader.GetOrdinal("CreatedTimestamp"));
                            theSubject.ModifiedTimestamp = myReader.GetDateTime(myReader.GetOrdinal("ModifiedTimestamp"));
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in Subject.GetSingleRecord", MessageBoxButtons.OK);
            }

            return theSubject;
        }

        private static void SetSQLParameters(clsSubject theSubject, SqlCommand myCommand)
        {
            myCommand.Parameters.Add(new SqlParameter("@Id", theSubject.ID));
            myCommand.Parameters.Add(new SqlParameter("@Name", theSubject.Name));
            myCommand.Parameters.Add(new SqlParameter("@Description", theSubject.Description));
            myCommand.Parameters.Add(new SqlParameter("@DepartmentID", theSubject.DepartmentID));
            myCommand.Parameters.Add(new SqlParameter("@UserID", clsGlobalParameters.UserID));
        }

        public static int Save(clsSubject theSubject)
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

                    if (theSubject.ID < 0)
                    { theStatementType = "Insert"; }
                    else
                    { theStatementType = "Update"; }

                    SqlCommand myCommand = new SqlCommand("spSubjectInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SetSQLParameters(theSubject, myCommand);
                    myCommand.Parameters.Add(new SqlParameter("@StatementType", theStatementType));
                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in SubjectDB.Save", MessageBoxButtons.OK);
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
                    clsSubject theSubject = new clsSubject();

                    SqlCommand myCommand = new SqlCommand("spSubjectInsertUpdateDelete", myConnection);

                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    theSubject.ID = theId;
                    SetSQLParameters(theSubject, myCommand);

                    myCommand.Parameters.Add(new SqlParameter("@StatementType", "Delete"));

                    myConnection.Open();

                    rowsUpdated = myCommand.ExecuteNonQuery();

                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in SubjectDB.Delete", MessageBoxButtons.OK);
                return (-1);
            }
        }
    }
}
