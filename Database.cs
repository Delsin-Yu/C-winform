using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Database
    {
        //singleton pattern
        private static Database database_1=null;

        public static Database database
        {
            get
            {
                if (database_1 == null)
                    database_1 = new Database();
                return database_1;

            }
        }

        public string service_name;
        public string table_number;
        public string meun_name_number;
        public int number_ordered;

    }
}
