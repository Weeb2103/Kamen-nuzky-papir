using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kámen_nůžky_papír
{
    class Hra
    {
        public int SkoreHrac { get; set; }
        public int SkoreNepritel { get; set; }
        public Random generatorVoleb = new Random();
        public Hra()
        {
            SkoreHrac = 0;
            SkoreNepritel = 0;
        }
        public void ZvyseniSkore(bool vyhraHrace)
        {
            if (vyhraHrace)
            {
                SkoreHrac++;
            }
            else
            {
                SkoreNepritel++;
            }
        }
        public void Remiza()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Remíza / Tie");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Vyhra()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hráč vyhrál / Player won");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Prohra()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepřítel vyhrál / Opponent won");
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
