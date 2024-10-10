using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public interface IPlayer
    {
        string Name { get; }
        string Position { get; }
        int Skill {  get; }
    }
}
