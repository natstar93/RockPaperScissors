using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public class Player
    {
        public string Name;
        public Player(string playerName)
        {
            Name = playerName;
        }

        public int Score { get; set; }
    }
}
