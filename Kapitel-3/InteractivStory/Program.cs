// Program för en interaktiv historia
Console.Clear();
Console.Write("Vill du ha en korv? (Ja/Nej) ");
string answer = Console.ReadLine();

//Kolla om svar är Ja eller Nej/
if (answer == "Ja")
{ // Ja = Yes
    Console.Write("Vilken sort? (Vanlig/Kyckling) ");
    Console.ReadLine();

    if (answer == "Ja")
    {
        Console.WriteLine("Varsågod!");
    }
    else
    {
        Console.WriteLine("Köp en då!");
    }
}
else
{ // Nej = No
    Console.Write("Är du säker? (Ja/Nej) ");
    answer = Console.ReadLine();
    if (answer == "Ja")
    {
        Console.WriteLine("Ha en fortsatt trevlig dag!");
    }
    else
    {
        Console.WriteLine("Då får du tänka igen, ha en bra dag!");
    }
}