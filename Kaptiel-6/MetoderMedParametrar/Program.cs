/* ****************************************
* **************** M A I N ****************
****************************************** */
Console.Clear();

// Skriv ett meddelande vertikalt
// string meddelande = "Måndag!";
// SkrivVertikalt(meddelande);

// Skriv ett meddelande vertikalt nr 2
// string meddelande1 = "Tisdag är bättre!";
// SkrivVertikalt(meddelande1);

// Skriv ett meddelande vertikalt nr 3
// string meddelande2 = "Tisdag är bättre!";
// SkrivVertikalt(meddelande2);

// Rita ut en fyrkant med sidlängd 3
// RitaKvadrat(3);

// UpprepaText("Hej", 3);
// UpprepaText("Hejsan", 5);

KastaTärning(6);

/* **********************************************
* **************** M E T O D E R ****************
************************************************ */



// static void SkrivVertikalt(string meddelande)
// {
//    for (int i = 0; i < meddelande.Length; i++)
//    {
//        Console.WriteLine(meddelande[i]);
//    }
//
// }   

// static void RitaKvadrat(int sidlängd)
// {
// for (int i = 0; i < sidlängd; i++)
// {
//    for (int j = 0; j < sidlängd; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
// }
//  }

// static void UpprepaText(string text, int antal)
// {
//    for (int i = 0; i < text.Length; i++)
//    {
//        Console.WriteLine(text);
//    }
//}

static void OmvandlaCTillF(int celsius)
{
    int fahrenheit = celsius * 9/5 + 32;
    Console.WriteLine($"{celsius} grader Celsius motsvarar {fahrenheit} grader Fahrenheit");
}

static void KastaTärning(int antal)
{
    for (int i = 0; i < antal; i++)
    {
        Console.WriteLine($"Tärningen visar {Random.Shared.Next(1, 7)}");
    }
}