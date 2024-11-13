// Slumpa många tal och spara i lista
Console.Clear();
Console.WriteLine("Slumpa många tal och spara i lista");

// Globala variabler
// En lista för heltal
List<int> listaSlumptal = [];

// Be användaren ange antal slumpade tal
Console.Write("Hur många tal vill du slumpa?: ");
int antal = int.Parse(Console.ReadLine());

// Be användaren ange min & max slumptal
Console.Write("Ange minsta  värde slumptal: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Ange max värde slumptal: ");
int max = int.Parse(Console.ReadLine());

// Loopa 5 ggr
for (int i = 0; i < antal; i++)
{
    // Slumpa ett tal 1-100
    int slumptal = 0;
    
    // Lägg till slumptalet i listan
    listaSlumptal.Add(slumptal);

    slumptal = Random.Shared.Next(max, max+1);
    Console.WriteLine($"Slumpat tal {i + 1}: {slumptal}");
}