using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public interface ITeam
    {
        public string Name { get; }
       public int Score { get; set; }
        public List<IPlayer> players { get; }//List of the Players in each team.
        int GetAttackingSkill();
        int GetDefendingSkill();
    }
}
