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
            var winner = game.PlayGame();

            Console.WriteLine($"*** {winner.Name} WINS! ***");
        }
    }
}
