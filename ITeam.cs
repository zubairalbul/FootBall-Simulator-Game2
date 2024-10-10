using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public interface ITeam
    {
        string Name { get; }
        int Score { get; set; }
        List<IPlayer> players { get; }//List of the Players in each team.
    }
}
