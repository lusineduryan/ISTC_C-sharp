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

        public StreamWriter CreateTextFileW(string path, string name, out long memory)
        {
            memory = GC.GetTotalMemory(false);
            return new StreamWriter(Path.Combine(path, name));
        }

        public void WriteInTextFile(string text, StreamWriter file, out long memory)
        {
            memory = GC.GetTotalMemory(false);
            file.Write(text);
        }

        public StreamReader CreateTextFileR(string path, out long memory)
        {
            memory = GC.GetTotalMemory(false);
            return new StreamReader(path);
        }

        public string ReadFromTextFile(StreamReader file, out long memory)
        {
            memory = GC.GetTotalMemory(false);
            return file.ReadToEnd();
        }
    }
}
