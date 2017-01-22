using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    class clsDepartment
    {
        #region Properties

        private int id;
        private string name;
        private string description;

        private DateTime createdTimestamp;
        private DateTime modifiedTimestamp;
        private int userCreatedID;
        private int userModifiedID;

        #region Public Accessors

        public int Id
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
                return UserModifiedID;
            }

            set
            {
                UserModifiedID = value;
            }
        }

        #endregion Public Accessors

        #endregion
    }
}
