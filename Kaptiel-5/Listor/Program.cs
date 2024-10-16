// Använda listor för att skapa/hantera samlingar
Console.Clear();

// Lista på trevliga frukter, tex "äpple", "apelsin", "ananas"
List<string> frukter = ["äpple", "apelsin", "ananas"];

Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Ändra i listan:
frukter[0] = "banan";
Console.WriteLine($"Min fruktlista: {frukter[0]}, {frukter[1]}, {frukter[2]}");

// Loopa igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}

// Skapa en lista på valfri ska 4st
// Skriv ut varje sak på samma rad
List<string> städer = ["Stockholm", "Borås", "Göteborg"];
// Console.WriteLine($"Mina städer: {städer[0]}, {städer[1]}, {städer[2]}");
foreach (var stad in städer)
{
    Console.Write($"stad");
}
for (int i = 0; i < städer.Count; i++)
{
    Console.Write($"{städer[i]}");
}

// Skapa ett register
Console.Clear();
// En tom lista
List<string> namnlista = [];

// While-loop
while (true)
{
    Console.Write("Ange ett namn: ");
    string namn = Console.ReadLine();
    namnlista.Add(namn);

    // Skriv ut hela listan på en rad
    foreach (var namnet in namnlista)
    {
        Console.Write($"{namnet}, ");
    }
    Console.WriteLine();
}