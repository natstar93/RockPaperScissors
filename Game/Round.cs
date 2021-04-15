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

            Console.WriteLine($"Winner {Winner}");
        }


        public IPlayer GetWinner(IPlayer[] players)
        {
            if (players[0].CurrentMoveOption == players[1].CurrentMoveOption) return null;
            return players[0]; // Fix this
        }

    }
}
