using codingChallenges.Codewars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class SplitStringTests
    {
        private SplitStrings _string = new SplitStrings();
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, _string.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, _string.Solution("abcdef"));
        }
    }
}