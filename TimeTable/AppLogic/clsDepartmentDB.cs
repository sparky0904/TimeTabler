using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TimeTable.HelperClasses;

namespace TimeTable.AppLogic
{
    public static class clsDepartmentDB
    {
        private static string DBConnectionString = clsGlobalParameters.DatabaseConnectionString;

        public static List<clsDepartment> GetList()
        {
            List<clsDepartment> myDepartmentList = new List<clsDepartment>();
            string con = DBConnectionString;

            clsDepartment theDepartment;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spDepartmentSelectList", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theDepartment = new clsDepartment();

                            theDepartment.ID = myReader.GetInt32(myReader.GetOrdinal("ID"));
                            theDepartment.Name = myReader["Name"].ToString();
                            theDepartment.Description = myReader["Description"].ToString();

                            myDepartmentList.Add(theDepartment);
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in DepartmentDB.GetList", MessageBoxButtons.OK);
            }

            return myDepartmentList;
        }

        public static clsDepartment GetSingleRecord(int theId)
        {
            string con = DBConnectionString;

            clsDepartment theDepartment = new clsDepartment();

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spDepartmentSelectDepartmentById", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    myCommand.Parameters.Add(new SqlParameter("@Id", theId));

                    myConnection.Open();

                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theDepartment.ID = myReader.GetInt32(myReader.GetOrdinal("Id"));
                            theDepartment.Name = myReader["Name"].ToString();
                            theDepartment.Description = myReader["Description"].ToString();
                            theDepartment.UserCreatedID = myReader.GetInt32(myReader.GetOrdinal("UserCreatedID"));
                            theDepartment.UserModifiedID = myReader.GetInt32(myReader.GetOrdinal("UserModifiedID"));
                            theDepartment.CreatedTimestamp = myReader.GetDateTime(myReader.GetOrdinal("CreatedTimestamp"));
                            theDepartment.ModifiedTimestamp = myReader.GetDateTime(myReader.GetOrdinal("ModifiedTimestamp"));
                        }

                        myConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in DepartmentDB.GetSingleRecord", MessageBoxButtons.OK);
            }

            return theDepartment;
        }

        private static void SetSQLParameters(clsDepartment theDepartment, SqlCommand myCommand)
        {
            myCommand.Parameters.Add(new SqlParameter("@Id", theDepartment.ID));
            myCommand.Parameters.Add(new SqlParameter("@Name", theDepartment.Name));
            myCommand.Parameters.Add(new SqlParameter("@Description", theDepartment.Description));
            myCommand.Parameters.Add(new SqlParameter("@UserID", clsGlobalParameters.UserID));
        }

        public static int Save(clsDepartment theDepartment)
        {
            string con = DBConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    string theStatementType;

                    if (theDepartment.ID < 0)
                    { theStatementType = "Insert"; }
                    else
                    { theStatementType = "Update"; }

                    SqlCommand myCommand = new SqlCommand("spDepartmentInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SetSQLParameters(theDepartment, myCommand);
                    myCommand.Parameters.Add(new SqlParameter("@StatementType", theStatementType));
                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in DepartmentDB.Save", MessageBoxButtons.OK);
                return (-1);
            }
        }

        public static int Delete(int theId)
        {
            string con = DBConnectionString;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    int rowsUpdated = 0;
                    clsDepartment theDepartment = new clsDepartment();

                    SqlCommand myCommand = new SqlCommand("spDepartmentInsertUpdateDelete", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    theDepartment.ID = theId;
                    SetSQLParameters(theDepartment, myCommand);

                    myCommand.Parameters.Add(new SqlParameter("@StatementType", "Delete"));
                    myConnection.Open();
                    rowsUpdated = myCommand.ExecuteNonQuery();
                    myConnection.Close();

                    return (rowsUpdated);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error in DepartmentDB.Delete", MessageBoxButtons.OK);
                return (-1);
            }
        }
    }
}