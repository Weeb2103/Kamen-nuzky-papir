using System.Threading;
using Kámen_nůžky_papír;
bool end = false;
while (end == false)//pouzito pro opakovani hry
{
    Hra hra = new Hra();
    hra.Start();
    while (hra.SkoreHrac < 5 && hra.SkoreNepritel < 5)
    {
        hra.Menu();
        ConsoleKeyInfo vyberHrace = Console.ReadKey(true);
        Random generatorVoleb = new Random();
        int vyberNepritele = generatorVoleb.Next(3);

        switch (vyberHrace.Key)
        {
            //kdyz hrac vybere kámen
            case ConsoleKey.D1:
            case ConsoleKey.NumPad1:
                if (vyberNepritele == 1)
                {
                    hra.Remiza();
                    break;
                }
                else if (vyberNepritele == 2)
                {
                    hra.Vyhra();
                    hra.ZvyseniSkore(true);
                    break;
                }
                else
                {
                    hra.Prohra();
                    hra.ZvyseniSkore(false);
                    break;
                }
            //kdyz hrac vybere nuzky
            case ConsoleKey.D2:
            case ConsoleKey.NumPad2:
                if (vyberNepritele == 1)
                {
                    hra.Prohra();
                    hra.ZvyseniSkore(false);
                    break;
                }
                else if (vyberNepritele == 2)
                {
                    hra.Remiza();
                    break;
                }
                else
                {
                    hra.Vyhra();
                    hra.ZvyseniSkore(true);
                    break;
                }
            //kdyz hrac vybere papir
            case ConsoleKey.D3:
            case ConsoleKey.NumPad3:
                if (vyberNepritele == 1)
                {
                    hra.Vyhra();
                    hra.ZvyseniSkore(true);
                    break;
                }
                else if (vyberNepritele == 2)
                {
                    hra.Prohra();
                    hra.ZvyseniSkore(false);
                    break;
                }
                else
                {
                    hra.Remiza();
                    break;
                }
            //spatna volba
            default:
                hra.Chyba();
                break;
        }
    }
    zpet:
    if (hra.SkoreHrac > hra.SkoreNepritel)
    {
        hra.FinalVyhra(); //vyhra hrace
    }
    else
    {
        hra.FinalProhra(); //prohra hrace
    }    
    //rozhodnuti znova
    Console.WriteLine("Chceš znovu? / Again?");
    Console.WriteLine("A/N");
    ConsoleKeyInfo vyber = Console.ReadKey(true);
    switch (vyber.Key) 
    { 
      //znova
      case ConsoleKey.A:
            end = false;
            Console.Clear();
            break;
      //konec
      case ConsoleKey.N:
            end = true;
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("Konec programu");
            Console.ForegroundColor= ConsoleColor.White;
            break;
      //chyba
        default:
            hra.Chyba();
            goto zpet;            
    }
}