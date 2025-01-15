/* ****************************************
* **************** M A I N ****************
****************************************** */
// Använd metoder här!
//  int svar = Addera(3, 5);
// Console.WriteLine($"Svaret är {svar}");
// Console.WriteLine(Addera(3, 5));
// Console.WriteLine($"3 + 5 = {Addera(3, 5)}");
Console.Clear();
string namn = "Melker";
Console.WriteLine($"{namn} baklänges är {VändText(namn)}");
Console.WriteLine($"4*6 = {Multiplicera(4, 6)}");
Console.WriteLine($"6/2 = {Dividera(6, 2)}");
Console.WriteLine($"Längst av Hej och Hejdå är {Längst("Hej", "Hejdå")}");

Console.Write("Ange ett tal: ");
int nyTal1 = LäsInHeltal();

Console.Write("Ange ett tal: ");
int nyTal2 = LäsInHeltal();


/* **********************************************
* **************** M E T O D E R ****************
************************************************ */
// Skapa metoder här!

/// <summary>
/// Summera två tal
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static int Addera(int tal1, int tal2) // signatur
{
    int summa = tal1 + tal2;
    return summa;
}
/// <summary>
/// Vänder på texten
/// </summary>
/// <param name="text"></param>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i < 0; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}


double Multiplicera(double tal1, double tal2)
{
    return tal1 * tal2;
}

double Dividera(double tal1, double tal2)
{
    return tal1 / tal2;
}


string Längst(string text1, string text2)
{
    if (text2.Length > text1.Length)
    {
        return text2;
    }
    else
    {
        return text1;
    }
}

/// <summary>
/// Säkert sätt att läsa in ett tal (utan att det kraschar)
/// </summary>
/// <param name="args"></param>
static int LäsInHeltal()
{
    int tal = 0;
    while (true)
    {
        // Läs in från användaren
        string textSomBlirTal = Console.ReadLine();
        // Kolla om texten är ett tal
        bool lyckades = int.TryParse(textSomBlirTal, out tal);

        if (lyckades == true)
        {
            break;
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, ange ett heltal! ");
        }
    }

    return tal;
}