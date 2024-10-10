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
    }
}
