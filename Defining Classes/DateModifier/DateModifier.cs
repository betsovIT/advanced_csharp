using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateTime FirstDate { get; private set; }
        public DateTime SecondDate { get; private set; }

        public DateModifier(string firstDate,string secondDate)
        {
            this.FirstDate = DateTime.ParseExact(firstDate, "yyyy MM dd", CultureInfo.InvariantCulture);
            this.SecondDate = DateTime.ParseExact(secondDate, "yyyy MM dd", CultureInfo.InvariantCulture);
        }

        public int CalculateDifferenceInDays()
        {
            TimeSpan difference = FirstDate - SecondDate;
            return difference.Days;
        }
    }
}
