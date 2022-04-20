using System;

namespace DateFormat
{
    public class TestDateFormat
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }
    }
}