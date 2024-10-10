using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public class Players : IPlayer
    {
        // Properties for player name, position, and skill
        public string Name { get; private set; }
        public string Position { get; private set; }
        public int Skill {  get; private set; }
        // Constructor to initialize player with a name, position, and skill
        
    }
}
