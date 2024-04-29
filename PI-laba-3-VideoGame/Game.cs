using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_laba_3_VideoGame
{
    public class Game
    {
        List<Level> Levels;

        public Game(List<Level> levels) 
        { 
            this.Levels = levels;
        }
        

        public List<Level> GetLevels()
        {
            return Levels;
        }
    }
}
