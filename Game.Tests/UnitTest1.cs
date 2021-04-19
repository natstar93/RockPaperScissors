using Xunit;

namespace Game.Tests
{
    public class GetWinnerTests
    {
        private IPlayer[] players;
        private Round r1;
        private IPlayer p1;
        private IPlayer p2;

        public GetWinnerTests()
        {
            p1 = new HumanPlayer("Nat");
            p2 = new ComputerPlayer();
            players = new[] { p1, p2 };

            r1 = new Round(players);
        }

        [Theory]
        [InlineData(MoveOption.Paper)]
        [InlineData(MoveOption.Scissors)]
        [InlineData(MoveOption.Stone)]
        public void TwoPlayersWithSameChoiceReturnsADraw(MoveOption moveOption)
        {

            p1.CurrentMoveOption = moveOption;
            p2.CurrentMoveOption = moveOption;

            Assert.Null(r1.GetWinner(new [] {p1, p2}));
        }

        [Theory]
        [InlineData(MoveOption.Scissors, MoveOption.Paper)]
        [InlineData(MoveOption.Stone, MoveOption.Scissors)]
        public void TwoPlayersWithDifferentChoicesReturnsWinner(MoveOption p1MoveOption, MoveOption p2MoveOption)
        {

            p1.CurrentMoveOption = p1MoveOption;
            p2.CurrentMoveOption = p2MoveOption;

            Assert.Equal(p1, r1.GetWinner(new[] { p1, p2 }));
        }
    }
}
