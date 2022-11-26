using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatRentingClassLibrary
{
    public static class DatabaseHelper
    {
        //main database route
        public static string mainDatabase { get;} = "Server=studmysql01.fhict.local;Username=dbi450046;Database=dbi450046;Password=Mrf3MwW8di;";

        //database null doesn't convert to c#, it returns DBNull to null
        public static string DBNullConverter(string val)
        {
            if (val == DBNull.Value.ToString())
            {
                val = null;
            }
            return val;
        }

        //return 1 or 0 base on boolean
        public static int BoolConverterToDB(bool input)
        {
            if (input)
            {
                return 1;
            }
            else
                return 0;
        }

        //convert dd/mm/yyyy to yyyy/mm/dd
        public static string DateConverterToDB(DateTime date)
        {
            //26/08/2016 00:00:00
            string dateStr = date.ToString();
            dateStr = dateStr.Split(" ")[0];
            string[] newDate = dateStr.Split("/");
            dateStr = $"{newDate[2]}-{newDate[1]}-{newDate[0]}";
            return dateStr;
        }
    }
}
