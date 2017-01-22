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

        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime defaultOpeningTime;

        public DateTime DefaultOpeningTime
        {
            get { return defaultOpeningTime; }
            set { defaultOpeningTime = value; }
        }

        private DateTime defaultClosingTime;

        public DateTime DefaultClosingTime
        {
            get { return defaultClosingTime; }
            set { defaultClosingTime = value; }
        }

        private int defaultDaysOpen;

        public int  DefaultDaysOpen
        {
            get { return defaultDaysOpen; }
            set { defaultDaysOpen = value; }
        }

        private int defaultTimeBetweenClasses;

        public int DefaultTimeBetweenClasses
        {
            get { return defaultTimeBetweenClasses; }
            set { defaultTimeBetweenClasses = value; }
        }

        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private DateTime modifiedDate;

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
