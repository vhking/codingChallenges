using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class SimplePigLatinTest
    {
        private SimplePigLatin _sp = new SimplePigLatin();
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", _sp.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", _sp.PigIt("This is my string"));
        }
    }
}