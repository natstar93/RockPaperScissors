using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Round
    {
        public string Result;
        public Round()
        {
            Console.WriteLine("Type an option: Paper, Scissors or Stone.");
            string userOption = Console.ReadLine();
            // generate computer option
            // check which wins
            // assign a proper result
            Result = "WIN";
        }
    }
}
