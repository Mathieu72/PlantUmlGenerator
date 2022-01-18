using DiagramGenerators.Results;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DiagramGenerators
{
    public interface IClassDiagramGenerator
    {
        void Generate(string file, SyntaxNode root);
    }

    public class ClassDiagramGenerator : CSharpSyntaxWalker, IClassDiagramGenerator
    {
        private readonly IAnalysisResultBuilder resultBuilder;

        public ClassDiagramGenerator()
        {
            this.resultBuilder = new AnalysisResultBuilder();
        }

        public void Generate(string file, SyntaxNode root)
        {
            this.resultBuilder.BuildFileNode(file);
            Visit(root);
        }
    }
}
