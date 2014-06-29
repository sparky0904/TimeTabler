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
            get
            {
                return (TutorLastName + " " + TutorFirstName);
            }
        }

        public static List<clsTutor> GetList()
        {
            return clsTutorDB.GetList();
        }


    }
}
