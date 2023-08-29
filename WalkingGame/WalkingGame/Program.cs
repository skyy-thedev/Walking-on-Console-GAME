using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player ("p", "q");
            Scene c = new Scene ("_", 60);
            ConsoleKey key;

            c.print(p);

            do
            {
                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        // WALK BACK //
                        p.walk(false, c.Width);
                        c.print(p);
                        break;
                    case ConsoleKey.RightArrow:
                        //WALK FORWARD //
                        p.walk(true, c.Width);
                        c.print(p);
                        break;
                    case ConsoleKey.UpArrow:
                        // JUMPING //
                        p.Jumping = true;
                        c.print(p);
                        p.jump();
                        p.Jumping = false;
                        c.print(p);
                        break;
                    default:
                        c.print(p);
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
    }
}