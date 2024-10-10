using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public class MatchFlow
    {
        private ITeam team1;
        private ITeam team2;
        private Random random = new Random();

        // Initialize with two teams
        public MatchFlow(ITeam team1, ITeam team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
        // Display all players on the team, including their name, position, and skill level
        private void DisplayTeamPlayers(ITeam team)
        {
            Console.WriteLine($"\nTeam {team.Name}:");
            for (int i = 0; i < team.players.Count; i++)
            {
                var player = team.players[i];
                Console.WriteLine($"{i + 1}. {player.Name} - {player.Position} (Skill: {player.Skill})");
            }
        }
        public void Matchstart()
        {
            // Display players for both teams
            DisplayTeamPlayers(team1);
            DisplayTeamPlayers(team2);
        }
    }
}
