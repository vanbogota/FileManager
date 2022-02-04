using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using FileManagerLibrary;

namespace TestFileManager
{
    [TestClass]
    public class UnitTestFolder
    {
        Folder testFolder = new Folder();

        [TestMethod]
        public void TestMethod_CopyFromTo()
        {
            //Arrange
            string fromPath = @"D:\Ваня\Test\FolderToCopy";

            string toPath = @"D:\Ваня\Test\FolderForCopy";

            string expected1 = @"D:\Ваня\Test\FolderForCopy\FolderToCopy";

            string expected2 = @"D:\Ваня\Test\FolderForCopy\FolderToCopy\FolderInFolder";

            string expected3 = @"D:\Ваня\Test\FolderForCopy\FolderToCopy\FolderInFolder\ForFolderTest.txt";

            //Act
            testFolder.CopyFromTo(fromPath, toPath);

            //Assert
            Assert.IsTrue(Directory.Exists(fromPath));

            Assert.IsTrue(Directory.Exists(expected1));

            Assert.IsTrue(Directory.Exists(expected2));

            Assert.IsTrue(File.Exists(expected3));
        }

        [TestMethod]
        public void TestMethod_Create()
        {
            //Arrange
            string pathToCreate = @"D:\Ваня\Test\FolderToCreate";

            //Act
            testFolder.Create(pathToCreate);

            //Assert
            Assert.IsTrue(Directory.Exists(pathToCreate));
        }

        [TestMethod]
        public void TestMethod_Delete()
        {
            //Arrange
            string pathToDelete = @"D:\Ваня\Test\FolderToDelete";

            //Act
            testFolder.Delete(pathToDelete);

            //Assert
            Assert.IsFalse(Directory.Exists(pathToDelete));
        }

        [TestMethod]
        public void TestMethod_MoveFromTo()
        {
            //Arrange
            string fromPath = @"D:\Ваня\Test\FolderToMove";

            string toPath = @"D:\Ваня\Test\FolderForMoved";

            string expected1 = @"D:\Ваня\Test\FolderForMoved\FolderToMove";

            string expected2 = @"D:\Ваня\Test\FolderForMoved\FolderToMove\FolderInFolder";

            string expected3 = @"D:\Ваня\Test\FolderForMoved\FolderToMove\FolderInFolder\ForFolderTest.txt";

            //Act
            testFolder.MoveFromTo(fromPath, toPath);

            //Assert
            Assert.IsFalse(Directory.Exists(fromPath));

            Assert.IsTrue(Directory.Exists(expected1));

            Assert.IsTrue(Directory.Exists(expected2));

            Assert.IsTrue(File.Exists(expected3));
        }

        [TestMethod]
        public void TestMethod_Rename()
        {
            //Arrange
            string targetPath = @"D:\Ваня\Test\FolderToRename";

            string newName = "AfterTest";

            string expected = @"D:\Ваня\Test\AfterTest";

            //Act
            testFolder.Rename(targetPath, newName);

            //Assert
            Assert.IsTrue(Directory.Exists(expected));
        }

        [TestMethod]
        public void Rename_WhenEmptyNewName_ShouldThrowArgumentExeprion()
        {
            //Arrange
            string targetPath = @"D:\Ваня";

            string newName = "";

            //Act and Assert
            Assert.ThrowsException<System.ArgumentException>(() => testFolder.Rename(targetPath, newName));
        }
    }
}
