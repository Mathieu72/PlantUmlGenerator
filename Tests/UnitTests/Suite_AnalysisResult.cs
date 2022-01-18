using DiagramGenerators.Nodes;
using DiagramGenerators.Results;

using Moq;

using NUnit.Framework;

namespace Tests.UnitTests
{
    public class Suite_AnalysisResult
    {
        private IEditableAnalysisResult result;

        [SetUp]
        public void SetUp()
        {
            this.result = new AnalysisResult();
        }

        [Test]
        public void Test001_FileNodes_IsInitialyEmpty()
        {
            CollectionAssert.IsEmpty(result.FileNodes);
        }

        [Test]
        public void Test002_AddFileNode_MustAddFileNodeToFileNodes()
        {
            //Arrange
            var fileNode = Mock.Of<IFileNode>();

            //Act
            result.AddFileNode(fileNode);

            //Assert
            CollectionAssert.AreEqual(new[] { fileNode }, result.FileNodes);
        }
    }
}
