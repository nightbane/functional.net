using NUnit.Framework;

namespace ObjectiveShell.UnitTests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void TestOneisOne()
        {
            Assert.That(FizzBuzzer.Translate(1), Is.EqualTo("1"));
        }
    }
}
