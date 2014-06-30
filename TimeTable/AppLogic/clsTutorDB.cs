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

        internal static clsTutor GetSingleRecord(int theId)
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
                MessageBox.Show(ex.Message, "An Error in TutorDB.GetList", MessageBoxButtons.OK);
            }

            return theTutor;
        }
    }
}
