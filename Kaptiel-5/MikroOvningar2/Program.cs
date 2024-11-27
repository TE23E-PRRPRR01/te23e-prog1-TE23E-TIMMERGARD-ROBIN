// Lista med 5 namn
Console.Clear();
List<string> namn = ["Melker", "Robin", "Johnny", "Benjamin", "Melvin"];
Console.WriteLine($"Listan på namn är: {string.Join(", ", namn)}");


// Lista med 5 städer
List<string> städer = ["Göteborg", "Stockholm", "Borås", "Uppsala", "Sundsvall"];
Console.WriteLine($"Fem orter: ({string.Join(", ", städer)}) ligger i Sverige.");

// Skapa en lista med 5 årtal
List<int> årtal = [1492, 1845, 1923, 1674, 1179];
Console.WriteLine($"Fem viktiga årtal är: '{string.Join("', '", årtal)}'");

// Plocka ut det första och sista namnet ur listan
List<string> listaNamn = ["Adam", "Jonas", "Pelle", "Melker", "Johnny"];
Console.WriteLine("Första namnet: " + listaNamn[0]);
Console.WriteLine("Sista namnet: " + listaNamn[4]);

// Lista med 5 drycker
List<string> drycker = ["Monster", "Nocco", "Redbull", "Celsius", "Pepsi"];
Console.WriteLine("Första drycken: " + drycker[0]);
Console.WriteLine("Andra drycken: " + drycker[1]);
Console.WriteLine("Tredje drycken: " + drycker[2]);
Console.WriteLine("Fjärde drycken: " + drycker[3]);
Console.WriteLine("Femte drycken: " + drycker[4]);

// Lista med 5 åldrar
List<int> listaÅldrar = [14, 18, 23, 27, 44];
Console.WriteLine(string.Join(", ", listaÅldrar));
Console.WriteLine("Första åldern: " + listaÅldrar[0]);
Console.WriteLine("Andra åldern: " + listaÅldrar[1]);
Console.WriteLine("Tredje åldern: " + listaÅldrar[2]);
Console.WriteLine("Fjärde åldern: " + listaÅldrar[3]);
Console.WriteLine("Femte åldern: " + listaÅldrar[4]);

List<string> namnen = ["Adam", "Jonas", "Pelle", "Melker", "Johnny"];
Console.WriteLine($"Listan på namn är: {string.Join(", ", namn)}");
Console.Write("Nytt namn att lägga till: ");
string nyttnamn = Console.ReadLine();
namnen.Add(nyttnamn);
Console.WriteLine($"Listan på namn är: {string.Join(", ", namn)}");