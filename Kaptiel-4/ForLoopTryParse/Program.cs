// Program som loopar städer flera gånger
Console.Clear();
Console.WriteLine("Program som loopar städer flera gånger");

while (true)
{

    Console.Write("Ange en stad: ");
    string stad = Console.ReadLine();

    Console.Write("Ange hur många gånger du vill repetera din stad: ");

    string antalText = Console.ReadLine();
    int antal = 0;
    bool success = int.TryParse(antalText, out antal);
    if (true)
    {

        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine($"{i}. {stad}");
        }

        // Be användaren mata in ytterligare ett tal
        Console.Write("Ange ett ytterligare tal: ");
        string talText = Console.ReadLine();
        int tal = 0;
        success = int.TryParse(talText, out tal);

        // Skriv ut resultaten av följande beräkningar på talet¨
        // Multiplicera det med 2.
        Console.WriteLine($"Multiplicera med 2: {tal * 2}");
        // Dividera det med 2.
        Console.WriteLine($"Dividerat med 2: {(tal * 2)} / 2");
        // Addera 2.
        Console.WriteLine($"Addera med 2 {(tal * 2) / 2}) + 2");
        // Subtrahera 2.
    }
}