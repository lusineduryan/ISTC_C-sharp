using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class TaskBuilding
    {
        public double Square(double arg)
        {
            return arg * arg;
        }

        public void BuidTasks(Task[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Task.Factory.StartNew
                    (
                        () =>
                        {
                            Console.WriteLine($"{Square(i)} - {Thread.CurrentThread.ManagedThreadId}");
                        }
                    );
            }
        }
    }
}
