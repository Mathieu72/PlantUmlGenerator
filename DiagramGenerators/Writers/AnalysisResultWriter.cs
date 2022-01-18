using DiagramGenerators.Nodes;
using DiagramGenerators.Results;

using System.IO;

namespace DiagramGenerators.Writers
{
    public interface IAnalysisResultWriter
    {
        void Write(IAnalysisResult result);
    }

    /// <summary>
    /// PlantUML writer.
    /// </summary>
    public class AnalysisResultWriter : IAnalysisResultWriter
    {
        private readonly string outputDirectory;
        private readonly IWriterFactory writerFactory;

        // TODO: to test [preve, 18/01/2022]
        public AnalysisResultWriter(string outputDirectory, IWriterFactory writerFactory)
        {
            this.outputDirectory = outputDirectory;
            this.writerFactory = writerFactory;
        }

        public void Write(IAnalysisResult result)
        {
            foreach (var fileNode in result.FileNodes)
            {
                WriteFileNode(fileNode);
            }
        }

        private void WriteFileNode(IFileNode fileNode)
        {
            var path = CreateFileName(fileNode);
            var umlFileWriter = writerFactory.Create(path);
        }

        private string CreateFileName(IFileNode fileNode)
        {
            var baseName = Path.GetFileNameWithoutExtension(fileNode.Path);
            return Path.Combine(outputDirectory, baseName);
        }
    }
}
