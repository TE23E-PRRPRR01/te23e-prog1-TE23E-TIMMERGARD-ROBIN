
Console.Clear();
Console.WriteLine("*** Filmregistret ***");

List<string> listaFilmer = [];

Console.Write("Ange antal filmer per sida (3-5): ");
string antalText = Console.ReadLine();
int antal = 0;
while (true)
{
    bool success = int.TryParse(antalText, out antal);
    if (success)
    {
      break;  
    }
    else
    {
        Console.WriteLine("Fel, mata in ett heltal");
    }
}
// Programloop
while (true)
{

    // Visa en meny
    Console.WriteLine();
    Console.Write("""
1. Lägg till filmer
2. Skriv ut alla filmer
3. Sök efter en film
4. Avsluta
Välj ett alternativ: 
""");
    string val = Console.ReadLine();

    // Hanterar med valet
    if (val == "1")
    {
        for (int i = 0; i < antal; i++)
        {
            Console.Write("Ange film att lägga till: ");
            string film1 = Console.ReadLine();
            listaFilmer.Add(film1);
        }
    }
    else if (val == "2")
    {
        // Skriv ut alla filmer
        foreach (var filmnamn in listaFilmer)
        {
            Console.WriteLine($"- {filmnamn}");
        }
    }
    else if (val == "3")
    {
        // Sök en film
        Console.Write("Ange en film att söka efter (Första bokstaven): ");
        string bokstav = Console.ReadLine();
        foreach (var filmnamn in listaFilmer)
        {
            // Kolla om varje film börjar på bokstaven
            if (filmnamn.StartsWith(bokstav))
            {
                Console.WriteLine($"- {filmnamn}");
            }
        }

    }
    else if (val == "4")
    {
        Console.WriteLine("Tack för idag");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt, försök igen");
    }
}
