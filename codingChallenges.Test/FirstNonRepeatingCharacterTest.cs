using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
   
    [TestFixture]
    public class FirstNonRepeatingLetterTest
    {
        private FirstNonRepeatingLetter _first = new FirstNonRepeatingLetter();
        [Test]
        public void FirstNonRepeatingLetter_NoIntelligence_ReturnTrue()
        {
            Assert.AreEqual("a", _first.Find("a"));
            Assert.AreEqual("t", _first.Find("stress"));
            Assert.AreEqual("e", _first.Find("moonmen"));
        }
        [Test]
        public void FirstNonRepeatingLetter_Linq_ReturnTrue()
        {
            Assert.AreEqual("a", _first.Find_w_Linq("a"));
            Assert.AreEqual("T", _first.Find_w_Linq("sTreSS"));
            Assert.AreEqual("e", _first.Find_w_Linq("moonmen"));
        }
         [Test]
        public void FirstNonRepeatingLetter_Linq2_ReturnTrue()
        {
            Assert.AreEqual("a", _first.FindBP("a"));
            Assert.AreEqual("T", _first.FindBP("sTreSS"));
            Assert.AreEqual("e", _first.FindBP("moonmen"));
        }
        
    }
}