using System.Collections.Generic;
using Microsoft.FSharp.Collections;
using NUnit.Framework;

namespace ObjectiveShell.UnitTests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        private readonly FSharpListHelper fSharpListHelper = new FSharpListHelper();

        [Test]
        public void TestOneisOne()
        {
            Assert.That(FizzBuzzer.Translate(1), Is.EqualTo("1"));
        }
    }
}
