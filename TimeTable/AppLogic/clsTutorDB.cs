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

                    using(SqlDataReader myReader = myCommand.ExecuteReader())
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
               MessageBox.Show(ex.Message , "An Error in TutorDB.GetList", MessageBoxButtons.OK) ;
            }
            return myTutorList;
        }
    }
}
