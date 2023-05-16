using System.Threading;
using Kámen_nůžky_papír;

Hra hra = new Hra();
Console.WriteLine("Vítej ve hře kámen - nůžky - papír / Welcome at rock - paper - scissors");
Console.WriteLine("Hra začíná za... / Game starts in...");
Console.WriteLine("3");
Thread.Sleep(1000);
Console.WriteLine("2");
Thread.Sleep(1000);
Console.WriteLine("1");
Thread.Sleep(1000);
Console.Clear();
while (hra.SkoreHrac < 5 && hra.SkoreNepritel < 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hráč / Player: " + hra.SkoreHrac);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nepřítel / Opponent: " + hra.SkoreNepritel);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("-------------");
    Console.WriteLine("1 - kámen / rock");
    Console.WriteLine("2 - nůžky / scissors");
    Console.WriteLine("3 - papír / paper");
    Console.WriteLine("-------------");
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Špatně zadaná hodnota - zadej vstup znovu / Incorrectly entered value - enter the input again ");
            Thread.Sleep(2000);
            Console.Clear();
            break;
    }
}
if (hra.SkoreHrac > hra.SkoreNepritel)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Hráč vyhrál / Player won");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Nepřítel vyhrál / Opponent won");
    Console.ForegroundColor = ConsoleColor.White;
}