using NUnit.Framework;
using codingChallenges.CodeWars;

namespace codingChallenges.Test
{
    [TestFixture]
    public class Tests
    {
        private StopGninnipsMySdrow _spin = new StopGninnipsMySdrow();

        [Test]
        public void Test1()
        {
            Assert.AreEqual("emocleW", _spin.SpinWords("Welcome"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Hey wollef sroirraw", _spin.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("This is a test", _spin.SpinWords("This is a test"));
        }

        [Test]
        public void Test4()
        {
            Assert.AreEqual("This is rehtona test", _spin.SpinWords("This is another test"));
        }

        [Test]
        public void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", _spin.SpinWords("You are almost to the last test"));
        }

        [Test]
        public void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", _spin.SpinWords("Just kidding there is still one more"));
        }
    }
}