using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager
{
    class CoreData
    {
        public int score;
        public int speed;
        public int UFOspeed;
        public int playerSpeed;
        public int index;
        
        public CoreData(int aScore, int aSpeed, int aUFOspeed, int aPlayerSpeed, int aIndex)
        {
            score = aScore;
            speed = aSpeed;
            UFOspeed = aUFOspeed;
            playerSpeed = aPlayerSpeed;
            index = aIndex;
        }
    }
}
