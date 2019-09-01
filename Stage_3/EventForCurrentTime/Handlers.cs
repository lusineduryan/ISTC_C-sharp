using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EventForCurrentTime
{
    public class Handlers
    {
        private static FileStream fs;
        private static StreamWriter sw;

        public static async void TimeInConsole()
        {
            Console.WriteLine(DateTime.Now);
        }

        public static async void TimeInFile()
        {
            using (fs = new FileStream(Environment.CurrentDirectory + "\\Time.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (sw = new StreamWriter(fs))
                {
                    sw.Write(DateTime.Now.ToString());
                }
            }
        }
    }
}
