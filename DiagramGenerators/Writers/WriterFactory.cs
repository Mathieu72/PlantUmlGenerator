namespace DiagramGenerators.Writers
{
    public interface IWriterFactory
    {
        IUmlFileWriter Create(string path);
    }

    public class WriterFactory : IWriterFactory
    {
        public IUmlFileWriter Create(string path)
        {
            return new UmlFileWriter(path);
        }
    }
}
