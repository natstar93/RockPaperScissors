using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name?");
            string name = Console.ReadLine();

            var game = new Game(name, 3); // could pass round instances (with round logic) instead of an int
            game.PlayGame();

            Console.WriteLine($"*** {game.Winner.Name} WINS! ***");

            // Winner as result of PlayGame method OR GetResults method (score breakdown or something like that)
        }
    }
}
