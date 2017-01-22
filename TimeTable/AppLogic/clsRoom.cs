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

        private int ID;  // The ID
        private string knowID; // Room unique ID as the organisation knows it
        private string cmmonName; // What the room is commonoly know as
        private bool hasEUC; // Does the room have End User Commpute;
        private bool hasProjector; // Does the room have a projector
        private int numberOfSeats; // Number of seats in the room
        private int numberOfComputers; // Number of computers in the room, this can be desktop or laptop

        #endregion
    }
}
