using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptrumps
{
    class TrumpBasic
    {
        public string Name { get; set; }
        public int Color { get; set; }
        public int Fluff { get; set; }
        public int Speed { get; set; }

        public TrumpBasic(string n, int c, int f, int s)
        {
            Name = n;
            Color = c;
            Fluff = f;
            Speed = s;
        }
    }
}
