using Xunit;
using Game;

namespace Game.Tests
{
    public class GameTests
    {
        [Fact]
        public void CreatesPlayer()
        {
            var game = new Game("Nat");
            Assert.Equal("Nat", game.Player1.Name);
        }
    }
}
