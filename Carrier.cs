using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task3
{
    class Carrier: Ship
    {
        string planes;
        int plane_num;
        public Carrier(string n, string p, int d, int ep, string ft, string pl, int pn):base(n, p, d, ep, ft)
        {
            this.planes = pl;
            this.plane_num = pn;
            Input_Info();
        }
        public void Input_Info()
        {
            Console.WriteLine("Plane type - {0}", planes);
            Console.WriteLine("Number of planes - {0}", plane_num);
        }
    }
}
