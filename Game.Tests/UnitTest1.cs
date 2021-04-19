using Xunit;

namespace Game.Tests
{
    public class GetWinnerTests
    {
        [Fact]
        public void TwoPlayersWithSameChoiceReturnsADraw()
        {
            IPlayer p1 = new HumanPlayer("Nat");
            IPlayer p2 = new ComputerPlayer();
            IPlayer[] players = {p1, p2};

            Round r1 = new Round(players);
            p1.CurrentMoveOption = MoveOption.Paper;
            p2.CurrentMoveOption = MoveOption.Paper;

            Assert.Null(r1.GetWinner(new [] {p1, p2}));
        }

        [Fact]
        public void ThreePlayersWithSameChoiceReturnsADraw()
        {
            IPlayer p1 = new HumanPlayer("Nat");
            IPlayer p2 = new ComputerPlayer();
            IPlayer p3 = new ComputerPlayer();
            IPlayer[] players = { p1, p2, p3 };

            Round r1 = new Round(players);
            p1.CurrentMoveOption = MoveOption.Paper;
            p2.CurrentMoveOption = MoveOption.Paper;
            p3.CurrentMoveOption = MoveOption.Paper;

            Assert.Null(r1.GetWinner(new[] { p1, p2, p3 }));
        }

        [Fact]
        public void TwoPlayersWithDifferentChoicesReturnsWinner()
        {
            IPlayer p1 = new HumanPlayer("Nat");
            IPlayer p2 = new ComputerPlayer();
            IPlayer[] players = { p1, p2 };

            Round r1 = new Round(players);
            p1.CurrentMoveOption = MoveOption.Scissors;
            p2.CurrentMoveOption = MoveOption.Paper;

            Assert.Equal(p1, r1.GetWinner(new[] { p1, p2 }));
            Assert.Equal(p1, r1.GetWinner(new[] { p2, p1 }));
        }
    }
}
