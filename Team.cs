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

        private void GeneratePlayers() // This function is for Generating Players with names and positioning them.
        {
            // Predefined positions for players
            string[] positions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };
            // Create 11 players: 3 Forwards, 4 Midfielders, 3 Defenders, and 1 Goalkeeper
            for (int i = 0; i < 11; i++) 
            {
            string positioning= positions[i < 3 ? 0 : i < 7 ? 1 : i < 10 ? 2 : 3];
                players.Add(playerFactory.CreatePlayer(positioning));//noticed we need an list to store the positions of the players.
            }
        }
    }
}
    