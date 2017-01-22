using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    public class clsSubject
    {
        #region Properties

        private int id = 0;
        private string name = "";
        private string description = "";
        private int departmentID = 0;

        private DateTime createdTimestamp = DateTime.MinValue;
        private DateTime modifiedTimestamp = DateTime.MinValue;
        private int userCreatedID = -1;
        private int userModifiedID = -1;

        #region Public Accessors

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime CreatedTimestamp
        {
            get
            {
                return createdTimestamp;
            }

            set
            {
                createdTimestamp = value;
            }
        }

        public DateTime ModifiedTimestamp
        {
            get
            {
                return modifiedTimestamp;
            }

            set
            {
                modifiedTimestamp = value;
            }
        }

        public int UserCreatedID
        {
            get
            {
                return userCreatedID;
            }

            set
            {
                userCreatedID = value;
            }
        }

        public int UserModifiedID
        {
            get
            {
                return userModifiedID;
            }

            set
            {
                userModifiedID = value;
            }
        }

        public int DepartmentID
        {
            get
            {
                return departmentID;
            }

            set
            {
                departmentID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        #endregion Public Accessors

        #endregion

        #region Methods

        // Return a list of Subjects, to be used in a list box
        public static List<clsSubject> GetList()
        {
            return clsSubjectDB.GetList();
        }

        // Retrieve a single Record
        public static clsSubject GetSingleRecord(int theId)
        {
            return clsSubjectDB.GetSingleRecord(theId);
        }

        // Save
        public int Save()
        {
            return clsSubjectDB.Save(this);
        }

        // Delete record
        public static int Delete(int theID)
        {
            return clsSubjectDB.Delete(theID);
        }

        #endregion

    }
}
