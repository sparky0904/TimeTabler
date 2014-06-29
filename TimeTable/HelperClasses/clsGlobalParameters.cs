using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.HelperClasses
{
    public static class clsGlobalParameters
    {
        // Connection String
        private static string connectionString = "Data Source=Data\\Database.mdf;Integrated Security=True;Connect Timeout=30";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }

    }
}
