// Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Console.Clear();
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

Console.Write("Vad heter du?: ");
string namn = Console.ReadLine();

// Programlopp
while (true)
{
    Console.Write("Ange din bruttolön i kronor: ");
    int bruttolön = int.Parse(Console.ReadLine());

    // Har användaren matat vettiga siffror?
    if (bruttolön < 10000 || bruttolön > 1000000)
    {
        Console.WriteLine($"{namn}, bruttolön måste vara mellan 10000:- och 1000000:-");
    }
    else
    {
        // Vad är skattesatsen?
        // 10000:- till 145000:- -> 22%
        int skattesatsen = 0;
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            skattesatsen = 22; // Skapa variabeln skattesatsen
        }
        // 145000:- till 515000:- -> 33%
        else if (bruttolön >= 145000 && bruttolön < 515000)
        {
            skattesatsen = 33; // Skapa variabeln skattesatsen
        }
        else if (bruttolön >= 515000)
        {
            skattesatsen = 53; // Skapa variabeln skattesatsen
        }

        // Skatteuträkning
        int nettolön = bruttolön * (100 - skattesatsen) / 100;

        // Feedback till användaren
        Console.WriteLine($"Din nettolön blir {nettolön} kr. Uträkning baserad på bruttolön {bruttolön} kr och marginalskatten {skattesatsen}%.");
    }
    // Vill du göra en ny beräkning? (j/n) n
    Console.Write("Vill du göra en ny beräkning? (j/n): ");
    string görOm = Console.ReadLine().ToLower().Trim();
    if (görOm == "n")
    {
        break;
    }

}

