namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DateModifier
    {
        public static int GetDateDifference(string date1, string date2)
        {
            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate = DateTime.Parse(date2);

            return Math.Abs((firstDate - secondDate).Days);
        }
    }
}
