using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGame
{
     class Scene
    {
        public String Floor { set; get; }

        public Byte Size { set; get; }  

        public Scene(String floor) 
        {
            this.Floor = floor;
            this.Size = size;
        }

        public void print(Player p)
        {
            Console.Clear();
            Console.WriteLine();

            // PRINT FIRST LINE //
            if (p.Jumping)
            {
                for (Byte i = 0; i  p.Position; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Skin);
            }
            else
            {
                Console.WriteLine();
            }

            // PRINT SECOND LINE //
            for (Byte i = 0; i < p.Position; i++)
            {
                Console.Write(Floor);
            }

            if (p.Jumping) Console.Write(Floor);
            else Console.Write(p.Skin);

            for (Byte i = 0; i < (Size - p.Position); i++)
            {
                Console.Write(Floor);
            }
        }
    }
}
