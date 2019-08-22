using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GCAndMemoryManagement
{
    class TextFiles : IDisposable
    {
        private void ReleaseUnmanagedResources()
        {
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}
