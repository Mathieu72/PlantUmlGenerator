using DiagramGenerators;
using DiagramGenerators.Results;

using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;

using NUnit.Framework;

using System.IO;
using System.Linq;

namespace Tests
{
    public class Suite001_ClassDiagramGenerator
    {
        public const string CSHARP_FILE = @"C:\Users\preve\Documents\CodeProjects\CSharp\UMLDiagramGenerator\PlantUmlGenerator\Tests\Data\CustomerDescriptor.cs";

        private IAnalysisResult Analyze(string file)
        {
            using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                var tree = CSharpSyntaxTree.ParseText(SourceText.From(stream));
                var root = tree.GetRoot();

                return ClassDiagramGenerator.Instance.Generate(file, root);
            }
        }

        [Test]
        public void Test001_Scenario()
        {
            var result = Analyze(CSHARP_FILE);

            //Check file nodes
            CollectionAssert.AreEqual(
                new[] { CSHARP_FILE }, 
                result.FileNodes.Select(f => f.Path));
        }
    }
}
