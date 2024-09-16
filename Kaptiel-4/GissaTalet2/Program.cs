// Spelet - gissa ett slumptal 1-100
using System.Runtime.Intrinsics.Arm;

Console.Clear();
Console.WriteLine("Spelet - Gissa ett slumptal 1-100");

// En variabel för att hålla koll på antal gissningar
int antal = 0;

// Be användaren ange slumptalets gränser med min och max
Console.Write("Ange slumptalets lägsta värde: ");
int minVärde = int.Parse(Console.ReadLine());
Console.Write("Ange slumptalets högsta värde: ");
int maxVärde = int.Parse(Console.ReadLine());

// Slumpar ett tal 1-100 (Gammal)
// int slumptal = Random.Shared.Next(1, 101); (Gammal)

int slumptal = Random.Shared.Next (minVärde, maxVärde + 1);

// Upprepning - loop
while (true)
{
   
    // Ställ fråga till användaren 
    Console.Write($"Gissa ett tal ({minVärde}-{maxVärde}): ");
    int gissning = int.Parse(Console.ReadLine());

    // Räkna upp antal med 1
    antal++;

    // Kontrollera om gissningen är rätt eller fel
    if (gissning == slumptal)
    {
        Console.WriteLine($"Rätt gissat på {antal} gång/gånger!");
        break;
    }
    else if (gissning > slumptal)
    {
        Console.WriteLine("För högt!");
    }
    else
    {
        Console.WriteLine("För lågt!");
    }
    
    // Vill användaren gissa en gång till?
    Console.Write("Vill du gissa en gång till? (J/N): ");
    string svar = Console.ReadLine();
   if (svar == "N")
    {
        break;
    }

}
// Slut på spelet
Console.WriteLine("Slut, tack för att du spelade!");