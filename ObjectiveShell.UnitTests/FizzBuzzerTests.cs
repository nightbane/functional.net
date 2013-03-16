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


        
        private FSharpList<T> ConvertList<T>(List<T> inputList)
        {
            FSharpList<T> sharplist = null;
            for (int i = inputList.Count - 1; i >= 0; i--)
            {
                sharplist = new FSharpList<T>(inputList[i], sharplist);
            }
            return sharplist;
        }
    }
}
