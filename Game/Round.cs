using System;

namespace Game
{
    public class Round
    {
        public IPlayer Winner
        {
            get; set;
        }
        public IPlayer[] Players;


        public Round(IPlayer[] players)
        {
            Players = players;
        }

        public void Play()
        {

            while (Winner == null)
            {
                foreach (var player in Players)
                {
                    player.Move();
                }

                Winner = GetWinner(Players);
            };

            Console.WriteLine($"\n**Round winner: {Winner.Name}**");
        }


        public IPlayer GetWinner(IPlayer[] players)
        {
            MoveOption p1MoveOption = players[0].CurrentMoveOption;
            MoveOption p2MoveOption = players[1].CurrentMoveOption;

            if (p1MoveOption == p2MoveOption) return null;

            return (((p1MoveOption == MoveOption.Scissors) && (p2MoveOption == MoveOption.Paper)) ||
                ((p1MoveOption == MoveOption.Stone) && (p2MoveOption == MoveOption.Scissors)) || 
                ((p1MoveOption == MoveOption.Paper) && (p2MoveOption == MoveOption.Stone)))
            ? players[0] : players[1];
        }
    }
}
