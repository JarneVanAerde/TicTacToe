using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GameCreated_WithTwoPlayers()
        {
            var players = new List<int>();

            players.Add(1);
            players.Add(2);

            Assert.AreEqual(2, players.Count());
        }

        [Test]
        public void GameStarted_PlayersGetCharacterAssinged()
        {
            var players = new Dictionary<int, char>();

            players.Add(1, 'X');
            players.Add(2, 'O');

            Assert.AreEqual('X', players[1]);
            Assert.AreEqual('O', players[2]);
        }
    }
}