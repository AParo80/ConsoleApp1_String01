using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_String01
{
    internal class VokaleZaehlen
    {
        public static void VokaleZaehlen01(string input)
        {

            int a = 0, e = 0, i = 0, o = 0, u = 0;

            //o = input.Sum(x => x.CompareTo('o'));

            foreach (char c in input.ToLower())
            {
                if (c == 'o')
                {
                    o++;
                }
            }


            Console.WriteLine("Anzahl von 'o'= " + o);
        }
        public static void VokaleZaehlenDictionary(string input)
        {
            // Wieviele Vokale sind in einem String enthalten?

            Dictionary<char, int> vokale = new Dictionary<char, int>();
            vokale.Add('a', 0);
            vokale.Add('e', 0);
            vokale.Add('i', 0);
            vokale.Add('o', 0);
            vokale.Add('u', 0);

            int a = 0, e = 0, i = 0, o = 0, u = 0;

            //o = input.Sum(x => x.CompareTo('o'));

            foreach (char c in input.ToLower())
            {
                if (c == 'o')
                {
                    vokale['o']++;
                }
            }


            Console.WriteLine("VokaleZaehlenDictionary: Anzahl von 'o'= " + vokale['o']);
        }
    }
}
