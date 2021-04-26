using System;
using System.Linq;

namespace Game
{
    // list of rounds to be played 
    public class Game
    {
        private static IPlayer[] _players;
        public int TotalRounds;
        public int RoundsCompleted = 0;
        public IPlayer Winner;

        public Game(string playerName, int rounds)
        {
            TotalRounds = rounds;
            _players = new IPlayer[] {new HumanPlayer(playerName), new ComputerPlayer()};
        }

        public IPlayer PlayGame()
        {

            // create IO interface and call method to get user input 
            Console.WriteLine($"Hello {_players[0].Name} your score is currently {_players[0].Score}.");
            Console.WriteLine($"This game has {TotalRounds} rounds.");

            while (RoundsCompleted < TotalRounds)
            {
                var round = new Round(_players);
                round.Play();

                IPlayer roundWinner = round.Winner;

                RoundsCompleted += 1;

                roundWinner.Score += 1;
                
                Console.WriteLine($"Rounds Completed {RoundsCompleted}.");
                Console.WriteLine($"{_players[0].Name} has a score of {_players[0].Score}.");
                Console.WriteLine($"{_players[1].Name} has a score of {_players[1].Score}.\n");
            }

            return _players.OrderByDescending(player => player.Score).FirstOrDefault();
        }

    }
}
