using FileManagerLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestFileManager
{
    [TestClass]
    public class UnitTestFiles
    {
        Files testFiles = new Files();

        [TestMethod]
        public void TestMethod_CopyFromTo()
        {
            //Arrange
            string fromPath = @"D:\Ваня\Test\CopyFromTo.txt";

            string toPath = @"D:\Ваня\Test\2";

            string expected = @"D:\Ваня\Test\2\CopyFromTo.txt";

            //Act
            testFiles.CopyFromTo(fromPath, toPath);

            //Assert
            Assert.IsTrue(File.Exists(expected));
            Assert.IsTrue(File.Exists(fromPath));
        }

        [TestMethod]
        public void TestMethod_Create()
        {
            //Arrange
            string pathToCreate = @"D:\Ваня\Test\CreateMethod.txt";

            //Act
            testFiles.Create(pathToCreate);

            //Assert
            Assert.IsTrue(File.Exists(pathToCreate));            
        }

        [TestMethod]
        public void TestMethod_Delete()
        {
            //Arrange
            string pathToDelete = @"D:\Ваня\Test\FileToDelete.txt";

            //Act
            testFiles.Delete(pathToDelete);

            //Assert
            Assert.IsFalse(File.Exists(pathToDelete));
        }
        
        [TestMethod]
        public void TestMethod_MoveFromTo()
        {
            //Arrange
            string fromPath = @"D:\Ваня\Test\MoveFromTo.txt";

            string toPath = @"D:\Ваня\Test\2";

            string expected = @"D:\Ваня\Test\2\MoveFromTo.txt";

            //Act
            testFiles.MoveFromTo(fromPath, toPath);

            //Assert
            Assert.IsTrue(File.Exists(expected));
            Assert.IsFalse(File.Exists(fromPath));
        }

        [TestMethod]
        public void TestMethod_Rename()
        {
            //Arrange
            string targetPath = @"D:\Ваня\Test\FileToRename.docx";

            string newName = "AfterTest.docx";

            string expected = @"D:\Ваня\Test\AfterTest.docx";

            //Act
            testFiles.Rename(targetPath, newName);

            //Assert
            Assert.IsTrue(File.Exists(expected));            
        }

        [TestMethod]
        public void Rename_WhenEmptyNewName_ShouldThrowArgumentExeprion()
        {
            //Arrange
            string targetPath = @"D:\Ваня\Test\CopyFromTo.txt";

            string newName = "";
                        
            //Act and Assert
            Assert.ThrowsException<System.ArgumentException>(() => testFiles.Rename(targetPath, newName));           
        }        
    }
}
