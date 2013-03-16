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
        private readonly int[,] middleCell = new[,]
                                       {
                                           {0, 0, 0},
                                           {0, 1, 0},
                                           {0, 0, 0},
                                       };
        private int[,] board;

        [SetUp]
        public void SetupMethod()
        {
            board = (int[,])middleCell.Clone();
        }

        [Test]
        public void DeadBoardStillDead()
        {
            Assert.That(LifeGame.Advance(empty), Is.EqualTo(empty));
        }

        [Test]
        public void AliveCellAloneDies()
        {
            Assert.That(LifeGame.Advance(board), Is.EqualTo(empty));
        }

        [Test]
        public void AliveCellOneNeighborDies()
        {
            board[0, 0] = 1;
            Assert.That(LifeGame.Advance(board), Is.EqualTo(empty));
        }

        [Test]
        public void AliveCellTwoNeighborLives()
        {
            board[0, 0] = 1;
            board[2, 2] = 1;
            Assert.That(LifeGame.Advance(board), Is.EqualTo(middleCell));
        }

        [Test]
        public void AliveCellThreeNeighborLives()
        {
            board[0, 0] = 1;
            board[2, 2] = 1;
            board[0, 2] = 1;
            var advance = LifeGame.Advance(board);
            Assert.That(advance[1,1], Is.EqualTo(1));
        }

        [Test]
        public void DeadCellThreeNeighborBecomesLive()
        {
            board = (int[,])empty.Clone();
            board[0, 0] = 1;
            board[2, 2] = 1;
            board[0, 2] = 1;
            var advance = LifeGame.Advance(board);
            Assert.That(advance[1,1], Is.EqualTo(1));
        }

        [Test]
        public void AliveCellFourNeighborDies()
        {
            board[0, 0] = 1;
            board[2, 2] = 1;
            board[0, 2] = 1;
            board[1, 2] = 1;
            var advance = LifeGame.Advance(board);
            Assert.That(advance[1, 1], Is.EqualTo(0));
        }


    }
}
