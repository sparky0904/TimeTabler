using System;

namespace TimeTable.AppLogic
{
    internal class clsAcademicYear
    {
        #region Properties

        private int id;
        private string description;
        private DateTime firstDayOfYear;

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

        public DateTime FirstDayOfYear
        {
            get
            {
                return firstDayOfYear;
            }

            set
            {
                firstDayOfYear = value;
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

        #endregion Public Accessors

        #endregion Properties
    }
}