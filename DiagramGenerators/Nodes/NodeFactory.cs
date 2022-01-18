namespace DiagramGenerators.Nodes
{
    public interface INodeFactory
    {
        IFileNode CreateFileNode(string path);
    }

    public class NodeFactory : INodeFactory
    {
        public IFileNode CreateFileNode(string path)
        {
            return new FileNode(path);
        }
    }
}
