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
            var createdPlayers = CreatePlayers();

            Assert.AreEqual(2, createdPlayers.Count());
        }

        [Test]
        public void GameCreated_PlayersHaveCharacterAssinged()
        {
            var createdPlayers = CreatePlayers();

            Assert.AreEqual('X', createdPlayers[1]);
            Assert.AreEqual('O', createdPlayers[2]);
        }

        public Dictionary<int, char> CreatePlayers()
        {
            var players = new Dictionary<int, char>();

            players.Add(1, 'X');
            players.Add(2, 'O');

            return players;
        }
    }
}