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
        private IPlayerGenerator PlayerGenerator;
        public Team(string name, IPlayerGenerator playerGenerator)
        {
            Name = name;
            this.PlayerGenerator = playerGenerator;
            GeneratePlayers();
        }// Constructor to initialize the team with a name

        private void GeneratePlayers() // This function is for Generating Players with names and positioning them.
        {
            // Predefined positions for players
            string[] positions = { "Forward", "Midfielder", "Defender", "Goalkeeper" };
            // Create 11 players: 3 Forwards, 4 Midfielders, 3 Defenders, and 1 Goalkeeper
            for (int i = 0; i < 11; i++) 
            {
            string positioning= positions[i < 3 ? 0 : i < 7 ? 1 : i < 10 ? 2 : 3];
                players.Add(PlayerGenerator.CreatePlayer(positioning));//noticed we need an list to store the positions of the players.
            }
        }
        //public int GetAttackingSkill()
        //{
        //    int attackingSkill = 0;
        //    foreach (var player in players)
        //    {
        //        if (player.Position == "Forward" || player.Position == "Midfielder")
        //            attackingSkill += player.Skill;
        //    }
        //    return attackingSkill;
        //}// function for attacking purpose which will calculate forwords and midfielders skills.
        //public int GetDefendingSkills()
        //{
        //    int defendingSkills = 0;
        //    int GoalKeeperSkils = 0;
        //    foreach (var player in players)
        //    {
        //        if (player.Position == "Defender") defendingSkills += player.Skill;
        //        else if (player.Position == "GoalKeeper") GoalKeeperSkils += player.Skill;

        //    }
        //    return defendingSkills + GoalKeeperSkils;
        //}
    }
}
    