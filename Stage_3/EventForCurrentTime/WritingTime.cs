using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventForCurrentTime
{
    public delegate void CurrentTime();

    public class WritingTime
    {
        public event CurrentTime TimeWriter;

        public void ShowTime()
        {
            while (true)
            {
                TimeWriter.Invoke();
                Thread.Sleep(10000);
            }
        }
    }
}
