using Lesson_7.Models;
using NUnit.Framework;

namespace TestsOfLesson7
{
    public class UnitTestACoder
    {
        ACoder aCoder = new ACoder();              

        [Test]
        public void Test_Encode()
        {
            string[] words = { "AbCdEzZ", "bazman", "TEST", "ﬂˇ¿‡" };            

            Assert.AreEqual(aCoder.Encode(words[0]), "BcDeFaA");
            Assert.AreEqual(aCoder.Encode(words[1]), "cbanbo");
            Assert.AreEqual(aCoder.Encode(words[2]), "UFTU");
            Assert.AreEqual(aCoder.Encode(words[3]), "¿‡¡·");
        }

        [Test]
        public void Test_Decode()
        {
            string[] words = { "BcDeFaA", "cbanbo", "UFTU", "¿‡¡·" };

            Assert.AreEqual(aCoder.Decode(words[0]), "AbCdEzZ");
            Assert.AreEqual(aCoder.Decode(words[1]), "bazman");
            Assert.AreEqual(aCoder.Decode(words[2]), "TEST");
            Assert.AreEqual(aCoder.Decode(words[3]), "ﬂˇ¿‡");
        }
    }
}