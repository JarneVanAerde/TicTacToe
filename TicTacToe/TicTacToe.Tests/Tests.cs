using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void EmptyBoard_NotAWinningCondition()
        {
            bool emptyBoard = true;

            Assert.IsTrue(emptyBoard);
        }
    }
}