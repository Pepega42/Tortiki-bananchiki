using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Menu
    {
         public static int Show(int mins, int maxs)
        {
            int pos = 3;
            ConsoleKeyInfo key;

            do
            {
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

                key = Console.ReadKey();

                Console.SetCursorPosition(0, pos);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow && pos != mins)
                {
                    pos--;
                }
                else if (key.Key == ConsoleKey.DownArrow && pos != maxs)
                {
                    pos++;
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    pos = 0;
                    Console.Clear();
                }
                
            } while (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Escape);
            
            return pos;

        }
    }
}
