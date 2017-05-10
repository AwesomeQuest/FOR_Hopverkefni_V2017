using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptrumps
{
    class TrumpFemale : TrumpBasic
    {
        public int Grace { get; set; }
        public int Kondition { get; set; }
        public int Estrogen { get; set; }

        public TrumpFemale(string n, int c, int f, int s, int g, int k, int e) : base(n, c, f, s)
        {
            Grace = g;
            Kondition = k;
            Estrogen = e;
        }
    }
}
