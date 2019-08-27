using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace CriticalSection
{
    class MutexSection
    {
        private static Mutex mutex = new Mutex();
        private static int threads = 3;

        public static void UsingSource()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is requesting mutex!");
            mutex.WaitOne();
            Console.WriteLine($"{Thread.CurrentThread.Name} has entered the protected area!");
            using (StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "\\Lucy.txt"))
            {
                writer.Write("Text");
            }
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the protected area!");
            mutex.ReleaseMutex();
            Console.WriteLine($"{Thread.CurrentThread.Name} has released the mutex!");
        }

        public static void Process()
        {
            for (int i = 0; i < threads; i++)
            {
                Thread newThread = new Thread(new ThreadStart(UsingSource));
                newThread.Name = $"Thread{i+1}";
                newThread.Start();
            }
        }
    }
}
