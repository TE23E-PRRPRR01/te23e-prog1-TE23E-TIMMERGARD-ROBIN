Console.Clear();
Console.WriteLine("Alla maträtter");
// Maträtter
List<string> maträtt = ["Pasta", "Ris", "Bulgur"];
foreach (string namn in maträtt)
{
    Console.WriteLine($"- {namn}");
}
Console.WriteLine("Viktiga årtal");
// Årtal
List<int> årtal = [1294, 1482, 1999, 2012, 1740];
foreach (int namn in årtal)
{
    Console.WriteLine($"* {namn}");
}
Console.Write("Alla årtal: ");
// Årtal
List<int> årtal1 = [1294, 1482, 1999, 2012, 1740];
foreach (int namn in årtal1)
{
    Console.Write($"{namn}, ");
}
Console.WriteLine();
// Namn
List<string> listaNamn = [];
while (true)
{
    Console.Write("Ange ett namn att lägga till (eller 'exit' för att avsluta): ");
    string namn = Console.ReadLine();
    if (namn == "exit")
    {
        break;
    }
    listaNamn.Add(namn);
}
// Skriv ut alla namn
Console.WriteLine($"Din nuvarande lista är: {string.Join(", ", listaNamn)}");