using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Game15
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var game = new Game3(1, 2, 3, 4, 5, 6, 7, 0, 8);
                while (!game.win())
                {
                    Draw.Print(game);

                    Console.WriteLine("ВВедите число которое хотите передвинуть");
                    int choise = Convert.ToInt32(Console.ReadLine());
                    while (!game.Shift(choise))
                    {
                        Console.WriteLine("Введите другое число");
                        choise = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Draw.Print(game);
                Console.Read();
            }
        }
    }
}
