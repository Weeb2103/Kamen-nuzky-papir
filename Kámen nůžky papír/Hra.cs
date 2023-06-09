﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kámen_nůžky_papír;

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
        public void ZvyseniSkore(bool vyhraHrace) //jednoduche zvysovani skore
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
        public void Start() //odpocet na startu
        {
            Console.WriteLine("Vítej ve hře kámen - nůžky - papír / Welcome at rock - paper - scissors");
            Console.WriteLine("Hra začíná za... / Game starts in...");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Clear();
        }        
        public void Menu() //menu voleb
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hráč / Player: " + SkoreHrac);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepřítel / Opponent: " + SkoreNepritel);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------");
            Console.WriteLine("1 - kámen / rock");
            Console.WriteLine("2 - nůžky / scissors");
            Console.WriteLine("3 - papír / paper");
            Console.WriteLine("-------------");
        }
        public void Remiza() //kdyz nastane remiza
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Remíza / Tie");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Vyhra() //kdyz nastane vyhra
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hráč vyhrál / Player won");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Prohra() //kdyz nastane prohra
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepřítel vyhrál / Opponent won");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void Chyba() //kdyz spatne zada hodnotu
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Špatně zadaná hodnota - zadej vstup znovu / Incorrectly entered value - enter the input again ");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public void FinalVyhra() //usetreni 2 radku v Program
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hráč vyhrál / Player won");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void FinalProhra()  //usetreni 2 radku v Program
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nepřítel vyhrál / Opponent won");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
