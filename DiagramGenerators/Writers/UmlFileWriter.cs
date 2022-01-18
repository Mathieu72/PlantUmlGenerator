using System;
using System.IO;

namespace DiagramGenerators.Writers
{
    public interface IUmlFileWriter : IDisposable
    {
        void WriteLine(string line);
    }

    public class UmlFileWriter : IUmlFileWriter
    {
        private readonly TextWriter textWriter;

        public UmlFileWriter(string path)
        {
            this.textWriter = new StreamWriter(path);
        }

        public void Dispose()
        {
            this.textWriter.Dispose();
        }

        public void WriteLine(string line)
        {
            this.textWriter.WriteLine(line);
        }
    }
}
