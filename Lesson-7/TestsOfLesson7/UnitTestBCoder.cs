using Lesson_7.Models;
using NUnit.Framework;

namespace TestsOfLesson7
{
    public class UnitTestBCoder
    {
        BCoder bCoder = new BCoder();

        [Test]
        public void Test_Encode()
        {
            string[] words = { "АБВГЯ", "ABCDZ", "Test", "тесТ" };

            Assert.AreEqual(bCoder.Encode(words[0]), "ЯЮЭЬА");
            Assert.AreEqual(bCoder.Encode(words[1]), "ZYXWA");
            Assert.AreEqual(bCoder.Encode(words[2]), "Gvhg");
            Assert.AreEqual(bCoder.Encode(words[3]), "нъоН");
        }

        [Test]
        public void Test_Decode()
        {
            string[] words = { "ЯЮЭЬА", "ZYXWA", "Gvhg", "нъоН" };

            Assert.AreEqual(bCoder.Decode(words[0]), "АБВГЯ");
            Assert.AreEqual(bCoder.Decode(words[1]), "ABCDZ");
            Assert.AreEqual(bCoder.Decode(words[2]), "Test");
            Assert.AreEqual(bCoder.Decode(words[3]), "тесТ");
        }
    }
}
