using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_PlaybackAndRecording
{
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
}
