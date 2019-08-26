using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] array = new Task[3];
            TaskBuilding task = new TaskBuilding();
            task.BuidTasks(array);
            Console.ReadKey();
        }
    }
}
