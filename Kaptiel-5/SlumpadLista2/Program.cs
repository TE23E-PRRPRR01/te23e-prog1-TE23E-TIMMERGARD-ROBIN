// Skapa lista med slumpade tal
// Validera användarens inmatning
Console.Clear();
Console.WriteLine("");

// Deklarera variabler
// Skapa en lista för att spara det slumpade talet
List<int> listaSlumptal = [];

// Fråga användaren hur många slumptal som ska skapas
Console.Write("Ange antal slumptal: ");
int antal = 0;
while (true)
{

    bool lyckades = int.TryParse(Console.ReadLine(), out antal);

    if (lyckades)
    {
        Console.WriteLine($"Du vill ha {antal} slumptal!");
    }
    else
    {
        Console.Write("Du måste skriva ett heltal: ");
    }
}
Console.WriteLine($"Du vill ha {antal} slumptal");

// Användaren mata in min-värde
int min = 0;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas
    Console.Write("Ange högsta slumptal: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out min);
    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Du vill ha {min} slumptal");

// Användaren mata in max-värde
int max = 0;
while (true)
{
    // Fråga användaren hur många slumptal som skall skapas
    Console.Write("Ange högsta slumptal: ");

    bool lyckades = int.TryParse(Console.ReadLine(), out max);
    if (lyckades)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste skriva ett heltal");
    }
}
Console.WriteLine($"Du vill ha {max} slumptal");

// Slumpa fram ett annat tal
for(int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"Ditt nya slumptal är {slumptal}");
}