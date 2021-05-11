using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GameStarted_WithTwoPlayers()
        {
            var players = new List<int>();

            players.Add(1);
            players.Add(2);

            Assert.AreEqual(2, players.Count());
        }
    }
}