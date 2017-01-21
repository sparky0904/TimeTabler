using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.AppLogic
{
    class clsTimeTableEntry
    {
        #region Variables

        private int id = 0;
        private clsStudent[] students;
        private clsTutor tutor;
        private clsClass theClass;
        private DateTime startTime = DateTime.MinValue;
        private DateTime endTime = DateTime.MinValue;
        private int classSize = 0;

        private DateTime createdTimestamp = DateTime.Now;
        private DateTime modifieldTimestamp = DateTime.Now;

        #endregion
    }
}
