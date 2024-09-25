// Spelet blackjack även kallat 21:an
Console.Clear();
Console.WriteLine("Spelet BlackJack");

// Kortens värde är 
// 2-10 = 2-10
// Knekt, Dam, Kung = 10
// A/Ess = 1/(11)
// @todo slump måste va 4x1, 4x2 osv

// Variabler
int summaSpelare = 0;
int summaDealer = 0;
int kort = 0;
 // Dela ut 2 kort till varje spelare
 kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
 summaSpelare += kort;
 kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
 summaSpelare += kort;
 // Dela ut 2 kort till varje dealer
kort = Random.Shared.Next(1, 11);
summaDealer += kort;
kort = Random.Shared.Next(1, 11);
summaDealer += kort;
// Flera gånger (loop)
while (true)
{
    // Skriv ut summorna
    Console.WriteLine($"Du har {summaSpelare}!");
    Console.WriteLine($"Dealer har {summaDealer}!");

    // Stannar eller dra ett till kort 
    Console.Write("Vill du ha ett till kort? (J/N): ");
    string svar = Console.ReadLine().ToLower();
    if (svar == "N")
    {
        // @todo datorn får ta extra kort
        while (summaDealer > 17)
        {
        kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
        summaDealer += kort;
        }
        // Vem har vunnit
        // Den som har närmast 21 vinner
        if (summaSpelare > summaDealer && summaSpelare < 21)
        {
            Console.WriteLine("Du har vunnit!");
        }
        else 
        {
            Console.WriteLine("Datorn har vunnit");
        }
        break;
    }

    // Ta ett extra kort
    kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaSpelare += kort;
    // Skriv ut kortet
    Console.WriteLine($"Du fick {kort}");

    // Datorn får också ett extra kort
     kort = Random.Shared.Next(1, 11); // @todo Knekt, Dam och Kung?
    summaDealer += kort;
    // Skriv ut kortet
    Console.WriteLine($"Datorn fick {kort}");



    // Vem har vunnit?
    // Har datorn fått 21 o vunnit?
    if (summaDealer == 21)
    {
        Console.WriteLine("Datorn har vunnit!");
        break;
    }
    // Har spelaren fått 21, har han vunnit
    if (summaSpelare == 21)
    {
        Console.WriteLine("Du har vunnit");
        break;
    }

    // Har spelare mer än 21?
    if (summaSpelare > 21)
    {
        Console.WriteLine("Du har förlorat");
        break;
    }
    // Har dealer mer än 21?
    if (summaDealer > 21)
    {
        Console.WriteLine("Du har vunnit!");
        break;
    }


}
