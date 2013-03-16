using System.Collections.Generic;
using Microsoft.FSharp.Collections;
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

        private FSharpList<T> ConvertList<T>(List<T> inputlist)
        {
            FSharpList<T> sharplist = FSharpList<T>.Empty;
            for (int i = inputlist.Count - 1; i >= 0; i--)
            {
                sharplist = new FSharpList<T>(inputlist[i], sharplist);
            }
            return sharplist;
        }
    }
}
