﻿using System;
using System.Collections.Generic;

namespace TimeTable.AppLogic
{
    public class clsTimeTableEntry
    {
        #region Properites

        // Information requires to create timetable, held in database
        private int id = 0; // ID for this record
        private int classID; // Class ID
        private DateTime startTime = DateTime.MinValue;
        private DateTime endTime = DateTime.MinValue;
        private int roomID; // Room ID
        private DateTime createdTimestamp = DateTime.Now;
        private DateTime modifieldTimestamp = DateTime.Now;
        private int userCreated = 0;
        private int userModified = 0;

        // Reference data - set when object is created
        private int[] students; // Students in the class, program ID of the student used to lookup student

        private int tutorID;   // Tutor ID
        private int classSize = 0; // Size of the class to check against room size

        private clsTimeTableEntry theTimeTableEntry;
        private clsClass theClass;
        private clsRoom theRoom;

        #region  Public accessors

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public int ClassID
        {
            get { return classID; }
            set { classID = value; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public DateTime EndTime
        {
            get { return EndTime; }
            set { EndTime = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public DateTime CreatedTimestamp
        {
            get { return createdTimestamp; }
            set { createdTimestamp = value; }
        }

        public DateTime ModifieldTimestamp
        {
            get { return modifieldTimestamp; }
            set { modifieldTimestamp = value; }
        }

        public int UserCreated
        {
            get { return userCreated; }
            set { userCreated = value; }
        }

        public int UserModified
        {
            get { return userModified; }
            set { userModified = value; }
        }
        #endregion

        #endregion Properites

        #region Methods

        // Return a list of Tutors, to be used in a list box
        public static List<clsTimeTableEntry> GetList()
        {
            return clsTimeTableEntryDB.GetList();
        }

        // Retrieve a single Record
        public static clsTimeTableEntry GetSingleRecord(int theId)
        {
            return clsTimeTableEntryDB.GetSingleRecord(theId);
        }

        // Save
        public int Save()
        {
            return clsTimeTableEntryDB.Save(this);
        }

        // Delete record
        public static int Delete(int theID)
        {
            return clsTimeTableEntryDB.Delete(theID);
        }

        #endregion Methods
    }
}