using DiagramGenerators;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

using NUnit.Framework;

using System.IO;

namespace Tests
{
    public class Suite001_ClassDiagramGenerator
    {
        public const string CSHARP_FILE = @"C:\Users\preve\Documents\CodeProjects\CSharp\UMLDiagramGenerator\PlantUmlGenerator\Tests\Data\CustomerDescriptor.cs";

        private void Analyze(string file)
        {
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                var tree = CSharpSyntaxTree.ParseText(SourceText.From(stream));
                var root = tree.GetRoot();

                var gen = new ClassDiagramGenerator();
                gen.Generate(file, root);
            }
        }

        [Test]
        public void Test001_Scenario()
        {
            Analyze(CSHARP_FILE);
        }
    }
}
