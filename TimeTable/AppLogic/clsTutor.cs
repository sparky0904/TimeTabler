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

        private int id = 0;
        private bool active = true;
        private int workingPatternID = 0;
        private string tutorLastName = "";
        private string tutorFirstName = "";
        private DateTime createdDate;
        private DateTime modifiedDate;


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

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
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

        // Delete record
        public static int Delete(int theID)
        {
            return clsTutorDB.Delete(theID);
        }

        #endregion
    }
}
