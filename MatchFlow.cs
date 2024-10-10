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
        private void GameFlow(ITeam attacking,  ITeam defending)
        {
            
            int result1  = random.Next(0, attacking.players.Count);
            // Calculate attacking team's total attacking skill
            int AttackSkill = attacking.GetAttackingSkill();
            // Calculate defending team's total defending skill
            int defenseSkill = defending.GetDefendingSkill();
            // Add a random luck factor between -30 and +30 to the attacking team's skill
            int luckFactor = random.Next(-1000, 1001);

            // Display the attack and defense skills
            Console.WriteLine($"Attacking Skill: {AttackSkill}, Luck Factor: {luckFactor}, Defending Skill: {defenseSkill}");

            // Determine if the attack is successful (attack skill + luck must be greater than defense skill)
            if (AttackSkill + luckFactor > (defenseSkill + 5))
            {
                Console.WriteLine("Goal!"); // Attack is successful
                attacking.Score++; // Increase the attacking team's score by 1
            }
            else
            {
                Console.WriteLine("Defended successfully!"); // Defense was successful
            }
            // Display the current score of both teams after this turn
            Console.WriteLine($"Current Score: {team1.Name}: {team1.Score} | {team2.Name}: {team2.Score}");
        
        }

        
    }
}
