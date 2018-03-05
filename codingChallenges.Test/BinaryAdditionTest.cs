using codingChallenges.CodeWars;
using NUnit.Framework;

namespace Tests
{
    public class BinaryAdditionTest
    {
        private BinaryAddition _ba = new BinaryAddition();
        [Test]
        public void BinaryAddition_Addition_Returns11()
        {
             Assert.AreEqual("11", _ba.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }
    }
}