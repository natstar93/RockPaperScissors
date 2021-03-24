using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! What is your name?");
            string name = Console.ReadLine();

            Player player = new Player() { Name = name };

            Console.WriteLine($"Hello {player.Name} your score is currently {player.Score}.");
        }
    }
}
