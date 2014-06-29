using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTable.HelperClasses;

namespace TimeTable.AppLogic
{
    public static class clsTutorDB
    {
        public static List<clsTutor> GetTutors()
        {
            List<clsTutor> myTutorList = new List<clsTutor>();
            string con = clsGlobalParameters.ConnectionString;
            clsTutor theTutor;

            try
            {
                using (SqlConnection myConnection = new SqlConnection(con))
                {
                    SqlCommand myCommand = new SqlCommand("spTutorSelectListByLastName", myConnection);
                    myCommand.CommandType = System.Data.CommandType.StoredProcedure;

                    myConnection.Open();

                    using(SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            theTutor = new clsTutor();

                            theTutor.TutorFirstName = myReader["TutorFirstName"].ToString();
                            theTutor.TutorLastName = myReader["TutorLastName"].ToString();

                            myTutorList.Add(theTutor);
                        }
                        myConnection.Close();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            return myTutorList;
        }
    }
}
