using NUnit.Framework;

namespace TicTacToe.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        [Test]
        public void AssignCharacter_Success()
        {
            var result = AssignCharacter('X');

            Assert.AreEqual('X', result);
        }

        public char AssignCharacter(char character)
        {
            return character;
        }
    }
}
