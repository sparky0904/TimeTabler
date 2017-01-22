using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    class clsStudentClassLink // This class links the students to the classes they are in
    {
        #region Properties

        private int id;
        private int studentID;
        private int classID;
        private DateTime createdTimestamp;
        private DateTime modifiedTimestamp;
        private int userCreatedID;
        private int userModifiedID;

        #region Public Accessors

        public int StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        public int ClassID
        {
            get
            {
                return classID;
            }

            set
            {
                classID = value;
            }
        }

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

        #endregion

        #endregion

    }
}
