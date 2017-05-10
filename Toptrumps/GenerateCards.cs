using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Toptrumps
{
    class GenerateCards
    {
        public static void makeCardDeck(int numberOfCards, int type)
        {
            Random r = new Random();

            string path = @"c:\Users\torfi\Documents\Visual Studio 2015\Projects\Toptrumps\Toptrumps\cards.cs";

            StreamWriter file = new StreamWriter(path);
            
            try
            {

                string start = " using System; \r\n using System.Text; \r\n using System.IO; \r\n using Toptrumps; \r\n\r\n namespace Toptrumps { class CardDump { public static void dump() { \r\n";

                file.WriteLine(start);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }


            try
            {
                string name = null;

                if (type == 0)
                {
                    for (int i = 0; i < numberOfCards; i++)
                    {
                        name = "TT" + i.ToString("X");

                        int n = r.Next(0, 200);
                        int c = r.Next(0, 200);
                        int f = r.Next(0, 200);
                        int s = r.Next(0, 200);

                        string card = string.Format("\r\n TrumpBasic {0} = new TrumpBasic(\"{0}\", {1}, {2}, {3});", name, c, f, s);

                        file.WriteLine(card);
                    }
                }

                else if (type == 1)
                {
                    for (int i = 0; i < numberOfCards; i++)
                    {
                        name = "TTM" + i.ToString("X");
                        
                        int c = r.Next(0, 200);
                        int f = r.Next(0, 200);
                        int s = r.Next(0, 200);
                        int h = r.Next(0, 200);
                        int a = r.Next(0, 200);
                        int t = r.Next(0, 200);

                        string card = string.Format("\r\n TrumpMale {0} = new TrumpMale(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6});", name, c, f, s, h, a, t);

                        file.WriteLine(card);
                    }
                }

                else if (type == 2)
                {
                    for (int i = 0; i < numberOfCards; i++)
                    {
                        name = "TTF" + i.ToString("X");

                        int n = r.Next(0, 200);
                        int c = r.Next(0, 200);
                        int f = r.Next(0, 200);
                        int s = r.Next(0, 200);
                        int g = r.Next(0, 200);
                        int k = r.Next(0, 200);
                        int e = r.Next(0, 200);

                        string card = string.Format("\r\n TrumpFemale {0} = new TrumpFemale(\"{0}\", {1}, {2}, {3}, {4}, {5}, {6});", name, c, f, s, g, k, e);

                        file.WriteLine(card);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }

            try
            {
                string end = "\r\n\r\n\r\n\r\n } } }";

                file.WriteLine(end);

                file.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }

        
    }
}
