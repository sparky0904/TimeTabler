using System;

namespace TimeTable.AppLogic
{
    internal class clsStudent
    {
        #region Properties

        private bool active;

        private string firstName;
        private int id;
        private string knownName;
        private string lastName;
        private DateTime modifiedTimestamp;
        private int userCreatedID;
        private int userModifiedID;
        private DateTime createdTimestamp;

        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        public DateTime CreatedTimestamp
        {
            get { return createdTimestamp; }
            set { createdTimestamp = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string KnownName
        {
            get { return knownName; }
            set { knownName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime ModifiedTimestamp
        {
            get { return modifiedTimestamp; }
            set { modifiedTimestamp = value; }
        }

        public int UserCreatedID
        {
            get { return userCreatedID; }
            set { userCreatedID = value; }
        }

        public int UserModifiedID
        {
            get { return userModifiedID; }
            set { userModifiedID = value; }
        }

        #endregion Properties
    }
}