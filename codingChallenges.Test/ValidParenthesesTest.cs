using codingChallenges.CodeWars;
using NUnit.Framework;

namespace codingChallenges.Test
{
    [TestFixture]
    public class ValidParenthesesTest
    {
        private ValidParentheses _vp = new ValidParentheses();
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, _vp.FindValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            // Assert.AreEqual(false, _vp.FindValidParentheses("())()()()()()(()"));
            // Assert.AreEqual(false, _vp.FindValidParentheses(")(()))"));
            // Assert.AreEqual(false, _vp.FindValidParentheses("("));
            // Assert.AreEqual(false, _vp.FindValidParentheses(")"));
            // Assert.AreEqual(true, _vp.FindValidParentheses("(())((()())())"));
            // Assert.AreEqual(false, _vp.FindValidParentheses("()()()()()()()(()"));
            // Assert.AreEqual(false, _vp.FindValidParentheses("()()(()"));
            // Assert.AreEqual(true, _vp.FindValidParentheses("(((()()())))"));
            //Assert.AreEqual(true, _vp.FindValidParentheses("<><><>>>>><<<>>>"));
            Assert.AreEqual(true, _vp.FindValidParentheses( "" ));

        }
    }

}