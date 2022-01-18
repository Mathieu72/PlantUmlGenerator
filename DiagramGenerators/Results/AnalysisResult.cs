using DiagramGenerators.Nodes;

using System.Collections.Generic;

namespace DiagramGenerators.Results
{
    public interface IAnalysisResult
    {
        IEnumerable<IFileNode> FileNodes { get; }
    }

    public interface IEditableAnalysisResult : IAnalysisResult
    {
        void AddFileNode(IFileNode fileNode);
    }

    public class AnalysisResult : IEditableAnalysisResult
    {
        public IEnumerable<IFileNode> FileNodes => fileNodes;

        private readonly List<IFileNode> fileNodes;

        public AnalysisResult()
        {
            this.fileNodes = new List<IFileNode>();
        }

        public void AddFileNode(IFileNode fileNode)
        {
            this.fileNodes.Add(fileNode);
        }
    }
}
