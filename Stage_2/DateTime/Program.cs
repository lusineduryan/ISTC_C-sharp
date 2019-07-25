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
            DateTime dt = new DateTime(2016, 08, 01, 18, 50, 23, 230);
            var t = String.Format("{0:t}", dt);     // "6:50 PM" ShortTime
            var d = String.Format("{0:d}", dt);     // "8/1/2016" ShortDate
            var T = String.Format("{0:T}", dt);     // "6:50:23 PM" LongTime
            var D = String.Format("{0:D}", dt);     // "Monday, August 1, 2016" LongDate
            var f = String.Format("{0:f}", dt);     // "Monday, August 1, 2016 6:50 PM" LongDate+ShortTime
            var F = String.Format("{0:F}", dt);     // "Monday, August 1, 2016 6:50:23 PM" FullDateTime
            var g = String.Format("{0:g}", dt);     // "8/1/2016 6:50 PM" ShortDate+ShortTime
            var G = String.Format("{0:G}", dt);     // "8/1/2016 6:50:23 PM" ShortDate+LongTime
            var m = String.Format("{0:m}", dt);     // "August 1" MonthDay
            var y = String.Format("{0:y}", dt);     // "August 2016" YearMonth
            var r = String.Format("{0:r}", dt);     // "SMon, 01 Aug 2016 18:50:23 GMT" RFC1123
            var s = String.Format("{0:s}", dt);     // "2016-08-01T18:50:23" SortableDateTime
            var u = String.Format("{0:u}", dt);     // "2016-08-01 18:50:23Z" UniversalSortableDateTime

            var year = String.Format("{0:y yy yyy yyyy}", dt);      // "16 16 2016 2016" year
            var month = String.Format("{0:M MM MMM MMMM}", dt);     // "8 08 Aug August" month
            var day = String.Format("{0:d dd ddd dddd}", dt);       // "1 01 Mon Monday" day
            var hour = String.Format("{0:h hh H HH}", dt);          // "6 06 18 18" hour 12/24
            var minute = String.Format("{0:m mm}", dt);             // "50 50" minute
            var secound = String.Format("{0:s ss}", dt);            // "23 23" second
            var fraction = String.Format("{0:f ff fff ffff}", dt);  // "2 23 230 2300" sec.fraction
            var fraction2 = String.Format("{0:F FF FFF FFFF}", dt); // "2 23 23 23" without zeroes
            var period = String.Format("{0:t tt}", dt);             // "P PM" A.M. or P.M.
            var zone = String.Format("{0:z zz zzz}", dt);           // "+0 +00 +00:00" time zone

            System.DateTime myDate = System.DateTime.Now;
            int _year = myDate.Year;
            int _month = myDate.Month;
            int _day = myDate.Day;
            int _hour = myDate.Hour;
            int _minute = myDate.Minute;
            int _second = myDate.Second;
            DayOfWeek weekDay = myDate.DayOfWeek;
            Console.WriteLine(_year);
            Console.WriteLine(_month);
            Console.WriteLine(_day);
            Console.WriteLine(_hour);
            Console.WriteLine(_minute);
            Console.WriteLine(_second);
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
