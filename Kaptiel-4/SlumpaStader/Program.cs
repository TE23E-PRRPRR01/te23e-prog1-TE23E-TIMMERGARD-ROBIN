// Slumpa städer

Console.Clear();
Console.WriteLine("Slumpa städer ur en lista");

List<string> lista = ["Stockholm","Borås", "Göteborg", "Malmö", "Kiruna", 
"Uppsala", "Haparanda", "Norrköping", "Lidköping", "Luleå"];

int antal = 2;
while (antal > 0)
{
    int index = Random.Shared.Next(0, 11);

    string stad = lista [index];

    Console.WriteLine($"Den slumpade staden är {stad}");

    antal--;    
}