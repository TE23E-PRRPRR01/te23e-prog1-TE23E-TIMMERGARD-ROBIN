// Ett bonanza spel
Console.Clear();

Console.Write("Ange startvärde: ");
int startvärde = int.Parse(Console.ReadLine());

Console.Write("Ange slutvärde: ");
int slutvärde = int.Parse(Console.ReadLine());


int summan = 0;

for (var i = startvärde; i < slutvärde+1; i++)
{
    Console.WriteLine(i);
    summan += i;
}

Console.WriteLine($"Summan av siffrorna {startvärde} till {slutvärde} är {summan}");