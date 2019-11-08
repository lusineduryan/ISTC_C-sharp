using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Time : ITime
    {
        DateTime Birthday { get; set; }
        public Time()
        {
            Birthday = new DateTime(1993, 06, 16);
        }

        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }

        public int GetAge(DateTime birthday)
        {
            return (int)((DateTime.Now - birthday).TotalDays / 365.2425);
        }
    }
}
