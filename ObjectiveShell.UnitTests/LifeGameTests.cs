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
        private readonly int[,] empty = new[,]
                                       {
                                           {0, 0, 0},
                                           {0, 0, 0},
                                           {0, 0, 0},
                                       };

        [Test]
        public void DeadBoardStillDead()
        {
            Assert.That(LifeGame.Advance(empty), Is.EqualTo(empty));
        }

        [Test]
        public void AliveCellAloneDies()
        {
            var board = (int[,])empty.Clone();            
            Assert.That(LifeGame.Advance(empty), Is.EqualTo(empty));
        }


    }
}
