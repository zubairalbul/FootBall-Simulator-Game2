using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootBall_Simulator_Game2
{
    public class CreatePlayers : IPlayerGenerator
    {
        private Random random = new Random();
        private readonly List<string> PlayerNames = new List<string>()
        {
        "Ahmed", "Omar", "Hassan", "Ali", "Mohammed", "Youssef", "Mahmoud", "Khaled", "Ibrahim", "Said",
        "Ziad", "Tariq", "Fahad", "Musa", "Salim", "Rami", "Samir", "Jamil", "Nasser", "Mustafa"
        };


    }
}

