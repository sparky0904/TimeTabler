using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    public class clsParameters
    {
        #region Properties

        private DateTime createdDate;
        private DateTime defaultClosingTime;
        private int defaultDaysOpen;
        private DateTime defaultOpeningTime;
        private int defaultTimeBetweenClasses;
        private int id;
        private DateTime modifiedDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        public DateTime DefaultClosingTime
        {
            get { return defaultClosingTime; }
            set { defaultClosingTime = value; }
        }

        public int DefaultDaysOpen
        {
            get { return defaultDaysOpen; }
            set { defaultDaysOpen = value; }
        }

        public DateTime DefaultOpeningTime
        {
            get { return defaultOpeningTime; }
            set { defaultOpeningTime = value; }
        }

        public int DefaultTimeBetweenClasses
        {
            get { return defaultTimeBetweenClasses; }
            set { defaultTimeBetweenClasses = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime ModifiedDate
        {
            get { return modifiedDate; }
            set { modifiedDate = value; }
        }

        #endregion

        #region Methods

        // Retrieve a single Record
        public static clsParameters GetSingleRecord(int theId)
        {
            return clsParametersDB.GetSingleRecord(theId);
        }

        #endregion
    }
}
