using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CriticalSection
{
    class MonitorSection
    {
        static List<Task> tasks = new List<Task>();
        static Random rnd = new Random();

        public static void TaskCreator()
        {
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run( () =>
                {
                    int[] rndNumbers = new int[100];
                    int taskTotal = 0;
                    int taskCount = 0;
                    Monitor.Enter(rnd);
                    for (int j = 0; j < rndNumbers.Length; j++)
                    {
                        rndNumbers[i] = rnd.Next(0, 1001);
                        taskCount++;
                    }
                    Monitor.Exit(rnd);
                    foreach (var item in rndNumbers)
                    {
                        taskTotal += item;
                    }

                    Console.WriteLine($"Mean for task {Task.CurrentId} is {taskTotal / taskCount}");
                }));
            }
        }
    }
}
