using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.HelperClasses;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimeTable.AppLogic
{
    public static class clsParametersDB
    {
        static string DBConnectionString = clsGlobalParameters.DatabaseConnectionString;

        public static clsParameters GetSingleRecord(int theId)
        {
            // string con = Properties.Settings.Default.DatabaseConnectionString;
            // string con = clsGlobalParameters.DatabaseConnectionString;
            string con = DBConnectionString;

            clsParameters theParameters = new clsParameters();

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spParametersSelectParametersById", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("@Id", theId));

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theParameters.ID = myReader.GetInt32(myReader.GetOrdinal("Id"));
                            theParameters.DefaultOpeningTime = myReader.GetDateTime(myReader.GetOrdinal("DefaultOpeningTime"));
                            theParameters.DefaultClosingTime = myReader.GetDateTime(myReader.GetOrdinal("DefaultClosingTime"));
                            theParameters.DefaultTimeBetweenClasses = myReader.GetInt32(myReader.GetOrdinal("DefaultTimeBetweenClasses"));
                            theParameters.CreatedDate = myReader.GetDateTime(myReader.GetOrdinal("CreatedDate"));
                            theParameters.ModifiedDate = myReader.GetDateTime(myReader.GetOrdinal("ModifiedDate"));
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in clsParameters.GetSingleRecord", MessageBoxButtons.OK);
            }

            return theParameters;
        }

        private static void SetSQLParameters(clsParameters clsParameters, SqlCommand myCommand)
        {
            myCommand.Parameters.Add(new SqlParameter("@Id", clsParameters.ID));

        }

        public static int Save(clsParameters clsParamneters)
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

                    if (clsParamneters.ID < 0)
                    { theStatementType = "Insert"; }
                    else
                    { theStatementType = "Update"; }

                    SqlCommand myCommand = new SqlCommand("spTutorInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SetSQLParameters(clsParamneters, myCommand);
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
    }
}
