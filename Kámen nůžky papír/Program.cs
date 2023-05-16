using System.Threading;
using Kámen_nůžky_papír;

Hra hra = new Hra();
hra.Start();
while (hra.SkoreHrac < 5 && hra.SkoreNepritel < 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hráč / Player: " + hra.SkoreHrac);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nepřítel / Opponent: " + hra.SkoreNepritel);
    hra.Menu();
    ConsoleKeyInfo vyberHrace = Console.ReadKey(true);
    Random generatorVoleb = new Random();
    int vyberNepritele = generatorVoleb.Next(3);

    switch (vyberHrace.Key)
    {
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
        default:
            hra.Chyba();
            break;
    }
}
if (hra.SkoreHrac > hra.SkoreNepritel)
{
    hra.FinalVyhra();
}
else
{
    hra.FinalProhra();
}