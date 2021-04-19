using System;
using System.Linq;

namespace Game
{
    public class Game
    {
        private static IPlayer[] Players;
        public int TotalRounds;
        public int RoundsCompleted = 0;
        public IPlayer Winner;

        public Game(string playerName, int rounds)
        {
            TotalRounds = rounds;
            Players = new IPlayer[] {new HumanPlayer(playerName), new ComputerPlayer()};
        }

        public void PlayGame()
        {

            // create IO interface and call method to get user input 
            Console.WriteLine($"Hello {Players[0].Name} your score is currently {Players[0].Score}.");
            Console.WriteLine($"This game has {TotalRounds} rounds.");

            while (RoundsCompleted < TotalRounds)
            {
                var round = new Round(Players);
                round.Play();

                IPlayer roundWinner = round.Winner;

                RoundsCompleted += 1;

                roundWinner.Score += 1;
                
                Console.WriteLine($"Rounds Completed {RoundsCompleted}.");
                Console.WriteLine($"{Players[0].Name} has a score of {Players[0].Score}.");
                Console.WriteLine($"{Players[1].Name} has a score of {Players[1].Score}.\n");
            }

            Winner = Players.OrderByDescending(player => player.Score).FirstOrDefault();
        }

    }
}
