using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ObjectiveShell.UnitTests
{
    [TestFixture]
    public class LifeGameNeighborCountTests
    {
        private readonly int[,] starting = new[,]
                                       {
                                           {0, 0, 0},
                                           {0, 1, 0},
                                           {0, 0, 0},
                                       };
        
        [Test]
        public void CountNeighborsEmpty()
        {
            Assert.That(LifeGame.CountNeighbors(starting, 1, 1), Is.EqualTo(0));
        }

        [TestCase(0, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 2)]
        [TestCase(1, 0)]
        [TestCase(1, 2)]
        [TestCase(2, 0)]
        [TestCase(2, 1)]
        [TestCase(2, 2)]
        public void CountNeighborsOne(int x, int y)
        {
            var board = (int[,])starting.Clone();
            board[x, y] = 1;
            Assert.That(LifeGame.CountNeighbors(board, 1, 1), Is.EqualTo(1));
        }

        [Test]
        public void CountNeighborsTwo()
        {
            var board = new[,]
                            {
                                {0, 1, 0},
                                {0, 1, 1},
                                {0, 0, 0},
                            };
            Assert.That(LifeGame.CountNeighbors(board, 1, 1), Is.EqualTo(2));
        }

        [Test]
        public void CountNeighborsThree()
        {
            var board = new[,]
                            {
                                {0, 1, 0},
                                {0, 1, 1},
                                {1, 0, 0},
                            };
            Assert.That(LifeGame.CountNeighbors(board, 1, 1), Is.EqualTo(3));
        }

        [TestCase(0,0)]
        [TestCase(0,1)]
        [TestCase(0,2)]
        [TestCase(1,0)]
        [TestCase(1,2)]
        [TestCase(2,0)]
        [TestCase(2,1)]
        [TestCase(2,2)]
        public void BoundryTestTop(int x, int y)
        {
            var array = (int[,]) starting.Clone();
            array[x, y] = 1;
            Assert.That(LifeGame.CountNeighbors(array, x, y), Is.EqualTo(1));
        }

        [Test]
        public void MiddleRowTest()
        {
            Assert.That(LifeGame.IsFirstColumn(starting, 0));            
        }

    }
}
