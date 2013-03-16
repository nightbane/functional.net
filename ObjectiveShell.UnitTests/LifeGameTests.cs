using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ObjectiveShell.UnitTests
{
    [TestFixture]
    public class LifeGameTests
    {
        [Test]
        public void DeadBoardStillDead()
        {
            var board = new[,]
                            {
                                {0, 0, 0},
                                {0, 0, 0},
                                {0, 0, 0},
                            };
            Assert.That(LifeGame.Advance(board), Is.EqualTo(board));
        }
    }
}
