using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_Game
{
    public enum Direction 
    { 
        up,
        down,
        left,
        right,
    };


    class Settings
    {
        public static int width
        {
            set;
            get;
        }

        public static int height
        {
            set;
            get;
        }
        public static int speed
        {
            set;
            get;
        }
        public static int score
        {
            set;
            get;
        }
        public static int points
        {
            set;
            get;
        }
        public static bool Gameover
        {
            set;
            get;
        }

        public static Direction direction
        {
            set;
            get;
        }

        public Settings()
        {
            width = 16;
            height= 16;
            speed = 16;
            points= 10;
            score = 0;
            Gameover = false;
            direction=Direction.down;




        
        }

    }
}
