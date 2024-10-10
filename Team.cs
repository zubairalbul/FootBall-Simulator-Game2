using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public class Team : ITeam
    {
        //Team's Name and List of Players:
        public string Name { get; private set; }
        public int Score { get; private set; }
        public List<IPlayer> players { get; private set; }= new List<IPlayer>();
        
        public Team(string name , int score, List<IPlayer> players)
        {
            Name = name;
            Score = score;
            this.players = players;
        }// Constructor to initialize the team with a name
    }
}
    