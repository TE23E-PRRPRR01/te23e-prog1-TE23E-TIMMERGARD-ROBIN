Console.Clear();
Console.WriteLine("Lista med actionspel");

List<string> listaSpel = [];

// Addera spel
listaSpel.Add("Fortntie");
listaSpel.Add("Call of Duty");

// Låt användaren mata in 2 spel
Console.Write("Ange ett action-spel: ");
string spel1 = Console.ReadLine();
Console.Write("Ange ett till action-spel: ");
string spel2 = Console.ReadLine();

Console.WriteLine();
// Användaren fyller på en lista med äventyrsspel med for-loop
Console.WriteLine("Nu ska du fylla i 3 äventyrspel!");
for (int i = 0; i < 3; i++)
{

    Console.Write("Ange ett äventyrsspel: ");
    string spel = Console.ReadLine();
    listaSpel.Add(spel);

    Console.WriteLine($"{listaSpel[i]} ");
}

