using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game
    {
        public Player Player1;
        public int TotalRounds = 3;
        public int RoundsCompleted = 0;
        public string Winner;

        public Game(string playerName)
        {
            Player1 = new Player(playerName);

            Console.WriteLine($"Hello {Player1.Name} your score is currently {Player1.Score}.");
            Console.WriteLine($"This game has {TotalRounds} rounds.");

            while (RoundsCompleted < TotalRounds)
            {
                var round = new Round();

                RoundsCompleted += 1;

                if (round.Result == "WIN")
                {
                    Player1.Score += 1;
                } ;
            }

            Winner = Player1.Score == 3 ? Player1.Name : "Computer";
        }

    }
}
