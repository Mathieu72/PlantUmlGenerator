using DiagramGenerators.Nodes;

using NUnit.Framework;

namespace Tests.UnitTests
{
    public class Suite_FileNode
    {
        [Test]
        public void Test001_Path_MustSet()
        {
            //Arrange
            var path = "filePath";

            //Act
            IFileNode node = new FileNode(path);

            //Assert
            Assert.AreEqual(path, node.Path);
        }
    }
}
