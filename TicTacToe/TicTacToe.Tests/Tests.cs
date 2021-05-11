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

        [Test]
        public void GameCreated_PlayerOneIsOnTurn()
        {
            int? playerOnTurn;

            playerOnTurn = 1;

            Assert.AreEqual(1, playerOnTurn);
        }

        [Test]
        public void PlayerOneOnTurn_PlayerOneMadeMove_PlayerTwoOnTurn()
        {
            int playerOnTurn = 1;

            playerOnTurn = 2;

            Assert.AreEqual(2, playerOnTurn);
        }

        [Test]
        public void PlayerOneOnTurn_PlayerOneMakesMove_MoveHasBeenMade()
        {
            bool playerOneMakesMove = false;
            bool moveMade = false;
            int playerOnTurn = 1;

            if (playerOnTurn == 1) playerOneMakesMove = true;
            if (playerOneMakesMove) moveMade = true;

            Assert.IsTrue(moveMade);
        }

        private Dictionary<int, char> CreatePlayers()
        {
            var players = new Dictionary<int, char>();

            players.Add(1, 'X');
            players.Add(2, 'O');

            return players;
        }
    }
}