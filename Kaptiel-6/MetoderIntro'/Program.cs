Console.Clear();
Console.WriteLine("Hej metoder!");

// Använd metoden
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();
SägHej();

/// <summary>
/// Metod som skriver ut en hälsning
/// <summary>
static void SägHej()
{
    Console.WriteLine("Hej på dig");
}

/// <summary>
/// Metod för att visa en meny
/// <summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Skriv ut alla uppgifter
    4. Avsluta
    """);
}

// Använd 
VisaMeny();

static void RegistreraNamn()
{
    Console.WriteLine("Melker B!");
}

// Använd metoden
RegistreraNamn();

/* ****************************************
***************** M A I N *****************
**************************************** */

/// <summary>
/// Skriv ut hälsning
/// <summary>
/// <param name="name">Namnet</param>
static void SägHejNamn(string namn)
{
    Console.WriteLine($"Hej på dig {namn}");
}

// Metod som skriver ett tal i kvadrat!
static void KvadreraTal()
{
    
}