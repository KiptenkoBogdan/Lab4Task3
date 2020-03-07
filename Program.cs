using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Ship galeon = new Ship("Neptune", "galleon", 500, 5, "none");
            Console.WriteLine();
            Carrier gerald = new Carrier("Gerald Ford", "carrier", 100000, 30, "n/a", "F-35", 90);
            Console.WriteLine();
            Missile_Carrier kongo = new Missile_Carrier("JS Kongo", "destroyer", 7500, 30, "n/a", "RGM-84 Harpoon", 32);
            Console.ReadKey();
        }
    }
}
