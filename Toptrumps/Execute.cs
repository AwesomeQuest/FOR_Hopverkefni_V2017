using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptrumps
{
    class Execute
    {
        static void Main(string[] args)
        {
            CardDump cardDump = new CardDump();

            GenerateCards.makeCardDeck(100, 0);

            cardDump.dump();

            cardDump.dump().TT0
            
        }
    }
}
