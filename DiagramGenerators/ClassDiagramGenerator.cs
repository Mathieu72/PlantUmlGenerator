using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace DiagramGenerators
{
    public interface IClassDiagramGenerator
    {
        void Generate(SyntaxNode root);
    }

    public class ClassDiagramGenerator : CSharpSyntaxWalker, IClassDiagramGenerator
    {
        public void Generate(SyntaxNode root)
        {
            Visit(root);
        }
    }
}
