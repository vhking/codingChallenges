using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("TestCase", "test case".CamelCase());
            Assert.AreEqual("CamelCaseMethod", "camel case method".CamelCase());
            Assert.AreEqual("SayHello", "say hello".CamelCase());
            Assert.AreEqual("CamelCaseWord", " camel case word".CamelCase());
            Assert.AreEqual("", "".CamelCase());
        }
    }
}