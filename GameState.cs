using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    enum Difficulty
    {
        EASY,
        MEDIUM,
        HARD
    };

    internal class GameState
    {
        public Difficulty difficulty;
        
        public GameState(Difficulty difficulty)
        {
            this.difficulty = difficulty;
        }
        public GameState(String gameFile)
        {
        }
    }
}
