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
        public static int Width
        {
            set;
            get;
        }

        public static int Height
        {
            set;
            get;
        }
        public static int Speed
        {
            set;
            get;
        }
        public static int Score
        {
            set;
            get;
        }
        public static int Points
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
            Width = 16;
            Height= 16;
            Speed = 100;
            Points= 10;
            Score = 0;
            Gameover = false;
            direction=Direction.down;
        }
    }
}
