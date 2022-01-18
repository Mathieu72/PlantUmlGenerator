namespace DiagramGenerators.Nodes
{
    public interface IFileNode
    {
        string Path { get; }
    }

    public class FileNode : IFileNode
    {
        public string Path { get; }

        public FileNode(string path)
        {
            Path = path;
        }
    }
}
