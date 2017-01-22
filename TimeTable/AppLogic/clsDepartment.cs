using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    public class clsDepartment
    {
        #region Properties

        private int id = 0;
        private string name = "";
        private string description = "";

        private DateTime createdTimestamp;
        private DateTime modifiedTimestamp;
        private int userCreatedID;
        private int userModifiedID;

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

        // Return a list of Departments, to be used in a list box
        public static List<clsDepartment> GetList()
        {
            return clsDepartmentDB.GetList();
        }

        // Retrieve a single Record
        public static clsDepartment GetSingleRecord(int theId)
        {
            return clsDepartmentDB.GetSingleRecord(theId);
        }

        // Save
        public int Save()
        {
            return clsDepartmentDB.Save(this);
        }

        // Delete record
        public static int Delete(int theID)
        {
            return clsDepartmentDB.Delete(theID);
        }

        #endregion
    }
}
