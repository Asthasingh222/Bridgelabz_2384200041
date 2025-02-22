using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                throw new ArgumentException("Invalid date format");
            }
            return date.ToString("dd-MM-yyyy");
        }
    }
}
