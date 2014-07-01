using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TimeTable.AppLogic
{
    public class clsTutor
    {
        #region Variables

        private int id;
        private bool active;
        private int workingPatternID;
        private string tutorLastName;
        private string tutorFirstName;

        public int Id
        {
            get { return (id); }
            set { id = value; }
        }

        public string TutorFirstName
        {
            get { return (tutorFirstName); }
            set { tutorFirstName = value; }
        }

        public string TutorLastName
        {
            get { return tutorLastName; }
            set { tutorLastName = value; }
        }

        public string TutorDisplayName
        {
            get { return (TutorLastName + " " + TutorFirstName); }
        }

        public bool Active
        {
            get {  return active; }
            set { active = value; }
        }

        public int WorkingPatternID
        {
            get { return workingPatternID; }
            set { workingPatternID = value; }
        }

        #endregion


        #region Methods

        // Return a list of Tutors, to be used in a list box
        public static List<clsTutor> GetList()
        {
            return clsTutorDB.GetList();
        }  

        // Retrieve a single Record
        public static clsTutor GetSingleRecord(int theId)
        {
            return clsTutorDB.GetSingleRecord(theId);
        }

        // Save
        public int Save()
        {
            return clsTutorDB.Save(this);
        }

        #endregion
    }
}
