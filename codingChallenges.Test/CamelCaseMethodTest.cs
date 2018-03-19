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
        [Test]
        public void BasicTestTwo()
        {
            //Assert.AreEqual("aCatIsPippiThePippiIsKawaii", CamelCaseMethod.ToCamelCase("a_Cat_is_pippiThe_pippi_is_kawaii"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("aCatIsPippithePippiIsKawaii", CamelCaseMethod.ToCamelCase("a_Cat_is_pippiThe_pippi_is_kawaii"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }

        // "a_Cat_is_pippiThe_pippi_is_kawaii" expects
        // "aCatIsPippiThePippiIsKawaii" which is wrong because The in pippiThe should lose capitalization.
        // "aCatIsPippithePippiIsKawaii" should be the correct expectation.
    }
}