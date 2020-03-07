using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task3
{
    class Missile_Carrier: Ship
    {
        string missile_type;
        int missile_num;
        public Missile_Carrier(string n, string p, int d, int ep, string ft, string mt, int mn) : base(n, p, d, ep, ft)
        {
            this.missile_type = mt;
            this.missile_num = mn;
            Input_Info();
        }
        public void Input_Info()
        {
            Console.WriteLine("Missile type - {0}", missile_type);
            Console.WriteLine("Number of missiles - {0}", missile_num);
        }
    }
}
