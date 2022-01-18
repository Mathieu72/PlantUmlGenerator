using DiagramGenerators.Nodes;
using DiagramGenerators.Results;

using Moq;

using NUnit.Framework;

namespace Tests.UnitTests
{
    public class Suite_AnalysisResultBuilder
    {
        private IAnalysisResultBuilder builder;
        private Mock<INodeFactory> nodeFactoryMock;
        private Mock<IEditableAnalysisResult> resultMock;

        [SetUp]
        public void SetUp()
        {
            nodeFactoryMock = new Mock<INodeFactory> { DefaultValue = DefaultValue.Mock };
            resultMock = new Mock<IEditableAnalysisResult> { DefaultValue = DefaultValue.Mock };
            builder = new AnalysisResultBuilder(resultMock.Object, nodeFactoryMock.Object);
        }

        [Test]
        public void Test001a_BuildFileNode_MustCallCreateFileNodeMethodFromFactory()
        {
            //Arrange
            var file = "filePath";

            //Act
            builder.BuildFileNode(file);

            //Assert
            nodeFactoryMock.Verify(f => f.CreateFileNode(file), Times.Once);
        }

        [Test]
        public void Test001b_BuildFileNode_MustCallAddFileNodeMethodFromResult()
        {
            //Arrange
            var file = "filePath";
            var fileNode = Mock.Of<IFileNode>();
            nodeFactoryMock.Setup(f => f.CreateFileNode(file)).Returns(fileNode);

            //Act
            builder.BuildFileNode(file);

            //Assert
            resultMock.Verify(r => r.AddFileNode(fileNode), Times.Once);
        }

        [Test]
        public void Test002_Result_IsSet()
        {
            Assert.AreEqual(resultMock.Object, builder.Result);
        }
    }
}
