using TimeTable.AppLogic;
using System;

namespace TimeTable.HelperClasses
{
    public static class clsGlobalParameters
    {
        // Connection String
        private static bool DebugModeEnabled = Properties.Settings.Default.DebugMode;

        private static string connectionStringPart1 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=";
        private static string connectionStringPart2 = "\\Data\\Database.mdf;Integrated Security=True;Connect Timeout=30";
        private static string Directory = "|DataDirectory|";
        private static int userID = -1;

        // Load the paramaters from the database
        public static clsParameters theParameteres = clsParameters.GetSingleRecord(1);

        public static string DatabaseConnectionString
        {
            get
            {
                string connectionString = string.Empty;

                if (DebugModeEnabled)
                {
                    if (Environment.MachineName == "WW025555")
                    {
                        Directory = "C:\\Users\\mark.taylor\\Source\\Repos\\TimeTabler\\TimeTable";
                    }
                    else
                    {
                        Directory = "D:\\My Documents\\GitHub\\TimeTabler\\TimeTable";
                    }
                }

                connectionString = connectionStringPart1 + Directory + connectionStringPart2;
                return connectionString;
            }
        }

        public static int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        // Constructor for the class, It is called automatically before the first instance is created or any static members are referenced.
        static clsGlobalParameters()
        {
        }
    }
}