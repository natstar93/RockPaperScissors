using Xunit;

namespace Game.Tests
{
    public class GetResultTests
    {
        [Fact]
        public void GetResultReturnsADraw()
        {
            IPlayer p1 = new HumanPlayer("Nat");
            IPlayer p2 = new ComputerPlayer();
            IPlayer[] players = {p1, p2};

            Round r1 = new Round(players);
            p1.CurrentMoveOption = MoveOption.Paper;
            p2.CurrentMoveOption = MoveOption.Paper;

            Assert.Equal(Outcome.Draw, r1.GetResult(new [] {p1, p2}));
        }
    }
}
