using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
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

        public int GetAge()
        {
            return (int)((DateTime.Now - Birthday).TotalDays / 365.2425);
        }
    }
}
