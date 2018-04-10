using codingChallenges.Codewars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class DutstepTest
    {
        private Dubstep _dub = new Dubstep();
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", _dub.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", _dub.SongDecoderRF("RWUBWUBWUBLWUB")); // RL
        }
    }
}