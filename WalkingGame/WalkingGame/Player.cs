using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGame
{
     class Player
    {
        public Byte Position { set; get; }
        public String Skin { set; get; }
        public String FacingRight { set; get; } 
        public String FacingLeft { set; get;}
        public Boolean Jumping { set; get; }    

        public Player(String right, String left) 
        {
            Position = 0;
            FacingRight = right;
            FacingLeft = left;
            Skin = FacingRight;
            Jumping = false;
        }

        public void jump()
        {
            Console.Beep(234, 100);
        }

        public void walk(Boolean direction, Byte limit)
        {
            if (direction)
            {
                if (Position < limit)
                {
                    Position++;
                    Skin = FacingRight;
                }
            }
            else
            {
                if (Position > 0)
                {
                    Position--;
                    Skin = FacingLeft;
                }
            }
        }
    }
}
