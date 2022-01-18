using DiagramGenerators.Nodes;

namespace DiagramGenerators.Results
{
    public interface IAnalysisResultBuilder
    {
        IAnalysisResult Result { get; }
        void BuildFileNode(string file);
    }

    public class AnalysisResultBuilder : IAnalysisResultBuilder
    {
        private readonly IEditableAnalysisResult result;
        private readonly INodeFactory nodeFactory;
        public IAnalysisResult Result => result;

        public AnalysisResultBuilder() 
            : this(new AnalysisResult(), new NodeFactory())
        {}

        public AnalysisResultBuilder(IEditableAnalysisResult result, INodeFactory nodeFactory)
        {
            this.result = result;
            this.nodeFactory = nodeFactory;
        }

        public void BuildFileNode(string file)
        {
            var fileNode = nodeFactory.CreateFileNode(file);
            result.AddFileNode(fileNode);
        }
    }
}
