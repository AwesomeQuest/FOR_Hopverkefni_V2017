using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptrumps
{
    class TrumpMale : TrumpBasic
    {
        public int HornSize { get; set; }
        public int Aggressiveness { get; set; }
        public int Testosterone { get; set; }
        
        public TrumpMale(string n, int c, int f, int s, int h, int a, int t) : base(n, c, f, s)
        {
            HornSize = h;
            Aggressiveness = a;
            Testosterone = t;
        }

    }
}
