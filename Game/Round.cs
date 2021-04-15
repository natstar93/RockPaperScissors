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
        public bool IsComplete;
        public IPlayer[] Players;


        public Round(IPlayer[] players)
        {
            IsComplete = false;
            Players = players;
        }

        public void Play()
        {
            IsComplete = false;

            while (IsComplete == false)
            {
                foreach (var player in Players)
                {
                    player.Move();
                }


                Winner = GetWinner(Players);

                if (Winner != null)
                {
                    IsComplete = true;

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
