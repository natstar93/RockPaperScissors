using System;

namespace Game
{
    public enum Outcome
    {
        Win,
        Lose,
        Draw
    }

    public class Round
    {
        public IPlayer Winner
        {
            get; set;
        }
        private bool _isComplete;
        public IPlayer[] Players;


        public Round(IPlayer[] players)
        {
            _isComplete = false;
            Players = players;
        }

        public void Play()
        {

            while (_isComplete == false)
            {
                foreach (var player in Players)
                {
                    player.Move();
                }


                Winner = GetWinner(Players);

                if (Winner != null)
                {
                    _isComplete = true;

                }

            };

            Console.WriteLine($"Round winner: {Winner.Name}");
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
