using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PlaybackAndRecording
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
}
