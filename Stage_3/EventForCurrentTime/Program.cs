using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventForCurrentTime
{
    class Program
    {
        static void Main(string[] args)
        {
            WritingTime tm = new WritingTime();
            tm.TimeWriter += Handlers.TimeInConsole;
            tm.TimeWriter += Handlers.TimeInFile;
            tm.ShowTime();
            Console.ReadKey();
        }
    }
}
