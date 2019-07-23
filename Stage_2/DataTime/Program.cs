using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            System.DateTime myDate = System.DateTime.Now;
            int year = myDate.Year;
            int month = myDate.Month;
            int day = myDate.Day;
            int hour = myDate.Hour;
            int minute = myDate.Minute;
            int second = myDate.Second;
            DayOfWeek weekDay = myDate.DayOfWeek;
            Console.WriteLine(year);
            Console.WriteLine(month);
            Console.WriteLine(day);
            Console.WriteLine(hour);
            Console.WriteLine(minute);
            Console.WriteLine(second);
            Console.WriteLine(weekDay);

            string dateInUSA = myDate.ToString("D", new CultureInfo("en-US"));
            Console.WriteLine(dateInUSA);

            System.DateTime date1 = new System.DateTime(2018, 1, 10, 11, 20, 30);
            System.DateTime date2 = new System.DateTime(2018, 2, 20, 12, 25, 35);

            TimeSpan interval = date1 - date2;

            Console.WriteLine($"No of Days: {interval.Days}");
            Console.WriteLine($"Total No of Days: {interval.TotalDays}");
            Console.WriteLine("No of Hours:", interval.Hours); 
            Console.WriteLine("Total No of Hours:", interval.TotalHours);
            Console.WriteLine("No of Minutes:", interval.Minutes);
            Console.WriteLine("Total No of Minutes:", interval.TotalMinutes);
            Console.WriteLine("No of Seconds:", interval.Seconds);
            Console.WriteLine("Total No of Seconds:", interval.TotalSeconds); 
            Console.WriteLine("Total No of Milliseconds:", interval.TotalMilliseconds);
            Console.WriteLine("Ticks:", interval.Ticks);

            string simpleTime = "1/3/2000";
            DateTime time = DateTime.Parse(simpleTime);
            Console.WriteLine(time);

            string httpTime = "Fri, 27 Feb 2009 03:11:21 GMT";
            time = DateTime.Parse(httpTime);
            Console.WriteLine(time);

            string windowsPanelTime = "8:04:00 PM";
            time = DateTime.Parse(windowsPanelTime);
            Console.WriteLine(time);

            string dateString = "Mon 16 Jun 8:30 AM 2008";
            string format = "ddd dd MMM h:mm tt yyyy";
            DateTime dateTime = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            Console.WriteLine(dateTime);



            Console.ReadKey();
        }
    }
}
