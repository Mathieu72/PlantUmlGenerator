using DiagramGenerators.Results;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DiagramGenerators
{
    public interface IClassDiagramGenerator
    {
        IAnalysisResult Generate(string file, SyntaxNode root);
    }

    public class ClassDiagramGenerator : CSharpSyntaxWalker, IClassDiagramGenerator
    {
        private readonly IAnalysisResultBuilder resultBuilder;
        private static IClassDiagramGenerator instance;

        public static IClassDiagramGenerator Instance
        {
            get => instance ??= new ClassDiagramGenerator();
        }

        private ClassDiagramGenerator()
        {
            this.resultBuilder = new AnalysisResultBuilder();
        }

        public IAnalysisResult Generate(string file, SyntaxNode root)
        {
            this.resultBuilder.BuildFileNode(file);
            Visit(root);
            return resultBuilder.Result;
        }
    }
}
