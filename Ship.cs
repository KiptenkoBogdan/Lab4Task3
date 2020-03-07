using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task3
{
    public class Ship
    {
        string name;
        string purpose;
        int displacement;
        int engine_power;
        string fuel_type;
        public Ship(string n, string p, int d, int ep, string ft)
        {
            this.name = n;
            this.purpose = p;
            this.displacement = d;
            this.engine_power = ep;
            this.fuel_type = ft;
            Put_Info();
        }
        public void Put_Info()
        {
            Console.WriteLine("Name - {0}", name);
            Console.WriteLine("Purpose - {0}", purpose);
            Console.WriteLine("Displacement - {0}", displacement);
            Console.WriteLine("Engine power - {0}", engine_power);
            Console.WriteLine("Fuel type - {0}", fuel_type);
        }
    }
}
