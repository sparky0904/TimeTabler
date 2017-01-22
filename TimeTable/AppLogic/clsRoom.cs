using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    class clsRoom
    {
        #region Properties

        private int id;  // The ID
        private string knowID; // Room unique ID as the organisation knows it
        private string commonName; // What the room is commonoly know as
        private bool hasEUC; // Does the room have End User Commpute;
        private bool hasProjector; // Does the room have a projector
        private int numberOfSeats; // Number of seats in the room
        private int numberOfComputers; // Number of computers in the room, this can be desktop or laptop

        private DateTime createdTimestamp;
        private DateTime modifiedTimestamp;
        private int userCreatedID;
        private int userModifiedID;

        #region PublicAccessors


        public int NumberOfComputers
        {
            get
            {
                return numberOfComputers;
            }

            set
            {
                numberOfComputers = value;
            }
        }

        public int NumberOfSeats
        {
            get
            {
                return numberOfSeats;
            }

            set
            {
                numberOfSeats = value;
            }
        }

        public bool HasProjector
        {
            get
            {
                return hasProjector;
            }

            set
            {
                hasProjector = value;
            }
        }

        public bool HasEUC
        {
            get
            {
                return hasEUC;
            }

            set
            {
                hasEUC = value;
            }
        }

        public string CommonName
        {
            get
            {
                return commonName;
            }

            set
            {
                commonName = value;
            }
        }

        public string KnowID
        {
            get
            {
                return knowID;
            }

            set
            {
                knowID = value;
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
        #endregion

        #endregion
    }
}
