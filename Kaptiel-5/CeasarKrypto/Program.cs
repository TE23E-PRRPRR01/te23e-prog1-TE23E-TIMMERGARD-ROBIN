// Ett program som för kryptering med Caesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Ett program som för kryptering med Caesar-chiffer");

// Alfabetet, lista av bokstäver att använda
string alfabetet = "ABCDEFGHJIKLMNOPQRSTUVWXYZÅÄÖ";

// Ange en bokstav
Console.Write("Ange ett meddelande: ");
string meddelande = Console.ReadLine().ToUpper();

// Ange en nyckel (1-9)
Console.Write("Ange en nyckel (1-9): ");
int nyckel = int.Parse(Console.ReadLine());

foreach (var bokstav in meddelande)
{
// Hitta bokstavens position (index)
int index = alfabetet.IndexOf(bokstav);
Console.WriteLine($"'A' så är index={index}");

// Om bokstaven finns i alfabetet
if (index != -1)
{
// Caesar-kryptering, addera en nyckel (tex, 2)
int nyIndex = index + nyckel;
Console.WriteLine($"{index} + {nyckel} = {nyIndex}");

// Plocka ut bokstaven för nyIndex
char krypteradBokstav = alfabetet[nyIndex];
Console.WriteLine($"{nyIndex} är bokstaven {krypteradBokstav}");
    
}
else
{
    
}
    
}

