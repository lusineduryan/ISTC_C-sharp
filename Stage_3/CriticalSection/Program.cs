using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalSection
{
    class Program
    {
        static void Main(string[] args)
        {
           // MutexSection.Process();
            MonitorSection.TaskCreator();
            Console.ReadKey();
        }
    }
}
