using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ObjectiveShell.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void TestOneisOne()
        {
            Assert.That(FizzBuzzer.Translate(1), Is.EqualTo("1"));
        }
    }
}
