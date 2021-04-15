using System;

namespace Game
{
    public enum MoveOption
    {
        Paper,
        Scissors,
        Stone
    };

    // abstract because it never gets instantiated
    // can be an interface (no methods) - signature of method but no implementation 
    public interface IPlayer
    {
        public string Name
        {
            get; set;
        }
        public int Score
        {
            get; set;
        }
        MoveOption CurrentMoveOption
        {
            get;
            set;
        }

        void Move();
    }

    public class HumanPlayer : IPlayer
    {
        public string Name
        {
            get; set;
        }
        public int Score
        {
            get; set;
        }
        public MoveOption CurrentMoveOption
        {
            get; set;
        }

        public HumanPlayer(string playerName)
        {
            Name = playerName;

        }

        public void Move()
        {
            bool isMoveValid = false;
            string userOption = "";

            while (isMoveValid == false)
            {
                Console.WriteLine("Type an option: Paper, Scissors or Stone.");

                userOption = Console.ReadLine();
                if (IsValid(userOption))
                {
                    isMoveValid = true;
                }
            };
            CurrentMoveOption = (MoveOption)Enum.Parse(typeof(MoveOption), userOption);
            Console.WriteLine($"{Name} chose {CurrentMoveOption}");
        }




        private static bool IsValid(string input)
        {
            return Enum.IsDefined(typeof(MoveOption), input);
        }
    }

    public class ComputerPlayer : IPlayer
    {
        private readonly Random _random = new Random();

        public string Name
        {
            get; set;
        }
        public int Score { get; set; }
        public MoveOption CurrentMoveOption
        {
            get; set;
        }
        public ComputerPlayer()
        {
            Name = "Computer";
        }

        public void Move()
        {
            Array moveOptions = Enum.GetValues(typeof(MoveOption));
            CurrentMoveOption = (MoveOption)moveOptions.GetValue(_random.Next(moveOptions.Length));

            Console.WriteLine($"Computer chose {CurrentMoveOption}");
        }
    }

}
