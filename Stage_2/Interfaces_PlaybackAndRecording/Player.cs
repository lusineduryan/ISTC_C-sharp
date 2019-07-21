using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PlaybackAndRecording
{
    class Player : IPlayable, IRecordable, IDisposable
    {
        public void Play()
        {
            Console.WriteLine("Music started!");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Music paused!");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Music stopped!");
        }

        public void Record()
        {
            Console.WriteLine("Recording started!");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Recording paused!");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Recording stopped!");
        }

        public void Dispose()
        {
            Console.WriteLine("Player closed!");
        }
    }
}
