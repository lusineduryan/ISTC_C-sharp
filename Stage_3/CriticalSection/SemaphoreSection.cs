using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CriticalSection
{
    class SemaphoreSection
    {
        private static Semaphore pool = new Semaphore(0, 3);
        
        public static void WorkingWithSource(object number)
        {
            Console.WriteLine($"Thread {number} begins and waits for semaphore!");
            pool.WaitOne();
            Console.WriteLine($"Thread {number} enters the semaphore!");
            using (StreamReader readFile = new StreamReader(Environment.CurrentDirectory + "\\Lucy.txt"))
            {
                Console.WriteLine(readFile.ReadToEnd());
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Thread {number} releases the semaphore!");
            Console.WriteLine($"Thread {number} previous semaphore count: {pool.Release()}");
        }

        public static void Mainprocess()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread newThread = new Thread(new ParameterizedThreadStart(WorkingWithSource));
                newThread.Start(i);
            }
            Thread.Sleep(1000);
            Console.WriteLine("The waiting threads are allowed to enter the semaphore, up to 3 at a time!");
            pool.Release(3);
        }
    }
}
